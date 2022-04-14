using ACT.Core.Interfaces.Common;

namespace ACT.Core.Interfaces.Communication
{
    public interface I_Emails :  Plugins.I_Plugin 
    {
        Guid StartBatch();
        bool SendBatch();
        I_Result SendEmail(List<string> To, List<string> CC, List<string> BCC, string ReplyTo, string Subject, string Body);

        I_Result SendEmail(string To, string CC, string BCC, string ReplyTo, string Subject, string Body);

        I_Result SendEmail(string To, string CC, string BCC, string ReplyTo, string Subject, string Body, string FileName);



    }
}
