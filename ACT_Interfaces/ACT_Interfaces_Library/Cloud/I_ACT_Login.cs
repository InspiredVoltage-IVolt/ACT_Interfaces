using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Cloud
{
    /// <summary>
    /// I_ACT_UPDATE
    /// Defines the method called to update an application
    /// </summary>
    public interface I_ACT_Update
    {
        public Guid RequestUpdate(Guid ApplicationID, string AppVersionInfo);
        public bool RequestComplete(Guid UpdateRequest);
        public byte[] GetPacket(Guid UpdateRequest, int PacketNumber);
    }
}
