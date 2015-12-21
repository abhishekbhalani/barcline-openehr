using Barcline.OpenEhr.Model;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Diagnostics.Contracts;
using Barcline.OpenEhr.Storage;
using NLog;
using System.Text.RegularExpressions;

namespace Barcline.OpenEhr.Generator
{
    public class InstanceFactory
    {
        private ILogger logger;

        private List<Tuple<OpenEhrObject, String>> archetypeInternalRefs = new List<Tuple<OpenEhrObject, string>>();

        public InstanceFactory(ARCHETYPE archetype)
        {
            logger = LogManager.GetCurrentClassLogger();

            Contract.Requires(archetype != null);
            this._archetype = archetype;
        }

        public InstanceFactoryOptions Options
        {
            get
            {
                return options;
            }
        }

        private LOCATABLE CreateRootItem(C_COMPLEX_OBJECT complexObject)
        {
            LOCATABLE item = (LOCATABLE)CreateInstance(complexObject.rm_type_name);
            return item;
        }

        public LOCATABLE Create()
        {
            Contract.Requires(_archetype.definition != null);

            this._result = CreateRootItem(_archetype.definition);
            InitRootItem(_result, _archetype.definition);
            TraverseComplexObject(_result, _archetype.definition);

            ProcessArchetypeInternalRefs();
            return _result;
        }

        private void ProcessArchetypeInternalRefs()
        {
            foreach (var item in archetypeInternalRefs)
            {
                Object target = OpenEhrUtils.SelectSingle(this._result, item.Item2);
                Object y = this;
            }
        }

        private ARCHETYPE _archetype;
        private LOCATABLE _result;
        private InstanceFactoryOptions options = new InstanceFactoryOptions();

        private static Object CreateInstance(String rm_type_name)
        {
            var ns = typeof(LOCATABLE).Namespace;
            var asm = typeof(LOCATABLE).Assembly.FullName;
            String typeName = String.Format("{0}.{1}, {2}", ns, rm_type_name, asm);
            Type type = Type.GetType(typeName, true);
            if (type.IsAbstract)
                throw new InstanceFactoryTypeIsAbstractException(type);
            return Activator.CreateInstance(type);
        }

        private static Type GetOpenEhrType(String rm_type_name)
        {
            if (String.IsNullOrEmpty(rm_type_name))
                return null;
            rm_type_name = rm_type_name.Trim();

            switch (rm_type_name)
            {
                case "DV_INTERVAL<DV_QUANTITY>":
                    return typeof(DV_INTERVAL);
                case "DV_INTERVAL<DV_PROPORTION>":
                    return typeof(DV_INTERVAL);
                case "DV_INTERVAL<DV_COUNT>":
                    return typeof(DV_INTERVAL);
                case "DV_INTERVAL<DV_DURATION>":
                    return typeof(DV_INTERVAL);
                case "DV_INTERVAL<DV_DATE>":
                    return typeof(DV_INTERVAL);
                case "DV_INTERVAL<DV_DATE_TIME>":
                    return typeof(DV_INTERVAL);
                case "DV_INTERVAL<DV_TIME>":
                    return typeof(DV_INTERVAL);
                case "DV_INTERVAL<DV_ORDINAL>":
                    return typeof(DV_INTERVAL);
                default:
                    var ns = typeof(LOCATABLE).Namespace;
                    var asm = typeof(LOCATABLE).Assembly.FullName;
                    String typeName = String.Format("{0}.{1}, {2}", ns, rm_type_name, asm);
                    Type type = Type.GetType(typeName, false);
                    return type;
            }
        }

        private void InitArchetypeInternalRef(OpenEhrObject obj, ARCHETYPE_INTERNAL_REF cArchetypeInternalRef)
        {
            String path = cArchetypeInternalRef.target_path;
            if (!String.IsNullOrEmpty(path))
            {
                archetypeInternalRefs.Add(new Tuple<OpenEhrObject, string>(obj, path));
            }
        }

