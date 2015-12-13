using Barcline.Core;
using Barcline.OpenEhr.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Barcline.OpenEhr.Storage
{
    public sealed class ArchetypeFileStorage : IArchetypeStorage
    {
        private DirectoryInfo rootDirectory;

        public ArchetypeFileStorage(String directory)
        {
            rootDirectory = new DirectoryInfo(directory);
            if (!rootDirectory.Exists)
                throw new FileNotFoundException(directory);
        }

        public List<String> EnumArchetypeIds()
        {
            List<FileInfo> files = new List<FileInfo>();

            files.AddRange(rootDirectory.GetFiles("*CLUSTER*.xml", SearchOption.AllDirectories));
            files.AddRange(rootDirectory.GetFiles("*COMPOSITION*.xml", SearchOption.AllDirectories));
            files.AddRange(rootDirectory.GetFiles("*DEMOGRAPHIC*.xml", SearchOption.AllDirectories));
            files.AddRange(rootDirectory.GetFiles("*ELEMENT*.xml", SearchOption.AllDirectories));

            files.AddRange(rootDirectory.GetFiles("*ACTION*.xml", SearchOption.AllDirectories));
            files.AddRange(rootDirectory.GetFiles("*ADMIN_ENTRY*.xml", SearchOption.AllDirectories));
            files.AddRange(rootDirectory.GetFiles("*EVALUATION*.xml", SearchOption.AllDirectories));
            files.AddRange(rootDirectory.GetFiles("*INSTRUCTION*.xml", SearchOption.AllDirectories));
            files.AddRange(rootDirectory.GetFiles("*OBSERVATION*.xml", SearchOption.AllDirectories));

            files.AddRange(rootDirectory.GetFiles("*SECTION*.xml", SearchOption.AllDirectories));

            return files.Select(row => Path.GetFileNameWithoutExtension(row.Name)).Distinct().ToList();
        }

        private void InternalPopulateFolder(DirectoryInfo di, FOLDER folder)
        {
            foreach (var sdi in di.GetDirectories())
            {
                FOLDER subFolder = new FOLDER() { name = new DV_TEXT() { value = sdi.Name } };
                folder.folders.Add(subFolder);
                InternalPopulateFolder(sdi, subFolder);
            }
            foreach (var fi in di.GetFiles("*.xml"))
            {
                OBJECT_REF oref = new OBJECT_REF();
                ARCHETYPE_ID aid = new ARCHETYPE_ID();
                aid.value = Path.GetFileNameWithoutExtension(fi.Name);
                oref.id = aid;
                folder.items.Add(oref);
            }
        }

        public FOLDER GetRootFolder(ORIGINAL_VERSION version)
        {
            FOLDER folder = new FOLDER();
            folder.name = new DV_TEXT() { value = rootDirectory.Name };
            InternalPopulateFolder(rootDirectory, folder);
            return folder;
        }

        public ARCHETYPE LoadArchetype(String id)
        {
            String pattern = id;
            String extension = ("" + Path.GetExtension(id)).ToLower();

            if (!"xml".Equals(extension))
                pattern = pattern + ".xml";

            var file = rootDirectory.GetFiles(pattern, SearchOption.AllDirectories).FirstOrDefault();
            if (file == null)
                throw new FileNotFoundException(pattern);

            using (var stream = file.OpenRead())
            {
                return (ARCHETYPE)(new XmlSerializer(typeof(ARCHETYPE)).Deserialize(stream));
            }
        }

        public List<ARCHETYPE> LoadArchetypeList()
        {
            Dictionary<String, ARCHETYPE> map = LoadArchetypeMap();
            return map.Values.ToList();
        }

        public Dictionary<string, ARCHETYPE> LoadArchetypeMap()
        {
            Dictionary<String, ARCHETYPE> result = new Dictionary<string, ARCHETYPE>();
            List<String> ids = EnumArchetypeIds();

            XmlSerializer serializer = new XmlSerializer(typeof(ARCHETYPE));

            foreach (var id in ids)
            {
                String fileName = id + ".xml";
                FileInfo fi = rootDirectory.GetFiles(fileName, SearchOption.AllDirectories).FirstOrDefault();
                if (fi != null)
                {
                    using (var fs = fi.OpenRead())
                    {
                        ARCHETYPE archetype = (ARCHETYPE)serializer.Deserialize(fs);
                        if (!result.ContainsKey(archetype.archetype_id.value))
                            result.Add(archetype.archetype_id.value, archetype);
                    }
                }
            }

            return result;
        }


        public List<ARCHETYPE> LoadArchetypes(ORIGINAL_VERSION version, string folder)
        {
            List<ARCHETYPE> result = new List<ARCHETYPE>();
            var rootFolder = this.rootDirectory;
            var targetDir = rootFolder.GetDirectories(folder, SearchOption.AllDirectories).FirstOrDefault();
            if (targetDir != null)
            {
                foreach (FileInfo fi in targetDir.GetFiles("*.xml", SearchOption.TopDirectoryOnly)) 
                {
                    using (var stream = fi.OpenRead())
                    {
                        ARCHETYPE archetype = Factory.Load<ARCHETYPE>(stream);
                        result.Add(archetype);
                    }
                }
            }
            return result;
        }


        public void UploadArchetype(string folder, ARCHETYPE archetype)
        {
            throw new NotImplementedException();
        }
    }
}