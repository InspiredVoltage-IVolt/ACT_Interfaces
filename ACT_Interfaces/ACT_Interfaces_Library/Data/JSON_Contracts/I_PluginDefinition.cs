using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data.JSON_Contracts
{
    public interface I_PluginDefinition
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("store_once", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoreOnce { get; set; }

        [JsonProperty("arguments", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Arguments { get; set; }

        [JsonProperty("checksum", NullValueHandling = NullValueHandling.Ignore)]
        public string Checksum { get; set; }

        [JsonProperty("license_key", NullValueHandling = NullValueHandling.Ignore)]
        public string LicenseKey { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public long? Order { get; set; }

        [JsonProperty("interface_support", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InterfaceSupport { get; set; }
    }
}
