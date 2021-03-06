using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Managers
{
    /// <summary>
    /// Message Que Manager
    /// </summary>
    public interface I_MessageQueManager
    {
        ArrayList Messages { get; set; }
        ArrayList HighImportanceMessages { get; set; }
        int ImportanceExecuteNowMin { get; set; }

        (string, bool) POP();
        string  PUSH(string message, int Importance);
        string  PUSHTOTOP(string message, int Importance);
        string  PUSHTOBOTTOM(string message, int Importance);
        
        SortedDictionary<Guid, Func<string, int, bool>> ProcessorPlugins { get; set; }

        string Json_Encoding_Type { get; set; }

        decimal MovingProcessingAverage { get; }

        void Pause();
        void Start();
        void Stop();
        void Process();

    }
}
