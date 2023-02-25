using ACT.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Common.ErrorLogging
{
    /// <summary>
    /// Basic Error Information Interface
    /// </summary>
    public interface I_Error_Info
    {
        /// <summary>Severity of the Error</summary>
        ACT.Core.Enums.Common.Error_Code_Severity ErrorSeverity { get; set; }
        
        /// <summary>Error Message</summary>
        string Message { get; set; }
        
        /// <summary>Error Exception Information</summary>
        Exception ExceptionInfo { get; set; }

        /// <summary>Additional Information</summary>
        List<I_NameValue> AdditionalInformation { get; set; }
    }
}
