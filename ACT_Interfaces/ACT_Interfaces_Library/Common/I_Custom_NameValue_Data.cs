using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Common
{
    public interface I_CustomNameValueData
    {       
        public string Name { get; set; }
        
        public string Value { get; set; }
    }
}
