using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class Json_Schema_Definitions : Attribute
    {
        private string _jsonSchemaIdentifier;
        private int _namedInt;

        /// <summary>
        /// This is a JSON Schema Definitions
        /// </summary>
        /// <param name="jsonSchemaIdentifier"></param>
        public Json_Schema_Definitions(string jsonSchemaIdentifier)
        {
            this._jsonSchemaIdentifier = jsonSchemaIdentifier;
        }

        /// <summary>
        /// JSON Schema Identifier
        /// </summary>
        public string Json_Schema_Identifier
        {
            get { return _jsonSchemaIdentifier; }
        }

        /// <summary>
        /// JSON Schema Identifier
        /// </summary>
        public int NamedInt { get { return _namedInt; } }

        /// <summary>
        /// Process the Positional String
        /// </summary>
        private void ProcessPositionalString()
        {
            // Connect To API If Cache Doesnt Contain Schema
        }
    }    
}
