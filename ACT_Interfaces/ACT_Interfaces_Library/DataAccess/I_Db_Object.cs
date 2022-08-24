// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 04-13-2022
// ***********************************************************************
// <copyright file="I_DBObject.cs" company="IVolt, LLC">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACT.Core.Interfaces.Common;


namespace ACT.Core.Interfaces.DataAccess
{
    /// <summary>
    /// Interface I_DBObject
    /// Implements the <see cref="ACT.Core.Interfaces.I_Core" />
    /// Implements the <see cref="ACT.Core.Interfaces.Common.I_Saveable" />
    /// </summary>
    /// <seealso cref="ACT.Core.Interfaces.I_Core" />
    /// <seealso cref="ACT.Core.Interfaces.Common.I_Saveable" />
    public interface I_Db_Object : I_Core, I_Saveable
    {

        /// <summary>
        /// Returns a object that represnts a Database Table.  Used primarly for AUTO Generated Code.
        /// </summary>
        /// <param name="PhysicalTableName">The Physical Table Name</param>
        /// <returns>object representing that table.</returns>
        object ReturnDatabaseChild(string PhysicalTableName);
        /// <summary>
        /// Generates the SQL insert.
        /// </summary>
        /// <param name="IncludeNulls">if set to <c>true</c> [include nulls].</param>
        /// <returns>System.String.</returns>
        string GenerateSqlInsert(bool IncludeNulls);
        /// <summary>
        /// Generates the SQL update.
        /// </summary>
        /// <param name="IncludeNulls">if set to <c>true</c> [include nulls].</param>
        /// <returns>System.String.</returns>
        string GenerateSqlUpdate(bool IncludeNulls);
    


    }
}
