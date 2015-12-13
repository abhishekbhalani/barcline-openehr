using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Barcline.Core
{
    public sealed class XsdValidator
    {
        public static void Validate(XmlSchema schema, Object obj)
        {
            XmlSchemaSet xmlSchemaSet = new XmlSchemaSet();
            xmlSchemaSet.Add(schema);

            XmlDocument doc = new XmlDocument();

            XmlSerializer ser = new XmlSerializer(obj.GetType());
            using (MemoryStream stm = new MemoryStream())
            {
                ser.Serialize(stm, obj);
                stm.Flush();
                stm.Position = 0;
                doc.Load(stm);
            }

            StringBuilder errors = new StringBuilder();
            bool bErrorsFound = false;
            ValidationEventHandler h = (sender, args) =>
            {
                if (args.Severity == XmlSeverityType.Error)
                {
                    bErrorsFound = true;
                    errors.AppendLine(args.Exception.Message);
                }
            };

            doc.Schemas.Add(schema);
            doc.Validate(h);
            if (bErrorsFound)
            {
                throw new Exception(errors.ToString());
            }
        }
    }
}
