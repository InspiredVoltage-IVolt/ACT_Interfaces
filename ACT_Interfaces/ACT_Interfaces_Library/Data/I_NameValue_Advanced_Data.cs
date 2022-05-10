using ACT.Core.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data
{
    public interface I_NameValue_Advanced_Data : Plugins.I_Plugin
    {
        string Name { get; set; }
        string Value { get; set; }
        string AdditionalInformation { get; set; }
    }
}
