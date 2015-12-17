using Barcline.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Barcline.Hl7.Cda
{
    public interface ICdaObject: IModelObject
    {
    }

    [Serializable]
    public abstract class CdaObject: ModelObject, ICdaObject
    {
    }

    public abstract class CdaObjectCollection<T> : ModelObjectCollection<T>
        where T : CdaObject
    {
        [XmlIgnore]
        public int Length
        {
            get
            {
                return Count;
            }
        }
    }
}
