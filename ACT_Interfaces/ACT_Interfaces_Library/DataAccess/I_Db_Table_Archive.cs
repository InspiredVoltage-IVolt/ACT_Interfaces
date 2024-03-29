﻿// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 04-13-2022
// ***********************************************************************
// <copyright file="I_DB_Table_Archive.cs" company="IVolt, LLC">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using ACT.Core.Interfaces.Common;
using System.Collections.Generic;


namespace ACT.Core.Interfaces.DataAccess
{
    /// <summary>
    /// Interface I_DB_Table_Archive
    /// Implements the <see cref="ACT.Core.Interfaces.Plugins. Plugins.I_Plugin " />
    /// </summary>
    /// <seealso cref="ACT.Core.Interfaces.Plugins. Plugins.I_Plugin " />
    public interface I_Db_Table_Archive :  Plugins.I_Plugin 
    {
        /// <summary>
        /// Generates the archive SQL.
        /// </summary>
        /// <param name="TableName">Name of the table.</param>
        /// <returns>System.String.</returns>
        string GenerateArchiveSql(string TableName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        List<string> GetDependantTables(string TableName);

    
    }
}
