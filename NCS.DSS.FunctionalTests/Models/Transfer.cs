using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.DSS.FunctionalTests.Models
{
    class Transfer
    {

        public string TransferId { get; set; }
        public string CustomerId { get; set; }
        public string InteractionId { get; set; }
        public string OriginatingTouchpointId { get; set; }
        public string TargetTouchpointId { get; set; }
        public string Context { get; set; }
        public string DateandTimeOfTransfer { get; set; }
        public string DateandTimeofTransferAccepted { get; set; }
        public string RequestedCallbackTime { get; set; }
        public string ActualCallbackTime { get; set; }
        public string LastModifiedDate { get; set; }
        public string LastModifiedTouchpointId { get; set; }

    }
}
