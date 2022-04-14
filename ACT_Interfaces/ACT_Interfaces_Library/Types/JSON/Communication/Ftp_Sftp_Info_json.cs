using ACT.Core.Types;
using ACT.Core.Types.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Types.Communication
{
    public class Ftp_Sftp_Info_json
    {
        [JsonProperty("hostname", NullValueHandling = NullValueHandling.Ignore)]
        public string Hostname { get; set; }

        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("tls", NullValueHandling = NullValueHandling.Ignore)]
        public bool TLS { get; set; }

        /// <summary>
        /// Base64 Encoded Files (UTF8)
        /// </summary>
        [JsonProperty("files-to-upload", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FilesToUpload { get; set; }

        [JsonProperty("remotepath", NullValueHandling = NullValueHandling.Ignore)]
        public string RemotePath { get; set; }

        [JsonProperty("connect-timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int ConnectTimeout { get; set; }

        [JsonProperty("idle-timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int IdleTimeout { get; set; }

        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int Port { get; set; }
        
        public static Ftp_Sftp_Info_json FromJson(string json) => JsonConvert.DeserializeObject<Ftp_Sftp_Info_json>(json, JSONHelper.Converter.Settings);

        public string ToJson() => JsonConvert.SerializeObject(this, JSONHelper.Converter.Settings);
    }
}
