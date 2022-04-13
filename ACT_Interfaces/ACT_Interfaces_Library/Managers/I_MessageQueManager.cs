using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Managers
{
    public interface I_MessageQueManager
    {
        ArrayList Messages { get; set; }
        ArrayList HighImportanceMessages { get; set; }
        int ImportanceExecuteNowMin { get; set; }

        (string, bool) POP();
        string  PUSH(string message, int Importance);
        string  PUSHTOTOP(string message, int Importance);
        string  PUSHTOBOTTOM(string message, int Importance);
        

        Func<string,bool,string> ExternalProcessor(string Message, bool BasedOnImportance);

        string Json_Encoding_Type { get; set; }

        decimal MovingProcessingAverage { get; }

        void Pause();
        void Start();
        void Stop();
        void Process();

    }
}
