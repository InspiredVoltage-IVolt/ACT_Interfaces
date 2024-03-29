﻿// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 04-13-2022
// ***********************************************************************
// <copyright file="I_DbWhereStatement.cs" company="IVolt, LLC">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACT.Core.Interfaces.Common;
using System.ComponentModel;
using ACT.Core.Enums;

namespace ACT.Core.Interfaces.DataAccess
{
    /// <summary>
    /// Interface I_DbWhereStatement
    /// Implements the <see cref="ACT.Core.Interfaces.I_Core" />
    /// </summary>
    /// <seealso cref="ACT.Core.Interfaces.I_Core" />
    public interface I_Db_Where_Statement : I_Core
    {
        /// <summary>
        /// Adds the child.
        /// </summary>
        /// <param name="ColumnName">Name of the column.</param>
        /// <param name="DataType">Type of the data.</param>
        /// <param name="Value">The value.</param>
        /// <param name="UseAndWithParent">if set to <c>true</c> [use and with parent].</param>
        /// <returns>I_DbWhereStatement.</returns>
        I_Db_Where_Statement AddChild(string ColumnName, System.Data.DbType DataType, object Value, bool UseAndWithParent);
        /// <summary>
        /// Gets or sets a value indicating whether [use and].
        /// </summary>
        /// <value><c>true</c> if [use and]; otherwise, <c>false</c>.</value>
        bool UseAnd { get; set; }
        /// <summary>
        /// Gets or sets the statement operators.
        /// </summary>
        /// <value>The statement operators.</value>
        Operators StatementOperators { get; set; }
        /// <summary>
        /// Gets or sets the column.
        /// </summary>
        /// <value>The column.</value>
        I_Db_Column Column { get; set; }
        /// <summary>
        /// Gets or sets the name of the column.
        /// </summary>
        /// <value>The name of the column.</value>
        string ColumnName { get; set; }
        /// <summary>
        /// Gets or sets the type of the column data.
        /// </summary>
        /// <value>The type of the column data.</value>
        System.Data.DbType ColumnDataType { get; set; }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        object Value { get; set; }
        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>The children.</value>
        List<I_Db_Where_Statement> Children { get; set; }
        /// <summary>
        /// Gets a value indicating whether this instance has children.
        /// </summary>
        /// <value><c>true</c> if this instance has children; otherwise, <c>false</c>.</value>
        bool HasChildren { get; }
        /// <summary>
        /// Generates from.
        /// </summary>
        /// <param name="FieldsAndValues">The fields and values.</param>
        /// <returns>I_DbWhereStatement.</returns>
        I_Db_Where_Statement GenerateFrom(Dictionary<I_Db_Column, object> FieldsAndValues);
    }
}
