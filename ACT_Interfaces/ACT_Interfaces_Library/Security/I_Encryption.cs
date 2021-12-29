namespace ACT.Core.Interfaces.Security
{
    /// <summary>
    /// Work in progress
    /// </summary>
    public interface I_EncryptionPacket
    {
        I_Encryption EncryptionObject { get; set; }
        string PasswordMD5 { get; set; }

    }


    public interface I_Encryption
    {
        string NarrowEncrypt(string ClearText, bool UseUser = true, bool UseMachine = false);
        string NarrowDecrypt(string ClearText, bool UseUser = true, bool UseMachine = false);
        string Encrypt(string ClearText);
        string Encrypt(string clearText, string Password);
        byte[] Encrypt(byte[] clearData, string Password);
        void Encrypt(string fileIn, string fileOut, string Password);
        byte[] Encrypt(byte[] clearData, string Salt, byte[] IV, string Password);
        byte[] Decrypt(byte[] cipherData, string Salt, byte[] IV, string Password);
        string Decrypt(string ClearText);
        string Decrypt(string cipherText, string Password);
        byte[] Decrypt(byte[] cipherData, string Password);
        void Decrypt(string fileIn, string fileOut, string Password);
        string MD5(string value);
        string MD5ALT(string value);
        string SHA256(string value);
        string SHA512(string value);
        bool HealthCheck();
    }
}
