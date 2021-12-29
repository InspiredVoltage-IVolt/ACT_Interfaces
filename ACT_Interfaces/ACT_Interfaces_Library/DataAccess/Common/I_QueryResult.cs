namespace ACT.Core.Interfaces.DataAccess
{
    public interface I_QueryResult : I_Core
    {
        List<System.Data.DataTable> Tables { get; }
        List<int> RecordsEffected { get; }
        List<bool> Errors { get; }
        List<string> IdentitiesCaptured { get; set; }
        List<string> Messages { get; set; }
        List<Exception> Exceptions { get; }
        bool Commited { get; set; }
        bool RolledBack { get; set; }
        List<List<System.Data.IDataParameter>> Params { get; set; }
        System.Data.DataTable FirstTable { get; }
        System.Data.DataTable FirstDataTable_WithRows();
        bool FirstQueryHasExceptions { get; }

        bool HasValidData { get; }
        bool HasRows();

        object GetValue(string ColumnName, int Row = 0);

        bool Test_Return_Data(string ErrorMessageForClient, bool TestForNoRecords, bool NoRecordsIsClientIssue, bool TestForNULLValue, bool NULLValueIsClientIssue, bool TestForBlankValue, bool BlankValueIsClientIssue, bool TestForMoreThanOneRecord, bool MoreThanOneRecorIsClientIssue);

    }
}