        private void InitArchetypeSlot(OpenEhrObject obj, ARCHETYPE_SLOT archetypeSlot)
        {
            if (options.Storage == null)
            {
                logger.Warn("Found ARCHETYPE_SLOT but storage was not set");
            }
            if (obj is CLUSTER)
            {
                CLUSTER cluster = (CLUSTER)obj;

                List<String> allArchetypeIds = options.Storage.EnumArchetypeIds();
                List<String> appropriateArchetypeIds = new List<string>();

                foreach (ASSERTION include in archetypeSlot.includes)
                {
                    var expr = "" + include.string_expression;
                    if (!String.IsNullOrEmpty(expr))
                    {
                        expr = expr.Replace("archetype_id/value matches {", "");
                        expr = expr.Replace("}", "");
                        expr = expr.Replace("/", "");
                        Regex re = new Regex(expr);
                        appropriateArchetypeIds.AddRange(allArchetypeIds.Where(row => re.IsMatch(row)));
                    }
                }
                foreach (ASSERTION exclude in archetypeSlot.excludes)
                {
                    var expr = "" + exclude.string_expression;
                    if (!String.IsNullOrEmpty(expr))
                    {
                        expr = expr.Replace("archetype_id/value matches {", "");
                        expr = expr.Replace("}", "");
                        expr = expr.Replace("/", "");
                        Regex re = new Regex(expr);
                        appropriateArchetypeIds.RemoveAll(row => re.IsMatch(row));
                    }
                }
                foreach (var appropriateArchetypeId in appropriateArchetypeIds)
                {
                    /*
                    var appropriateArchetype = options.Storage.LoadArchetype(appropriateArchetypeId);
                    InstanceFactory factory = new InstanceFactory(appropriateArchetype);
                    factory.options = this.options;
                    LOCATABLE l = factory.Create();
                    if (l is ITEM)
                    {
                        cluster.items.Add((ITEM)l);    
                    }*/
                }
            }
            else
            {
                // TODO: handle that
            }
        }

        private void InitCodePhrase(OpenEhrObject obj, C_CODE_PHRASE codePhrase)
        {
            DV_CODED_TEXT codedText = obj as DV_CODED_TEXT;
            if (codedText != null)
            {
                codedText.defining_code = codePhrase.assumed_value;
                if (codedText.defining_code == null)
                    codedText.defining_code = new CODE_PHRASE();
                codedText.defining_code.terminology_id = codePhrase.terminology_id;
                if (codePhrase.code_list != null && codePhrase.code_list.Length != 0)
                {
                    codedText.defining_code.code_string = codePhrase.code_list[0];
                    codedText.value = _archetype.LookupTranslationText(options.Lang, codedText.defining_code.code_string);
                }
            }
        }

        private void InitCodeReference(OpenEhrObject obj, C_CODE_REFERENCE c_CODE_REFERENCE)
        {
        }

        private void InitComplexObject(OpenEhrObject obj, C_COMPLEX_OBJECT complexObject)
        {
            if (obj is LOCATABLE)
            {
                LOCATABLE locatableObj = (LOCATABLE)obj;
                if (!String.IsNullOrEmpty(complexObject.node_id))
                {
                    locatableObj.archetype_node_id = complexObject.node_id;
                    locatableObj.name = new DV_TEXT();
                    locatableObj.name.value = _archetype.LookupTranslationText(options.Lang, locatableObj.archetype_node_id);
                    locatableObj.name.language = new CODE_PHRASE() { code_string = options.Lang };
                    // TODO: language terminology
                }
            }
        }

        private void InitConstraintRef(OpenEhrObject obj, CONSTRAINT_REF cConstraintRef)
        {
            // TODO:
        }

        private void InitDefaults(OpenEhrObject obj)
        {
            if (obj is DV_TEXT)
            {
            }
        }

        private void InitDvOrdinal(OpenEhrObject obj, C_DV_ORDINAL c_DV_ORDINAL)
        {
            if (!String.IsNullOrEmpty(c_DV_ORDINAL.node_id))
            {
                if (obj is LOCATABLE)
                {
                    (obj as LOCATABLE).archetype_node_id = c_DV_ORDINAL.node_id;
                }
            }
        }

        private void InitDvQuantity(OpenEhrObject obj, C_DV_QUANTITY cDvQuantity)
        {
            if (obj is ITEM)
            {
                if (obj is ELEMENT)
                {
                    ELEMENT element = (ELEMENT)obj;
                    DV_QUANTITY quantity = new DV_QUANTITY();
                    if (cDvQuantity.list != null && cDvQuantity.list.Count != 0)
                    {
                        C_QUANTITY_ITEM item = cDvQuantity.list[0];
                        if (item.magnitude != null)
                        {
                            quantity.magnitude = item.magnitude.lower;
                        }
                        quantity.units = item.units;
                        element.value = quantity;
                    }
                }
                else if (obj is CLUSTER)
                {
                    // throw new Exception("Unhandled");
                }
            }
            else
            {
                // throw new Exception("Unhandled");
            }
        }

        private void InitDvState(OpenEhrObject obj, C_DV_STATE c_DV_STATE)
        {
        }

