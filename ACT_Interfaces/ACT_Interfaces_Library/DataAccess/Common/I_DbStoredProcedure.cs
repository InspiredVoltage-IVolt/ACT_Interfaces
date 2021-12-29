using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACT.Core.Interfaces.Common;
using System.ComponentModel;


namespace ACT.Core.Interfaces.DataAccess
{
    public interface IDbStoredProcedure : I_Plugin
    {
        string Name { get; set; }
        string Owner { get; set; }

        List<IDbStoredProcedureParameter> Parameters { get; set; }


    }
}
