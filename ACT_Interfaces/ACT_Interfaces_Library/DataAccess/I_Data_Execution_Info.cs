// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 04-13-2022
// ***********************************************************************
// <copyright file="I_DataExecutionInfo.cs" company="IVolt, LLC">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.DataAccess
{
    /// <summary>
    /// Interface I_DataExecutionInfo
    /// </summary>
    public interface I_Data_Execution_Info : Plugins.I_Plugin
    {
        /// <summary>
        /// Gets or sets the name of the database connection.
        /// </summary>
        /// <value>The name of the database connection.</value>
        string DatabaseConnectionName { get; set; }

        /// <summary>
        /// Gets or sets the database command text.
        /// </summary>
        /// <value>The database command text.</value>
        string DatabaseCommandText { get; set; }

        /// <summary>
        /// Gets or sets the execution parameters.
        /// </summary>
        /// <value>The execution parameters.</value>
        List<System.Data.IDataParameter> ExecutionParameters { get; set; }

        
    }
}
