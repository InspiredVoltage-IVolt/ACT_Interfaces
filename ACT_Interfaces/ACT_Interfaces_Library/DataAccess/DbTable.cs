using System.ComponentModel;

namespace ACT.Core.Interfaces.DataAccess
{
    public interface I_DbTable : I_Core, IComparable
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

        /// <summary>
        /// Remove a Column From A Index Position
        /// </summary>
        /// <param name="Index"></param>
        void RemoveColumn(int Index);

        /// <summary>
        /// Remove a Column by Name
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="IgnoreCase"></param>
        void RemoveColumn(string Name, bool IgnoreCase);

        /// <summary>
        /// Gets the Primary Keys
        /// </summary>
        List<string> GetPrimaryColumnNames { get; set; }

        /// <summary>
        /// Return the Column Count
        /// </summary>
        int ColumnCount { get; }



        /// <summary>
        /// Is a System Table
        /// </summary>
        bool IsSystem { get; }

        /// <summary>
        /// Is a Package Table??
        /// </summary>
        bool IsPackageTable { get; }

        /// <summary>
        /// Is a UserTable
        /// </summary>
        bool IsUserTable { get; }

        /// <summary>
        /// We only Support Single Primary Keys.  NO Composite Keys!
        /// </summary>
        string PrimaryKeyColumnName { get; }


        /// <summary>
        /// FOREIGN Keys are only the ones that are found using sp_fkeys in MSSSQL
        /// </summary>
        int RelationshipCount { get; }
        bool AddRelationship(I_DbRelationship Relationship);
        void Remove_Relationship(int Index);
        void Remove_Relationship(string Name, bool IgnoreCase);
        I_DbRelationship GetRelationship(string Name, bool IgnoreCase);
        I_DbRelationship GetRelationship(int Index);
        BindingList<I_DbRelationship> AllRelationships { get; }

        /// <summary>
        /// Good luck implemeting this . I choose to only process this on create 
        /// </summary>
        /// <param name="ColName"></param>
        void MoveColumnUp(string ColName);
        /// <summary>
        /// Good luck implemeting this .  I choose to only process this on create
        /// </summary>
        /// <param name="ColName"></param>
        void MoveColumnDown(string ColName);

        string GenerateDataExportStructure();
        string GetInsertDataSQL(List<string> Fields);
        string GetUpdateDataSQL(List<string> Fields, I_DbWhereStatement Where);
        string GetUpdateDataSQL(List<string> Fields);
        string GetDeleteDataSQL(I_DbWhereStatement Where);

    }
}
