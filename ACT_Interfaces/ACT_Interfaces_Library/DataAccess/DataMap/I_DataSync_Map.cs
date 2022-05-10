using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.DataAccess.DataSync
{
    public interface I_DataSync_Map : IO.I_Saveable 
    {        
        Guid AddColumn(I_Db SourceDatabase, string FullyQualified_ColumnName, uint Importamce, string ColumnGroupName);
        void ReCreate_AssociationMap();
        void DeleteSpecificNap(Guid MapID);
        void DeleteAll(bool LogMap);
        byte[] GenerateVisualMap();
    }
}
