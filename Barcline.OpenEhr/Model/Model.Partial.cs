
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using System.Linq;
using Newtonsoft.Json;
using System.Globalization;
using System.ComponentModel;

namespace Barcline.OpenEhr.Model
{
    public interface IPATHABLE
    {
        Object item_at_path(String path);

        IList<Object> items_at_path(String path);

        IPATHABLE parent();
        bool path_exists(String path);

        String path_of_item(IPATHABLE item);

        bool path_unique(String path);
    }

    public static class PARTY_REF_TYPE
    {
        public const String ACTOR = "ACTOR";
        public const String AGENT = "AGENT";
        public const String GROUP = "GROUP";
        public const String ORGANISATION = "ORGANISATION";
        public const String PARTY = "PARTY";
        public const String PERSON = "PERSON";
        public const String ROLE = "ROLE";
    }

    public static class VERSION_LIFECYCLE_STATE
    {
        public const String DELETED = "deleted";
    }

    [Table("CONTRIBUTION", Schema = "openehr")]
    public class CONTRIBUTION : OpenEhrNaturalKeyBasedObject
    {
        private OBJECT_REFCollection _versions;

        [Required]
        public virtual AUDIT_DETAILS audit_details { get; set; }

        public override object[] PrimaryKey
        {
            get
            {
                return new Object[] { this.uid_value };
            }
        }

        [Required]
        [ForeignKey("uid_value")]
        public virtual HIER_OBJECT_ID uid { get; set; }

        [Key]
        public String uid_value { get; set; }

        public virtual OBJECT_REFCollection versions
        {
            get
            {
                if (_versions == null)
                    _versions = new OBJECT_REFCollection();
                return _versions;
            }
            set
            {
                _versions = value;
            }
        }
    }

    [Table("VERSIONED", Schema = "openehr")]
    public abstract partial class VERSIONED : LOCATABLE
    {
        public virtual ORIGINAL_VERSION version { get; set; }
    }

