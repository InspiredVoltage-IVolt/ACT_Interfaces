using ACT.Core.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.PluginHelper.Virtual_Classes
{
   /// <summary>
   /// Virtual I_Result Class
   /// </summary>
   public class Virtual_I_Result : I_Result
   {
      public virtual Guid TransactionId { get; set; }
      public virtual List<Exception> Exceptions { get; set; }
      public virtual List<string> Messages { get; set; }
      public virtual bool Success { get; set; }
      public virtual List<string> Warnings { get; set; }
      public virtual bool HasWarnings { get; set; }
   }
}
