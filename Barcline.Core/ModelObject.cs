using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Linq;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Barcline.Core
{
    [Serializable]
    public abstract class ModelObject : IModelObject, IValidatableObject
    {
        public ModelObject()
        {
        }

        [Browsable(false)]
        public virtual IReadOnlyList<IModelObject> GetChildren()
        {
            return EntityUtil.GetChildren(this);
        }

        [Browsable(false)]
        public virtual IModelObject GetParent()
        {
            return null;
        }

        [NotMapped]
        [XmlIgnore]
        [JsonIgnore]
        [Browsable(false)]
        public virtual object[] PrimaryKey
        {
            get
            {
                return EntityUtil.GetPrimaryKey(this);
            }
        }

        [XmlIgnore]
        [JsonIgnore]
        [Browsable(false)]
        [NotMapped]
        public Object UserData { get; set; }

        [Browsable(false)]
        public virtual bool EqualsTo(IModelObject value)
        {
            return EntityUtil.HaveSamePrimaryKey(this, value);
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return new List<ValidationResult>();
        }

        protected internal IModelObject _parentField;

        public override string ToString()
        {
            var rv = this.GetType().Name +
                " [" +
                String.Join(",", this.PrimaryKey.Select(row => String.Format("{0}", row)).ToArray()) +
                "]";
            return rv;
        }
    }
}