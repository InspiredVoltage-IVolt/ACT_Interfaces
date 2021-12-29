using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACT.Core.Interfaces.Common;
using System.ComponentModel;

namespace ACT.Core.Interfaces.DataAccess
{
    public interface IDbStoredProcedureParameter : I_Plugin
    {

        string Name { get; set; }
        System.Data.DbType DataType { get; set; }
        int Length { get; set; }
        int Order { get; set; }

        string DataTypeName { get; set; }
    }
}
