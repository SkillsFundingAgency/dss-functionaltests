using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using FunctionalTests.StepDefs;

namespace NCS.DSS.FunctionalTests
{
    class RequestContext
    {
        public string baseUrl;
        public string url;
        public string json;
        public string json2;
        public string id;
        public string customerId;
        public string adviserDetailId;
        public string addressId;
        public string contactId;
        public string interactionId;
        public string actionPlanId;

        public string sessionId;
        public string goalId;
        public string outcomeId;
        public string webChatId;
        public string diversityId;
        public string subscriptionId;
        public string transferId;
        public bool lastRequestWasPatch = false;
        public string targetOfLastPost = "";
        public DateTime requestTime;
        public DateTime PostUpdateTime;
        public string creatingTouchpoint;
        public string lastTouchpoint;
        public String lastResourceName;
        public string actionId;

        private Dictionary<string, Guid> documentIds = new Dictionary<string, Guid>();
        private Dictionary<string, string> requestUrls = new Dictionary<string, string>();
        private Dictionary<string, HttpStatusCode> requestResponseCodes = new Dictionary<string, HttpStatusCode>();
        private Dictionary<string, string> requestResponseContent = new Dictionary<string, string>();

        public void SetRequestDetails(string resource, string url, Guid guid, HttpStatusCode responseCode, string responseContent)
        {
            //if (documentIds.ContainsKey(resource))
            //{
            //    documentIds[resource] = guid;
            //}
            //else
            //{
            //    documentIds.Add(resource, guid);
            //}
            SetDocumentId(resource, guid);

            if (requestUrls.ContainsKey(resource))
            {
                requestUrls[resource] = url;
            }
            else
            {
                requestUrls.Add(resource, url);
            }
            if (requestResponseCodes.ContainsKey(resource))
            {
                requestResponseCodes[resource] = responseCode;
            }
            else
            {
                requestResponseCodes.Add(resource, responseCode);
            }
            if (requestResponseContent.ContainsKey(resource))
            {
                requestResponseContent[resource] = responseContent;
            }
            else
            {
                requestResponseContent.Add(resource, responseContent);
            }
            //requestUrls.Add(resource, url);
            //requestResponseCodes.Add(resource, responseCode);
            //requestResponseContent.Add(resource, responseContent);
        }

        public void UpdateRequestDetails(string resource, HttpStatusCode responseCode, string responseContent)
        {
            requestResponseCodes[resource] = responseCode;
            requestResponseContent[resource] = responseContent;

        }

        public Guid GetDocumentId(string resource)
        {
            return documentIds[resource];
        }

        public void SetDocumentId(string resource, Guid guid)
        {
            if (documentIds.ContainsKey(resource))
            {
                documentIds[resource] = guid;
            }
            else
            {
                documentIds.Add(resource, guid);
            }
        }

        public string GetDocumentBaseUrl(string resource)
        {
            return requestUrls[resource];
        }

        public HttpStatusCode GetResponseCode(string resource)
        {
            return requestResponseCodes[resource];
        }

        public string GetResponseContent(string resource)
        {
            return requestResponseContent[resource];
        }

        public string getUrlPart(string resource)
        {
            return ( resource + "/" + GetDocumentId(resource) + "/");
        }

        public string UrlBuilder( string resource)
        {
            string returnUrl = "/" + resource + "/api/";
            
            switch( resource)
            {
                case constants.Customers:
                case constants.AdviserDetails:
                    returnUrl += resource + "/";
                    break;
                case constants.Interactions:
                case constants.Subscriptions:
                case constants.DiversityDetails:
                case constants.Addresses:
                case constants.LearningProgressions:
                    returnUrl += getUrlPart(constants.Customers) + resource + "/";
                    break;
                case constants.Sessions:
                case constants.ActionPlans:
                case constants.WebChats:
                case constants.Transfers:
                    returnUrl += getUrlPart(constants.Customers) + getUrlPart(constants.Interactions) + resource + "/";
                    break;
                case constants.Outcomes:
                case constants.Actions:
                case constants.Goals:
                    returnUrl += getUrlPart(constants.Customers) + getUrlPart(constants.Interactions) + getUrlPart(constants.ActionPlans) + resource + "/";
                    break;
                case constants.Contacts: // exception - doesn't fit patter so handle on its own
                    returnUrl = "/ContactDetails/api/" + getUrlPart(constants.Customers) + "ContactDetails/";
                    break;
            }
            //returnUrl += resource + "/";

            return returnUrl;
        }

    }
}
