using ACT.Core.Interfaces.Common;
using System.ComponentModel;

namespace ACT.Core.Interfaces.DataAccess
{
    /// <summary>
    /// Defines the Structure of a Database
    /// </summary>
    public interface I_Db : I_Plugin
    {
        I_DataAccess DataAccessClass { get; set; }

        string Name { get; set; }

        BindingList<I_DbTable> Tables { get; set; }

        List<IDbDataType> Types { get; set; }
        List<I_DbView> Views { get; set; }
        List<IDbStoredProcedure> StoredProcedures { get; set; }

        I_DbTable GetTable(string Name, bool IgnoreCase);
        I_DbTable GetTable(int Index);

        I_DbView GetView(string Name, bool IgnoreCase);
        I_DbView GetView(int Index);

        int TableCount { get; }

        int ViewCount { get; }
        I_Result AddTable(I_DbTable Table);
        I_Result AddView(I_DbView View);

        I_Result RemoveTable(string Name, bool IgnoreCase);
        I_Result RemoveTable(int Index);

        /// <summary>
        /// Included to reduce 1 line of developers code :->
        /// </summary>
        /// <param name="Original"></param>
        /// <param name="New"></param>
        /// <returns></returns>
        I_Result ModifyTable(I_DbTable Original, I_DbTable New);
        I_Result ModifyTable(string OriginalName, I_DbTable New);

        /// <summary>
        /// Validate the Current Structure of the Database
        /// </summary>
        /// <returns>I_Result</returns>
        I_Result Validate();

    }
}
