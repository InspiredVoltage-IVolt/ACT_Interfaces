using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data.SSDD
{
    /// <summary>
    /// Interface defining the structure of the response.
    /// </summary>
    public interface I_SSDD_Response
    {
        /// <summary>
        /// String that Represents the Specific Announcer ResponseID
        /// </summary>
        public string Response_ID { get; }

        /// <summary>
        /// The Content Type of the Content Returned
        /// </summary>
        public string Content_Type { get; }
        
        /// <summary>
        /// The content ususally a JSON object that represents the object returned
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Contains all the Encoding Data Needed.  Example GZip, Encrypted:ACTStandard
        /// </summary>
        public List<string> Encoding_Data { get; }

        /// <summary>
        /// Contains all files available for download related to the ResponseID
        /// </summary>
        public List<string> File_IDs { get; }

        /// <summary>
        /// The Specific JSON Object Type that represents the Content Object
        /// </summary>
        public string Object_Type { get; }

        /// <summary>
        /// Returns true/false if there is code available to download.
        /// </summary>
        public bool Programming_Code_Available { get; }

        /// <summary>
        /// Returns list of the available Programming Code Languages
        /// </summary>
        public List<string> Programming_Code_Languages_Available { get; }

        /// <summary>
        /// Total page count
        /// </summary>
        public int Total_Page_Count { get; set; }

        /// <summary>
        /// Current Page Number
        /// </summary>
        public int Page_Number { get; } 

        /// <summary>
        /// Represents the page Size
        /// </summary>
        public int Page_Size { get; }

        /// <summary>
        /// List of all Errors available
        /// </summary>
        public List<string> Errors { get; }

        /// <summary>
        /// Returns true/false if the call was successfull or not
        /// </summary>
        public bool Success { get; }
    }
}
