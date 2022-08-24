// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 04-13-2022
// ***********************************************************************
// <copyright file="I_ACT_APP_ENVIRONMENT_CONFIG_FILE.cs" company="IVolt, LLC">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ACT.Core.Interfaces.Application
{
    /// <summary>
    /// Interface I_ACT_APP_ENVIRONMENT_CONFIG_FILE
    /// </summary>
    public interface I_ACT_App_Environment_Config_File
    {
        /// <summary>
        /// Gets or sets the environment identifier.
        /// </summary>
        /// <value>The environment identifier.</value>
        Guid EnvironmentId { get; set; }
        /// <summary>
        /// Sets the name of the environment.
        /// </summary>
        /// <value>The name of the environment.</value>
        string EnvironmentName { set; }
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        string FileName { get; set; }
        /// <summary>
        /// Gets or sets the file data.
        /// </summary>
        /// <value>The file data.</value>
        string FileData { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [act configuration].
        /// </summary>
        /// <value><c>true</c> if [act configuration]; otherwise, <c>false</c>.</value>
        bool ACTConfig { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [web configuration].
        /// </summary>
        /// <value><c>true</c> if [web configuration]; otherwise, <c>false</c>.</value>
        bool WebConfig { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [other configuration].
        /// </summary>
        /// <value><c>true</c> if [other configuration]; otherwise, <c>false</c>.</value>
        bool OtherConfig { get; set; }
        /// <summary>
        /// Gets or sets the other destination.
        /// </summary>
        /// <value>The other destination.</value>
        string OtherDestination { get; set; }
        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        int Version { get; set; }
    }
}
