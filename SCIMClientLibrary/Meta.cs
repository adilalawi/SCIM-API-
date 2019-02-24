using System;

namespace SCIMClientLibrary
{
    public class Meta
    {
        public DateTime created { get; set; }
        public string location { get; set; }
        public DateTime lastModified { get; set; }
        public string version { get; set; }
        public string resourceType { get; set; }
    }
}