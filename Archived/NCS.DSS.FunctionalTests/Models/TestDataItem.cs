using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.DSS.FunctionalTests.Models
{
    public class TestDataItem
    {
        public TestDataItem( string key, string id)
        {
            Key = key;
            Id = id;
        }
        public string Key { get; set; }
        public string Id { get; set; }
  //      string  Resource { get; set; }

    }
}
