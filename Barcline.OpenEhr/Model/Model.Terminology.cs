using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcline.OpenEhr.Model
{
    [Table("CODE_SYSTEM", Schema="terminology")]
    public class CODE_SYSTEM : OpenEhrNaturalKeyBasedObject
    {
        [Required]
        [MaxLength(200)]
        [Key]
        public String oid { get; set; }

        [Required]
        [MaxLength(200)]
        [Index(IsUnique=true)]
        public String code { get; set; }

        [Required]
        [MaxLength(2000)]
        [Index(IsUnique=true)]
        public String name { get; set; }

        [MaxLength(4000)]
        public String description {get;set;}

        private CODE_SYSTEM_VERSIONCollection _versions;

        public virtual CODE_SYSTEM_VERSIONCollection versions
        {
            get
            {
                if (_versions == null)
                    _versions = new CODE_SYSTEM_VERSIONCollection();
                return _versions;
            }
            set
            {
                _versions = value;
            }
        }
    }

    [Table("CODE_SYSTEM_VERSION", Schema="terminology")]
    public class CODE_SYSTEM_VERSION : OpenEhrNaturalKeyBasedObject
    {
        [Required]
        [Key]
        [Column(Order=0)]
        [MaxLength(200)]
        public String code_system_oid { get; set; }

        [Required]
        [ForeignKey("code_system_oid")]
        public CODE_SYSTEM code_system {get;set;}

        [Key]
        [Required]
        [MaxLength(200)]
        [Column(Order = 1)]
        [Index(IsUnique=true)]
        public String version {get;set;}

        [Required]
        public DateTime valid_from { get; set; }

        private CONCEPTCollection _concepts;

        public virtual CONCEPTCollection concepts
        {
            get
            {
                if (_concepts == null)
                    _concepts = new CONCEPTCollection();
                return _concepts;
            }
            set
            {
                _concepts = value;
            }
        }
    }

    public class CODE_SYSTEM_VERSIONCollection : List<CODE_SYSTEM_VERSION> { }

    [Table("CONCEPT", Schema="terminology")]
    public class CONCEPT : OpenEhrNaturalKeyBasedObject
    {
        [Required]
        [Key]
        [Column(Order = 0)]
        [ForeignKey("version")]
        public String code_system_oid { get; set; }

        [Required]
        [ForeignKey("code_system_oid")]
        public virtual CODE_SYSTEM code_system { get; set; }

        [Required]
        [Key]
        [Column(Order = 1)]
        [ForeignKey("version")]
        public String version_id { get; set; }

        [Required]
        public virtual CODE_SYSTEM_VERSION version {get;set;}

        [Required]
        [MaxLength(200)]
        [Key]
        [Column(Order = 2)]
        public String code { get; set; }

        [MaxLength(4000)]
        public String description { get; set; }

        public int? position { get; set; }

        public CONCEPT parent { get; set; }

        private CONCEPTCollection _concepts;

        public virtual CONCEPTCollection concepts
        {
            get
            {
                if (_concepts == null)
                    _concepts = new CONCEPTCollection();
                return _concepts;
            }
            set
            {
                _concepts = value;
            }
        }
    }

    public class CONCEPTCollection : List<CONCEPT>
    {
    }

    [Table("VALUESET", Schema="terminology")]
    public class VALUESET : OpenEhrUuidBasedObject
    {
        [Index("C_VALUESET_CODE_UK", IsUnique = true, Order = 0)]
        [MaxLength(200)]
        [Required]
        public String code { get; set; }

        [Index("C_VALUESET_NAME_UK", IsUnique = true, Order = 0)]
        [MaxLength(1000)]
        [Required]
        public String name { get; set; }

        private VALUESET_VERSIONCollection _versions;

        public VALUESET_VERSIONCollection versions
        {
            get
            {
                if (_versions == null)
                    _versions = new VALUESET_VERSIONCollection();
                return _versions;
            }
            set
            {
                _versions = value;
            }
        }
    }

    [Table("VALUESET_VERSION", Schema="terminology")]
    public class VALUESET_VERSION : OpenEhrUuidBasedObject
    {
        [Required]
        public Guid valueset_uuid { get; set; }

        [Required]
        [ForeignKey("valueset_uuid")]
        public VALUESET valueset { get; set; }

        [Required]
        [MaxLength(200)]
        public String version { get; set; }

        [Required]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]
        public DateTime valid_from { get; set; }

        private VALUESET_ITEMCollection _items;

        public virtual VALUESET_ITEMCollection items
        {
            get
            {
                if (_items == null)
                    _items = new VALUESET_ITEMCollection();
                return _items;
            }
            set
            {
                items = value;
            }
        }
    }

    public class VALUESET_VERSIONCollection: List<VALUESET_VERSION>
    {
    }

    [Table("VALUESET_ITEM", Schema="terminology")]
    public class VALUESET_ITEM : OpenEhrUuidBasedObject
    {
        [Required]
        public Guid version_uuid { get; set; }

        [Required]
        public Guid concept_uuid { get; set; }

        public Guid? parent_uuid { get; set; }
        
        [Required]
        [ForeignKey("version_uuid")]
        public VALUESET_VERSION version { get; set; }

        [ForeignKey("concept"), Column(Order = 0)]
        public String code_system_oid { get; set; }

        [ForeignKey("concept"), Column(Order = 1)]
        public String version_id { get; set; }

        [ForeignKey("concept"), Column(Order = 2)]
        public String code { get; set; }


        [Required]
        public CONCEPT concept { get; set; }

        private VALUESET_ITEMCollection _items;

        public virtual VALUESET_ITEMCollection items
        {
            get
            {
                if (_items == null)
                    _items = new VALUESET_ITEMCollection();
                return _items;
            }
            set
            {
                _items = value;
            }
        }
    }

    public class VALUESET_ITEMCollection : List<VALUESET_ITEM>
    {
    }
}
