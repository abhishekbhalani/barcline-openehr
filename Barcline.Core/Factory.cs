using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Barcline.Core
{
    public static class Factory
    {
        public static T CreateInstance<T>()
            where T: ModelObject, new()
        {
            return new T();
        }

        public static T Load<T>(Stream stream)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            return (T)ser.Deserialize(stream);
        }

        public static String GetXml<T>(Object value)
            where T: IModelObject
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (var sw = new StringWriter())
            {
                ser.Serialize(sw, value);
                sw.Flush();
                return sw.ToString();
            }
        }
    }


}