        private void InitRootItem(LOCATABLE item, C_COMPLEX_OBJECT complexObject)
        {
            // 519
            item.archetype_details = new ARCHETYPED();
            item.archetype_details.archetype_id = new ARCHETYPE_ID() { value = _archetype.archetype_id.value };
            item.archetype_details.template_id = new TEMPLATE_ID() { };
            item.archetype_details.rm_version = "1.0.1";

            // ITEM->(CLUSTER|ELEMENT)
            if (item is ITEM)
            {
                var itemItem = item as ITEM;
            }
            else if (item is CONTENT_ITEM)
            {
                var contentItem = item as CONTENT_ITEM;

                if (contentItem is ENTRY)
                {
                    ENTRY entry = (ENTRY)contentItem;
                    entry.subject = new PARTY_IDENTIFIED() { name = "Identified Patient" };
                    entry.encoding = new CODE_PHRASE() { code_string = "UTF-8", terminology_id = new TERMINOLOGY_ID() { value = "IANA_character-sets" } };
                    entry.language = new CODE_PHRASE() { code_string = "en" };
                }
            }
        }
        private void Log(String message, params object[] args)
        {
            Trace.WriteLine(String.Format(message, args));
        }

        private void InitPrimitive(OpenEhrObject obj, PropertyInfo propertyInfo, C_PRIMITIVE cPrimitive)
        {
            INotifyPropertyChanged propertyChanged = obj as INotifyPropertyChanged;

            String pp = String.Format("{0} {1}", propertyInfo.PropertyType.Name, cPrimitive.GetType().Name);
            var propertyType = propertyInfo.PropertyType;
            if (propertyType.Equals(typeof(String)) && cPrimitive is C_STRING)
            {
                var cString = cPrimitive as C_STRING;
                if (cString.assumed_value != null)
                {
                    propertyInfo.SetValue(obj, cString.assumed_value);
                }
                if (propertyChanged != null)
                {
                    // TODO: list constraint
                    // TODO: pattern constraint
                    // TODO: list_open constraint
                }
            }
            else if (propertyType.Equals(typeof(Single)) && cPrimitive is C_REAL)
            {
                var cReal = cPrimitive as C_REAL;
                if (cReal.assumed_valueSpecified)
                {
                    // TODO cReal.list constraint
                    // TODO cReal.range constraint
                    propertyInfo.SetValue(obj, cReal.assumed_value);
                }
            }
            else if (propertyType.Equals(typeof(Boolean)) && cPrimitive is C_BOOLEAN)
            {
                var cBoolean = cPrimitive as C_BOOLEAN;
                if (cBoolean.assumed_valueSpecified)
                {
                    propertyInfo.SetValue(obj, cBoolean.assumed_value);
                    // TODO: cBoolean.false_valid
                    // TODO: cBoolean.true_valid
                }
            }
            else if (propertyType.Equals(typeof(PROPORTION_KIND)) && cPrimitive is C_INTEGER)
            {
                var cInteger = cPrimitive as C_INTEGER;
                if (cInteger.assumed_valueSpecified)
                {
                    propertyInfo.SetValue(obj, (PROPORTION_KIND)cInteger.assumed_value);
                    // TODO: cInteger.list
                    // TODO: cInteger.range
                }
            }
            else if (propertyType.Equals(typeof(int)) && cPrimitive is C_INTEGER)
            {
                var cInteger = cPrimitive as C_INTEGER;
                if (cInteger.assumed_valueSpecified)
                {
                    propertyInfo.SetValue(obj, cInteger.assumed_value);
                    // TODO: cInteger.list
                    // TODO: cInteger.range
                }
            }
            else if (propertyType.Equals(typeof(Int64)) && cPrimitive is C_INTEGER)
            {
                var cInteger = cPrimitive as C_INTEGER;
                if (cInteger.assumed_valueSpecified)
                {
                    propertyInfo.SetValue(obj, cInteger.assumed_value);
                    // TODO: cInteger.list
                    // TODO: cInteger.range
                }
            }
            else if (propertyType.Equals(typeof(TimeSpan)) && cPrimitive is C_DURATION)
            {
                var cDuration = cPrimitive as C_DURATION;
                if (cDuration.assumed_value != null)
                {
                    propertyInfo.SetValue(obj, cDuration.assumed_value.Value);
                    // TODO: cDuration.pattern
                    // TODO: cDuration.range
                }
            }
            else if (propertyType.Equals(typeof(DateTime)) && cPrimitive is C_DATE_TIME)
            {
                var cDateTime = cPrimitive as C_DATE_TIME;
                if (cDateTime.assumed_value != null)
                {
                    propertyInfo.SetValue(obj, cDateTime.assumed_value.Value);
                    // TODO: cDateTime.pattern
                    // TODO: cDateTime.range
                    // TODO: cDateTime.timezone_validity
                }
            }
            else
            {
                throw new Exception(String.Format("Cannot initialize {0}.{1} with primitive {2}", obj.GetType().Name, propertyInfo.Name, cPrimitive.GetType().Name));
            }
        }

