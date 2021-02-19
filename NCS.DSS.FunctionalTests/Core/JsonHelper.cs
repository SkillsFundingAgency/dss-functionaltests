using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace NCS.DSS.FunctionalTests.Core
{
    public static class JsonHelper
    {
        private static bool DoesContain(JToken targetDoc, JObject sourceDoc, List<string> fieldsToIgnore)
        {
            if (sourceDoc != null || targetDoc != null)
            {
                var targetJson = targetDoc.ToString();
                var targetObj = JsonConvert.DeserializeObject<JObject>(targetJson);
                foreach (var sourceProp in sourceDoc.Properties())
                {
                    if (fieldsToIgnore != null && fieldsToIgnore.Contains(sourceProp.Name))
                        continue;

                    JProperty target = targetObj.Property(sourceProp.Name);
                    if (target == null)
                    {
                        throw new Exception($"expceted property: {sourceProp.Name}  - {sourceProp.Value} but not present");
                    }
                    if (target?.Value?.Type != JTokenType.Array)
                    {
                        if (!JToken.DeepEquals(target.Value?.ToString()?.ToLower(), sourceProp?.Value?.ToString()?.ToLower()))
                        {
                            throw new Exception($"{sourceProp?.Name} value is {target?.Value}, expected {sourceProp?.Value} but got { target?.Value}");
                        }
                    }
                    else
                    {
                        var sourceArray = JArray.Parse(target?.Value?.ToString());
                        var targetArray = JArray.Parse(sourceProp?.Value?.ToString());
                        if (!JToken.DeepEquals(sourceArray, targetArray))
                        {
                            throw new Exception($"{sourceProp?.Name} value is {sourceArray?.ToString()}, expected {targetArray?.ToString()} but got { target?.Value}");
                        }
                    }
                }
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Checks to see if targetDoc contains the sourceDoc Json document
        /// </summary>
        /// <param name="targetDoc">Json target document that may contain sourceDoc</param>
        /// <param name="sourceDoc">Json document</param>
        /// <returns></returns>
        public static bool JsonContains(string targetDoc, string sourceDoc, List<string> fieldsToIgnore)
        {
            if (!string.IsNullOrEmpty(targetDoc) && !string.IsNullOrEmpty(sourceDoc))
            {
                try
                {
                    var targetObj = JToken.Parse(targetDoc);
                    var sourceOject = JsonConvert.DeserializeObject<JObject>(sourceDoc);

                    if (targetObj is JArray)
                    {
                        foreach (var item in targetObj.Children())
                        {
                            var contains = DoesContain(item, sourceOject, fieldsToIgnore);
                            if (contains)
                                return contains;
                        }
                    }
                    else
                    {
                        return DoesContain(targetObj, sourceOject, fieldsToIgnore);
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns a count of documents from a json string
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static int DocumentCount(string json)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(json))
            {
                try
                {
                    JArray a = JArray.Parse(json);
                    count = a.Count;
                }
                catch
                {
                    count = 1;
                }
            }
            return count;
        }

        /// <summary>
        /// Tries to get the value of a key from a json string. This is used
        /// from the HttpResponseHelper
        /// </summary>
        /// <param name="json"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValueByKey(string json, string key)
        {
            if (json != null)
            {
                try
                {
                    var values = JObject.Parse(json);
                    dynamic field = values[key];
                    return field;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }

        public static string AsJson(string content)
        {
            try
            {
                JObject json = JObject.Parse(content);

                return json.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string ToSerializedObject(IDictionary<string, object> source)
        {
            var x = new ExpandoObject() as IDictionary<string, object>;

            foreach (var i in source)
            {
                x.Add(i.Key, i.Value);
            }
            return JsonConvert.SerializeObject(x);
        }

        public static string ToSerializedObjectArray(List<object> source)
        {
            DFC.JSON.Standard.JsonHelper helper = new DFC.JSON.Standard.JsonHelper();
            return JsonConvert.SerializeObject(source);
        }

        public static dynamic ToObject(IDictionary<string, object> source)
        {
            var x = new ExpandoObject() as IDictionary<string, object>;

            foreach (var i in source)
            {
                x.Add(i.Key, i.Value);
            }
            return x;
        }

        public static string RenameProperty(string json, string propertyName, string newPropertyName)
        {
            DFC.JSON.Standard.JsonHelper helper = new DFC.JSON.Standard.JsonHelper();
            var obj = JObject.Parse(json);
            return helper.SerializeObjectAndRenameIdProperty(obj, propertyName, newPropertyName);
        }
    }
}


