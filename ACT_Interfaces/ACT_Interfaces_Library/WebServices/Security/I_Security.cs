namespace ACT.Core.Interfaces.WebServices.Security
{


    public interface I_Security
    {

        string EncryptString(string AccessToken, string DataToEncrypt, string apiKey);


        string DecryptString(string AccessToken, string DataToDecrypt, string apiKey);


        string ReturnEncryptionMethods(string apiKey, List<String> Language);


        bool KeepTokenAlive(string AccessToken, string apiKey);


        string Login(string UserName, string Password, string apiKey);


        string CreateUser(string Email, string UserName, string Password, string FirstName, string LastName, string apiKey);


        string UpdateUser(string AccessToken, string UserName, string FirstName, string LastName, string apiKey);


        string UpdatePassword(string AccessToken, string OldPassword, string NewPassword, string apiKey);


        string DeleteUser(string Token, string api);


        string SendConfirmationEmail(string AccessToken, string apiKey);


        bool SendForgotPasswordEmail(string EmailAddress, string apiKey);


        bool AssignUserToApplication(string AccessToken, string apiKey);


        string GetUserInfo(string AccessToken, string apiKey);

    }
}
