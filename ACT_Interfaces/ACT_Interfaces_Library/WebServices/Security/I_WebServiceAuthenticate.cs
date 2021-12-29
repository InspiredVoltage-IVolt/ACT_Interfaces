namespace ACT.Core.Interfaces.WebServices.Security
{
    public interface I_WebServiceAuthenticate
    {
        Dictionary<string, string> Authenticate(object[] args);

    }
}
