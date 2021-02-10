using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.DSS.FunctionalTests.Models
{
    public class DigitalIdentity
    {
        public Guid? IdentityID { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? IdentityStoreId { get; set; }
        public string LegacyIdentity { get; set; }
        public string id_token { get; set; }
        public DateTime? LastLoggedInDateTime { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedTouchpointId { get; set; }
        public DateTime? DateOfClosure { get; set; }
        //public string CreatedBy { get; set; }
        public int? ttl { get; set; }
    }
}
