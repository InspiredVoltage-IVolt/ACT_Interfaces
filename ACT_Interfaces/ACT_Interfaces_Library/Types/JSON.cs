using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Types
{
    public class JSONObject
    {
        public enum DeserializeReturnTypes { Dictionary, List, Other }

        private string _RawJSON = "";
        Dictionary<string, string> JSONData = new Dictionary<string, string>();
        List<object> JSONListData = new List<object>();
       // object JSONObjectData = null;


        public string RawJSON { get { return _RawJSON; } }
        public DeserializeReturnTypes? CurrentProcessedJSONDataType = null;



        public void ParseJSON(string Path, bool UseJConvertMethod = true)
        {

            if (!System.IO.File.Exists(Path))
            {
                // TODO LOG ERROR
                return;
            }

            _RawJSON = System.IO.File.ReadAllText(Path);

            if (_RawJSON == null || _RawJSON == "")
            {
                // TODO LOG ERROR
                return;
            }


            if (UseJConvertMethod) { var o = JsonConvert.DeserializeObject<IDictionary<string, string>>(RawJSON, new DictionaryConverter()); }
            else
            {

                var jsonData = Deserialize(RawJSON);

                if (jsonData.GetType() == typeof(Dictionary<string, string>))
                {
                    CurrentProcessedJSONDataType = DeserializeReturnTypes.Dictionary;
                    return;
                }
                else if (jsonData.GetType() == typeof(List<string>))
                {
                    CurrentProcessedJSONDataType = DeserializeReturnTypes.List;
                    return;
                }
                else
                {
                    CurrentProcessedJSONDataType = DeserializeReturnTypes.Other;
                    return;
                }
            }
        }

        public static object Deserialize(string json)
        {
            return ToObject(JToken.Parse(json));
        }

        public static object ToObject(JToken token)
        {
            switch (token.Type)
            {
                case JTokenType.Object:
                    return token.Children<JProperty>()
                                .ToDictionary(prop => prop.Name,
                                              prop => ToObject(prop.Value));

                case JTokenType.Array:
                    return token.Select(ToObject).ToList();

                default:
                    return ((JValue)token).Value;
            }
        }

        internal static bool IsBase64String(string base64)
        {
            if (base64 == null) { return false; }

            Span<byte> buffer = new Span<byte>(new byte[base64.Length]);
            return Convert.TryFromBase64String(base64, buffer, out int bytesParsed);
        }
    }


    public class DictionaryConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { this.WriteValue(writer, value); }

        private void WriteValue(JsonWriter writer, object value)
        {
            var t = JToken.FromObject(value);
            switch (t.Type)
            {
                case JTokenType.Object:
                    this.WriteObject(writer, value.ToString());
                    break;
                case JTokenType.Array:
                    this.WriteArray(writer, value.ToString());
                    break;
                default:
                    writer.WriteValue(value.ToString());
                    break;
            }
        }

        private void WriteObject(JsonWriter writer, object value)
        {
            writer.WriteStartObject();
            var obj = value as IDictionary<string, string>;
            foreach (var kvp in obj)
            {
                writer.WritePropertyName(kvp.Key);
                this.WriteValue(writer, kvp.Value.ToString());
            }
            writer.WriteEndObject();
        }

        private void WriteArray(JsonWriter writer, object value)
        {
            writer.WriteStartArray();
            var array = value as IEnumerable<string>;
            foreach (var o in array)
            {
                this.WriteValue(writer, o);
            }
            writer.WriteEndArray();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return ReadValue(reader);
        }

        private object ReadValue(JsonReader reader)
        {
            while (reader.TokenType == JsonToken.Comment)
            {
                if (!reader.Read())
                {
                    throw new JsonSerializationException("Unexpected Token when converting IDictionary<string, string>");
                }
            }

            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    return ReadObject(reader);
                case JsonToken.StartArray:
                    return this.ReadArray(reader);
                case JsonToken.Integer:
                case JsonToken.Float:
                case JsonToken.String:
                case JsonToken.Boolean:
                case JsonToken.Undefined:
                case JsonToken.Null:
                case JsonToken.Date:
                case JsonToken.Bytes:
                    return reader.Value;
                default:
                    throw new JsonSerializationException
                        (string.Format("Unexpected token when converting IDictionary<string, string>: {0}", reader.TokenType));
            }
        }

        private object ReadArray(JsonReader reader)
        {
            IList<string> list = new List<string>();

            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonToken.Comment:
                        break;
                    default:
                        var v = ReadValue(reader);

                        list.Add(v.ToString());
                        break;
                    case JsonToken.EndArray:
                        return list;
                }
            }

            throw new JsonSerializationException("Unexpected end when reading IDictionary<string, string>");
        }

        private object ReadObject(JsonReader reader)
        {
            var obj = new Dictionary<string, string>();

            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonToken.PropertyName:
                        var propertyName = reader.Value.ToString();

                        if (!reader.Read())
                        {
                            throw new JsonSerializationException("Unexpected end when reading IDictionary<string, string>");
                        }

                        var v = ReadValue(reader);

                        obj[propertyName] = v.ToString();
                        break;
                    case JsonToken.Comment:
                        break;
                    case JsonToken.EndObject:
                        return obj;
                }
            }

            throw new JsonSerializationException("Unexpected end when reading IDictionary<string, string>");
        }

        public override bool CanConvert(Type objectType) { return typeof(IDictionary<string, object>).IsAssignableFrom(objectType); }
    }
}
