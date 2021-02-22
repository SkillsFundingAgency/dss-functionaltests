using Microsoft.Extensions.Configuration;
using NUnit.Framework;
[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(2)]

namespace NCS.DSS.FunctionalTests
{

    public class EnvironmentSettings
    {
        private static readonly IConfiguration Configuration =
            new EnvironmentSettingsConfigurationBuilder(nameof(NCS.DSS.FunctionalTests)).BuildConfiguration();

        public string BaseUrl => Configuration["RestService:BaseUrl"];
        public string TestEndpoint01 => Configuration["RestService:TestEndpoint01"];
        public string TestEndpoint02 => Configuration["RestService:TestEndpoint02"];
        public string TestEndpoint03 => Configuration["RestService:TestEndpoint03"];
        public string SubscriptionKey => Configuration["RestService:SubscriptionKey"];
        public string sqlConnectionString => Configuration["SQLDataStore:ConnectionString"];
        public string CosmosEndPoint => Configuration["CosmosDB:EndPoint"];
        public string CosmosAccountKey => Configuration["CosmosDB:Key"];


        public string ACTIONPLAN_POST_URL => BaseUrl + "actionplans/api/Customers/{0}/Interactions/{1}/ActionPlans";
        public string ACTIONPLAN_GET_URL => BaseUrl + "actionplans/api/Customers/{0}/Interactions/{1}/ActionPlans/{2}";
        public string ACTIONPLAN_PATCH_URL => BaseUrl + "actionplans/api/Customers/{0}/Interactions/{1}/ActionPlans/{2}";

        public string ACTION_POST_URL => BaseUrl + "actions/api/Customers/{0}/Interactions/{1}/ActionPlans/{2}/Actions/";
        public string ACTION_GET_URL => BaseUrl + "actions/api/Customers/{0}/Interactions/{1}/ActionPlans/{2}/Actions/{3}";
        public string ACTION_PATCH_URL => BaseUrl + "actions/api/Customers/{0}/Interactions/{1}/ActionPlans/{2}/Actions/{3}";

        public string CUSTOMER_POST_URL => $"{BaseUrl}Customers/api/Customers";
        public string CUSTOMER_GET_URL => BaseUrl + "Customers/api/customers/{0}";
        public string CUSTOMER_PATCH_URL => BaseUrl + "Customers/api/customers/{0}";

        public string WEBCHAT_POST_URL => BaseUrl + "webchats/api/Customers/{0}/Interactions/{1}/WebChats";
        public string WEBCHAT_GET_URL => BaseUrl + "webchats/api/Customers/{0}/Interactions/{1}/WebChats/{2}";
        public string WEBCHAT_PATCH_URL => BaseUrl + "webchats/api/Customers/{0}/Interactions/{1}/WebChats/{2}";

        public string ADVISER_POST_URL => BaseUrl + "adviserdetails/api/AdviserDetails";
        public string ADVISER_GET_URL => BaseUrl + "adviserdetails/api/AdviserDetails/{0}";
        public string ADVISER_PATCH_URL => BaseUrl + "adviserdetails/api/AdviserDetails/{0}";

        public string ADDRESS_POST_URL => BaseUrl + "addresses/api/Customers/{0}/Addresses";
        public string ADDRESS_GET_URL => BaseUrl + "addresses/api/customers/{0}/addresses/{1}";
        public string ADDRESS_PATCH_URL => BaseUrl + "addresses/api/Customers/{0}/addresses/{1}";

        public string CONTACT_POST_URL => BaseUrl + "contactdetails/api/customers/{0}/ContactDetails/";
        public string CONTACT_GETBY_CUSTOMERID_AND_CONTACTID_URL => BaseUrl + "contactdetails/api/customers/{0}/ContactDetails/{1}";
        public string CONTACT_GETBY_CUSTOMERID_URL => BaseUrl + "contactdetails/api/customers/{0}/ContactDetails";
        public string CONTACT_PATCH_URL => BaseUrl + "contactdetails/api/customers/{0}/ContactDetails/{1}";


