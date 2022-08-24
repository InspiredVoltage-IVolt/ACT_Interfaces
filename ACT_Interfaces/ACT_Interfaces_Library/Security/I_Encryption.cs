namespace ACT.Core.Interfaces.Security
{
    /// <summary>
    /// Work in progress
    /// </summary>
    public interface I_EncryptionPacket
    {
        I_Encryption EncryptionObject { get; set; }
        string PasswordMd5 { get; set; }

    }


    public interface I_Encryption
    {
        string NarrowEncrypt(string ClearText, bool UseUser = true, bool UseMachine = false);
        string NarrowDecrypt(string ClearText, bool UseUser = true, bool UseMachine = false);
        string Encrypt(string ClearText);
        string Encrypt(string clearText, string Password);
        byte[] Encrypt(byte[] clearData, string Password);
        void Encrypt(string fileIn, string fileOut, string Password);
        byte[] Encrypt(byte[] clearData, string Salt, byte[] iv, string Password);
        byte[] Decrypt(byte[] cipherData, string Salt, byte[] iv, string Password);
        string Decrypt(string ClearText);
        string Decrypt(string cipherText, string Password);
        byte[] Decrypt(byte[] cipherData, string Password);
        void Decrypt(string fileIn, string fileOut, string Password);
        string Md5(string value);
        string Md5Alt(string value);
        string Sha256(string value);
        string Sha512(string value);
        bool HealthCheck();
    }
}
