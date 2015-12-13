using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcline.OpenEhr
{
    public class AuditDetails: OpenEhrDTOBase
    {
        public AuditDetails()
        {
            TimeCommitted = DateTime.UtcNow;
        }
        public String ChangeType { get; set; }
        public String CommitterId { get; set; }
        public String CommitterName { get; set; }
        public String SystemId { get; set; }
        public String Description { get; set; }
        public DateTime TimeCommitted { get; set; }
    }

    public class Contribution : AuditDetails
    {
        public Contribution()
        {
        }
        public String Uid { get; set; }
    }
}
