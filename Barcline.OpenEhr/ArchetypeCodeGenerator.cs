using Barcline.OpenEhr;
using Barcline.OpenEhr.Model;
using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;

namespace Barcline.OpenEhr
{
    [Serializable]
    public class ArchetypeCodeGeneratorException : ApplicationException
    {
        public ArchetypeCodeGeneratorException()
        {
        }

        public ArchetypeCodeGeneratorException(String message) :
            base(message)
        {
        }

        public ArchetypeCodeGeneratorException(String message, Exception innerException) :
            base(message, innerException)
        {
        }
    }

    public class ArchetypeCodeGeneratorOptions
    {
        internal ArchetypeCodeGeneratorOptions()
        {
        }

        public String Namespace { get; set; }

        public String OutputUnitFileName { get; set; }
    }

    public class ArchetypeCodeGenerator
    {
        public ArchetypeCodeGenerator(ARCHETYPE archetype)
        {
            // TODO: preconditions
            this.options = new ArchetypeCodeGeneratorOptions();
            this.archetype = archetype;
        }

        private ARCHETYPE archetype;
        private ArchetypeCodeGeneratorOptions options;

        public ArchetypeCodeGeneratorOptions Options
        {
            get
            {
                return options;
            }
        }

        private Type GetOpenEhrType(String rm_type_name, bool throwIfMissing = false)
        {
            String ns = typeof(LOCATABLE).Namespace;
            Type type = Type.GetType(ns + "." + rm_type_name);
            if (type == null && throwIfMissing)
                throw new ArchetypeCodeGeneratorException("Failed to resolve RM type: " + rm_type_name);
            return type;
        }

        public void Generate()
        {
            // TODO: preconditions
            ArchetypeTraverser traverser = new ArchetypeTraverser(this.archetype);
            CodeCompileUnit cu = new CodeCompileUnit();
            CodeNamespace ns = new CodeNamespace(this.options.Namespace);
            cu.Namespaces.Add(ns);

            // Root class
            C_COMPLEX_OBJECT root = archetype.definition;
            Type rootType = GetOpenEhrType(root.rm_type_name, true);

            CodeTypeDeclaration rootDeclaration = new CodeTypeDeclaration(root.rm_type_name);
            ns.Types.Add(rootDeclaration);
            root.UserData = rootDeclaration;

            traverser.OnObjectFound += (sender, e) =>
            {
                if (e.UserData == rootDeclaration)
                    return;

                Object current = e.UserData;
                if (current == null)
                    return;

                CodeTypeDeclaration currentType = (CodeTypeDeclaration)current;
            };
            traverser.Traverse();

            CodeDomProvider csProvider = new CSharpCodeProvider();
            CodeGeneratorOptions options = new CodeGeneratorOptions();
            using (StreamWriter sourceWriter = new StreamWriter(this.options.OutputUnitFileName))
            {
                csProvider.GenerateCodeFromCompileUnit(cu, sourceWriter, options);
            }
            options.BracingStyle = "C";
        }
    }
}