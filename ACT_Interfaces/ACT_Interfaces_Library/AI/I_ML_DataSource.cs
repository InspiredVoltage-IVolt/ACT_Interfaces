// ***********************************************************************
// Assembly         : ACT_Core
// Author           : MarkAlicz
// Created          : 02-26-2019
//
// Last Modified By : MarkAlicz
// Last Modified On : 04-13-2022
// ***********************************************************************
// <copyright file="I_ML_DataSource.cs" company="IVolt, LLC">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.AI
{
    /// <summary>
    /// Interface I_ML_DataSource
    /// Implements the <see cref="ACT.Core.Interfaces.IO.I_Saveable" />
    /// </summary>
    /// <seealso cref="ACT.Core.Interfaces.IO.I_Saveable" />
    public interface I_Ml_DataSource : Interfaces.IO.I_Saveable
    {
    }
}
