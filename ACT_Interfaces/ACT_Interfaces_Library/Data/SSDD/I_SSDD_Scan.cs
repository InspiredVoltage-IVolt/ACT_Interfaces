using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data.SSDD
{
    /// <summary>
    /// A Stand Alone Scanner application that methodically scans the web for new endpoints.
    /// </summary>
    public interface I_SSDD_Scanner
    {
        /// <summary>
        /// Install The App
        /// </summary>
	    public void Install ();
        /// <summary>
        /// Start The App
        /// </summary>
        public void Start ();
        /// <summary>
        /// Stop The App
        /// </summary>
        public void Stop ();
        /// <summary>
        /// Interval in seconds to wait between actions
        /// </summary>
        public int Interval { get; set; }
        /// <summary>
        /// known service list that will be used to gain new hints
        /// </summary>
        public List<string> KnownListServers { get; set; }
        /// <summary>
        /// Auto Add Endpoint Servers As They Are Found
        /// </summary>
        public bool AutoAddFoundServers { get; set; }
        /// <summary>
        /// Odd Ports To Try
        /// </summary>
        public List<int> PortsToTry { get; set; }
    }
}
