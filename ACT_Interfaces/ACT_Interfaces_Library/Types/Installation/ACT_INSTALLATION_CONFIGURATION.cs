using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Types.Installation
{
    internal interface ACT_INSTALLATION_CONFIGURATION
    {
        string Application_Name { get; set; }
        
        bool Depends_On_ACTInstall { get; set; }

        bool UseACT_Standard_Installation_File { get; set; }

        //List<>
    }
}
