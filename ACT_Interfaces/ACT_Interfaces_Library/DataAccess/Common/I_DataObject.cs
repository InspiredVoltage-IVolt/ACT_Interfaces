namespace ACT.Core.Interfaces.DataAccess
{
    public interface I_DataObject
    {
        string PrimaryKey { get; }
        I_QueryResult Update();
        I_QueryResult Create();
    }
}
