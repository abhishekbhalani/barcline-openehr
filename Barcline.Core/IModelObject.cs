using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Xml.Serialization;

namespace Barcline.Core
{
    public interface IModelObject
    {
        [Browsable(false)]
        IModelObject GetParent();

        [Browsable(false)]
        IReadOnlyList<IModelObject> GetChildren();

        [XmlIgnore]
        [JsonIgnore]
        [NotMapped]
        [Browsable(false)]
        Object UserData { get; set; }

        [NotMapped]
        [XmlIgnore]
        [JsonIgnore]
        [Browsable(false)]
        object[] PrimaryKey { get; }

        [Browsable(false)]
        bool EqualsTo(IModelObject value);
    }
}