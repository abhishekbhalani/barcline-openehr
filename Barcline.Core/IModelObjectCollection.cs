using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Barcline.Core
{
    public interface IModelObjectCollection: IEnumerable
    {

    }
    public interface IModelObjectCollection<T> : IModelObjectCollection, IEnumerable<T>, IList<T>, IModelObject
        where T : IModelObject
    {
       
    }
}