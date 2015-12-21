using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Barcline.OpenEhr.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Barcline.OpenEhr
{
    public static class OpenEhrUtils
    {
        public static LOCATABLE FindElementByArchetypeNodeId(LOCATABLE locatable, String propertyName, String archetypeNodeId)
        {
            if (String.IsNullOrEmpty(archetypeNodeId))
                return null;

            var propertyValue = GetPropertyValue(locatable, propertyName);
            if (propertyValue == null)
                return null;

            if (!(propertyValue is IOpenEhrObject) && !(propertyValue is IOpenEhrCollection))
            {
                throw new Exception("Invalid object type. Expected instance of IOpenEhrObject, got " + propertyValue.GetType().Name);
            }
            if (propertyValue is IOpenEhrCollection)
            {
                foreach (IOpenEhrObject collectionItem in ((IOpenEhrCollection)propertyValue))
                {
                    if (
                        collectionItem is LOCATABLE &&
                         archetypeNodeId.Equals(((LOCATABLE)collectionItem).archetype_node_id)
                     )
                    {
                        return (LOCATABLE)collectionItem;
                    }
                }
                return null;
            }
            else
            {
                if (propertyValue is LOCATABLE &&
                    archetypeNodeId.Equals(((LOCATABLE)propertyValue).archetype_node_id))
                {
                    return (LOCATABLE)propertyValue;
                }
                else
                {
                    return null;
                }
            }
        }

        public static Object GetPropertyValue(Object obj, String propertyName)
        {
            if (obj == null)
                return null;
            return obj.GetType().GetProperty(propertyName).GetValue(obj);
        }

        public static List<Object> SelectMany(LOCATABLE obj, String aqlExpression)
        {
            return null;
        }

        public static Object SelectSingle(Object obj, String aqlExpression)
        {
            if (String.IsNullOrEmpty(aqlExpression))
                return null;

            var path = ParseRmPath(aqlExpression);

            Object current = obj;

            var list = path.children.OfType<Adl2.Parser.adlParser.PathSegmentContext>().ToList();
            if (list.Count == 0)
                return null;

            while (true)
            {
                var pathSegmentContext = list[0];
                list.RemoveAt(0);

                String propertyName = pathSegmentContext.nameIdentifier().NAME_IDENTIFIER().GetText();  // data, events etc
                var atCodeContext = pathSegmentContext.atCode();
                String atCode = atCodeContext == null ? null : atCodeContext.AT_CODE_VALUE().GetText(); // text between [ and ]

                Object propertyValue = GetPropertyValue(current, propertyName);
                if (propertyValue == null)
                {
                    return null;
                }

                else if (propertyValue is IOpenEhrCollection)
                {
                    if (String.IsNullOrEmpty(atCode))
                    {
                        if (list.Count == 0)
                        {
                            return propertyValue;
                        }
                        else
                        {
                            throw new Exception(String.Format("Invalid expression {0}. Expected [atCode]", pathSegmentContext));
                        }
                    }
                    else
                    {
                        foreach (var collectionItem in ((IEnumerable)propertyValue))
                        {
                            if (!(collectionItem is LOCATABLE))
                            {
                                throw new Exception(String.Format("Invalid expression {0}. Expected instance of LOCATABLE", pathSegmentContext));
                            }
                            LOCATABLE locatable = (LOCATABLE)collectionItem;
                            if (atCode.Equals(locatable.archetype_node_id))
                            {
                                if (list.Count == 0)
                                {
                                    return locatable;
                                }
                                else
                                {
                                    current = locatable;
                                }
                            }
                        }
                    }
                }

                else
                {
                    if (list.Count == 0)
                    {
                        return propertyValue;
                    }
                    else
                    {
                        current = propertyValue;
                    }
                }
            }
        }

        private static Adl2.Parser.adlParser.RmPathContext ParseRmPath(String aqlExpression)
        {
            AntlrInputStream inputStream = new AntlrInputStream(aqlExpression);
            var lexer = new Adl2.Parser.adlLexer(inputStream);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new Adl2.Parser.adlParser(tokenStream);
            return parser.rmPath();
        }
    }
}