        public string INTERACTION_POST_URL => BaseUrl + "interactions/api/Customers/{0}/Interactions/";
        public string INTERACTION_GETBY_CUSTOMERID_AND_INTERACTION_URL => BaseUrl + "interactions/api/Customers/{0}/Interactions/{1}";
        public string INTERACTION_GETBY_CUSTOMERID_URL => BaseUrl + "interactions/api/Customers/{0}/Interactions";
        public string INTERACTION_PATCH_URL => BaseUrl + "interactions/api/Customers/{0}/Interactions/{1}";


        public string EMPLOYMENTPROGRESSION_POST_URL => BaseUrl + "employmentprogressions/api/customers/{0}/employmentprogressions";
        public string EMPLOYMENTPROGRESSION_GETBY_CUSTOMERID_AND_EMPLOYMENTPROGRESSIONID_URL => BaseUrl + "employmentprogressions/api/customers/{0}/employmentprogressions/{1}";
        public string EMPLOYMENTPROGRESSION_GETBY_CUSTOMERID_URL => BaseUrl + "employmentprogressions/api/customers/{0}/employmentprogressions";
        public string EMPLOYMENTPROGRESSION_PATCH_URL => BaseUrl + "employmentprogressions/api/customers/{0}/employmentprogressions/{1}";


        public string SESSION_POST_URL => BaseUrl + "sessions/api/Customers/{0}/interactions/{1}/sessions/";
        public string SESSION_GET_URL => BaseUrl + "sessions/api/Customers/{0}/interactions/{1}/sessions/{2}";
        public string SESSION_PATCH_URL => BaseUrl + "sessions/api/Customers/{0}/interactions/{1}/sessions/{2}";

        public string LEARNINGPROGRESSION_POST_URL => BaseUrl + "learningprogressions/api/customers/{0}/LearningProgressions";
        public string LEARNINGPROGRESSION_GET_URL => BaseUrl + "learningprogressions/api/customers/{0}/LearningProgressions/{1}";
        public string LEARNINGPROGRESSION_PATCH_URL => BaseUrl + "learningprogressions/api/customers/{0}/learningprogressions/{1}";
        public string LEARNINGPROGRESSION_GETALL_URL => BaseUrl + "learningprogressions/api/customers/{0}/learningprogressions/";

        public string TRANSFER_POST_URL => BaseUrl + "transfers/api/Customers/{0}/Interactions/{1}/Transfers/";
        public string TRANSFER_GET_URL => BaseUrl + "transfers/api/Customers/{0}/Interactions/{1}/Transfers/{2}";
        public string TRANSFER_PATCH_URL => BaseUrl + "transfers/api/Customers/{0}/Interactions/{1}/Transfers/{2}";

        public string DIGITALIDENTITY_POST_URL => BaseUrl + "digitalidentities/api/identity";
        public string DIGITALIDENTITY_GET__BYCUSTOMERID_URL => BaseUrl + "digitalidentities/api/customers/{0}";
        public string DIGITALIDENTITY_GET_BYDIGITALIDENTITYID_URL => BaseUrl + "digitalidentities/api/identities/{0}";
        public string DIGITALIDENTITY_PATCH_BYCUSTOMERID_URL => BaseUrl + "digitalidentities/api/customer/{0}";
        public string DIGITALIDENTITY_PATCH_BYDIGITALIDENTITYID_URL => BaseUrl + "digitalidentities/api/identity/{0}";
        public string DIGITALIDENTITY_DELETE_BYCUSTOMERID_URL => BaseUrl + "digitalidentities/api/customer/{0}";


        public string OUTCOMES_POST_URL => BaseUrl + "outcomes/api/Customers/{0}/Interactions/{1}/actionplans/{2}/Outcomes/";
        public string OUTCOMES_GET_URL => BaseUrl + "outcomes/api/Customers/{0}/Interactions/{1}/actionplans/{2}/Outcomes/{3}";
        public string OUTCOMES_PATCH_URL => BaseUrl + "outcomes/api/Customers/{0}/Interactions/{1}/actionplans/{2}/Outcomes/{3}";

        public string DIVERSITYDETAIL_POST_URL => BaseUrl + "diversitydetails/api/Customers/{0}/DiversityDetails";
        public string DIVERSITYDETAIL_GET_URL => BaseUrl + "diversitydetails/api/Customers/{0}/DiversityDetails";
        public string DIVERSITYDETAIL_PATCH_URL => BaseUrl + "diversitydetails/api/Customers/{0}/DiversityDetails/{1}";

    }
}


