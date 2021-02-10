namespace NCS.DSS.FunctionalTests.Models
{
    class ActionV2
    {

        public string ActionId { get; set; }
        public string CustomerId { get; set; }
        public string ActionPlanId { get; set; }
        public string InteractionID { get; set; }
        public string DateActionAgreed { get; set; }
        public string DateActionAimsToBeCompletedBy { get; set; }
        public string DateActionActuallyCompleted { get; set; }
        public string ActionSummary { get; set; }
        public string SignpostedTo { get; set; }
        public string ActionType { get; set; }
        public string ActionStatus { get; set; }
        public string PersonResponsible { get; set; }
        public string LastModifiedDate { get; set; }
        public string LastModifiedTouchpointId { get; set; }

    }
}
