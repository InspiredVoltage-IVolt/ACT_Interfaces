using ACT.Core.Interfaces.Common;

namespace ACT.Core.Interfaces.Security
{
    public interface I_LoginResult :  Plugins.I_Plugin 
    {
        bool Success { get; set; }
        string TokenID { get; set; }
        DateTime TokenValidTill { get; set; }

        Dictionary<string, string> AdditionalInformation { get; set; }

        string ErrorMessage { get; set; }
        string ErrorCode { get; set; }

        I_UserInfo UserInfo { get; set; }
    }
}
