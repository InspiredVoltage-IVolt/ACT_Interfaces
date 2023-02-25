using ACT.Core.Types.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data.JSON_Contracts
{
    public interface I_ChangeLog : Plugins.I_Plugin
    {
        List<I_NameValue> OriginalValues { get; set; }
        List<I_NameValue> NewValues { get; set; }

        string ChangedBy_Name { get; set; }
        string DateLastEdited { get; set; }
        string Description { get; set; }
        bool Approved { get; set; }
        string ApprovedBy { get; set; }
    }
}
