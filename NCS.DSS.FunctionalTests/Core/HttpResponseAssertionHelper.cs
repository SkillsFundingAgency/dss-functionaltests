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
    public class HttpResponseAssertionHelper
    {
        public async Task<bool> ResponseShouldContain(HttpResponseMessage httpResponse, Table expectingResult)
        {
            var expectedVals = new Dictionary<string, object>();
            foreach (var row in expectingResult.Rows)
            {
                expectedVals.Add(row[0], row[1]);
            }
            var obj = ToSerializedObject(expectedVals);

            var body = await httpResponse.Content.ReadAsStringAsync();
            var targetJObject = JsonConvert.DeserializeObject<JObject>(obj);
            var sourceJObject = JsonConvert.DeserializeObject<JObject>(body);
            var responseContainsResult = true;
            foreach (var targetProp in targetJObject.Properties())
            {
                JProperty source = sourceJObject.Property(targetProp.Name);
                if (source == null)
                {
                    throw new Exception($"expceted property: {targetProp.Name}  - {targetProp.Value} but not present");
                }


                if (source.Value.Type != JTokenType.Array)
                {
                    if (!JToken.DeepEquals(source.Value.ToString().ToLower(), targetProp.Value.ToString().ToLower()))
                    {
                        throw new Exception($"{targetProp.Name} value is {source.Value}, expected {targetProp.Value} but got { source.Value}");
                    }
                }
                else
                {
                    var sourceArray = JArray.Parse(source.Value.ToString());
                    var targetArray = JArray.Parse(targetProp.Value.ToString());
                    if (!JToken.DeepEquals(sourceArray, targetArray))
                    {
                        throw new Exception($"{targetProp.Name} value is {sourceArray.ToString()}, expected {targetArray.ToString()} but got { source.Value}");
                    }

                }
            }
            return responseContainsResult;
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

        public async Task<string> GetKeyFromResponse(string key, HttpResponseMessage response)
        {
            var content = await response?.Content?.ReadAsStringAsync();
            if(content != null)
            {
                try
                {
                    var values = JObject.Parse(content);
                    dynamic field = values[key];
                    return field;
                } catch(Exception)
                {
                    return null;
                }
            }
            return null;
        }
    }
}
