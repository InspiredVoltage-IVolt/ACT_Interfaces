using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Security
{
    public interface I_Author
    {
        string Name { get; set; }
        string Email { get; set; }

        Dictionary<string, string> AdditionalInformation { get; set; }

        string DateLastEdited { get; set; }
        string Description { get; set; }

        string ACTIDHash { get; }

    }
}
