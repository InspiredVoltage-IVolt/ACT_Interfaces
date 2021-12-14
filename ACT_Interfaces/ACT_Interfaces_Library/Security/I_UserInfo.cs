namespace ACT.Core.Interfaces.Security
{
    /// <summary>
    /// Defines a common USER Information Structure
    /// </summary>
    public interface I_UserInfo
    {
        #region Data Members (9) 

        System.Security.Principal.IPrincipal ContextPrincipal { get; }
        System.Security.Principal.IIdentity ContactIdentity { get; }

        /// <summary> Current Authentication Token</summary>
        string AuthenticationToken { get; set; }

        /// <summary> Is User Active</summary>
        bool Active { get; set; }

        /// <summary> Additional User Information</summary>
        Dictionary<string, string> AdditionalInfo { get; set; }

        /// <summary> Is The Current User Authenticated</summary>
        bool Authenticated { get; set; }

        #region Data Elements

        /// <summary> Primary Key Of The User </summary>
        string UserKey { get; set; }

        /// <summary> UserName Associated With This User</summary>
        string UserName { get; set; }

        /// <summary> Used In Update And Create Procedures Otherwise Ignored</summary>
        string Password { get; set; }

        /// <summary> Email Address Of The User</summary>
        string Email { get; set; }

        /// <summary> First Name </summary>
        string CompanyName { get; set; }

        /// <summary> First Name </summary>
        string FirstName { get; set; }

        /// <summary> Last Name </summary>
        string LastName { get; set; }

        /// <summary> Middle Name </summary>
        string MiddleName { get; set; }

        /// <summary> Work Phone </summary>
        string WorkPhone { get; set; }

        /// <summary> Work Phone Ext </summary>
        string WorkPhoneExt { get; set; }

        /// <summary> Mobile Number </summary>
        string MobilePhone { get; set; }

        /// <summary> User Encryption Key </summary>
        string EncryptionKey { get; set; }

        /// <summary> Confirmation Code To Validate Email </summary>
        string ConfirmationCode { get; set; }


        #endregion



        #endregion Data Members 

        #region Operations (6) 

        /// <summary>
        /// Optional Function To Get UnEncrypted Password
        /// </summary>
        /// <returns></returns>
        string GetUnencryptedPassword();

        /// <summary> List Of All The Users Groups</summary>
        List<string> GetGroups();

        void AddAddress(I_UserAddress NewAddress);
        void UpdateAddress(I_UserAddress AddressToUpdate);
        void DeleteAddress(I_UserAddress AddressToDelete);

        I_UserAddress GetAddressByID(Guid ID);
        I_UserAddress GetAddressByName(string Name);
        List<I_UserAddress> GetAddresses();
        I_UserAddress GetPrimaryBillingAddress();
        I_UserAddress GetPrimaryShippingAddress();
        I_UserAddress GetPrimaryContactAddress();


        List<I_UserContact> GetUserContacts();
        I_UserContact GetContact(Guid ID);
        List<I_UserContact> Search(string SearchString);

        void UpdateContact(I_UserContact ContactToUpdate);
        void AddContact(I_UserContact ContactToAdd);
        void DeleteContact(I_UserContact ContactToDelete);


        #endregion Operations 
    }



}
