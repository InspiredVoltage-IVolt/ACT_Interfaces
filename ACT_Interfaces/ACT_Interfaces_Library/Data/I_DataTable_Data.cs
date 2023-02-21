using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data
{
    public interface I_DataTable_Data
    {
        public Dictionary<int, string> Columns { get; set; }
        public Dictionary<int, List<string>> RowData { get; set; }

    }
}
