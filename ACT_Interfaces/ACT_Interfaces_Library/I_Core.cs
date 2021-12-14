// Decompiled with JetBrains decompiler
// Type: ACT.Core.Interfaces.I_Core
// Assembly: ACT_CORE_DLL, Version=1.81.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2BD768EC-CB72-47CA-A911-138C5E31192C
// Assembly location: D:\IVolt_Development\Common\Kinguin\KinguinAPI_Solution\KinguinAPI_TestConsole\bin\Debug\net5.0\ACT_CORE_DLL.dll
using ACT.Core.Interfaces.Common;

namespace ACT.Core.Interfaces
{
    /// <summary>Core Functionality Definition</summary>
    public interface I_Core : IDisposable, Encoding.I_TextEncoder, I_ErrorLoggable, Reflection.I_PropertyManager
    {
        bool CacheErrors { get; set; }

        /// <summary>Standard Text Replacement Functionality - Powerful If Implemented Properly</summary>
        /// <param name="instr"></param>
        /// <returns></returns>
        string PerformStandardTextReplacement(string instr);

        /// <summary>Returns the Errors stored in the local variable</summary>
        /// <returns><![CDATA[List<Exception>]]></returns>
        List<Exception> GetCachedErrors();

        /// <summary>Specifies if the class has changed in any way</summary>
        bool HasChanged { get; set; }

        /// <summary>
        /// Checks The Health Of The Class.  Use this to return missing configuration.  Invalid Permissions Etc..
        /// </summary>
        /// <returns>I_TestResult - Specifying changes needed to be made to obtain a good health report.</returns>
        I_Result HealthCheck();

        event EventHandler ClassChanged;
    }
}
