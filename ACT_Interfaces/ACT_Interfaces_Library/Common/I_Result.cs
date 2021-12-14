// ***********************************************************************
// Assembly         : ACT_Interfaces
// Author           : MarkAlicz
// Created          : 02-26-2021
//
// Last Modified By : MarkAlicz
// Last Modified On : 02-26-2021
// ***********************************************************************
// <copyright file="I_TestResult.cs" company="IVolt, LLC">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ACT.Core.Interfaces.Common
{
    /// <summary>
    /// Defines a Common Test Result
    /// </summary>
    public interface I_Result
    {
        /// <summary>
        /// Gets the Specific Transaction ID For this Action.
        /// </summary>
        Guid TransactionID { get; set; }
        /// <summary>
        /// Gets or sets the exceptions.
        /// </summary>
        /// <value>The exceptions.</value>
        List<Exception> Exceptions { get; set; }
        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        /// <value>The messages.</value>
        List<string> Messages { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this is success.
        /// </summary>
        /// <value><c>true</c> if success; otherwise, <c>false</c>.</value>
        bool Success { get; set; }
        /// <summary>
        /// Gets or sets the warnings.
        /// </summary>
        /// <value>The warnings.</value>
        List<string> Warnings { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance has warnings.
        /// </summary>
        /// <value><c>true</c> if this instance has warnings; otherwise, <c>false</c>.</value>
        bool HasWarnings { get; set; }
    }
}
