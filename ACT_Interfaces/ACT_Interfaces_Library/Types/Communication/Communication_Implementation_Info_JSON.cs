using ACT.Core.Types.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace ACT.Core.Types.Communication
{
    /// <summary>
    /// MUST SUPPORT ALL OF THESE METHODS ::: EMAIL, SMS,MMS,WEBPOST,WEBGET,PHONE,FTP,SFTP,MESSAGEQUE,NETWORKFILE
    /// </summary>
    public class Communication_Implementation_Info_JSON
    {
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        [JsonIgnore()]
        public I_Author_JSON_TYPE Email_Phone_ContactInfo
        {
            get
            {
                try { return I_Author_JSON_TYPE.FromJson(System.Text.Encoding.Default.GetString(Convert.FromBase64String(IEmailPhoneContactInfo_BASE64JSON))); }
                catch { return null; }
            }
            set
            {
                try { IEmailPhoneContactInfo_BASE64JSON = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(value.ToJson())); }
                catch (Exception ex) { throw new Exception("Unable To convert the value to the Base64 String.. " + ex.Message, ex); }
            }
        }

        [JsonProperty("i-email_phone-contact-info", NullValueHandling = NullValueHandling.Ignore)]
        public string IEmailPhoneContactInfo_BASE64JSON { get; set; }

        [JsonProperty("ftpsftp-info", NullValueHandling = NullValueHandling.Ignore)]
        public string FTPSFTP_BASE64INFO { get; set; }
        
        [JsonProperty("web-url", NullValueHandling = NullValueHandling.Ignore)]
        public string WEB_URL { get; set; }

        [JsonProperty("web-variable-data", NullValueHandling = NullValueHandling.Ignore)]
        public Types.JSON.NameValue_Information Web_Variable_Data { get; set; }
        
        [JsonProperty("network-file-location", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkFileLocation { get; set; }

        [JsonProperty("network-file-base64-encoded", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkFile { get; set; }

        [JsonProperty("message-que-path", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageQuePath{ get; set; }

        [JsonProperty("message-que-data", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageQueData { get; set; }

        public static Communication_Implementation_Info_JSON FromJson(string json) => JsonConvert.DeserializeObject<Communication_Implementation_Info_JSON>(json, JSONHelper.Converter.Settings);

        public string ToJson() => JsonConvert.SerializeObject(this, JSONHelper.Converter.Settings);
    }

   
}




