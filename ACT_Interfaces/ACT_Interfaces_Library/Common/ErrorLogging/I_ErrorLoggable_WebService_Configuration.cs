using ACT.Core.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Common.ErrorLogging
{
    public interface I_ErrorLoggable_WebService_Configuration
    {        
        public string BaseMethod { get; set; }        
        public I_WebService_BaseConfig BaseConfig { get; set; }
        public I_ErrorLoggable_WebService_Configuration FromJson(string json);
        public string ToJson();
    }

    public interface I_WebService_BaseConfig
    {
        public string ServiceEndpoint { get; set; }
        public string GetUrlInformation { get; set; }
        public string ResponseType { get; set; }
        public bool? EncryptLog { get; set; }
        public string EncryptionMethod { get; set; }
        public List<Data.I_NameValue_Data> CustomData { get; set; }
        public string Plugin_Package { get; set; }
        public string Plugin_Full_ClassName { get; set; }
    }

}
