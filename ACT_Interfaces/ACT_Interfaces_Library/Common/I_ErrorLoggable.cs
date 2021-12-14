// ***********************************************************************
// Assembly         : ACT_Interfaces
// Author           : MarkAlicz
// Created          : 02-26-2021
//
// Last Modified By : MarkAlicz
// Last Modified On : 02-26-2021
// ***********************************************************************
// <copyright file="I_ErrorLoggable.cs" company="IVolt, LLC">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ACT.Core.Interfaces.Common
{

    /// <summary>
    /// Defines a method for logging errors
    /// </summary>
    public interface I_ErrorLoggable
    {
        /// <summary>
        /// Logs the Error
        /// </summary>
        /// <param name="className">Name of the class the error occured</param>
        /// <param name="summary">Summary of the Error</param>
        /// <param name="ex">Exception</param>
        /// <param name="additionInformation">Additional Information</param>
        /// <param name="errorType">Error Type</param>
        void LogError(string className, string summary, Exception ex, string additionInformation, string errorType);

        /// <summary>
        /// Logs the Error only in DEBUG MODE
        /// </summary>
        /// <param name="className">Name of the class the error occured</param>
        /// <param name="summary">Summary of the Error</param>
        /// <param name="ex">Exception</param>
        /// <param name="additionInformation">Additional Information</param>
        /// <param name="errorType">Error Type</param>
        void DLogError(string className, string summary, Exception ex, string additionInformation, string errorType);
    }

}
