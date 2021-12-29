using ACT.Core.Interfaces.Common;

namespace ACT.Core.Interfaces.DataAccess
{
    public interface I_DataAccess : I_Plugin
    {
        /// <summary>
        /// Create table from a Class 
        /// </summary>
        /// <param name="Class"></param>
        /// <param name="SQL"></param>
        /// <param name="AutoExecute"></param>
        /// <param name="CreateIdentity"></param>
        /// <param name="Recursive"></param>
        void CreateTableFromI_CoreObject(object Class, out string SQL, bool AutoExecute = false, bool CreateIdentity = true, bool Recursive = false);

        /// <summary>
        /// Generates The Where Statement Based On the IDbWhereStatement
        /// </summary>
        /// <param name="WhereStatement"></param>
        /// <returns></returns>
        string GenerateWhereStatement(I_DbWhereStatement Where, string WhereStatement);

        /// <summary>
        /// Generates a list of Parameters use in the SQL Action
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        List<System.Data.IDataParameter> GenerateWhereStatementParameters(I_DbWhereStatement Where);

        /// <summary>
        /// Authenticate User Based On Only Username and Password
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        Security.I_UserInfo AuthenticateUser(string UserName, string Password);

        /// <summary>
        /// Authenticate the user against the database.
        /// </summary>
        /// <param name="User">User Info</param>
        /// <returns></returns>
        bool AuthenticateUser(Security.I_UserInfo User);


        /// <summary>
        /// Performs a Database Action
        /// </summary>
        /// <param name="CommandText">SQL Command to Execute</param>
        /// <param name="Params">Params to Pass - System.Data.IDataParameter</param>
        /// <param name="ReturnsRows">Trap the return tables?</param>
        /// <param name="CmdType">Type of Command - System.Data.CommandType</param>
        /// <returns>IQueryResult</returns>
        I_QueryResult RunCommand(string CommandText, List<System.Data.IDataParameter> Params, bool ReturnsRows, System.Data.CommandType CmdType);

        /// <summary>
        /// Performs a Database Action.  All Indexes must match- i.e Command[0] with Param[0]
        /// </summary>
        /// <param name="CommandTexts">SQL Commands to Execute</param>
        /// <param name="Params">List of a List of Params to Pass - System.Data.IDataParameter</param>
        /// <param name="ReturnsRows">List of Trap the return tables?</param>
        /// <param name="CmdType">Type of Command - System.Data.CommandType</param>
        /// <returns>IQueryResult</returns>
        I_QueryResult RunCommand(List<string> CommandTexts, List<List<System.Data.IDataParameter>> Params, List<bool> ReturnsRows, List<System.Data.CommandType> CmdTypes);

        /// <summary>
        /// Performs a Database Action.  All Indexes must match- i.e Command[0] with Param[0]
        /// </summary>
        /// <param name="CommandTexts">SQL Commands to Execute</param>
        /// <param name="Params">List of a List of Params to Pass - System.Data.IDataParameter</param>
        /// <param name="ReturnsRows">List of Trap the return tables?</param>
        /// <param name="UseTransactions">This will wrap the Commands in 1 Transaction</param>
        /// <param name="AutoRollback">This will auto rollback the transaction on a failer</param>
        /// <param name="CmdType">Type of Command - System.Data.CommandType</param>
        /// <returns>IQueryResult</returns>
        I_QueryResult RunCommand(List<string> CommandTexts, List<List<System.Data.IDataParameter>> Params, List<bool> ReturnsRows, bool UseTransactions, bool AutoRollback, List<System.Data.CommandType> CmdTypes);

        /// <summary>
        /// Execute Bulk Insert (Fast Fast)
        /// </summary>
        /// <param name="BulkData"></param>
        /// <param name="TableName"></param>
        /// <param name="BulkCopyOptions"></param>
        /// <returns></returns>
        I_QueryResult ExecuteBulkInsert(System.Data.DataTable BulkData, string TableName, System.Data.SqlClient.SqlBulkCopyOptions BulkCopyOptions);

        /// <summary>
        /// Execute Bulk Insert (Fast Fast) With Column Mapping
        /// </summary>
        /// <param name="BulkData"></param>
        /// <param name="TableName"></param>
        /// <param name="BulkCopyOptions"></param>
        /// <param name="addColumnMapping"></param>
        /// <returns></returns>
        I_QueryResult ExecuteBulkInsert(System.Data.DataTable BulkData, string TableName, System.Data.SqlClient.SqlBulkCopyOptions BulkCopyOptions, bool addColumnMapping);

        /// <summary>
        /// Open the default connection.  Defined in SystemConfigurationFile
        /// </summary>
        /// <returns>Success Result</returns>
        bool Open();

        /// <summary>
        /// Open a Specific Connection.
        /// </summary>
        /// <param name="ConnectionString">Connection String</param>
        /// <returns>Success Result</returns>
        bool Open(string ConnectionString);

        /// <summary>
        /// Open a Specific Connection.
        /// </summary>
        /// <param name="ConnectionString">Connection String</param>
        /// <param name="EncryptConnectionString">Set to true if you want to Encrypt the Connection String using the default settings in configuration file</param>
        /// <returns>Success Result</returns>
        bool Open(string ConnectionString, bool EncryptConnectionString);

        /// <summary>
        /// Returns true if Database Connection is Active
        /// </summary>
        bool Connected { get; }

