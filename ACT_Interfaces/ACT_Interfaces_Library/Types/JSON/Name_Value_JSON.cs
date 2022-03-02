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
    public class NameValue_Information
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// Base64 Encoded
        /// </summary>
        [JsonProperty("binaryvalue", NullValueHandling = NullValueHandling.Ignore)]
        public string BinaryValue { get; set; }

        /// <summary>
        /// Base64Encoded
        /// </summary>
        [JsonProperty("jsonvalue", NullValueHandling = NullValueHandling.Ignore)]
        public string JSONValue { get; set; }

        public static NameValue_Information FromJson(string json) => JsonConvert.DeserializeObject<NameValue_Information>(json, JSONHelper.Converter.Settings);

        public string ToJson() => JsonConvert.SerializeObject(this, JSONHelper.Converter.Settings);
    }
}
