using ACT.Core.Types.JSON;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace ACT.Core.Types.Security
{
    /// <summary>
    /// Represents a Single Author
    /// </summary>
    public class I_Author_Json_Type
    {
        [JsonIgnore()]
        public string Name { get { return FirstName.ToString() + " " + LastName.ToString(); } }

        #region Primary Properties

        [JsonProperty("additional-information", NullValueHandling = NullValueHandling.Ignore)]
        public List<KeyValue_Information_Simple_Json> InformationData { get; set; }
                
        [JsonProperty("first-name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("last-name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }
        
        [JsonProperty("email-address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }
        
        [JsonProperty("homepage-website", NullValueHandling = NullValueHandling.Ignore)]
        public string HomepageWebsite { get; set; }

        [JsonProperty("biography", NullValueHandling = NullValueHandling.Ignore)]
        public string Biography { get; set; }

        [JsonProperty("date-last-edited", NullValueHandling = NullValueHandling.Ignore)]
        public string DateLastEdited { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("act-id-hash", NullValueHandling = NullValueHandling.Ignore)]
        public string ActidHash { get; set; }

        [JsonProperty("external-id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalID { get; set; }

        #endregion

        #region From and To Json Methods

        /// <summary>
        /// Static Constructor
        /// </summary>
        /// <param name="json">JSON to Represent</param>
        /// <returns>I_Author_Json_Type</returns>
        public static I_Author_Json_Type FromJson(string json)
        {
            var _tmpReturn = JsonConvert.DeserializeObject<I_Author_Json_Type>(json, JSONHelper.Converter.Settings);                    
            return _tmpReturn;
        }

        /// <summary>
        /// Save To Json
        /// </summary>
        /// <returns>Json String</returns>
        public string ToJson() => JsonConvert.SerializeObject(this, JSONHelper.Converter.Settings);

        #endregion
    }


}
