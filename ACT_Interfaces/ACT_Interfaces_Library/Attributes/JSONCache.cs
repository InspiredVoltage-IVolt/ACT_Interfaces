using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Attributes
{
    public class Json_Data
    {
        public string JsonSchemaIdentifierDll = "";
        public string JsonSchemaIdentifierFullClassName = "";
        public string JsonSchemaExampleBlank = "";
        public string JsonSchemaIdentifier = "";
        public Dictionary<string, string> JsonSchemaAdditionalInfo = new Dictionary<string, string>();
        public int DatabaseId;
        public DateTime? UpdateDate = null;
    }

    public static class Json_Schema_Information_Cache
    {
        public static Dictionary<string, Json_Data> JsonCache = new Dictionary<string, Json_Data>();

        public static Json_Data Get_Schema(string Identifier)
        {
            if (JsonCache.ContainsKey(Identifier)) { return JsonCache[Identifier]; }
            else { return null; }
        }

        public static void AddUpdateSchema(Json_Data Data)
        {
            if (JsonCache.ContainsKey(Data.JsonSchemaIdentifier))
            {
                if (Data.UpdateDate > JsonCache[Data.JsonSchemaIdentifier].UpdateDate)
                {
                    JsonCache[Data.JsonSchemaIdentifier] = Data;
                }
            }
            else
            {
                JsonCache.Add(Data.JsonSchemaIdentifier, Data);
            }
        }

        public static void ClearCache()
        {
            JsonCache.Clear();
        }
    }
}
