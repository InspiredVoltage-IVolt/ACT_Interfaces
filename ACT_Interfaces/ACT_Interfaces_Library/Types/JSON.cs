using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Types
{
    public class JsonObject
    {
        public enum DeserializeReturnTypes { Dictionary, List, Other }

        private string _rawJson = "";
        Dictionary<string, string> _jsonData = new Dictionary<string, string>();
        List<object> _jsonListData = new List<object>();
       // object JSONObjectData = null;


        public string RawJson { get { return _rawJson; } }
        public DeserializeReturnTypes? CurrentProcessedJsonDataType = null;



        public void ParseJson(string Path, bool UseJConvertMethod = true)
        {

            if (!System.IO.File.Exists(Path))
            {
                // TODO LOG ERROR
                return;
            }

            _rawJson = System.IO.File.ReadAllText(Path);

            if (_rawJson == null || _rawJson == "")
            {
                // TODO LOG ERROR
                return;
            }


            if (UseJConvertMethod) { var O = JsonConvert.DeserializeObject<IDictionary<string, string>>(RawJson, new DictionaryConverter()); }
            else
            {

                var JsonData = Deserialize(RawJson);

                if (JsonData.GetType() == typeof(Dictionary<string, string>))
                {
                    CurrentProcessedJsonDataType = DeserializeReturnTypes.Dictionary;
                    return;
                }
                else if (JsonData.GetType() == typeof(List<string>))
                {
                    CurrentProcessedJsonDataType = DeserializeReturnTypes.List;
                    return;
                }
                else
                {
                    CurrentProcessedJsonDataType = DeserializeReturnTypes.Other;
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

            Span<byte> Buffer = new Span<byte>(new byte[base64.Length]);
            return Convert.TryFromBase64String(base64, Buffer, out int BytesParsed);
        }
    }


    public class DictionaryConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { this.WriteValue(writer, value); }

        private void WriteValue(JsonWriter writer, object value)
        {
            var T = JToken.FromObject(value);
            switch (T.Type)
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
            var Obj = value as IDictionary<string, string>;
            foreach (var Kvp in Obj)
            {
                writer.WritePropertyName(Kvp.Key);
                this.WriteValue(writer, Kvp.Value.ToString());
            }
            writer.WriteEndObject();
        }

        private void WriteArray(JsonWriter writer, object value)
        {
            writer.WriteStartArray();
            var Array = value as IEnumerable<string>;
            foreach (var O in Array)
            {
                this.WriteValue(writer, O);
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
            IList<string> List = new List<string>();

            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonToken.Comment:
                        break;
                    default:
                        var V = ReadValue(reader);

                        List.Add(V.ToString());
                        break;
                    case JsonToken.EndArray:
                        return List;
                }
            }

            throw new JsonSerializationException("Unexpected end when reading IDictionary<string, string>");
        }

        private object ReadObject(JsonReader reader)
        {
            var Obj = new Dictionary<string, string>();

            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonToken.PropertyName:
                        var PropertyName = reader.Value.ToString();

                        if (!reader.Read())
                        {
                            throw new JsonSerializationException("Unexpected end when reading IDictionary<string, string>");
                        }

                        var V = ReadValue(reader);

                        Obj[PropertyName] = V.ToString();
                        break;
                    case JsonToken.Comment:
                        break;
                    case JsonToken.EndObject:
                        return Obj;
                }
            }

            throw new JsonSerializationException("Unexpected end when reading IDictionary<string, string>");
        }

        public override bool CanConvert(Type objectType) { return typeof(IDictionary<string, object>).IsAssignableFrom(objectType); }
    }
}
