using ACT.Core.Interfaces.Data.JSON_Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class Json_Schema_ReturnInfo : Attribute
    {
        private string _jsonSchemaIdentifierDll = "";
        private string _jsonSchemaIdentifierFullClassName = "";
        private string _jsonSchemaExampleBlank = "{\"Common\"}";
        private string _jsonSchemaIdentifier;
        private int _namedInt;

        /// <summary>
        /// This is a JSON Schema Definitions
        /// </summary>
        /// <param name="jsonSchemaIdentifier"></param>
        public Json_Schema_ReturnInfo(string jsonSchemaIdentifier, string implementationPluginJsonIdentifier = "")
        {
           // I_PluginDefinition _PluginParser = ACT.
            this._jsonSchemaIdentifier = jsonSchemaIdentifier;
          //  this._JSON_Schema_Identifier_DLL = DLLName;
          //  this._JSON_Schema_Identifier_FullClassName = FullClassName;

        }

        /// <summary>
        /// JSON Schema Identifier
        /// </summary>
        public string Json_Schema_Identifier => _jsonSchemaIdentifier ?? "CommonNameValue";

        /// <summary>
        /// JSON Schema Identifier
        /// </summary>
        public int NamedInt => _namedInt;

        public string Json_Schema_Identifier_Dll => _jsonSchemaIdentifierDll;
        public string Json_Schema_Identifier_FullClassName => _jsonSchemaIdentifierFullClassName;
        public string Json_Schema_Example_Blank => _jsonSchemaExampleBlank;

        /// <summary>
        /// Process the Positional String
        /// </summary>
        private void ProcessPositionalString()
        {
            // Connect To API If Cache Doesnt Contain Schema
        }
    }    
}
