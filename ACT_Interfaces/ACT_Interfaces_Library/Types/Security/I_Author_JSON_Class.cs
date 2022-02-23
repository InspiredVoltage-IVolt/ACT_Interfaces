using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ACT.Core.Types.Security
{
    public class I_Author_JSON_TYPE
    {
        [JsonProperty("additionalinformation", NullValueHandling = NullValueHandling.Ignore)]
        public List<Information> InformationData { get; set; }

        [JsonIgnore()]
        public Dictionary<string, string> AdditionalInformation { get; set; } = new Dictionary<string, string>();

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("datelastedited", NullValueHandling = NullValueHandling.Ignore)]
        public string DateLastEdited { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("actidhash", NullValueHandling = NullValueHandling.Ignore)]
        public string ActidHash { get; set; }

        public static I_Author_JSON_TYPE FromJson(string json)
        {
            var _tmpReturn = JsonConvert.DeserializeObject<I_Author_JSON_TYPE>(json, JSONHelper.Converter.Settings);
            foreach (var itm in _tmpReturn.InformationData)
            {
                _tmpReturn.AdditionalInformation.Add(itm.Key, itm.Value);
            }
            return _tmpReturn;
        }

        public string ToJson() => JsonConvert.SerializeObject(this, JSONHelper.Converter.Settings);
    }

    public class Information
    {
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
