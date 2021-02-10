using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace NCS.DSS.FunctionalTests.Transformations
{
    [Binding]
    public class DateTransformation
    {
        [StepArgumentTransformation(@"Translate Date To (.*)")]
        public string TransformDateExpressionIntoDateTimeString(string inString)
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
                            extractedDateTime = DateTime.UtcNow;
                            extractedDateTime = extractedDateTime.AddSeconds(-10);
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
                extractedDateTime = DateTime.UtcNow;
                extractedDateTime = extractedDateTime.AddSeconds(-10);
            }
            else
            {
                if (DateTime.TryParse(inString, null, DateTimeStyles.AdjustToUniversal, out extractedDateTime))
                    return extractedDateTime.ToString();
                else
                    return inString;

            }
            return extractedDateTime.ToString();
        }

        [StepArgumentTransformation(@"(.*) days ago")]
        public DateTime DaysAgoTransform(string daysAgo)
        {
            return DateTime.Today.AddDays(-1);
        }
    }
}
