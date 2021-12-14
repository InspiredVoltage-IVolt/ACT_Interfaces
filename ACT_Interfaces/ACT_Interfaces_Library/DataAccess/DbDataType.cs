using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACT.Core.Interfaces.DataAccess
{
    public interface IDbDataType
    {
        int SystemTypeID { get; set; }
        int UserTypeID { get; set; }
        bool IsUserType { get; set; }
        bool IsTableType { get; set; }
        bool IsNullable { get; set; }
        int MaxLength { get; set; }
        int Precision { get; set; }
        int Scale { get; set; }
        string Name { get; set; }
    }
}
