using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data.SSDD
{
    /// <summary>
    /// Interface representing the Announcer Class Engine
    /// </summary>
    public interface I_SSDD_Announcer
    {
        /// <summary>
        /// returns a list of intelligence information on finding new servers.
        /// Maps to JSON Standard Intelligence Object.
        /// </summary>
        /// <param name="ServerID">The Requesting Announcers ID</param>
        /// <returns></returns>
	    public List<string> GetScannerIntelligence (string ServerID);

        /// <summary>
        /// Returns the known announcers 
        /// </summary>
        public List<string> GetKnownExternalAnnouncers { get; }

        /// <summary>
        /// Is this Annoucer Online - Available to Accept and Return Data
        /// </summary>
        public bool Online { get; }

        /// <summary>
        /// The ID of this Server
        /// </summary>
        public string ServerID { get; }

        /// <summary>
        /// Public Returns a List of EndPoint Names for this specific Announcer
        /// </summary>
        /// <param name="AuthenticationData">Standard Authentication JSON Data</param>
        /// <param name="SearchData">Standard Search Criteria JSON String</param>
        /// <returns>List<string> EndPointNames</returns>
        public List<string> GetAvailableEndPointNames(string AuthenticationData, string SearchData);

        /// <summary>
        /// Gets the specific information for a specific Endpoint Name this announcer serves up
        /// </summary>
        /// <param name="AuthenticationData">Standard Authentication JSON Data</param>
        /// <param name="EndPointName">Name of the Endpoint</param>
        /// <returns></returns>
        public string GetAvailableEndpointInfo(string AuthenticationData, string EndPointName);

        /// <summary>
        /// Retrieve the actual data served up by this annoucer.
        /// </summary>
        /// <param name="AuthenticationData">Standard Authentication JSON Data</param>
        /// <param name="EndPointName">Name of the Endpoint</param>
        /// <param name="Filter">Standard Filter JSON Object</param>
        /// <param name="SortBy">Standard SortBy Filter JSON Object</param>
        /// <param name="Limit">Limit the result count to a specific number.</param>
        /// <param name="PageSize">Size of the Page Returned.  -1 Returns all data (Be Careful)</param>
        /// <returns>JSON String representing the I_SSDD_Response -  </returns>
        public I_SSDD_Response GetAvailableEndPointData(string AuthenticationData, string EndPointName, string Filter, string SortBy, int Limit, int PageSize = 100);

        /// <summary>
        /// Retrieve the actual data served up by this annoucer.
        /// </summary>
        /// <param name="AuthenticationData">Standard Authentication JSON Data</param>
        /// <param name="EndPointName">Name of the Endpoint</param>
        /// <param name="I_SSDD_Request_JSON_String">JSON String Representing the I_SSDD_Request Object</param>
        /// <returns>JSON String representing the I_SSDD_Response - Object</returns>
        public I_SSDD_Response GetAvailableEndPointData(string AuthenticationData, string EndPointName, string I_SSDD_Request_JSON_String);

        /// <summary>
        /// Get a Base64 Encoded File
        /// </summary>
        /// <param name="AuthenticationData">Standard Authentication JSON Data</param>
        /// <param name="ResponseID">ID of the Response</param>
        /// <param name="FileID">ID of the File</param>
        /// <returns>BASE64 Encoded File</returns>
        public string GetBase64EncodedFile(string AuthenticationData, string ResponseID, Guid FileID);

        /// <summary>
        /// Get Programming Class Code
        /// </summary>
        /// <param name="AuthenticationData">Standard Authentication JSON Data</param>
        /// <param name="Language">Language - Standard Language Code</param>
        /// <param name="ResponseID">ID of the Response</param>
        /// <param name="IncludeArrayWrapper">Include a wrapper that contains many objects.</param>
        /// <param name="IncludeStrictSSDDTies">Include specific code to make populating faster but specific to SSDD</param>
        /// <param name="SpecificCodeAuthorID">Specific Author ID</param>
        /// <returns>String Representing specific Author (Used only when specific code is required)</returns>
        public string GetProgrammingClassCode(string AuthenticationData, string Language, string ResponseID, bool IncludeArrayWrapper, bool IncludeStrictSSDDTies, string SpecificCodeAuthorID = "");

        public I_SSDD_Response ScanForNewCode (string Au9thenticationData, string DateTime);
        public I_SSDD_Response ScanForNewCodeVisHashCode(string Au9thenticationData, string HashCode);
    }
}
