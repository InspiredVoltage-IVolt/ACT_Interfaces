using ACT.Core.Types.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Types.JSON.Common
{
   /// <summary>
   /// KeyValue Interface - Advanced Information Version
   /// </summary>
   public interface I_KeyValue_Information_Advanced_Json
   {
      string Key { get; set; }
      string Value { get; set; }
      string Additional_Information { get; set; }
   }

   
}
