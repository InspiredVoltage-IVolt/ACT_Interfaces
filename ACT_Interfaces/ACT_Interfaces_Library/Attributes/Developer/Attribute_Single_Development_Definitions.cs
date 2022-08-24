using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Attributes.Developer
{
    public class Attribute_Single_Development_Definition
    {
        int? _priority = 0;

        [JsonProperty("classname", NullValueHandling = NullValueHandling.Ignore)]
        public string Classname { get; set; }

        [JsonProperty("typename", NullValueHandling = NullValueHandling.Ignore)]
        public string Typename { get; set; }

        [JsonProperty("todo", NullValueHandling = NullValueHandling.Ignore)]
        public string Todo { get; set; }

        [JsonProperty("todo_description", NullValueHandling = NullValueHandling.Ignore)]
        public string Todo_Description { get; set; }

        [JsonProperty("removebeforerelease", NullValueHandling = NullValueHandling.Ignore)]
        public string Removebeforerelease { get; set; }

        [JsonProperty("removebeforerelease_description", NullValueHandling = NullValueHandling.Ignore)]
        public string Removebeforerelease_Description { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Include)]
        public int? Priority { get { return _priority; } set { if (value != null) { _priority = value; } } }

        [JsonProperty("originadeveloperinfo", NullValueHandling = NullValueHandling.Ignore)]
        public string Originadeveloperinfo { get; set; }

        [JsonProperty("lastdeveloperinfo", NullValueHandling = NullValueHandling.Ignore)]
        public string Lastdeveloperinfo { get; set; }
    }
}
