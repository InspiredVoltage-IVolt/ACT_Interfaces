// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 02-26-2019
// ***********************************************************************
// <copyright file="I_DbColumn.cs" company="IVolt, LLC">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACT.Core.Interfaces.Common;
using System.ComponentModel;

namespace ACT.Core.Interfaces.DataAccess
{

    /// <summary>
    /// Interface I_DbColumn
    /// Implements the <see cref="ACT.Core.Interfaces.I_Core" />
    /// Implements the <see cref="System.IComparable" />
    /// </summary>
    /// <seealso cref="ACT.Core.Interfaces.I_Core" />
    /// <seealso cref="System.IComparable" />
    public interface I_Db_Column : IComparable
    {
        /// <summary>
        /// ACT Standard
        /// </summary>
        Guid ACT_Standard_ID { get; set; }

        /// <summary>
        /// Reference to the Parent Table
        /// </summary>
        /// <value>The parent table.</value>
        I_Db_Table ParentTable { get; set; }

        /// <summary>
        /// Fully Qualified Name
        /// </summary>
        /// <value>The name.</value>
        string FullyQualified_Name { get; set; }

        /// <summary>
        /// Short Name
        /// </summary>
        /// <value>The short name.</value>
        string ShortName { get; set; }

        /// <summary>
        /// Data Type Of Column
        /// </summary>
        /// <value>The type of the data.</value>
        System.Data.DbType DataType { get; set; }

        /// <summary>
        /// Custom Data Type Name Of Column
        /// </summary>
        /// <value>The type of the data.</value>
        string CustomUser_DataType_Name { get; set; }

        /// <summary>
        /// Default Value i.e GetDate() or 1 or '1' etc..
        /// </summary>
        /// <value>The default.</value>
        string Default { get; set; }

        /// <summary>
        /// Allows Nulls
        /// </summary>
        /// <value><c>true</c> if nullable; otherwise, <c>false</c>.</value>
        bool Nullable { get; set; }

        /// <summary>
        /// Size of Data Column
        /// </summary>
        /// <value>The size.</value>
        int Size { get; set; }

        /// <summary>
        /// The Precision
        /// </summary>
        /// <value>The precision.</value>
        int Precision { get; set; }

        /// <summary>
        /// The Scale
        /// </summary>
        /// <value>The scale.</value>
        int Scale { get; set; }

        /// <summary>
        /// Is this an Identity Column
        /// </summary>
        /// <value><c>true</c> if identity; otherwise, <c>false</c>.</value>
        bool Identity { get; set; }

        /// <summary>
        /// Auto Increment
        /// </summary>
        /// <value><c>true</c> if [automatic increment]; otherwise, <c>false</c>.</value>
        bool AutoIncrement { get; set; }

        /// <summary>
        /// Identity Increment
        /// </summary>
        /// <value>The identity increment.</value>
        int IdentityIncrement_Step { get; set; }

        /// <summary>
        /// Identity Seed
        /// </summary>
        /// <value>The identity seed.</value>
        int Identity_Seed { get; set; }

        /// <summary>
        /// Is this Column a Primary Key
        /// </summary>
        /// <value><c>true</c> if this instance is primary key; otherwise, <c>false</c>.</value>
        bool Is_PrimaryKey { get; set; }

        /// <summary>
        /// ColumnDescription
        /// </summary>
        /// <value>The description.</value>
        string Description { get; set; }

        /// <summary>
        /// The Date and Time this Column was Created
        /// </summary>
        DateTime DateCreated { get; set; }

        /// <summary>
        /// The Date and Time this Column was Last Modified
        /// </summary>
        DateTime LastModifiedDate { get; set; }
    }
    
}
