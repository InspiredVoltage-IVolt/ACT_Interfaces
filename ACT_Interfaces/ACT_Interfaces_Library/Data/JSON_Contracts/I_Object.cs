using ACT.Core.Types.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data.JSON_Contracts
{
    public interface I_Object : Plugins.I_Plugin
    {
        byte[] ObjectBytes { get; set; }
        string ObjectName { get; set; }
        string ObjectType { get; set; }
        string ObjectHash { get; set; }

        string DateLastEdited { get; set; }
        string Description { get; set; }
    }
}
