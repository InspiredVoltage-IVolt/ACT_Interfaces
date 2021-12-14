namespace ACT.Core.Interfaces.DataAccess
{

    public interface I_DbColumn : I_Core, IComparable
    {
        /// <summary>
        /// Reference to the Parent Table
        /// </summary>
        I_DbTable ParentTable { get; set; }

        /// <summary>
        /// Fully Qualified Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Short Name
        /// </summary>
        string ShortName { get; set; }

        /// <summary>
        /// Data Type Of Column
        /// </summary>
        System.Data.DbType DataType { get; set; }

        /// <summary>
        /// Default Value i.e GetDate() or 1 or '1' etc..
        /// </summary>
        string Default { get; set; }

        /// <summary>
        /// Allows Nulls
        /// </summary>
        bool Nullable { get; set; }

        /// <summary>
        /// Size of Data Column
        /// </summary>
        int Size { get; set; }

        /// <summary>
        /// The Precision
        /// </summary>
        int Precision { get; set; }

        /// <summary>
        /// The Scale
        /// </summary>
        int Scale { get; set; }

        /// <summary>
        /// Is this an Identity Column
        /// </summary>
        bool Identity { get; set; }

        /// <summary>
        /// Auto Increment
        /// </summary>
        bool AutoIncrement { get; set; }

        /// <summary>
        /// Identity Increment
        /// </summary>
        int IdentityIncrement { get; set; }

        /// <summary>
        /// Identity Seed
        /// </summary>
        int IdentitySeed { get; set; }

        /// <summary>
        /// Is this Column a Primary Key
        /// </summary>
        bool IsPrimaryKey { get; set; }

        /// <summary>
        /// ColumnDescription
        /// </summary>
        string Description { get; set; }
    }

}
