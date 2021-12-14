namespace ACT.Core.Interfaces.WebServices.Security
{


    public interface I_Security
    {

        string EncryptString(string AccessToken, string DataToEncrypt, string APIKey);


        string DecryptString(string AccessToken, string DataToDecrypt, string APIKey);


        string ReturnEncryptionMethods(string APIKey, List<String> Language);


        bool KeepTokenAlive(string AccessToken, string APIKey);


        string Login(string UserName, string Password, string APIKey);


        string CreateUser(string Email, string UserName, string Password, string FirstName, string LastName, string APIKey);


        string UpdateUser(string AccessToken, string UserName, string FirstName, string LastName, string APIKey);


        string UpdatePassword(string AccessToken, string OldPassword, string NewPassword, string APIKey);


        string DeleteUser(string Token, string API);


        string SendConfirmationEmail(string AccessToken, string APIKey);


        bool SendForgotPasswordEmail(string EmailAddress, string APIKey);


        bool AssignUserToApplication(string AccessToken, string APIKey);


        string GetUserInfo(string AccessToken, string APIKey);

    }
}
