using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcline.OpenEhr.Storage
{
    public interface ITerminologyService
    {
        List<CodeSystem> GetCodeSystems();
        List<ValueSet> GetValueSets();
    }
}
