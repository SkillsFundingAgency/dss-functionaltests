using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.DSS.FunctionalTests.Models
{
    class EmploymentProgression
    {
        public string DateProgressionRecorded { get; set; }
        public string CurrentEmploymentStatus { get; set; }
        public string EconomicShockStatus { get; set; }
        public string EconomicShockCode { get; set; }
        public string EmployerName { get; set; }
        public string EmployerAddress { get; set; }
        public string EmployerPostcode { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string EmploymentHours { get; set; }
        public string DateOfEmployment { get; set; }
        public string DateOfLastEmployment { get; set; }
        public string LengthOfUnemployment { get; set; }
        public string LastModifiedDate { get; set; }
        public string LastModifiedTouchpointID { get; set; }
        public string CreatedBy { get; set; }
    }
}
