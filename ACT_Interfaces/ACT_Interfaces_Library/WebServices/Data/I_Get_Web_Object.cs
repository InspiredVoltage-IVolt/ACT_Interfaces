namespace ACT.Core.Interfaces.WebServices.Data
{
    public interface I_Get_Web_Object
    {
        Dictionary<Guid, Dictionary<string, List<string>>> GatheredData { get; set; }
        bool LoginToService(string ServiceInfo, string un, string pw, string Token = "", string Other = "");
        bool GetData(Guid tracerId, string Object, DataAccess.I_Db_Where_Statement Conditions = null, string Token = "", string Other = "");
        Dictionary<Guid, List<string>> SystemMessages { get; set; }
        bool SetData(Guid tracerId, string Object, Dictionary<string, string> DataToSet, DataAccess.I_Db_Where_Statement Conditions = null, string Token = "", string Other = "");
    }
}
