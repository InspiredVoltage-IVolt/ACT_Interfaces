namespace ACT.Core.Interfaces.WebServices.Data
{
    public interface I_Get_Web_Object
    {
        Dictionary<Guid, Dictionary<string, List<string>>> GatheredData { get; set; }
        bool LoginToService(string ServiceInfo, string UN, string PW, string Token = "", string Other = "");
        bool GetData(Guid TracerID, string Object, DataAccess.I_Db_Where_Statement Conditions = null, string Token = "", string Other = "");
        Dictionary<Guid, List<string>> SystemMessages { get; set; }
        bool SetData(Guid TracerID, string Object, Dictionary<string, string> DataToSet, DataAccess.I_Db_Where_Statement Conditions = null, string Token = "", string Other = "");
    }
}
