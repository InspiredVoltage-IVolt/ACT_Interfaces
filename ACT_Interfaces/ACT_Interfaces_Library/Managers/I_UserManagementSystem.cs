using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Managers
{
    public interface I_UserManagementSystem : ACT.Core.Interfaces.Security.I_SecurityProvider
    {

        Security.I_UserAddress GetUserPrimaryShippingAddress(string user_id);
        Security.I_UserAddress GetUserPrimaryBillingAddress(string user_id);



    }
}
