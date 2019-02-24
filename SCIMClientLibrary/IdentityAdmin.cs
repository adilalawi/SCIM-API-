using System;
using System.Collections.Generic;

namespace SCIMClientLibrary
{
    public class IdentityAdmin
    {
        //public Administrator administrator { get; set; }
        public List<object> capabilities { get; set; }
        public DateTime lastRefresh { get; set; }
        public bool isManager { get; set; }
        public List<object> accounts { get; set; }
        public int riskScore { get; set; }
        public string personalnummer { get; set; }
        public string userid { get; set; }
    }
}