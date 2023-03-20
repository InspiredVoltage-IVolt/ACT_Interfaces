using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.PluginHelper.Virtual_Classes
{
   public class Virtual_I_NameValue : Interfaces.Data.I_NameValue
   {
      public virtual string Name { get; set; }
      public virtual string Value { get; set; }
   }
}
