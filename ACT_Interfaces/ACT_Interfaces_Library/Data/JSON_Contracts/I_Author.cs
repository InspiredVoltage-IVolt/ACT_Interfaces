using ACT.Core.Types.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data.JSON_Contracts
{
    public interface I_Author : Plugins.I_Plugin, IO.I_Exportable<I_Author>
    {        
        string Actid { get; set; }
        string ExternalId { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        string Company { get; set; }
        string DateLastEdited { get; set; }
        string Description { get; set; }
        string Validation_Hash { get; set; }
        List<I_NameValue_Data> AdditionalInformation { get; set; }
    }
}
