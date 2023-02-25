using ACT.Core.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Common.ErrorLogging
{
    public interface I_ErrorLoggable_AdoNet_Configuration
    {
        public string BaseMethod { get; set; }
        public I_AdoNet_BaseConfig BaseConfig { get; set; }
        public I_ErrorLoggable_AdoNet_Configuration FromJson(string json);
        public string ToJson();
    }

    public interface I_AdoNet_BaseConfig
    {

        public string DatabaseConnectionString { get; set; }
        public string PluginDllName { get; set; }
        public string InsertQuery { get; set; }
        public string UpdateQuery { get; set; }
        public string DeleteQuery { get; set; }
        public bool? EncryptLog { get; set; }
        public string EncryptionMethod { get; set; }
        public List<Data.I_NameValue> CustomData { get; set; }
        public string Plugin_Package { get; set; }
        public string Plugin_Full_ClassName { get; set; }

    }

}
