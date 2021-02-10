namespace NCS.DSS.FunctionalTests.Models
{
    class SessionV2
    {

        public string SessionID { get; set; }
        public string CustomerID { get; set; }
        public string InteractionID { get; set; }
        public string SubcontractorId { get; set; }
        public string DateandTimeOfSession { get; set; }
        public string VenuePostCode { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string SessionAttended { get; set; }
        public string ReasonForNonAttendance { get; set; }
        public string LastModifiedDate { get; set; }
        public string LastModifiedTouchpointID { get; set; }

    }
}
