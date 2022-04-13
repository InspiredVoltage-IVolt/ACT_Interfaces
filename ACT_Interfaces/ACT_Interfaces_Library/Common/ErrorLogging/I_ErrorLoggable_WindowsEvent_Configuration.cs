﻿using ACT.Core.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Common.ErrorLogging
{
    public interface I_ErrorLoggable_WindowsEvent_Configuration
    {
        public string BaseMethod { get; set; }

        public I_WindowsEvent_BaseConfig BaseConfig { get; set; }

        public I_ErrorLoggable_WindowsEvent_Configuration FromJson(string json);

        public string ToJson();
    }

    public interface I_WindowsEvent_BaseConfig
    {        
        public string EventSourceName { get; set; }
        public string EventLogName { get; set; }
        public bool? AppendSourceToAlllogs { get; set; }
        public bool? EncryptLog { get; set; }
        public string EncryptionMethod { get; set; }
        public List<I_CustomNameValueData> CustomData { get; set; }
        public string Plugin_Package { get; set; }
        public string Plugin_Full_ClassName { get; set; }
    }

}