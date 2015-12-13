using Barcline.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace Barcline.OpenEhr
{
    [Serializable]
    public class OpenEhrValidatorException : ApplicationException
    {
        public OpenEhrValidatorException()
        {
            Errors = new List<XmlSchemaException>();
        }

        public OpenEhrValidatorException(String message)
            : base(message)
        {
            Errors = new List<XmlSchemaException>();
        }

        public List<XmlSchemaException> Errors { get; private set; }
    }

    public static class OpenEhrValidator
    {
        private static XmlSchema openEhrXmlSchema;
        private static XmlSchema openEhrCompositionTemplateXmlSchema;

        public static XmlSchema OpenEhrCompositionTemplateXmlSchema
        {
            get
            {
                if (openEhrCompositionTemplateXmlSchema == null)
                {
                    String path = typeof(OpenEhrValidator).Namespace + ".Resources.CompositionTemplate.xsd";
                    using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
                    {
                        openEhrCompositionTemplateXmlSchema = XmlSchema.Read(stream, null); // TODO: add validator
                        openEhrCompositionTemplateXmlSchema.Compile(null); // TODO: add validator
                    }
                }
                return openEhrCompositionTemplateXmlSchema;
            }
        }

        public static XmlSchema OpenEhrXmlSchema
        {
            get
            {
                if (openEhrXmlSchema == null)
                {
                    String path = typeof(OpenEhrValidator).Namespace + ".v1_0_1.OpenEHR.xsd";
                    using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
                    {
                        openEhrXmlSchema = XmlSchema.Read(stream, null); // TODO: add validator
                        openEhrXmlSchema.Compile(null); // TODO: add validator
                    }
                }
                return openEhrXmlSchema;
            }
        }

        public static void Validate(IModelObject obj)
        {
            List<XmlSchemaException> list = new List<XmlSchemaException>();

            bool bError = false;
            var validator = new ValidationEventHandler((sender, e) =>
            {
                if (e.Severity == XmlSeverityType.Error)
                {
                    list.Add(e.Exception);
                    bError = true;
                }
            });

            using (MemoryStream stream = new MemoryStream())
            {
                // TODO: xml
                stream.Position = 0;
                XmlDocument document = new XmlDocument();
                document.Load(stream);
                document.Schemas.Add(OpenEhrXmlSchema);
                document.Validate(validator, document);
                if (bError)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var err in list)
                    {
                        String errm = String.Format("Line {0}, Element {1}: {2}", err.LineNumber, err.SourceSchemaObject, err.Message);
                        sb.AppendLine(errm);
                    }
                    OpenEhrValidatorException ex = new OpenEhrValidatorException(sb.ToString());
                    ex.Errors.AddRange(list);
                    throw ex;
                }
            }
        }
    }
}