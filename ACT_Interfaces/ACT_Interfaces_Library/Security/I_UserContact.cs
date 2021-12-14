namespace ACT.Core.Interfaces.Security
{
    public interface I_UserContact
    {
        string CompanyName { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string WorkPhone { get; set; }
        string WorkPhoneExt { get; set; }
        string MobilePhone { get; set; }
        string OtherPhone { get; set; }
        string BirthDate { get; set; }
    }
}
