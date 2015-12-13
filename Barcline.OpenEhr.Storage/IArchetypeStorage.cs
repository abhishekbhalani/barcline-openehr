using Barcline.OpenEhr;
using Barcline.OpenEhr.Model;
using System;
using System.Collections.Generic;

namespace Barcline.OpenEhr.Storage
{
    public interface IArchetypeStorage
    {
        FOLDER GetRootFolder(ORIGINAL_VERSION version);

        List<String> EnumArchetypeIds();

        ARCHETYPE LoadArchetype(String id);

        List<ARCHETYPE> LoadArchetypeList();

        List<ARCHETYPE> LoadArchetypes(ORIGINAL_VERSION version, String folder);

        Dictionary<String, ARCHETYPE> LoadArchetypeMap();

        void UploadArchetype(String folder, ARCHETYPE archetype);
    }
}