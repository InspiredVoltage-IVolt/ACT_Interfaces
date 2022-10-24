using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Data.SSDD
{
    public interface ACT_SSDD_CodeStation
    {
	    public string SearchForNewCode (string DBHashData);
	    public string LastDateTime_DataUpdated { get; }
	    public string GetLastUpdatedCode (string DateTime);


    }
}
