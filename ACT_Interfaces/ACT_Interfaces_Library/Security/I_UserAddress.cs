using ACT.Core.Interfaces.Common;

namespace ACT.Core.Interfaces.Security
{
    /// <summary>
    /// Defines a Basic Placeholder for passing User State
    /// </summary>
    public interface I_UserAddress : I_Plugin, I_Saveable
    {
        string ID { get; set; }
        string Name { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        string Address3 { get; set; }
        string City { get; set; }
        string PostalCode { get; set; }
        string State { get; set; }
        string Country { get; set; }
        string Phone { get; set; }
        string Fax { get; set; }
        string AddressType { get; set; }
        bool IsPrimaryShipping { get; set; }
        bool IsPrimaryBilling { get; set; }
        bool IsPrimaryContact { get; set; }


    }
}
