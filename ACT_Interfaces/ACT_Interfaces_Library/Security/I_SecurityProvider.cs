using ACT.Core.Interfaces.Common;

namespace ACT.Core.Interfaces.Security
{
    /// <summary>
    /// This interface defines the methods needed to Connect To A Security Provider.  Active Directory, Or Custom Base Auth
    /// </summary>
    public interface I_SecurityProvider :  Plugins.I_Plugin 
    {
        /// <summary>
        /// A Unique Provider Identity Within The ACT Scope  Example: ActiveDirectory
        /// </summary>
        string ProviderUID { get; }

        /// <summary>
        /// Validates A User Token
        /// </summary>
        /// <param name="TokenID"></param>
        /// <returns></returns>
        bool IsTokenValid(string TokenID, string AdditionalData);

        /// <summary>
        /// Generates A New Security Token and Populates the UserInfo Class
        /// </summary>
        /// <param name="UserInfo"></param>
        /// <returns></returns>
        bool GenerateToken(I_UserInfo UserInfo, string AdditionalData, Guid ApplicationID);

        /// <summary>
        /// Child Security Providers Provide Additional Options For a Multi Tier Authentication Application
        /// </summary>
        /// <returns></returns>
        List<I_SecurityProvider> GetChildSecurityProviders();

        /// <summary>
        /// Additional Configuration Settings Defined In the XML File.  Or Loaded Seperatly outside if the configuration file.
        /// </summary>
        Dictionary<string, string> ConfigurationSettings { get; set; }

        /// <summary>
        /// Login the User
        /// </summary>
        /// <param name="UserName">Clear Text UserName</param>
        /// <param name="Password">Clear Text PassWord</param>
        /// <returns></returns>
        I_LoginResult LoginUser(string UserName, string Password, string AdditionalData);

        #region Group Membership Functionality

        /// <summary>
        /// Validates User Group Membership
        /// </summary>
        /// <param name="UserInfo"></param>
        /// <param name="Group"></param>
        /// <returns>bool</returns>
        bool IsUserMemberOfGroup(string UserID, string GroupName, string AdditionalData);

        /// <summary>
        /// Get The Group ID From The Name
        /// </summary>
        /// <param name="GroupName"></param>
        /// <returns></returns>
        Guid GetGroupID(string GroupName, string AdditionalData);

        /// <summary>
        /// Returns all the available groups
        /// </summary>
        /// <returns></returns>
        List<string> GetAllGroups(string AdditionalData);

        /// <summary>
        /// Adds A User To The Group
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="GroupID"></param>
        I_ResultExpanded AddUserToGroup(string UserID, string GroupName, string AdditionalData);

        #endregion

        /// <summary>
        /// Gets the Confirmation Code For The Email Address
        /// </summary>
        /// <param name="EmailAddress"></param>
        /// <returns></returns>
        string GetConfirmationCode(string EmailAddress);

        /// <summary>
        /// Get Encryption Key
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns>Encryption Key</returns>
        string GetEncryptionKey(string UserID, string AdditionalData);

        /// <summary>
        /// Get User ID
        /// </summary>
        /// <param name="AccessToken"></param>
        /// <returns></returns>
        string GetUserID(string AccessToken, string AdditionalData);

        /// <summary>
        /// Sends the Forgot Password Email
        /// </summary>
        /// <param name="EmailAddress"></param>
        /// <returns>True if Email Address Found False If Not</returns>
        bool SendForgotPasswordEmail(string EmailAddress, string AdditionalData);

        /// <summary>
        /// Returns a Delimeted string of User Info.  Delimiters are defined in ACT Configuration Settings.
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        I_UserInfo GetUserInfo(string UserID, string AdditionalData);

        /// <summary>
        /// Creates A New User
        /// </summary>
        /// <param name="EmailAddress"></param>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns>False O</returns>
        I_ResultExpanded CreateUser(I_UserInfo BasicInfo, string AdditionalData);

        /// <summary>
        /// Updates A User.  
        /// </summary>
        /// <param name="BasicInfo">Make Sure You Set UserInfo.UserKey to ID of User</param>
        /// <param name="AdditionalData">APIKEY</param>
        /// <returns>Update Result</returns>
        I_ResultExpanded UpdateUser(I_UserInfo BasicInfo, string AdditionalData);

        /// <summary>
        /// Update Password
        /// </summary>
        /// <param name="UserID">UserID of Member to be updated</param>
        /// <param name="Password">New Unencrypted Password</param>
        /// <param name="AdditionalData">Additional Data</param>
        /// <returns></returns>
        I_ResultExpanded UpdatePassword(string UserID, string Password, string AdditionalData);

        /// <summary>
        /// Update UserName
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="UserName"></param>
        /// <returns></returns>
        I_ResultExpanded UpdateUserName(string UserID, string UserName, string AdditionalData);

        /// <summary>
        /// Update Email
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Email"></param>
        /// <returns></returns>
        I_ResultExpanded UpdateEmail(string UserID, string Email, string AdditionalData);

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        I_ResultExpanded DeleteUser(string UserID, string AdditionalData);

        /// <summary>
        /// Adds a User To The 
        /// </summary>
        /// <param name="AccessToken"></param>
        /// <param name="AdditionalData"></param>
        /// <returns></returns>
        I_ResultExpanded AddUserToApplication(string AccessToken, string AdditionalData);
    }
}
