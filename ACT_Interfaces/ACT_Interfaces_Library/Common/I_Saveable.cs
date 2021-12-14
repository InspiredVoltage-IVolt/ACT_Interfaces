// ***********************************************************************
// Assembly         : ACT_Interfaces
// Author           : MarkAlicz
// Created          : 02-26-2021
//
// Last Modified By : MarkAlicz
// Last Modified On : 02-26-2021
// ***********************************************************************
// <copyright file="I_Saveable.cs" company="IVolt, LLC">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ACT.Core.Interfaces.Common
{
    /// <summary>
    /// Specifies that the class can be Saved and Deleted
    /// </summary>
    public interface I_Saveable
    {
        /// <summary>Available File Formats</summary>
        string[] AvailableFileFormats { get; }

        /// <summary>Saves this instance.</summary>
        /// <returns>I_TestResult.</returns>
        I_Result Save(string FileFormat = "");

        /// <summary>Saves this instance.</summary>
        /// <returns>I_TestResult.</returns>
        I_Result Save(string Destination, string FileFormat = "");

        /// <summary>Saves this instance to a memory location.</summary>
        /// <returns>I_TestResult.</returns>
        I_Result Save(IntPtr ptr, string FileFormat = "");

        /// <summary>Deletes this instance.</summary>
        /// <returns>I_TestResult.</returns>
        I_Result Delete();

        /// <summary>Deletes this instance.</summary>
        /// <returns>I_TestResult.</returns>
        I_Result Delete(Guid TestResult_TransactionID);
    }

}
