using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACT.Core.Interfaces.Data.JSON_Contracts;
namespace ACT.Core.Interfaces.Managers
{
    public interface I_UserManagementSystem :Security.I_SecurityProvider
    {

        I_User_Address GetUserPrimaryShippingAddress(string user_id);
        I_User_Address GetUserPrimaryBillingAddress(string user_id);



    }
}
