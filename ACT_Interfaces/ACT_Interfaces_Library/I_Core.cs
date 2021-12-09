// Decompiled with JetBrains decompiler
// Type: ACT.Core.Interfaces.I_Core
// Assembly: ACT_CORE_DLL, Version=1.81.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2BD768EC-CB72-47CA-A911-138C5E31192C
// Assembly location: D:\IVolt_Development\Common\Kinguin\KinguinAPI_Solution\KinguinAPI_TestConsole\bin\Debug\net5.0\ACT_CORE_DLL.dll

namespace ACT.Core.Interfaces
{
    /// <summary>Core Functionality Definition</summary>
    public interface I_Core : IDisposable, I_ErrorLoggable
    {
        /// <summary>Standard Text Replacement Functionality</summary>
        /// <param name="instr"></param>
        /// <returns></returns>
        string StandardReplaceMent(string instr, RepacementStandard InputStandard);

        /// <summary>Imports the variable XML into the current class</summary>
        /// <param name="XML">XML Data to Import</param>
        /// <returns>true on success</returns>
        I_TestResult ImportXMLData(string XML);

        /// <summary>Exports the current class to XML</summary>
        /// <returns>XML Representation of class</returns>
        string ExportXMLData();

        /// <summary>Returns the Errors stored in the local variable</summary>
        /// <returns><![CDATA[List<Exception>]]></returns>
        List<Exception> GetErrors();

        /// <summary>Specifies if the class has changed in any way</summary>
        bool HasChanged { get; set; }

        /// <summary>Get all of the Public Properties in the class</summary>
        /// <returns><![CDATA[List<string> of all the property names]]></returns>
        List<string> PublicProperties { get; }

        /// <summary>Return a property value by name</summary>
        /// <param name="PropertyName"></param>
        /// <returns></returns>
        object ReturnProperty(string PropertyName);

        /// <summary>Returns the type of the property</summary>
        /// <param name="PropertyName"></param>
        /// <returns></returns>
        Type ReturnPropertyType(string PropertyName);

        /// <summary>
        /// Trys to set a property using the propertyname and the value. Case sensitive people.
        /// </summary>
        /// <param name="PropertyName">Case Sensitive Property Name</param>
        /// <param name="value">value</param>
        /// <returns>I_TestResult - Specifying if the Set was successfull</returns>
        I_TestResult SetProperty(string PropertyName, object value);

        /// <summary>
        /// Checks The Health Of The Class.  Use this to return missing configuration.  Invalid Permissions Etc..
        /// </summary>
        /// <returns>I_TestResult - Specifying changes needed to be made to obtain a good health report.</returns>
        I_TestResult HealthCheck();
    }
}
