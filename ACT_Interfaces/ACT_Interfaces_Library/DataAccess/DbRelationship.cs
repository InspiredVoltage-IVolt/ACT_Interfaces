using System.Data;

namespace ACT.Core.Interfaces.DataAccess
{
    /// <summary>
    /// Interface Defines a DBRelationship
    /// </summary>
    public interface I_DbRelationship : I_Core
    {
        bool MultiFieldRelationship { get; set; }

        void AddColumn(string ColName, string ExternalColName);

        List<string> ColumnNames { get; set; }
        List<string> ExternalColumnNames { get; set; }
        /// <summary>
        /// Column Name Where Relationship Is Found
        /// </summary>
        string ColumnName { get; set; }

        DbType ColumnType { get; set; }
        /// <summary>
        /// Table Name Where Relationship Is Found (Fully Qualified)
        /// </summary>
        string TableName { get; set; }

        /// <summary>
        /// Short Name of Table Where Relationship is Found
        /// </summary>
        string ShortTableName { get; set; }

        /// <summary>
        /// Relationship Name..  Changed depending on Origin (FK_NAME,PK_NAME)
        /// </summary>
        string RelationshipName { get; set; }

        /// <summary>
        /// Table Name Where Relationship Matched (Fully Qualified)
        /// </summary>
        string External_TableName { get; set; }

        DbType External_ColumnType { get; set; }
        /// <summary>
        /// Short Name of Table Where Relationship is Matched
        /// </summary>
        string ShortExternal_TableName { get; set; }

        /// <summary>
        /// Column Name Where Relationship Is Matched
        /// </summary>
        string External_ColumnName { get; set; }

        /// <summary>
        /// Specifies if this relationship is a ForeignKey or not Depending on Origin
        /// </summary>
        bool IsForeignKey { get; set; }


    }
}
