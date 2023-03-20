
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ACT.Core.Interfaces.Data.JSON_Contracts;

namespace ACT.Core.Types.Communication
{
    /// <summary>
    /// MUST SUPPORT ALL OF THESE METHODS ::: EMAIL, SMS,MMS,WEBPOST,WEBGET,PHONE,FTP,SFTP,MESSAGEQUE,NETWORKFILE
    /// </summary>
    public class Communication_Implementation_Info_Json
    {
        I_Author _emailPhoneContactInfo = null;

        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        [JsonIgnore()]
        public I_Author Email_Phone_ContactInfo
        {
            get
            {
                try { return (I_Author)_emailPhoneContactInfo.ImportDataFromJson(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(IEmailPhoneContactInfo_Base64Json))); }
                catch { return null; }
            }
            set
            {
                try { IEmailPhoneContactInfo_Base64Json = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(_emailPhoneContactInfo.ExportToJson())); }
                catch (Exception Ex) { throw new Exception("Unable To convert the value to the Base64 String.. " + Ex.Message, Ex); }
            }
        }

        [JsonProperty("i-email_phone-contact-info", NullValueHandling = NullValueHandling.Ignore)]
        public string IEmailPhoneContactInfo_Base64Json { get; set; }

        [JsonProperty("ftpsftp-info", NullValueHandling = NullValueHandling.Ignore)]
        public string Ftpsftp_Base64Info { get; set; }
        
        [JsonProperty("web-url", NullValueHandling = NullValueHandling.Ignore)]
        public string Web_Url { get; set; }

        [JsonProperty("web-variable-key-value-data", NullValueHandling = NullValueHandling.Ignore)]
        public JSON.KeyValue_Information_Simple_Json Web_Variable_Data { get; set; }
        
        [JsonProperty("network-file-location", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkFileLocation { get; set; }

        [JsonProperty("network-file-base64-encoded", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkFile { get; set; }

        [JsonProperty("message-que-path", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageQuePath{ get; set; }

        [JsonProperty("message-que-data", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageQueData { get; set; }

        public static Communication_Implementation_Info_Json FromJson(string json) => JsonConvert.DeserializeObject<Communication_Implementation_Info_Json>(json, JsonHelper.Converter.Settings);

        public string ToJson() => JsonConvert.SerializeObject(this, JsonHelper.Converter.Settings);
    }

   
}




