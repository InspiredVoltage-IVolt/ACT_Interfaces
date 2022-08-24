using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Text
{
    public interface I_TextReplacement : Plugins.I_Plugin 
    {
        void Populate(string textReplacementJsonFile);
        void Populate(Dictionary<string,string> TextReplacementData);
        void Populate(Interfaces.DataAccess.I_Db dbDatabase);
        void Populate(Interfaces.DataAccess.I_Db_Table dbTable);

        string Process(string Source);
        string Process(string Source, string Output);
    }
}
