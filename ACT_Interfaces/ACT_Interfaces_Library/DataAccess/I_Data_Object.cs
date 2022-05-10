// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 04-13-2022
// ***********************************************************************
// <copyright file="I_DataObject.cs" company="IVolt, LLC">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ACT.Core.Interfaces.DataAccess
{
    /// <summary>
    /// Interface I_DataObject
    /// </summary>
    public interface I_Data_Object
    {
        /// <summary>
        /// Gets the primary key.
        /// </summary>
        /// <value>The primary key.</value>
        string PrimaryKey { get; }
        /// <summary>
        /// Updates this instance.
        /// </summary>
        /// <returns>I_QueryResult.</returns>
        I_QueryResult Update();
        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>I_QueryResult.</returns>
        I_QueryResult Create();



    }
}
