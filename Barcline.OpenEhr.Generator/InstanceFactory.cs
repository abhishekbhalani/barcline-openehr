using Barcline.OpenEhr.Model;
using System;
using System.Collections;

namespace Barcline.OpenEhr.Generator
{
    public class InstanceFactory
    {
        private ARCHETYPE _archetype;
        private LOCATABLE _result;
        private InstanceFactoryOptions options = new InstanceFactoryOptions();

        public InstanceFactory(ARCHETYPE archetype)
        {
            this._archetype = archetype;
        }

        public InstanceFactoryOptions Options
        {
            get
            {
                return options;
            }
        }

        public static LOCATABLE CreateRootItem(C_COMPLEX_OBJECT complexObject)
        {
            LOCATABLE item = (LOCATABLE)CreateInstance(complexObject.rm_type_name);
            return item;
        }

        public LOCATABLE Create()
        {
            this._result = CreateRootItem(_archetype.definition);
            InitRootItem(_result, _archetype.definition);
            TraverseComplexObject(_result, _archetype.definition);
            return _result;
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
            // TODO:
        }

        private void InitArchetypeSlot(OpenEhrObject obj, ARCHETYPE_SLOT archetypeSlot)
        {
            // resolve archetype and link to obj
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

        private void InitPrimitive(ACTIVITY obj, C_STRING constraint)
        {
            
        }

        private void InitPrimitive(ITEM_TABLE obj, C_INTEGER constraint)
        {

        }

        private void InitPrimitive(ITEM_TABLE obj, C_BOOLEAN constraint)
        {

        }

        private void InitDvState(OpenEhrObject obj, C_DV_STATE c_DV_STATE)
        {
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
                            break;
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
                            InitPrimitive((dynamic)obj, (dynamic)cPrimitive);
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

        private void InitPrimitive(DV_PARSABLE obj, C_STRING constraint)
        {
            // TODO:
        }

        private void InitPrimitive(DV_DURATION obj, C_DURATION constraint)
        {
            if (constraint.assumed_value != null)
            {
                obj.value = constraint.assumed_value.Value;
            }
            if (constraint.range != null)
            {
                obj.normal_range = new DV_INTERVAL();
                if (constraint.range.lower != null)
                {
                    obj.normal_range.lower = new DV_TIME() { value = constraint.range.lower.Value };
                }
                if (constraint.range.upper != null)
                {
                    obj.normal_range.upper = new DV_TIME() { value = constraint.range.upper.Value };
                }
            }
        }

        private void InitPrimitive(DV_BOOLEAN obj, C_BOOLEAN constraint)
        {
            obj.value = constraint.assumed_value;
        }

        private void InitPrimitive(DV_TIME obj, C_TIME constraint)
        {
            if (constraint.assumed_value != null)
                obj.value = constraint.assumed_value.Value;
            if (constraint.range != null)
            {
            }
        }

        private void InitPrimitive(DV_PROPORTION obj, C_REAL constraint)
        {

        }

        private void InitPrimitive(DV_PROPORTION obj, C_BOOLEAN constraint)
        {

        }

        private void InitPrimitive(DV_PROPORTION obj, C_INTEGER constraint)
        {

        }

        private void InitPrimitive(DV_IDENTIFIER obj, C_STRING constraint)
        {

        }

        private void InitPrimitive(DV_COUNT obj, C_INTEGER constraint)
        {
            if (constraint.assumed_valueSpecified)
            {
                obj.magnitude = constraint.assumed_value;
            }
        }

        private void InitPrimitive(DV_DATE_TIME obj, C_DATE_TIME constraint)
        {
            if (constraint.assumed_value != null)
            {
                obj.value = constraint.assumed_value.Value;
            }
        }

        private void Log(String message, params object[] args)
        {
            Console.WriteLine(message, args);
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
    }
}