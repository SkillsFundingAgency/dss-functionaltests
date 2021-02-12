using NCS.DSS.FunctionalTests.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NCS.DSS.FunctionSteps.Core
{
    public class HttpResponseHelper
    {
        public async Task<bool> ResponseShouldContain(HttpResponseMessage httpResponse, Table expectingResult)
        {
            var expectedVals = new Dictionary<string, object>();
            foreach (var row in expectingResult.Rows)
            {
                expectedVals.Add(row[0], row[1]);
            }
            var expectingResultObject = ToSerializedObject(expectedVals);
            var body = await httpResponse?.Content?.ReadAsStringAsync();
            return JsonHelper.JsonContains(body, expectingResultObject);
        }

        public string ToSerializedObject(IDictionary<string, object> source)
        {
            var x = new ExpandoObject() as IDictionary<string, object>;

            foreach (var i in source)
            {
                x.Add(i.Key, i.Value);
            }
            return JsonConvert.SerializeObject(x);
        }

        public dynamic ToObject(IDictionary<string, object> source)
        {
            var x = new ExpandoObject() as IDictionary<string, object>;

            foreach (var i in source)
            {
                x.Add(i.Key, i.Value);
            }
            return x;
        }

        public async Task<int> DocumentCount(HttpResponseMessage httpResponse)
        {
            var response = await httpResponse?.Content?.ReadAsStringAsync();
            return JsonHelper.DocumentCount(response);
        }

        public async Task<string> GetKeyFromResponse(string key, HttpResponseMessage response)
        {
            var content = await response?.Content?.ReadAsStringAsync();
            return JsonHelper.GetValueByKey(content,  key);

        }
    }
}
