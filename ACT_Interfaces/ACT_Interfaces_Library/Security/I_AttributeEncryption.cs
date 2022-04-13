using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Security
{
    public interface I_AttributeEncryption
    {
        string Encrypt(string value);
        string Decrypt(string value);
    }
}
