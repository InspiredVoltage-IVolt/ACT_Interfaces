// ------------------------------------
// ACT_Interfaces - ACT_Interfaces_Library
// Mark Alicz
// 24-08-2022
// ------------------------------------

namespace ACT.Core.Interfaces.Common
{

    /// <summary>
    /// Defines a method for logging errors
    /// </summary>
    public interface I_ErrorLoggable
    {
	    #region Methods - ALL

	    /// <summary>
        /// Logs the Error only in DEBUG MODE
        /// </summary>
        /// <param name="className">Name of the class the error occured</param>
        /// <param name="summary">Summary of the Error</param>
        /// <param name="ex">Exception</param>
        /// <param name="additionInformation">Additional Information</param>
        /// <param name="errorType">Error Type</param>
        /// 

        void DLogError(string className, string summary, Exception ex, string additionInformation, Enums.Common.Error_Code_Severity errorType);

	    /// <summary>
        /// Logs the Error
        /// </summary>
        /// <param name="className">Name of the class the error occured</param>
        /// <param name="summary">Summary of the Error</param>
        /// <param name="ex">Exception</param>
        /// <param name="additionInformation">Additional Information</param>
        /// <param name="errorType">Error Type</param>
        void LogError(string className, string summary, Exception ex, string additionInformation, Enums.Common.Error_Code_Severity errorType);

	    /// <summary>
	    /// OverRide Current Plugin With Specified One
	    /// </summary>
	    /// <param name="pluginData"></param>
	    /// <returns></returns>
	    bool OverRidePlugin( Plugins.I_Plugin  pluginData);

	    /// <summary>
        /// Quick Error Logger
        /// </summary>
        /// <param name="Information">Information To Log</param>
        void QuickLog(string Information);

	    #endregion
    }

}
