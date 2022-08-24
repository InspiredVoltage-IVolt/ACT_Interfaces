

using ACT.Core.Interfaces.ACT;

namespace ACT.Core.Interfaces.Data.JSON_Contracts
{
    /// <summary>
    /// Contact Information
    /// </summary>
    public interface I_Contact_Information
    {
        I_Identifier IdProcessor { get; set; }
        Guid? Id { get; set; }
        string External_Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
       I_User_Address PersonalAddress { get; set; }
        string EmailAddress { get; set; }
        string ReachMeAddress { get; set; }              
        string MobilePhone { get; set; }        
        string OtherPhone { get; set; }        
        string BirthDate { get; set; }

        string CompanyName { get; set; }
        I_User_Address CompanyAddress { get; set; }
        string WorkPhone { get; set; }
        string WorkPhoneExt { get; set; }
    }
}
