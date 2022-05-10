using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Delegates
{
    public delegate string Process_Click_Return_String(object sender, Dictionary<string,string> Arguments);
    public delegate bool Process_Click_Return_Bool(object sender, Dictionary<string, string> Arguments);
    public delegate object Process_Click_Return_Object(object sender, Dictionary<string, string> Arguments);
    public delegate double Process_Click_Return_Double(object sender, Dictionary<string, string> Arguments);
    public delegate void Process_Click(object sender, Dictionary<string, string> Arguments);
    
    public delegate void Process_TextChange(object sender, string Original, string New, Dictionary<string, string> Arguments);
    
    public delegate Enums.Common.Error_Code_Severity Handle_Error(object sender, string ErrorMessage, Exception ex, Dictionary<string, string> Arguments);
    


}
