using ACT.Core.Interfaces.Common;

namespace ACT.Core.Interfaces.Payment
{
    public interface I_PaymentGateway :  Plugins.I_Plugin 
    {
        bool WasSuccessfullAuthorize(Dictionary<string, string> Response);
        bool WasSuccessfullCapture(Dictionary<string, string> Response);
        bool WasSuccessfullCredit(Dictionary<string, string> Response);

        Dictionary<string, string> PriorAuthCapture(string transactionId, decimal Amount);
        Dictionary<string, string> AuthorizeCc(decimal Amount, string Track1, string Track2, string CardCode, string ZipCode);
        Dictionary<string, string> AuthorizeCc(string ccNumber, string Month, string Year, decimal Amount, string Description, string CardCode, string ZipCode);
        Dictionary<string, string> Credit(string transactionId, decimal Amount, string cardNumber);

    }
}
