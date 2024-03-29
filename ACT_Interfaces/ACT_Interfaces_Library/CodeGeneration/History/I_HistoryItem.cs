﻿// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 04-13-2022
// ***********************************************************************
// <copyright file="I_HistoryItem.cs" company="IVolt, LLC">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ACT.Core.Interfaces.CodeGeneration.History
{
    /// <summary>
    /// Interface I_HistoryItem
    /// </summary>
    public interface I_HistoryItem
    {
        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        /// <value>The name of the project.</value>
        string ProjectName { get; set; }
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        string FileName { get; set; }
        /// <summary>
        /// Gets or sets the incremental count.
        /// </summary>
        /// <value>The incremental count.</value>
        string IncrementalCount { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        string Password { get; set; }
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        string Date { get; set; }
        /// <summary>
        /// Gets or sets the original file location.
        /// </summary>
        /// <value>The original file location.</value>
        string OriginalFileLocation { get; set; }
        /// <summary>
        /// Gets the actual date time.
        /// </summary>
        /// <value>The actual date time.</value>
        DateTime ActualDateTime { get; }
        /// <summary>
        /// Serializes the specified type.
        /// </summary>
        /// <param name="Type">The type.</param>
        /// <returns>System.String.</returns>
        string Serialize(Enums.IO.Serialization_Type Type);
        /// <summary>
        /// Deserializes the specified type.
        /// </summary>
        /// <param name="Type">The type.</param>
        /// <param name="Data">The data.</param>
        void Deserialize(Enums.IO.Serialization_Type Type, object Data);
    }
}
