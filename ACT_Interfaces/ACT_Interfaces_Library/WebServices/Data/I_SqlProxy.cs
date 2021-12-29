namespace ACT.Core.Interfaces.WebServices.Data
{
    public interface I_SqlProxy
    {
        string GetDataTable(string EncryptedConnectionData, string Command, string Parameters);
    }
}
