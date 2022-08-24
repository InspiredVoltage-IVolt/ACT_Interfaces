using ACT.Core.Interfaces.Common;

namespace ACT.Core.Interfaces
{
    /// <summary>Core Functionality Definition</summary>
    public interface I_Core : IDisposable, Reflection.I_PropertyManager
    {
        /// <summary>
        /// Required Configuration Properties
        /// </summary>
        List<string> RequiredProperties { get; set; }

        /// <summary>
        /// Resources\\......  File  Can Be "jsonname.json"  or "\\myapp\\myfile.json"
        /// Always will be looked for in Current Domain Base Directory\\Resources\\
        /// Unless FULL PATH SPECIFIED
        /// </summary>
        string ConfigurationJsonFileName { get; set; }

        /// <summary>
        /// Has Cached Errors
        /// </summary>
        bool CacheErrors { get; set; }

        /// <summary>
        /// Looks to see if the Configuration Attribute defines a value.
        /// </summary>
        /// <returns>usually a string, or List<string></returns>
        public dynamic GetConfigurationValue(string Key);

        /// <summary>Standard Text Replacement Functionality - Powerful If Implemented Properly   HI MY NAME IS ###FIRSTNAME###</summary>
        /// <param name="instr"></param>
        /// <returns></returns>
        string PerformStandardTextReplacement(string instr, Enums.RepacementStandard ReplacementFormats);

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
