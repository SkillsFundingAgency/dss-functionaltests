﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NCS.DSS.FunctionalTests.Helpers
{
    public static class JsonHelper
    {
        public static Boolean CheckJsonPropertyIsPresent(string json, string property)
        {
            var obj = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json.ToLower());
            var check = obj[property.ToLower()];
            return (check != null);//.GetValue(property.ToLower()).ToString().Length > 0;
        }

        public static int DocumentCount( string json)
        {
            JArray a = JArray.Parse(json);
            return a.Count();
        }

        public static bool MatchDocument(string jsonDocument, string jsonCollection)
        {
            // This function attempts to find a record in JsonCollection that matches all elements in jsonDocument
            // It doesn't care if the docs in JsonCollection contain elements that aren't in JsonDocument.

            bool foundMatch = false;
            JArray a = JArray.Parse(jsonCollection);
            JObject b = JObject.Parse(jsonDocument);
            foreach (var doc in a.Children<JObject>().Select((value, index) => new { value, index }))
            {
                bool thisMatches = true;
                foreach (var property in b.Properties() )
                {
                     // does each property in b exist in this item from a?
                    // if (doc.ContainsKey(property.Name) && doc.Property(property.Name).Value == property.Value)
                    // {

                    // }
                    //else
                    if ( !doc.value.ContainsKey(property.Name)  || doc.value.Property(property.Name).Value.ToString() != property.Value.ToString())
                    {
                        //Console.WriteLine("Mismatch found for: " + property.Name + " - " + property.Value);
                        thisMatches = false;
                        break;
                    }
                }
                if ( thisMatches)
                {
                    foundMatch = true;
                    Console.WriteLine("Matching record found at index " + doc.index);
                    break;
                }
            }
            return foundMatch;
        }

        public static Boolean CheckJsonPropertyHasValue(string json, string property)
        {
            var obj = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json.ToLower());
            return obj.GetValue(property.ToLower()).ToString().Length > 0;
        }

        public static Boolean CheckJsonPropertyHasNoValueValue(string json, string property)
        {
            return !CheckJsonPropertyHasValue(json, property);
        }

        public static string RemovePropertyFromJsonString(string json, string property)
        {
            var obj = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json);
            obj.Property(property).Remove();
            return obj.ToString();
        }

        public static Dictionary<string, string> ReplaceFutureDates(ref string json, DateTime replacement, Dictionary<string, int> offsets)
        {
            Dictionary<string, string> returnDict = new Dictionary<string, string>();
            var obj = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json);
            int offset;
            foreach (var property in obj)
            {
                if (property.Key.ToLower().Contains("date"))
                {
                    DateTime dateCheck;
                    if (DateTime.TryParse(property.Value.ToString(), out dateCheck)
                            && dateCheck > DateTime.Today/*.AddDays(-365) */)
                    {
                        try
                        {
                            offset = offsets[property.Key];
                        }
                        catch
                        {
                            offset = 0;
                        }
                        obj[property.Key] = DateTime.Today.AddDays(offset).ToString("yyyy-MM-ddTHH:mm:ssZ");
                        returnDict.Add(property.Key, dateCheck.ToString("yyyy-MM-ddTHH:mm:ssZ"));
                    }
                }
            }
            if (returnDict.Count() > 0)
            {
                json = obj.ToString();
            }
            return returnDict;
        }

        public static string AddPropertyToJsonString(string json, string property, string value)
        {
            if (CheckJsonPropertyIsPresent(json, property))
            {
                return SetPropertyInJsonString(json, property, value);
            }
            var obj = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json);
            obj.Add(property, value);
            return obj.ToString();
        }

        public static string SetPropertyInJsonString(string json, string property, string value)
        {
            var obj = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json);
            obj[property] = value;
            return obj.ToString();
        }

        public static string GetPropertyFromJsonString(string json, string property)
        {
            var obj = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json);
            return (obj.ContainsKey(property)? obj.Property(property).Value.ToString() : string.Empty );
        }
    }
}
