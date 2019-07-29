using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.DSS.FunctionalTests.Models
{
    class LearningProgression
    {
        public string LearningProgressionID { get; set; }
        public string CustomerID { get; set; }
        public string SubcontractorId { get; set; }
        public string DateProgressionRecorded { get; set; }
        public string CurrentLearningStatus { get; set; }
        public string LearningHours { get; set; }
        public string DateLearningStarted { get; set; }
        public string CurrentQualificationLevel { get; set; }
        public string DateQualificationLevelAchieved { get; set; }
        public string LastLearningProvidersUKPRN { get; set; }
        public string LastModifiedDate { get; set; }
        public string LastModifiedTouchpointID { get; set; }
        public string CreatedBy { get; set; }

    }
}
