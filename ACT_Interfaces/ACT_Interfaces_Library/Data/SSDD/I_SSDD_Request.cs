using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data.SSDD
{
    /// <summary>
    /// Interface representing a Request to any Endpoint
    /// </summary>
    public interface I_SSDD_Request
    {
        /// <summary>
        /// Allows authorized users and non authorized users the ability to publish code
        /// </summary>
        /// <param name="AuthenticationData">Authentiction Data</param>
        /// <param name="ApprovalKeyHash">Approval Key Hash</param>
        /// <returns></returns>
	    public string SubmitCode (string AuthenticationData, string ApprovalKeyHash);

        /// <summary>
        /// Limits the page size to this number
        /// </summary>
        public int Page_Size { get; set; }

        /// <summary>
        /// Limit the record count return limit to this number.
        /// </summary>
        public int Record_Limit { get; set; }

        /// <summary>
        /// Search Object that is either the Standard JSON Search Object or the
        /// JSON object that the Advanced Filter Code ID Requires
        /// </summary>
        public string Search_Object { get; set; }

        /// <summary>
        /// Represents an Advanced Filter Class ID - Uploaded by users/companies
        /// Uses the SearchObject Which Conforms to the specific JSON string required
        /// by the Filter Code ID
        /// </summary>
        public string Advanced_Filter_Code_ID { get; set; }

        /// <summary>
        /// Search Object that is either the Standard JSON Sort Object or the
        /// JSON object that the Advanced Sort Code ID Requires
        /// </summary>
        public string Sort_Object { get; set; }

        /// <summary>
        /// Represents an Advanced Sort Class ID - Uploaded by users/companies
        /// Uses the Sort Object Which Conforms to the specific JSON string required
        /// by the Sort Code ID
        /// </summary>
        public string Advanced_Sort_Code_ID { get; set; }
    }
}
