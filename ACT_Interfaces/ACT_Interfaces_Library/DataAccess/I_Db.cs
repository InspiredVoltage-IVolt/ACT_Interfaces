// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 02-26-2022
// ***********************************************************************
// <copyright file="I_Db.cs" company="IVolt, LLC">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using ACT.Core.Interfaces.Common;
using System.ComponentModel;

namespace ACT.Core.Interfaces.DataAccess
{
    /// <summary>
    /// Defines the Structure of a Database
    /// Implements the <see cref="ACT.Core.Interfaces.Plugins. Plugins.I_Plugin " />
    /// </summary>
    /// <seealso cref="ACT.Core.Interfaces.Plugins. Plugins.I_Plugin " />
    public interface I_Db : Plugins.I_Plugin 
    {
        /// <summary>
        /// Gets or sets the data access class.
        /// </summary>
        /// <value>The data access class.</value>
        I_DataAccess DataAccessClass { get; set; }

        /// <summary>
        /// Gets or sets the Database name.
        /// </summary>
        /// <value>The Database name.</value>
        string Name { get; set; }

        /// <summary>
        /// List of the Schema Names
        /// </summary>
        List<string> SchemaNames { get; set; }

        /// <summary>
        /// Gets the table names. With Schema i.e. [dbo].TableName
        /// </summary>
        /// <value>The table names.</value>
        List<string> FullyQualified_TableNames { get; }

        /// <summary>
        /// Gets the stored procedure names.
        /// </summary>
        /// <value>The stored praaaaaaaaaaaocedure names.</value>
        List<string> FullyQualified_StoredProcedureNames { get; }
        /// <summary>
        /// Gets the type names.
        /// </summary>
        /// <Fvalue>The type names.</value>
        List<string> FullyQualified_TypeNames { get; }
        /// <summary>
        /// Gets the view names.
        /// </summary>
        /// <value>The view names.</value>
        List<string> FullyQualified_ViewNames { get; }

        /// <summary>
        /// Gets or sets the tables.
        /// </summary>
        /// <value>The tables.</value>
         BindingList<I_Db_Table> FullyQualified_Tables { get; set; }

        /// <summary>
        /// Gets or sets the types.
        /// </summary>
        /// <value>The types.</value>
        List<I_Db_DataType> UserTable_Types { get; set; }
        /// <summary>
        /// Gets or sets the types.
        /// </summary>
        /// <value>The types.</value>
        List<I_Db_DataType> UserScalar_Types { get; set; }
        /// <summary>
        /// Gets or sets the views.
        /// </summary>
        /// <value>The views.</value>
        List<I_Db_View> FullyQualified_Views { get; set; }
        /// <summary>
        /// Gets or sets the stored procedures.
        /// </summary>
        /// <value>The stored procedures.</value>
        List<I_Db_StoredProcedure> FullyQualified_StoredProcedures { get; set; }

        /// <summary>
        /// Gets the table.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="IgnoreCase">if set to <c>true</c> [ignore case].</param>
        /// <returns>I_DbTable.</returns>
        I_Db_Table GetTable(string Name, bool IgnoreCase);
        /// <summary>
        /// Gets the table.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns>I_DbTable.</returns>
        I_Db_Table GetTable(int Index);

        /// <summary>
        /// Gets the view.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="IgnoreCase">if set to <c>true</c> [ignore case].</param>
        /// <returns>I_DbView.</returns>
        I_Db_View GetView(string Name, bool IgnoreCase);
        /// <summary>
        /// Gets the view.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns>I_DbView.</returns>
        I_Db_View GetView(int Index);

        /// <summary>
        /// Gets the table count.
        /// </summary>
        /// <value>The table count.</value>
        int TableCount { get; }

        /// <summary>
        /// Gets the view count.
        /// </summary>
        /// <value>The view count.</value>
        int ViewCount { get; }
        /// <summary>
        /// Adds the table.
        /// </summary>
        /// <param name="Table">The table.</param>
        /// <returns>I_Result.</returns>
        I_Result AddTable(I_Db_Table Table);
        /// <summary>
        /// Adds the view.
        /// </summary>
        /// <param name="View">The view.</param>
        /// <returns>I_Result.</returns>
        I_Result AddView(I_Db_View View);

        /// <summary>
        /// Removes the table.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="IgnoreCase">if set to <c>true</c> [ignore case].</param>
        /// <returns>I_Result.</returns>
        I_Result RemoveTable(string Name, bool IgnoreCase);
        /// <summary>
        /// Removes the table.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <returns>I_Result.</returns>
        I_Result RemoveTable(int Index);

        /// <summary>
        /// Included to reduce 1 line of developers code :-&gt;
        /// </summary>
        /// <param name="Original">The original.</param>
        /// <param name="New">The new.</param>
        /// <returns>I_Result.</returns>
        I_Result ModifyTable(I_Db_Table Original, I_Db_Table New);
        /// <summary>
        /// Modifies the table.
        /// </summary>
        /// <param name="OriginalName">Name of the original.</param>
        /// <param name="New">The new.</param>
        /// <returns>I_Result.</returns>
        I_Result ModifyTable(string OriginalName, I_Db_Table New);

        /// <summary>
        /// Validate the Current Structure of the Database
        /// </summary>
        /// <returns>I_Result</returns>
        I_Result Validate();

    }
}
