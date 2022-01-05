// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 02-26-2019
// ***********************************************************************
// <copyright file="I_DB_Table_Archive.cs" company="Stonegate Intel LLC">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using ACT.Core.Interfaces.Common;
using System.Collections.Generic;


namespace ACT.Core.Interfaces.DataAccess
{
    /// <summary>
    /// Interface I_DB_Table_Archive
    /// Implements the <see cref="ACT.Core.Interfaces.Common.I_Plugin" />
    /// </summary>
    /// <seealso cref="ACT.Core.Interfaces.Common.I_Plugin" />
    public interface I_DB_Table_Archive : I_Plugin
    {
        /// <summary>
        /// Generates the archive SQL.
        /// </summary>
        /// <param name="TableName">Name of the table.</param>
        /// <returns>System.String.</returns>
        string GenerateArchiveSQL(string TableName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        List<string> GetDependantTables(string TableName);

    
    }
}
