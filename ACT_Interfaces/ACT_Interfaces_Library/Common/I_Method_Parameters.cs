﻿using ACT.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Common
{
    public interface I_Method_Parameters
    {
        I_NameValue NameValueParameters { get; set; }
        
        bool IsRequired { get; set; }
    }
}
