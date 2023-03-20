using ACT.Core.Enums;
using ACT.Core.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.PluginHelper.Virtual_Classes
{
   public class Virtual_I_Core : Virtual_I_PropertyManager, Interfaces.I_Core
   {
      private List<Exception> _Exceptions = new List<Exception>();
      public virtual List<string> RequiredProperties { get; set; }
      public virtual string ConfigurationJsonFileName { get; set; }
      public virtual bool CacheErrors { get; set; }
      public virtual bool HasChanged { get; set; }
      public virtual List<string> PropertiesMonitoredForChange { get; set; }

      public event EventHandler ClassChanged;

      public virtual void Dispose()
      {
         return;
      }

      /// <summary>
      /// Get Cached Errors
      /// </summary>
      /// <returns></returns>
      public virtual List<Exception> GetCachedErrors()
      {
         return _Exceptions;
      }

      /// <summary>
      /// Return a Configuration Value if Available
      /// </summary>
      /// <param name="Key"></param>
      /// <returns></returns>
      /// <exception cref="NotImplementedException"></exception>
      public virtual dynamic GetConfigurationValue(string Key)
      {
         throw new NotImplementedException();
      }

      /// <summary>
      /// Performs a Health Check
      /// </summary>
      /// <returns></returns>
      public virtual I_Result HealthCheck()
      {
         return null;
      }

      /// <summary>
      /// Performs a Standard Text Replacement
      /// </summary>
      /// <param name="instr"></param>
      /// <param name="ReplacementFormats"></param>
      /// <returns></returns>
      public virtual string PerformStandardTextReplacement(string instr, RepacementStandard ReplacementFormats)
      {
         string _TmpReturn = instr;
         foreach (string name in this.PublicProperties)
         {
            string _name = name;
            if (ReplacementFormats == RepacementStandard.UPPERCASE) { _name = name.ToUpper(); }

            if (ReplacementFormats == RepacementStandard.WRAPPER_3HASHTAGSTANDARD)
            {
               _TmpReturn = _TmpReturn.Replace("###" + _name + "###", this.GetPropertyValue(name).ToString());
            }
            else if (ReplacementFormats == RepacementStandard.WRAPPER_3BRACKETSTANDARD)
            {
               _TmpReturn = _TmpReturn.Replace("[[[" + _name + "]]]", this.GetPropertyValue(name).ToString());
            }
         }

         return _TmpReturn;
      }

   }
}
