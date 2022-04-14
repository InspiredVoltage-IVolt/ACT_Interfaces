using System.Collections;

using ACT.Core.Interfaces.Security;

namespace ACT.Core.Interfaces.Plugins

{
    /// <summary>
    /// Defines a Plugin
    /// </summary>
    public interface I_Plugin  : I_Core
    {
        /// <summary>
        /// Author Information
        /// </summary>
        I_Author Author { get; }

        /// <summary>
        /// Author Chain
        /// </summary>
        List<Types.Security.I_Author_Json_Type> AuthorChain { get; }

        /// <summary>
        /// Indicate if this is a ACT built in Plugin or Not
        /// </summary>
        bool Is_ACTInternal { get; }

        /// <summary>
        /// DLLFileName
        /// </summary>
        string DLL_FileName { get; }

        /// <summary>
        /// Used for when a Plugin Can Implement Different End Implementations
        /// </summary>
        string Sub_Identifier { get; }

        /// <summary>
        /// Types and Classes Implemented.  With Priority
        /// </summary>
        Dictionary<Type, Dictionary<int, string>> Types_And_Class_Names { get; }

        /// <summary>
        /// Package Name to Download
        /// </summary>
        string GitHub_PackageName { get; }

        /// <summary>
        /// Version of the Package To Retrieve
        /// </summary>
        string GitHub_PackageVersion { get; }

        /// <summary>
        /// Sets the Impersonation of the Executing User Level
        /// </summary>
        /// <param name="UserInfo"></param>
        void SetImpersonate(I_UserInfo UserInfo);

        /// <summary>
        /// Returns all the System Settings Required By The Plugin
        /// </summary>
        /// <returns></returns>
        ArrayList ReturnSystemSettingRequirements(bool PerformReplacements = false);

        /// <summary>
        /// Returns all the Files Required By The Plugin
        /// </summary>
        /// <returns></returns>
        ArrayList ReturnRequiredFiles(bool PerformReplacements = false);

        /// <summary>
        /// Validates the Configuration File is Setup Properly
        /// </summary>
        /// <returns></returns>
        Common.I_Result ValidatePluginRequirements();
    }

    public interface I_WebPlugin : I_Core
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<string> ReturnSystemSettingRequirements();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StartSurroundTag"></param>
        /// <param name="Data"></param>
        /// <param name="EndSurroundTag"></param>
        /// <returns></returns>
        string GenerateOutput(string StartSurroundTag, Dictionary<string, object> Data, string EndSurroundTag);

    }
}
