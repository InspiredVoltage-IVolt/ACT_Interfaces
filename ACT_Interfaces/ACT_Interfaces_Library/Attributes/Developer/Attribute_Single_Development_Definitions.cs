﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Attributes.Developer
{
    public class Attribute_Single_Development_Definition
    {
        int? _Priority = 0;

        [JsonProperty("classname", NullValueHandling = NullValueHandling.Ignore)]
        public string classname { get; set; }

        [JsonProperty("typename", NullValueHandling = NullValueHandling.Ignore)]
        public string typename { get; set; }

        [JsonProperty("todo", NullValueHandling = NullValueHandling.Ignore)]
        public string todo { get; set; }

        [JsonProperty("todo_description", NullValueHandling = NullValueHandling.Ignore)]
        public string todo_description { get; set; }

        [JsonProperty("removebeforerelease", NullValueHandling = NullValueHandling.Ignore)]
        public string removebeforerelease { get; set; }

        [JsonProperty("removebeforerelease_description", NullValueHandling = NullValueHandling.Ignore)]
        public string removebeforerelease_description { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Include)]
        public int? priority { get { return _Priority; } set { if (value != null) { _Priority = value; } } }

        [JsonProperty("originadeveloperinfo", NullValueHandling = NullValueHandling.Ignore)]
        public string originadeveloperinfo { get; set; }

        [JsonProperty("lastdeveloperinfo", NullValueHandling = NullValueHandling.Ignore)]
        public string lastdeveloperinfo { get; set; }
    }
}
