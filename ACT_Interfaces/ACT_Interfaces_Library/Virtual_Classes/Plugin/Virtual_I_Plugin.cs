using ACT.Core.Enums;
using ACT.Core.Interfaces.Common;
using ACT.Core.Interfaces.Data.JSON_Contracts;
using ACT.Core.Interfaces.Plugins;
using ACT.Core.Interfaces.Security;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.PluginHelper.Virtual_Classes
{
   public class Virtual_I_Plugin : Virtual_I_Core, I_Plugin
   {
      public virtual I_Author Author { get; }
      public virtual List<I_Author> AuthorChain { get; }
      public virtual bool Is_ACT_Internal { get; }
      public virtual string Dll_FileName { get; }
      public virtual string Sub_Identifier { get; }
      public virtual Dictionary<Type, Dictionary<int, string>> Types_And_Class_Names { get; }
      public virtual string GitHub_PackageName { get; }
      public virtual string GitHub_PackageVersion { get; }

      public virtual ArrayList ReturnRequiredFiles(bool PerformReplacements = false) { return new ArrayList(); }
      public virtual ArrayList ReturnSystemSettingRequirements(bool PerformReplacements = false) { return new ArrayList(); }
      public virtual void SetImpersonate(I_UserInfo UserInfo) { throw new NotImplementedException(); }
      public virtual I_Result ValidatePluginRequirements()
      {
         return null;

      }
   }
}
