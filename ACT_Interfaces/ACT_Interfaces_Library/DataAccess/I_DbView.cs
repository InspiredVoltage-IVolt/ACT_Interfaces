using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACT.Core.Interfaces.Common;
using System.ComponentModel;

namespace ACT.Core.Interfaces.DataAccess
{
    public interface I_DbView : I_Core, IComparable
    {
        /// <summary>
        /// Enumerable List of Columns
        /// </summary>
        BindingList<I_DbColumn> Columns { get; set; }

        /// <summary>
        /// Parent Of This Table
        /// </summary>
        I_Db ParentDatabase { get; set; }

        /// <summary>
        /// Name of the Physical Table.  FULLY Qualified Name i.e [DatabaseA].[dbo].[Member]
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Name of the table.  Not Fully Qualified. i.e. Member
        /// </summary>
        string ShortName { get; set; }

        /// <summary>
        /// Description Of The Table
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Owner of the Table
        /// </summary>
        string Owner { get; set; }

        /// <summary>
        /// Add a Column to the Structure
        /// </summary>
        /// <param name="Column"></param>
        /// <returns></returns>
        bool AddColumn(I_DbColumn Column);

        /// <summary>
        /// Get Column by Name
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="IgnoreCase"></param>
        /// <returns>IDbColumn</returns>
        I_DbColumn GetColumn(string Name, bool IgnoreCase);

        /// <summary>
        /// Get Column at Index Position
        /// </summary>
        /// <param name="Index"></param>
        /// <returns>IDbColumn</returns>
        I_DbColumn GetColumn(int Index);


    }
}