        private void TraverseComplexObject(OpenEhrObject obj, C_COMPLEX_OBJECT cobj)
        {
            foreach (var c_attr in cobj.attributes)
            {
                var propertyName = c_attr.rm_attribute_name;
                var propertyInfo = obj.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

                foreach (var attr_child_object in c_attr.children)
                {
                    var propertyTypeName = attr_child_object.rm_type_name;
                    if (propertyTypeName == "EVENT")
                        propertyTypeName = "POINT_EVENT";
                    var propertyType = GetOpenEhrType(propertyTypeName);

                    if (attr_child_object is C_COMPLEX_OBJECT)
                    {
                        if (propertyType.IsAbstract)
                        {
                            Log("Cannot create instance of {0}: type is abstract.", propertyTypeName);
                            continue;
                        }
                        OpenEhrObject propertyValue = Activator.CreateInstance(propertyType) as OpenEhrObject;
                        var list = (propertyInfo.GetValue(obj) as IList);
                        if (list != null)
                        {
                            list.Add(propertyValue);
                        }
                        else
                        {
                            propertyInfo.SetValue(obj, propertyValue);
                        }
                        var cComplexObject = attr_child_object as C_COMPLEX_OBJECT;
                        TraverseComplexObject(propertyValue, cComplexObject);
                        InitComplexObject(propertyValue, cComplexObject);
                        InitDefaults(propertyValue);
                        if (c_attr is C_SINGLE_ATTRIBUTE)
                            break;
                    }
                    else if (attr_child_object is C_PRIMITIVE_OBJECT)
                    {
                        var cPrimitiveObject = attr_child_object as C_PRIMITIVE_OBJECT;
                        var cPrimitive = cPrimitiveObject.item;
                        if (cPrimitive != null)
                        {
                            InitPrimitive(obj, propertyInfo, cPrimitive);
                        }
                    }
                    else if (attr_child_object is C_DOMAIN_TYPE)
                    {
                        var cDomainType = attr_child_object as C_DOMAIN_TYPE;
                        if (cDomainType is C_DV_ORDINAL)
                        {
                            InitDvOrdinal(obj, cDomainType as C_DV_ORDINAL);
                        }
                        else if (cDomainType is C_CODE_PHRASE)
                        {
                            InitCodePhrase(obj, cDomainType as C_CODE_PHRASE);
                            if (cDomainType is C_CODE_REFERENCE)
                            {
                                InitCodeReference(obj, cDomainType as C_CODE_REFERENCE);
                            }
                        }
                        else if (cDomainType is C_DV_STATE)
                        {
                            InitDvState(obj, cDomainType as C_DV_STATE);
                        }
                        else if (cDomainType is C_DV_QUANTITY)
                        {
                            InitDvQuantity(obj, cDomainType as C_DV_QUANTITY);
                        }
                        //else InitDomainType((dynamic)obj, (dynamic)cDomainType);
                    }
                    else if (attr_child_object is ARCHETYPE_SLOT)
                    {
                        var cArchetypeSlot = attr_child_object as ARCHETYPE_SLOT;
                        InitArchetypeSlot(obj, cArchetypeSlot);
                    }
                    else if (attr_child_object is ARCHETYPE_INTERNAL_REF)
                    {
                        var cArchetypeInternalRef = attr_child_object as ARCHETYPE_INTERNAL_REF;
                        InitArchetypeInternalRef(obj, cArchetypeInternalRef);
                    }
                    else if (attr_child_object is CONSTRAINT_REF)
                    {
                        var cConstraintRef = attr_child_object as CONSTRAINT_REF;
                        InitConstraintRef(obj, cConstraintRef);
                    }
                }
            }
        }
        private class InstanceFactoryTypeIsAbstractException : Exception
        {
            public InstanceFactoryTypeIsAbstractException(Type type) :
                base("Type " + type.Name + " is abstract")
            {
            }
        }
    }

    public class InstanceFactoryOptions
    {
        public InstanceFactoryOptions()
        {
            Lang = "en";
        }

        public String Lang { get; set; }

        public IArchetypeStorage Storage { get; set; }
    }
}