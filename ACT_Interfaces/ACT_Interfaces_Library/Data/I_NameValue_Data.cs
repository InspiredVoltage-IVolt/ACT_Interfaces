﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data
{
    public interface I_NameValue : Plugins.I_Plugin
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }

    public interface I_NameValue_Data : Plugins.I_Plugin
   {
        public string Name { get; set; }

        public object Value { get; set; }
    }
}
