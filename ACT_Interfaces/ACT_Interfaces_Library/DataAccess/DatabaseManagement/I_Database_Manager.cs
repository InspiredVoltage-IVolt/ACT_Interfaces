using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.DataAccess.DatabaseManagement
{
    /// <summary>
    /// Database Manager
    /// </summary>
    public interface I_Database_Manager : Interfaces.Plugins.I_Plugin 
    {
        /// <summary>
        /// Holds the BASE Data Access Object
        /// Implementation is All You
        /// </summary>
        I_DataAccess DataAccessObject { get; }

        /// <summary>
        /// Create a Table
        /// </summary>
        /// <param name="tableDefinition"></param>
        /// <returns>Test Result Expanded</returns>
        Common.I_ResultExpanded CreateTable(I_Db_Table tableDefinition);

        /// <summary>
        /// Create a Column
        /// </summary>
        /// <param name="columnDefinition"></param>
        /// <returns>Test Result Expanded</returns>
        Common.I_ResultExpanded CreateColumn(I_Db_Column columnDefinition, int OrdinalPosition);

        /// <summary>
        /// Create a Stored Proc
        /// </summary>
        /// <param name="procDefinition"></param>
        /// <returns>Test Result Expanded</returns>
        Common.I_ResultExpanded CreateStoredProc(I_Db_StoredProcedure procDefinition);

        /// <summary>
        /// Create a Function
        /// </summary>
        /// <param name="functionDefinition"></param>
        /// <returns>Test Result Expanded</returns>
        Common.I_ResultExpanded CreateFunction(I_Db_StoredProcedure functionDefinition);


    }
}
