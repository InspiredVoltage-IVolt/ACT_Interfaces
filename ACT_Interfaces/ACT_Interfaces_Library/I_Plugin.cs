using ACT.Core.Interfaces.Security;

namespace ACT.Core.Interfaces.Common
{
    /// <summary>
    /// Defines a Plugin
    /// </summary>
    public interface I_Plugin : I_Core
    {
        /// <summary>
        /// Sets the Impersonation of the Executing User Level
        /// </summary>
        /// <param name="UserInfo"></param>
        void SetImpersonate(I_UserInfo UserInfo);

        /// <summary>
        /// Returns all the System Settings Required By The Plugin
        /// </summary>
        /// <returns></returns>
        List<string> ReturnSystemSettingRequirements(bool PerformReplacements = false);

        /// <summary>
        /// Returns all the Files Required By The Plugin
        /// </summary>
        /// <returns></returns>
        List<string> ReturnRequiredFiles(bool PerformReplacements = false);

        /// <summary>
        /// Validates the Configuration File is Setup Properly
        /// </summary>
        /// <returns></returns>
        I_Result ValidatePluginRequirements();
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
