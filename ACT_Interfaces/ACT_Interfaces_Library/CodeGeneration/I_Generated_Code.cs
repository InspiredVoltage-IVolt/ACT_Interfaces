﻿// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 04-13-2022
// ***********************************************************************
// <copyright file="I_GeneratedCode.cs" company="IVolt, LLC">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ACT.Core.Interfaces.CodeGeneration
{
    /// <summary>
    /// Defines The Code Generation Output
    /// </summary>
    public interface I_Generated_Code
    {
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        string FileName { get; set; }
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        string Path { get; set; }
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        string Code { get; set; }
        /// <summary>
        /// Gets or sets the user code.
        /// </summary>
        /// <value>The user code.</value>
        string UserCode { get; set; }
        /// <summary>
        /// Gets or sets the web service code.
        /// </summary>
        /// <value>The web service code.</value>
        string WebServiceCode { get; set; }
        /// <summary>
        /// Gets or sets the web service SOAP code.
        /// </summary>
        /// <value>The web service SOAP code.</value>
        string WebServiceSoapCode { get; set; }
        /// <summary>
        /// Gets or sets the web service SOAP asmx.
        /// </summary>
        /// <value>The web service SOAP asmx.</value>
        string WebServiceSoapAsmx { get; set; }
        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        string TableName { get; set; }

        /// <summary>
        /// Gets or sets the database connection string.
        /// </summary>
        /// <value>The database connection string.</value>
        string DatabaseConnectionString { get; set; }
        /// <summary>
        /// Gets or sets the name of the database connection.
        /// </summary>
        /// <value>The name of the database connection.</value>
        string DatabaseConnectionName { get; set; }

    }
}
