using ACT.Core.Interfaces.Common;
using System.Collections;

namespace ACT.Core.Interfaces.Data.JSON_Contracts
{
    /// <summary>
    /// Defines a Basic Placeholder for passing User State
    /// </summary>
    public interface I_User_Address :  Plugins.I_Plugin 
    {   
        ACT.I_Identifier ID_Processor { get; set; }
        string Name { get; set; }
        ArrayList AllAddressLines { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        string Address3 { get; set; }
        string City { get; set; }
        string PostalCode { get; set; }
        Enums.Data.Geographic.USA_States_Enum State { get; set; }
        string Country { get; set; }
        string Phone { get; set; }
        string Fax { get; set; }
        string AddressType { get; set; }
        bool IsPrimaryShipping { get; set; }
        bool IsPrimaryBilling { get; set; }
        bool IsPrimaryContact { get; set; }

    }
}
