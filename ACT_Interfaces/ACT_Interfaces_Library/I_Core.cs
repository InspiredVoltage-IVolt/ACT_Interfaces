using ACT.Core.Interfaces.Common;

namespace ACT.Core.Interfaces
{
    /// <summary>Core Functionality Definition</summary>
    public interface I_Core : IDisposable, I_ErrorLoggable, Reflection.I_PropertyManager
    {
        /// <summary>
        /// Has Cached Errors
        /// </summary>
        bool CacheErrors { get; set; }

        /// <summary>Standard Text Replacement Functionality - Powerful If Implemented Properly   HI MY NAME IS ###FIRSTNAME###</summary>
        /// <param name="instr"></param>
        /// <returns></returns>
        string PerformStandardTextReplacement(string instr);

        /// <summary>Returns the Errors stored in the local variable</summary>
        /// <returns><![CDATA[List<Exception>]]></returns>
        List<Exception> GetCachedErrors();

        /// <summary>Specifies if the class has changed in any way</summary>
        bool HasChanged { get; set; }

        /// <summary>
        /// Checks The Health Of The Class.  Use this to return missing configuration.  Invalid Permissions Etc..
        /// </summary>
        /// <returns>I_Result - Specifying changes needed to be made to obtain a good health report.</returns>
        I_Result HealthCheck();

        /// <summary>
        /// Event is triggered when something in the class has changed.
        /// </summary>
        event EventHandler ClassChanged;

        /// <summary>
        /// List of properties monitoried by the ClassChanged Event.
        /// </summary>
        List<string> PropertiesMonitoredForChange { get; set; }
    }
}
