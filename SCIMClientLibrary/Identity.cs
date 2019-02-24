using Newtonsoft.Json;
using System.Collections.Generic;

namespace SCIMClientLibrary
{
    public class Identity
    {
        [JsonProperty("urn:ietf:params:scim:schemas:sailpoint:1.0:User")]
        public IdentityAdmin Administrator { get; set; }
        List<Email> emails { get; set; }
        public string displayName { get; set; }
        public Meta meta { get; set; }
        public List<string> schemas { get; set; }
        public IdentityName name { get; set; }
        public bool active { get; set; }
        public string id { get; set; }
        public string userName { get; set; }
    }
}