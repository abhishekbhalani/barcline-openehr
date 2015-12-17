using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcline.OpenEhr
{
    public class CodeSystem : OpenEhrDTOBase
    {
        public CodeSystem()
        {
            Versions = new List<CodeSystemVersion>();
        }

        public CodeSystem(String oid, String code, String name)
        {
            CodeSystemId = oid;
            Code = code;
            Name = name;
            Versions = new List<CodeSystemVersion>();
            Concepts = new List<Concept>();
        }

        public String URI { get; set; }

        public String Issuer { get; set; }

        [Required]
        public String CodeSystemId { get; set; }

        [Required]
        public String Code { get; set; }

        [Required]
        public String Name { get; set; }
        public String Description { get; set; }

        public List<CodeSystemVersion> Versions { get; set; }

        public List<Concept> Concepts { get; set; }

        protected override void OnValidate(ValidationContext validationContext, List<ValidationResult> vr)
        {
            if (String.IsNullOrEmpty(Code))
                vr.Add(new ValidationResult("Code is required"));
            if (String.IsNullOrEmpty(Name))
                vr.Add(new ValidationResult("Name is required"));
        }
    }

    public class CodeSystemVersion : OpenEhrDTOBase
    {
        public CodeSystemVersion()
        {
            Concepts = new List<Concept>();
        }

        public CodeSystemVersion(String version, DateTime? validFrom = null)
        {
            Concepts = new List<Concept>();
            Version = version;
            if (validFrom != null)
                ValidFrom = validFrom.Value;
        }

        [Required]
        public String Version { get; set; }

        [Required]
        public CodeSystem CodeSystem { get; set; }

        public List<Concept> Concepts {get;set;}

        [Required]
        public DateTime ValidFrom { get; set; }
    }

    public class Concept : OpenEhrDTOBase
    {
        public Concept()
        {

        }

        public Concept(String code, String description = null)
        {
            this.Code = code;
            this.Description = description;
        }

        [Required]
        public CodeSystemVersion Version { get; set; }

        [Required]
        public String Code { get; set; }

        public String CodeSystemId { get; set; }
        public String CodeSystemVersion { get; set; }

        public String Description { get; set; }
        public int? Position { get; set; }
    }

    public class ValueSet : OpenEhrDTOBase
    {
        public ValueSet()
        {
            Versions = new List<ValueSetVersion>();
        }

        [Required]
        [Index(IsUnique=true)]
        public String Code { get; set; }

        [Required]
        [Index(IsUnique = true)]
        public String Name { get; set; }
        public List<ValueSetVersion> Versions {get;set;}
    }

    public class ValueSetVersion : OpenEhrDTOBase
    {
        public ValueSetVersion()
        {
            Items = new List<ValueSetItem>();
        }

        [Required]
        public String Version { get; set; }
        [Required]
        public ValueSet ValueSet { get; set; }

        public List<ValueSetItem> Items {get;set;}
    }

    public class ValueSetItem : OpenEhrDTOBase
    {
        public ValueSetItem()
        {
            Concept = new Concept();
        }

        [Required]
        public ValueSetVersion ValueSetVersion { get; set; }

        [Required]
        public Concept Concept { get; set; }
    }
}
