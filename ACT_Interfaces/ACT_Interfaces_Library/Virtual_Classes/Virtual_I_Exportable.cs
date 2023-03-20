using ACT.Core.Interfaces.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.PluginHelper.Virtual_Classes
{
   public class Virtual_I_Exportable : Virtual_I_Plugin, Interfaces.IO.I_Exportable
   {
      public virtual string CustomExport(string Identifier, string jsonString)
      {
         throw new NotImplementedException();
      }

      public virtual object CustomImport(string Identifier, string jsonString)
      {
         throw new NotImplementedException();
      }

      public virtual object Export()
      {
         throw new NotImplementedException();
      }

      public virtual string ExportToJson()
      {
         throw new NotImplementedException();
      }

      public virtual object Import(object item)
      {
         throw new NotImplementedException();
      }

      public virtual object ImportDataFromJson(string jsonString)
      {
         throw new NotImplementedException();
      }
   }
}
