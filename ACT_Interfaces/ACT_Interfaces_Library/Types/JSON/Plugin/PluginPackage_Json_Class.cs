
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ACT.Core.Interfaces.Data.JSON_Contracts;

namespace ACT.Core.Types.PluginPackage
{

    public class ACT_Plugin_Package_Definition_Json
    {
        //[JsonIgnore()]
        //public I_Author AuthorData
        //{
        //    get {
        //        try { return I_Author.ImportDataFromJson(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(IAuthorInfo))); }
        //        catch { return null; }
        //    }
        //    set {
        //        try { IAuthorInfo = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value.ToJson())); }
        //        catch (Exception ex)
        //        {
                    
        //            throw new Exception("Unable To convert the value to the Base64 String.. " + ex.Message, ex);
        //        }
        //    }
        //}

        [JsonProperty("i-author-info", NullValueHandling = NullValueHandling.Ignore)]
        public string IAuthorInfo { get; set; }

        [JsonProperty("package-id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? PackageId { get; set; }

        [JsonProperty("package-name", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageName { get; set; }

        [JsonProperty("certification-hash", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificationHash { get; set; }

        [JsonProperty("filesystem-config", NullValueHandling = NullValueHandling.Ignore)]
        public FileSystem_Config FilesystemConfig { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<Plugin_Type_Information> Included_Plugin_Type_Implementations { get; set; } = new List<Plugin_Type_Information>();

        public static ACT_Plugin_Package_Definition_Json FromJson(string json) => JsonConvert.DeserializeObject<ACT_Plugin_Package_Definition_Json>(json, JsonHelper.Converter.Settings);

        public string ToJson() => JsonConvert.SerializeObject(this, JsonHelper.Converter.Settings);
    }

    public class FileSystem_Config
    {
        [JsonProperty("filesystem-root", NullValueHandling = NullValueHandling.Ignore)]
        public string FilesystemRoot { get; set; }

        [JsonProperty("dll-filename", NullValueHandling = NullValueHandling.Ignore)]
        public string DllFilename { get; set; }

        [JsonProperty("append-systemconfiguration-values", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppendSystemconfigurationValues { get; set; }

        [JsonProperty("systemconfiguration-values-filename", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemconfigurationValuesFilename { get; set; }

        [JsonProperty("encrypt-systemconfiguration-values-file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EncryptSystemconfigurationValuesFile { get; set; }

        [JsonProperty("encryption-method", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptionMethod { get; set; }

        [JsonProperty("additional-data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Types.JSON.KeyValue_Information_Simple_Json> AdditionalData { get; set; } = new List<Types.JSON.KeyValue_Information_Simple_Json>();
    }

    public class Plugin_Type_Information
    {
        [JsonProperty("interface-fullname", NullValueHandling = NullValueHandling.Ignore)]
        public string InterfaceFullname { get; set; }

        [JsonProperty("interface-shortname", NullValueHandling = NullValueHandling.Ignore)]
        public string InterfaceShortname { get; set; }

        [JsonProperty("full-class-name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullClassName { get; set; }

        [JsonProperty("dll_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DllFileName { get; set; }

        [JsonProperty("i-author-info", NullValueHandling = NullValueHandling.Ignore)]
        public string IAuthorInfo { get; set; }
    }
}
