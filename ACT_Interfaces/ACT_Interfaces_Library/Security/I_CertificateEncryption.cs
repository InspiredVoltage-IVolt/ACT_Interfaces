using System.Security.Cryptography.X509Certificates;

namespace ACT.Core.Interfaces.Security
{
    public interface I_CertificateEncryption
    {
        public string EncryptToString(string plainText, X509Certificate2 cert);
        public byte[] Encrypt(string plainText, X509Certificate2 cert);
        public string DecryptToString(string encryptedText, X509Certificate2 cert);
        public byte[] Decrypt(string encryptedText, X509Certificate2 cert);

        public X509Certificate2 GenerateCertificate(string certName, string AdminPassword);
    }
}
