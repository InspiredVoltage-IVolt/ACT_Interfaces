﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACT.Core.Interfaces.WebServices.Security
{
    public interface IWebServiceAuthenticate
    {
        Dictionary<string, string> Authenticate(object[] args);

    }
}
