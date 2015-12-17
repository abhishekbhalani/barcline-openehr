using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Barcline.OpenEhr.Storage
{
    public class SimpleTerminologyService : ITerminologyService
    {
        XDocument openEhrTerminology;
        XDocument externalTerminologies;
        List<CodeSystem> codeSystems = new List<CodeSystem>();
        List<ValueSet> valueSets = new List<ValueSet>();

        public SimpleTerminologyService()
        {
            ParseOpenEhrTerminology();
        }

        private void ParseOpenEhrTerminology()
        {
            codeSystems.Clear();
            valueSets.Clear();

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(typeof(SimpleTerminologyService).Namespace + ".Resources.openehr_terminology_en.xml"))
            {
                openEhrTerminology = XDocument.Load(stream);
                foreach (var codeSetElement in openEhrTerminology.Root.Elements("codeset"))
                {
                    CodeSystem cs = new CodeSystem();
                    cs.CodeSystemId = codeSetElement.Attribute("external_id").Value;
                    cs.Code = codeSetElement.Attribute("openehr_id").Value;
                    cs.Issuer = codeSetElement.Attribute("issuer").Value;
                    codeSystems.Add(cs);
                    CodeSystemVersion v = new CodeSystemVersion() { Version = "1.0" };
                    cs.Versions.Add(v);
                    foreach (var conceptElement in codeSetElement.Elements("code"))
                    {
                        Concept concept = new Concept();
                        concept.Code = conceptElement.Attribute("value").Value;
                        concept.Description = concept.Code;
                        v.Concepts.Add(concept);
                    }
                }

                foreach (var valueSetElement in openEhrTerminology.Root.Elements("group"))
                {
                    ValueSet vs = new ValueSet();
                    vs.Name = valueSetElement.Attribute("name").Value;
                    vs.Code = vs.Name;
                    valueSets.Add(vs);
                    ValueSetVersion vsv = new ValueSetVersion();
                    vsv.Version = "1.0";
                    vs.Versions.Add(vsv);

                    foreach (var valueSetItemElement in valueSetElement.Elements("concept"))
                    {
                        Concept concept = new Concept();
                        concept.Code = valueSetItemElement.Attribute("id").Value;
                        concept.Description = valueSetItemElement.Attribute("rubric").Value;
                        ValueSetItem vsi = new ValueSetItem();
                        vsi.Concept = concept;
                        vsv.Items.Add(vsi);
                    }
                }
            }
        }

        public List<CodeSystem> GetCodeSystems()
        {
            return codeSystems;
        }

        public List<ValueSet> GetValueSets()
        {
            return valueSets;
        }
    }
}
