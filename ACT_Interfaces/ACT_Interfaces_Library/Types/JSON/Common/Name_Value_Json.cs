using ACT.Core.Types;
using ACT.Core.Types.Communication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Types.JSON
{
    /// <summary>
    /// Common Name Value Class
    /// </summary>
    public class NameValue_Information_Advanced_Json
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// Base64 Encoded
        /// </summary>
        [JsonProperty("additional-information-value", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalInformation { get; set; }

        public static NameValue_Information_Advanced_Json FromJson(string json) => JsonConvert.DeserializeObject<NameValue_Information_Advanced_Json>(json, JSONHelper.Converter.Settings);

        public string ToJson() => JsonConvert.SerializeObject(this, JSONHelper.Converter.Settings);
    }

    /// <summary>
    /// Simple Key Value Class
    /// </summary>
    public class KeyValue_Information_Simple_Json
    {
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
