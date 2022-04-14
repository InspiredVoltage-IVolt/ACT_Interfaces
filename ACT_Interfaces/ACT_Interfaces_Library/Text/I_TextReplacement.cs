using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Text
{
    public interface I_TextReplacement : Plugins.I_Plugin 
    {
        void Populate(string TextReplacement_JSON_File);
        void Populate(Dictionary<string,string> TextReplacementData);
        void Populate(Interfaces.DataAccess.I_Db Db_Database);
        void Populate(Interfaces.DataAccess.I_Db_Table Db_Table);

        string Process(string Source);
        string Process(string Source, string Output);
    }
}
