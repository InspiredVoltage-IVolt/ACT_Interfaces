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


   //Alias
   public class Basic_Name_Value : KeyValue_Information_Simple_Json
   {

   }

    /// <summary>
    /// Simple Key Value Class
    /// </summary>
    public class KeyValue_Information_Simple_Json
    {
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