        /// <summary>
        /// Returns the Connection String.
        /// </summary>
        string ConnectionString { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="GroupName"></param>
        /// <returns></returns>
        string GetStoredSQLQuery(string Name, string GroupName);

        /// <summary>
        /// Start a Transaction
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Commit A Transaction
        /// </summary>
        void CommitTransaction();

        /// <summary>
        /// Roll Current Transaction Back
        /// </summary>
        void RollbackTransaction();

        /// <summary>
        /// Sets the Current Command Timeout In Seconds
        /// </summary>
        /// <param name="Seconds"></param>
        void SetCommandTimeout(int Seconds);

        /// <summary>
        /// Export the Current Database
        /// </summary>
        /// <returns></returns>
        I_Db ExportDatabase();

        /// <summary>
        /// Modify Table
        /// </summary>
        /// <param name="OriginalTable">Original Table Structure</param>
        /// <param name="NewTable">New Table Structure</param>
        /// <returns>True on Success</returns>
        bool ModifyTable(I_DbTable OriginalTable, I_DbTable NewTable);

        /// <summary>
        /// Create A Table
        /// </summary>
        /// <param name="NewTable">New Table Structure</param>
        /// <returns>True on Success</returns>
        bool CreateTable(I_DbTable NewTable);

        /// <summary>
        /// Drop / Remove a Table
        /// </summary>
        /// <param name="TableToDrop">Table To Drop</param>
        /// <returns>True on Success</returns>
        bool DropTable(I_DbTable TableToDrop);

        /// <summary>
        /// Inserts Data Into the Table
        /// </summary>
        /// <param name="TableName">Table Name To Insert Data Into</param>
        /// <param name="FieldsAndValues">Fields and Values To Insert</param>
        /// <returns></returns>
        I_QueryResult InsertData(string TableName, Dictionary<string, object> FieldsAndValues);

        /// <summary>
        /// Updates the data in the table specified
        /// </summary>
        /// <param name="TableName">Table To Update data In</param>
        /// <param name="FieldsAndValues">Fields And Values</param>
        /// <param name="Where">Where statement defining scope of update</param>
        /// <returns>IQueryResult</returns>
        I_QueryResult UpdateData(string TableName, Dictionary<string, object> FieldsAndValues, I_DbWhereStatement Where);


        /// <summary>
        /// Deletes the data in the table specified
        /// </summary>
        /// <param name="TableName">Table To Delete data From</param>
        /// <param name="Where">Where statement defining scope of delete</param>
        /// <returns>IQueryResult</returns>
        I_QueryResult DeleteData(string TableName, I_DbWhereStatement Where);

        /// <summary>
        /// Duplicate Rows BasedOn the Where Statement
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Where"></param>
        /// <returns></returns>
        I_QueryResult DuplicateRow(string TableName, I_DbWhereStatement Where);

        /// <summary>
        /// Duplicate Rows BasedOn the Where Statement Limit to the First x Number
        /// </summary>
        /// <param name="TableName">Table Name</param>
        /// <param name="Where"></param>
        /// <param name="Number">Limit to First Number Of Rows</param>
        /// <returns></returns>
        I_QueryResult DuplicateRow(string TableName, I_DbWhereStatement Where, int Number);

        /// <summary>
        /// Insert Data
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="FieldsAndValues"></param>
        /// <returns></returns>
        I_QueryResult InsertData(I_DbTable Table, Dictionary<I_DbColumn, object> FieldsAndValues);

        /// <summary>
        /// Update Data
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="FieldsAndValues"></param>
        /// <param name="Where"></param>
        /// <returns></returns>
        I_QueryResult UpdateData(I_DbTable Table, Dictionary<I_DbColumn, object> FieldsAndValues, I_DbWhereStatement Where);

        /// <summary>
        /// Update Data
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="FieldsAndValues"></param>
        /// <returns></returns>
        I_QueryResult UpdateData(I_DbTable Table, Dictionary<I_DbColumn, object> FieldsAndValues);

        /// <summary>
        /// Delete Data
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="Where"></param>
        /// <returns></returns>
        I_QueryResult DeleteData(I_DbTable Table, I_DbWhereStatement Where);

        /// <summary>
        /// Special Function.  You can use the to clean databases when you are really deleting items.  FK Erros would occur otherwise
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="FieldsAndValues"></param>
        /// <param name="RecursiveDelete"></param>
        /// <returns></returns>
        I_QueryResult DeleteData(I_DbTable Table, Dictionary<I_DbColumn, object> FieldsAndValues, bool RecursiveDelete);

        /// <summary>
        /// Duplicate Row
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="FieldsAndValues"></param>
        /// <returns></returns>
        I_QueryResult DuplicateRow(I_DbTable Table, Dictionary<I_DbColumn, object> FieldsAndValues);

        /// <summary>
        /// Duplicate Row With Limit
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="FieldsAndValues"></param>
        /// <param name="Number"></param>
        /// <returns></returns>
        I_QueryResult DuplicateRow(I_DbTable Table, Dictionary<I_DbColumn, object> FieldsAndValues, int Number);

        /// <summary>
        /// Get Table Data
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="Where"></param>
        /// <returns></returns>
        I_QueryResult GetTableData(I_DbTable Table, I_DbWhereStatement Where);
    }

}
