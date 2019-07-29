﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Text.RegularExpressions;

namespace NCS.DSS.FunctionalTests.Helpers
{
    public class SpecflowHelper
    {
        //private static string TimestampString;

        public static Table ReplaceTokensInTable(Table table, bool propertyInColumnName = true, string propertyValueRef = "" )
        {
            string[] headers = table.Header.ToArray();
            bool processingDateRow = false;
            Table newTable = new Table(headers);
            foreach (var row in table.Rows)
            {
                IDictionary<string, string> newRow = new Dictionary<string, string>();
                foreach (var value in row)
                {
                    string newValue = string.Empty;
                    DateTime extractedDateTime = DateTime.MinValue;
                    //            bool longDate = false;

                    if ((propertyInColumnName && value.Key.ToLower().Contains("date"))
                         ||
                         processingDateRow
                        )
                    {
                        extractedDateTime = TranslateDateToken(value.Value);
                        string dateFormat = (value.Value.Length == 10 ? "yyyy-MM-dd" : "yyyy-MM-ddTHH:mm:ssZ");
                        newValue = (extractedDateTime == DateTime.MinValue ? "" : extractedDateTime.ToString(dateFormat));
                        processingDateRow = false;
                    }
                    else if (!propertyInColumnName
                            && value.Key.ToLower().Equals(propertyValueRef.ToLower())
                            && value.Value.ToLower().Contains("date")
                            )
                    {
                        // table is in format  of Field / Value.  A date field has been detected, so the next item to be processed should be the field value
                        processingDateRow = true;
                    }
                    else
                    {
                        processingDateRow = false;
                    }
                    //else if (value.Value.Contains("[FEATURE_TS]"))
                    //{
                    //    newValue = value.Value.Replace("[FEATURE_TS]", TimestampString);
                    //}
                    if (value.Key.Length > 0)
                    {
                        newRow.Add(value.Key, (newValue == string.Empty) ? value.Value : newValue);
                    }
            
                }
                newTable.AddRow(newRow);
            }
            return newTable;
        }

        public static DateTime TranslateDateToken(string inString)
        {
            DateTime extractedDateTime = DateTime.MinValue;
            if (inString.Contains(" "))
            {
                // extract to componets
                var parts = System.Text.RegularExpressions.Regex.Split(inString, @"\s+");
                Regex rxv = new Regex(@"[+-]{0,1}\d+");

                foreach (var part in parts)
                {
                    switch (part.ToLower())
                    {
                        case "today":
                            extractedDateTime = DateTime.Today;
                            break;
                        case "now":
                            extractedDateTime = DateTime.Now;
                            //                            longDate = true;
                            break;
                        default:
                            var number = rxv.Match(part).Value;
                            if (Regex.IsMatch(part, @"[+-]{0,1}\d+[Y]"))
                            {
                                extractedDateTime = extractedDateTime.AddYears(Convert.ToInt32(number));
                            }
                            else if (Regex.IsMatch(part, @"[+-]{0,1}\d+[D]"))
                            {
                                extractedDateTime = extractedDateTime.AddDays(Convert.ToInt32(number));
                            }
                            else if (Regex.IsMatch(part, @"[+-]{0,1}\d+[M]"))
                            {
                                extractedDateTime = extractedDateTime.AddMonths(Convert.ToInt32(number));
                            }
                            else if (Regex.IsMatch(part, @"[+-]{0,1}\d+[H]"))
                            {
                                extractedDateTime = extractedDateTime.AddHours(Convert.ToInt32(number));
                            }

                            break;

                    }
                }
            }
            else if (inString.ToLower() == "today")
            {
                extractedDateTime = DateTime.Today;
            }
            else if (inString.ToLower() == "now")
            {
                extractedDateTime = DateTime.Now;
            }
            else
            {
                DateTime.TryParse(inString, null, DateTimeStyles.AdjustToUniversal, out extractedDateTime);
            }
            return extractedDateTime;
        }
    }
}
