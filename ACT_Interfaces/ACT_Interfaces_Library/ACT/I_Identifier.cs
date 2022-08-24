using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.ACT
{
    public interface I_Identifier: Plugins.I_Plugin
    {
        string Id { get; set; }
        string External_Id { get; set; }
        string SourceEngine { get; set; }
    }
}
