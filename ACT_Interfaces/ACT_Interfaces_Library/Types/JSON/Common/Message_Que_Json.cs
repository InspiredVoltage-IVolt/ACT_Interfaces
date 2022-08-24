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
    /// Message Que JSON Class
    /// </summary>
    public class Message_Que_Json
    {
        [JsonProperty("msg-id", NullValueHandling = NullValueHandling.Ignore)]
        public int Message_Identifier { get; set; }

        [JsonProperty("application-id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Application_Id { get; set; }

        [JsonProperty("member-id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Member_Id { get; set; }

        [JsonProperty("company-id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Company_Id { get; set; }
        
        [JsonProperty("client-id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Client_Id { get; set; }

        [JsonProperty("connection-string-name", NullValueHandling = NullValueHandling.Ignore)]
        public string Connection_String_Name { get; set; }

        [JsonProperty("custom-connection-string", NullValueHandling = NullValueHandling.Ignore)]
        public string Custom_Connection_String { get; set; }

        [JsonProperty("message-base64-utf8", NullValueHandling = NullValueHandling.Include)]
        public string Message_Base64_Utf8 { get; set; }

        [JsonProperty("encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public bool Encrypted { get; set; }

        public static Message_Que_Json FromJson(string json) => JsonConvert.DeserializeObject<Message_Que_Json>(json, JsonHelper.Converter.Settings);

        public string ToBase64Json() => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this, JsonHelper.Converter.Settings)));

        public string ToJson() => Encoding.UTF8.GetString(Convert.FromBase64String(JsonConvert.SerializeObject(this, JsonHelper.Converter.Settings)));

        public string ToDecryptedJson(string Provider = "ACT")
        {
            // TODO IMPLEMENT PLUGIN
            return "";
        }
    }
}
