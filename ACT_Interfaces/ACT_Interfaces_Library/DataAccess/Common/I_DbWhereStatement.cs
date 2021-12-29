using ACT.Core.Interfaces.Common;


namespace ACT.Core.Interfaces.DataAccess
{
    public interface I_DbWhereStatement : I_Plugin
    {
        I_DbWhereStatement AddChild(string ColumnName, System.Data.DbType DataType, object Value, bool UseAndWithParent);
        bool UseAND { get; set; }
        string StatementOperators { get; set; }
        I_DbColumn Column { get; set; }
        string ColumnName { get; set; }
        System.Data.DbType ColumnDataType { get; set; }
        object Value { get; set; }
        List<I_DbWhereStatement> Children { get; set; }
        bool HasChildren { get; }
        I_DbWhereStatement GenerateFrom(Dictionary<I_DbColumn, object> FieldsAndValues);
    }
}
