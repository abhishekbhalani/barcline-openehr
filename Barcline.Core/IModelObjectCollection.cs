using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Barcline.Core
{
    public interface IModelObjectCollection<T> : IEnumerable, IEnumerable<T>, IList<T>, IModelObject
        where T : IModelObject
    {
       
    }
}