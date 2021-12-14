using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.WebServices.Data
{
    public interface IACTSqlProxy
    {
        string GetDataTable(string EncryptedConnectionData, string Command, string Parameters);
    }
}