    partial class ACTION
    {
        [ForeignKey("description")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid description_uuid { get; set; }

        [ForeignKey("instruction_details")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? instruction_details_uuid { get; set; }

        [ForeignKey("ism_transition")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? ism_transition_uuid { get; set; }

        [ForeignKey("time")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? time_uuid { get; set; }
    }

    partial class ACTIVITY
    {
        [ForeignKey("description")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? description_uuid { get; set; }

        [ForeignKey("timing")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? timing_uuid { get; set; }

        [ForeignKey("instruction")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? instruction_uuid { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public virtual INSTRUCTION instruction { get; set; }
    }

    partial class ADMIN_ENTRY
    {
        [ForeignKey("data")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? data_uuid { get; set; }
    }

    partial class ARCHETYPE
    {
        [ForeignKey("definition")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? definition_uuid { get; set; }

        [ForeignKey("ontology")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? ontology_uuid { get; set; }

        [ForeignKey("archetype_id")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual String archetype_id_value {get;set;}

        [ForeignKey("uid")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual String uid_value { get; set; }
    }

    partial class ARCHETYPE_TERM : OpenEhrUuidBasedObject
    {
        [XmlIgnore]
        [JsonIgnore]
        public virtual C_ARCHETYPE_ROOT c_archetype_root { get; set; }

        [ForeignKey("c_archetype_root")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? c_archetype_root_uuid { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public virtual CodeDefinitionSet code_definition_set { get; set; }

        [ForeignKey("code_definition_set")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? code_definition_set_uuid { get; set; }
    }

    partial class ADDRESS
    {
        [ForeignKey("details")]
        public virtual Guid details_uuid { get; set; }
    }

    partial class ARCHETYPE_CONSTRAINT : OpenEhrUuidBasedObject
    {

    }

    partial class ARCHETYPE_ONTOLOGY : OpenEhrUuidBasedObject
    {
    }


    partial class ARCHETYPED : OpenEhrNaturalKeyBasedObject
    {
        [Key]
        [XmlIgnore]
        [JsonIgnore]
        [ForeignKey("archetype_id")]
        [Required]
        public virtual string archetype_id_value { get; set; }
    }

    partial class ASSERTION : OpenEhrUuidBasedObject
    {
        [ForeignKey("expression")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid expression_uuid { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public virtual ARCHETYPE_SLOT archetype_slot_includes { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public virtual ARCHETYPE_SLOT archetype_slot_excludes { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public virtual ARCHETYPE archetype { get; set; }

        [ForeignKey("archetype")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? archetype_uuid { get; set; }
    }

    partial class ASSERTION_VARIABLE : OpenEhrUuidBasedObject
    {
        [XmlIgnore]
        [JsonIgnore]
        public virtual ASSERTION assertion { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        [ForeignKey("assertion")]
        public virtual Guid? assertion_uuid { get; set; }
    }

    partial class ATTESTATION
    {
        [XmlIgnore]
        [JsonIgnore]
        [ForeignKey("attested_view")]
        public virtual Guid? attested_view_uuid { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        [ForeignKey("reason")]
        public virtual Guid? reason_uuid { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public virtual ORIGINAL_VERSION original_version { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        [ForeignKey("original_version")]
        public virtual Guid? original_version_uuid { get; set; }
    }

    partial class AUDIT_DETAILS : OpenEhrUuidBasedObject
    {
        [XmlIgnore]
        [JsonIgnore]
        public virtual REVISION_HISTORY_ITEM revision_history_item { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        [ForeignKey("revision_history_item")]
        public virtual String revision_history_item_id { get; set; }
    }

    partial class AUTHORED_RESOURCE : OpenEhrUuidBasedObject
    {
        [ForeignKey("description")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid? description_uuid { get; set; }

        [ForeignKey("original_language")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual Guid original_language_uuid { get; set; }
    }

    partial class C_ATTRIBUTE
    {
        [XmlIgnore]
        [JsonIgnore]
        public virtual C_COMPLEX_OBJECT c_complex_object { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        [ForeignKey("c_complex_object")]
        public virtual Guid c_complex_object_uuid { get; set; }
    }

    partial class C_STRING
    {
        [XmlIgnore]
        [JsonIgnore]
        [Column("list")]
        public virtual String listArray
        {
            get
            {
                if (list == null)
                    return String.Empty;
                return String.Join(";", list);                
            }
            set
            {
                value = "" + value;
                list = value.Split(new String[]{";"}, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }

    partial class C_REAL
    {
        [XmlIgnore]
        [JsonIgnore]
        [Column("list")]
        public virtual String listArray
        {
            get
            {
                var culture = CultureInfo.InvariantCulture;
                if (list == null)
                    return String.Empty;
                return String.Join(";", list.Select(row => Convert.ToString(row, culture)));
            }
            set
            {
                var culture = CultureInfo.InvariantCulture;
                value = "" + value;
                list = value
                    .Split(new String[] { ";" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(row => float.Parse(row, culture))
                    .ToArray();
            }
        }
    }

    partial class C_INTEGER
    {
        [XmlIgnore]
        [JsonIgnore]
        [Column("list")]
        public virtual String listArray
        {
            get
            {
                var culture = CultureInfo.InvariantCulture;
                if (list == null)
                    return String.Empty;
                return String.Join(";", list.Select(row => Convert.ToString(row, culture)));
            }
            set
            {
                var culture = CultureInfo.InvariantCulture;
                value = "" + value;
                list = value
                    .Split(new String[] { ";" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(row => int.Parse(row, culture))
                    .ToArray();
            }
        }
    }

    partial class C_OBJECT
    {
        [XmlIgnore]
        [JsonIgnore]
        public virtual C_ATTRIBUTE c_attribute { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        [ForeignKey("c_attribute")]
        public virtual Guid? c_attribute_uuid { get; set; }
    }

    partial class C_PRIMITIVE : OpenEhrUuidBasedObject
    {

    }

    partial class C_QUANTITY_ITEM : OpenEhrUuidBasedObject
    {
        /*
        [XmlIgnore]
        [JsonIgnore]
        public virtual C_DV_QUANTITY c_dv_quantity { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        [ForeignKey("c_dv_quantity")]
        public virtual Guid? c_dv_quantity_uuid { get; set; }
         */
    }

    partial class CARDINALITY : OpenEhrUuidBasedObject
    {
        [NotMapped]
        [XmlIgnore]
        [JsonIgnore]
        public bool is_bag
        {
            get
            {
                return !is_ordered && !is_unique;
            }
        }

        [NotMapped]
        [XmlIgnore]
        [JsonIgnore]
        public bool is_list
        {
            get
            {
                return is_ordered && !is_unique;
            }
        }

        [NotMapped]
        [XmlIgnore]
        [JsonIgnore]
        public bool is_set
        {
            get
            {
                return !is_ordered && is_unique;
            }
        }
    }

    partial class CLUSTER
    {
        [XmlIgnore]
        [JsonIgnore]
        public virtual ITEM_TABLE item_table { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        [ForeignKey("item_table")]
        public virtual Guid? item_table_uuid { get; set; }
    }

    partial class CODE_PHRASE : OpenEhrUuidBasedObject
    {
        [ForeignKey("terminology_id")]
        [XmlIgnore]
        [JsonIgnore]
        [Required]
        public virtual String terminology_id_value { get; set; }
    }

    partial class CodeDefinitionSet : OpenEhrUuidBasedObject
    {

    }

    partial class CONSTRAINT_BINDING_ITEM : OpenEhrUuidBasedObject
    {

    }

    partial class ConstraintBindingSet : OpenEhrUuidBasedObject
    {

    }

    partial class DATA_VALUE : OpenEhrUuidBasedObject
    {

    }

    partial class DEFAULT_VALUE : OpenEhrUuidBasedObject
    {

    }

    partial class DV_CODED_TEXT
    {
    }

    partial class DV_PROPORTION
    {
        /// <remarks>Not present in RM</remarks>
        [XmlIgnore]
        [JsonIgnore]
        [NotMapped]
        public virtual bool is_integral { get; set; }
    }

    partial class DV_DATE_TIME
    {
        public DV_DATE_TIME()
        {

        }

        public DV_DATE_TIME(DateTime value)
        {
            this.value = value;
        }
    }

    partial class DV_EHR_URI
    {

    }

    partial class DV_INTERVAL
    {

    }

    partial class DV_TEXT
    {
        public DV_TEXT()
        {

        }

        public DV_TEXT(String value)
        {
            this.value = value;
        }
    }

    partial class EVENT
    {
        [XmlIgnore]
        [NotMapped]
        [JsonIgnore]
        public virtual DV_DURATION offset { get; set; }
    }

    partial class EVENT_CONTEXT : OpenEhrUuidBasedObject
    {

    }

    partial class EXPR_ITEM : OpenEhrUuidBasedObject
    {

    }

    partial class EXTRACT_CONTENT : OpenEhrUuidBasedObject
    {

    }

    partial class EXTRACT_ENTITY_IDENTIFIER : OpenEhrUuidBasedObject
    {

    }

    partial class EXTRACT_ENTITY_MANIFEST : OpenEhrUuidBasedObject
    {

    }

    partial class EXTRACT_ITEM : OpenEhrUuidBasedObject
    {

    }

    partial class EXTRACT_MANIFEST : OpenEhrUuidBasedObject
    {

    }

    partial class EXTRACT_SPEC : OpenEhrUuidBasedObject
    {

    }

    partial class EXTRACT_UPDATE_SPEC : OpenEhrUuidBasedObject
    {

    }

    partial class EXTRACT_VERSION_SPEC : OpenEhrUuidBasedObject
    {

    }

    partial class FEEDER_AUDIT : OpenEhrUuidBasedObject
    {

    }

    partial class FEEDER_AUDIT_DETAILS : OpenEhrUuidBasedObject
    {

    }

    partial class FOLDER
    {
        public FOLDER parentFolder { get; set; }

        public static FOLDER Create(String name)
        {
            FOLDER folder = new FOLDER();
            folder.name = new DV_TEXT();
            folder.name.value = name;
            folder.uid = new UID_BASED_ID();
            folder.uid.value = Guid.NewGuid().ToString("D");
            return folder;
        }

        public static FOLDER Create(String name, String uid)
        {
            FOLDER folder = FOLDER.Create(name);
            folder.uid.value = uid;
            return folder;
        }
    }

    partial class ITEM_TABLE
    {
        /// <remarks>Not present in RM</remarks>
        [NotMapped]
        [XmlIgnore]
        [JsonIgnore]
        public virtual bool rotated { get; set; }

        /// <remarks>Not present in RM</remarks>
        [NotMapped]
        [XmlIgnore]
        [JsonIgnore]
        public virtual int number_key_columns { get; set; }
    }

    partial class HIER_OBJECT_ID
    {
        public static HIER_OBJECT_ID Create(String id)
        {
            HIER_OBJECT_ID rv = new HIER_OBJECT_ID();
            rv.value = id;
            return rv;
        }

        public static HIER_OBJECT_ID CreateAsUuid()
        {
            HIER_OBJECT_ID rv = new HIER_OBJECT_ID();
            rv.value = Guid.NewGuid().ToString("D");
            return rv;
        }
    }

    partial class INSTRUCTION_DETAILS : OpenEhrUuidBasedObject
    {

    }

    partial class Interval : OpenEhrUuidBasedObject
    {

    }

    partial class ISM_TRANSITION : OpenEhrUuidBasedObject
    {

    }

    partial class LINK : OpenEhrUuidBasedObject
    {

    }

    partial class OBJECT_ID : OpenEhrNaturalKeyBasedObject
    {
        public override object[] PrimaryKey
        {
            get
            {
                return new Object[] { this.value };
            }
        }

        public override bool EqualsTo(Core.IModelObject value)
        {
            return (value is OBJECT_ID) &&
                this.value != null &&
                this.value.Equals(((OBJECT_ID)value).value);
        }
    }

    partial class OBJECT_REF : OpenEhrUuidBasedObject
    {
        public FOLDER folder { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    partial class OBJECT_VERSION_ID
    {
        private static String[] separator = new String[] { "::" };

        public OBJECT_VERSION_ID()
        {

        }

        public OBJECT_VERSION_ID(String object_id, String system_id, String ver)
        {
            String svalue = object_id;
            if (!String.IsNullOrEmpty(system_id))
                svalue += "::" + system_id;
            if (!String.IsNullOrEmpty(ver))
                svalue += "::" + ver;
            value = svalue;
        }
        public String get_creating_system_id()
        {
            return get_part(1);
        }

        public String get_object_id()
        {
            return get_part(0);
        }

        public String get_version_tree_id()
        {
            return get_part(2);
        }

        public void set_creating_system_id(String value)
        {
            set_part(1, value);
        }

        public void set_object_id(String value)
        {
            set_part(0, value);
        }

        public void set_version_tree_id(String value)
        {
            set_part(2, value);
        }

        private string get_part(int index)
        {
            if (String.IsNullOrEmpty(value))
                return String.Empty;
            List<string> parts = value.Split(separator, StringSplitOptions.None).ToList();
            parts.AddRange(new String[] { String.Empty, String.Empty, String.Empty });
            return parts[index];
        }

        private void set_part(int index, String value)
        {
            List<string> parts = ("" + value).Split(separator, StringSplitOptions.None).ToList();
            parts.AddRange(new String[] { String.Empty, String.Empty, String.Empty });
            parts[index] = value;
            String svalue = parts[0];
            if (!String.IsNullOrEmpty(parts[1]))
                svalue += "::" + parts[1];
            if (!String.IsNullOrEmpty(parts[2]))
                svalue += "::" + parts[2];
            value = svalue;
        }
    }

    partial class ORIGINAL_VERSION
    {
        [Required]
        [ForeignKey("x_versioned_object_uid")]
        public virtual X_VERSIONED_OBJECT x_versioned_object { get; set; }

        [Required]
        public String x_versioned_object_uid { get; set; }
    }

    partial class PARTICIPATION : OpenEhrUuidBasedObject
    {

    }

    partial class PARTY_IDENTIFIED
    {
        public static PARTY_IDENTIFIED Create(String name)
        {
            PARTY_IDENTIFIED rv = new PARTY_IDENTIFIED();
            rv.name = name;
            return rv;
        }
    }

    partial class PARTY_PROXY : OpenEhrUuidBasedObject
    {
        public virtual VERSION Version { get; set; }
    }

    partial class REFERENCE_RANGE : OpenEhrUuidBasedObject
    {

    }

    partial class RESOURCE_DESCRIPTION : OpenEhrUuidBasedObject
    {
        [XmlIgnore]
        [JsonIgnore]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual AUTHORED_RESOURCE authored_resource { get; set; }
    }

    partial class RESOURCE_DESCRIPTION_ITEM : OpenEhrUuidBasedObject
    {

    }

    partial class REVISION_HISTORY : OpenEhrUuidBasedObject
    {

    }

    partial class REVISION_HISTORY_ITEM : OpenEhrNaturalKeyBasedObject
    {

    }

    partial class STATE : OpenEhrUuidBasedObject
    {

    }

    partial class STATE_MACHINE : OpenEhrUuidBasedObject
    {

    }

    partial class StringDictionaryItem : OpenEhrUuidBasedObject
    {

    }
    partial class TERM_BINDING_ITEM : OpenEhrUuidBasedObject
    {

    }

    partial class TERM_MAPPING : OpenEhrUuidBasedObject
    {

    }

    partial class TermBindingSet : OpenEhrUuidBasedObject
    {

    }

    partial class TERMINOLOGY_ID
    {

    }

    partial class TRANSITION : OpenEhrUuidBasedObject
    {

    }

    partial class TRANSLATION_DETAILS : OpenEhrUuidBasedObject
    {
        [ForeignKey("authored_resource_uuid")]
        [XmlIgnore]
        [JsonIgnore]
        public virtual AUTHORED_RESOURCE authored_resource { get; set; }

        public virtual Guid authored_resource_uuid { get; set; }
        [Required]
        [ForeignKey("language")]
        public virtual Guid language_uuid { get; set; }
    }

    partial class UID_BASED_ID
    {
        public String GetExtension()
        {
            var rv = this.value.Split(new String[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
            if (rv.Length > 1)
                return rv[1];
            return String.Empty;
        }

        public String GetRoot()
        {
            var rv = this.value.Split(new String[] {"::"}, StringSplitOptions.RemoveEmptyEntries);
            if (rv.Length != 0)
                return rv[0];
            return String.Empty;
        }
    }
    /* The version identification scheme described here is adapted from the work of Hnìtynka and Plášil [3].
        VERSION objects are identified by a uid attribute, which is a three-part identifier consisting of the
        attributes object_id, creating_system_id and version_tree_id (see support.identification
        package in the Common IM). The first part of the VERSION identifier - the object_id attribute - is a
        copy of the uid of the VERSIONED_OBJECT container in which the VERSION was originally created.
        The second and third parts of the identifier are explained below. 
      
     lifecycle_state : DV_CODED_TEXT - Lifecycle state of the content item in this version.  
        preceding_version_uid : OBJECT_VERSION_ID - Unique identifier of the version of which this version is a modification; Void if this is the first version.  
        uid : OBJECT_VERSION_ID  1 - Unique identifier of this version, containing owner_id, version_tree_id and creating_system_id.
    */
    partial class VERSION : OpenEhrUuidBasedObject
    {
        
    }

    partial class X_VERSIONED_OBJECT: OpenEhrNaturalKeyBasedObject
    {
        public List<OBJECT_VERSION_ID> all_version_ids()
        {
            return this.versions.Select(row => row.uid).ToList();
        }
    }
}