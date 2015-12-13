using Barcline.OpenEhr;
using Barcline.OpenEhr.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcline.OpenEhr
{
    public class Agent : OpenEhrDTOBase
    {
        public Agent()
        {
            Identifiers = new List<II>();
            Roles = new List<Role>();
        }

        public virtual String AgentType
        {
            get
            {
                return PARTY_REF_TYPE.AGENT;
            }
        }

        public List<II> Identifiers { get; set; }

        public String Name { get; set; }
        public List<Role> Roles { get; set; }
    }

    public class EhrSystem : Agent
    {

    }

    public class Folder : OpenEhrDTOBase
    {
        public Folder()
        {
            Folders = new List<Folder>();
            Items = new List<string>();
        }

        public List<Folder> Folders { get; set; }

        public List<String> Items { get; set; }

        public String Name { get; set; }
    }

    public class II
    {
        public String Extension { get; set; }

        public String Root { get; set; }
    }

    public class OpenEhrDTOBase : IValidatableObject
    {
        [Key]
        [Required]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public String Id { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> rv = new List<ValidationResult>();
            OnValidate(validationContext, rv);
            return rv;
        }

        protected virtual void OnValidate(ValidationContext validationContext, List<ValidationResult> vr)
        {

        }
    }
    public class Organisation : Agent
    {
        public override string AgentType
        {
            get
            {
                return PARTY_REF_TYPE.ORGANISATION;
            }
        }
    }

    public class Person : Agent
    {
        public override string AgentType
        {
            get
            {
                return PARTY_REF_TYPE.PERSON;
            }
        }
    }

    public class Role : Agent
    {
        public override string AgentType
        {
            get
            {
                return PARTY_REF_TYPE.ROLE;
            }
        }
    }
}
