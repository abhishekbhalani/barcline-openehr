using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using System.ComponentModel;

namespace Barcline.Core
{
    [Serializable]
    public class ModelObjectCollection<T> : List<T>, IModelObjectCollection<T>, IModelObject
        where T : IModelObject
    {
        public virtual IModelObject GetParent()
        {
            return null;
        }
        
        [XmlIgnore]
        [JsonIgnore]
        [NotMapped]
        public object UserData {get;set;}

        public virtual IReadOnlyList<IModelObject> GetChildren()
        {
            return this.Cast<IModelObject>().ToList().AsReadOnly();
        }

        [NotMapped]
        [XmlIgnore]
        [JsonIgnore]
        [Browsable(false)]
        public object[] PrimaryKey
        {
            get { return new Object[0]; }
        }

        public bool EqualsTo(IModelObject value)
        {
            return this == value;
        }
    }
}