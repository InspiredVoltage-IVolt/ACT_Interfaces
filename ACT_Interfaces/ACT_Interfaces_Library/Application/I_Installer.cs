// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 04-13-2022
// ***********************************************************************
// <copyright file="I_Installer.cs" company="IVolt, LLC">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Application
{
    /// <summary>
    /// Installer
    /// </summary>
    public interface I_Installer
    {
        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="ConfigurationFile">The configuration file.</param>
        /// <param name="SourcePackage">The source package.</param>
        void Initialize(string ConfigurationFile, string SourcePackage);

        /// <summary>
        /// Install
        /// </summary>
        /// <param name="Destination">The destination.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool Install(string Destination);

        /// <summary>
        /// Install From Web
        /// </summary>
        /// <param name="Destination">The destination.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool InstallFromWeb(string Destination);
    }
}
