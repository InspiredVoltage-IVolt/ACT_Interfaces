using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Plugins.WinForms
{
   public interface I_Simple_WinForm_Expansion
   {
      public void PopulateData(Dictionary<string, string> DataToConsider);
   }
}
