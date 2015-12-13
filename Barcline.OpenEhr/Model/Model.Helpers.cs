using System;
using System.Linq;

namespace Barcline.OpenEhr.Model
{
    public static class ModelHelpers
    {
        public static String LookupTranslationText(this ARCHETYPE archetype, String language, String code)
        {
            if (archetype.ontology == null ||
                archetype.ontology.term_definitions == null)
            {
                return String.Empty;
            }

            if (String.IsNullOrEmpty(language) ||
                String.IsNullOrEmpty(code))
            {
                return String.Empty;
            }

            var td = archetype.ontology.term_definitions.FirstOrDefault(row => row.language.Equals(language));
            if (td != null)
            {
                var item = td.items.FirstOrDefault(row => row.code.Equals(code));
                if (item != null)
                {
                    var rv = item.items.FirstOrDefault(row => row.id.Equals("text"));
                    if (rv != null)
                        return rv.Value;
                }
            }
            return String.Empty;
        }

        public static String LookupTranslationDescription(this ARCHETYPE archetype, String language, String code)
        {
            if (archetype.ontology == null ||
                archetype.ontology.term_definitions == null)
            {
                return String.Empty;
            }

            if (String.IsNullOrEmpty(language) ||
                String.IsNullOrEmpty(code))
            {
                return String.Empty;
            }

            var td = archetype.ontology.term_definitions.FirstOrDefault(row => row.language.Equals(language));
            if (td != null)
            {
                var item = td.items.FirstOrDefault(row => row.code.Equals(code));
                if (item != null)
                {
                    var rv = item.items.FirstOrDefault(row => row.id.Equals("description"));
                    if (rv != null)
                        return rv.Value;
                }
            }
            return String.Empty;
        }
    }
}