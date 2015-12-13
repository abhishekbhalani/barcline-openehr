using Barcline.Core;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Barcline.OpenEhr.Model
{
    /// <summary>
    /// Base OpenEHR object
    /// </summary>
    public interface IOpenEhrObject : IModelObject
    {
    }

    /// <summary>
    /// Base collection of OpenEHR objects
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class OpenEhrCollection<T> : ModelObjectCollection<T>
        where T : OpenEhrObject
    {
    }

    /// <summary>
    /// An object which has natural primary key
    /// </summary>
    public class OpenEhrNaturalKeyBasedObject : OpenEhrObject
    {
    }

    /// <summary>
    /// Base OpenEHR object
    /// </summary>
    public class OpenEhrObject : ModelObject, IOpenEhrObject
    {
    }

    /// <summary>
    /// An object which has artifical primary key
    /// </summary>
    public class OpenEhrUuidBasedObject : OpenEhrObject
    {
        public OpenEhrUuidBasedObject()
        {
            uuid = Guid.NewGuid();
        }

        public override object[] PrimaryKey
        {
            get
            {
                return new Object[] { this.uuid };
            }
        }

        [Key]
        [Required]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [XmlIgnore]
        public Guid uuid
        {
            get;
            set;
        }

        public override bool EqualsTo(IModelObject value)
        {
            return (value is OpenEhrUuidBasedObject) &&
                   (this.uuid.Equals(((OpenEhrUuidBasedObject)value).uuid));
        }
    }
}