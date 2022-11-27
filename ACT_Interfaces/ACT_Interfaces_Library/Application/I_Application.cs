using ACT.Core.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Application
{
    /// <summary>
    /// Application Definition
    /// </summary>
    public interface I_Application
    {
        /// <summary>
        /// Unique Application ID
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Name of the Application
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Author ID
        /// </summary>
        Guid AuthorId { get; }

        /// <summary>
        /// If this application is open source
        /// </summary>
        bool OpenSource { get; }

        /// <summary>
        /// Required Settings
        /// </summary>
        List<string> RequiredSettings { get; }

        /// <summary>
        /// Required Files
        /// </summary>
        List<string> RequiredFiles { get; }

        /// <summary>
        /// Initialize Application
        /// </summary>
        /// <param name="Params">Method Parameters</param>
        public void Initialize(List<I_Method_Parameters> Params);
    }
}
