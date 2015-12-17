using Barcline.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcline.Hl7.Cda
{
    public interface ICdaObject: IModelObject
    {
    }

    public class CdaObject: ModelObject, ICdaObject
    {
    }

    public class CdaObjectCollection<T> : ModelObjectCollection<T>
        where T : CdaObject
    {
    }
}
