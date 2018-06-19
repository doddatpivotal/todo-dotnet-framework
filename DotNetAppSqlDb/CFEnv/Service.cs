using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.CFEnv
{
    public class Service
    {
        public string ServiceName { get; set; }
        public string BindingName { get; set; }
        public string Label { get; set; }
        public List<string> Tags { get; set; }
        public string Plan { get; set; }
        public Dictionary<string, string> Credentials { get; set; }
    }
}