namespace ACT.Core.Types.PluginPackage
{
    public interface I_PluginPackage_Basic_Configuration
    {
        string Plugin_Files_RootPath { get; set; }
        string Dll_Filename { get; set; }
               
        string EncryptionMethod { get; set; }        
        bool? EncryptSystemConfigurationValuesFile { get; set; }        

        bool? Append_System_ConfigurationValues { get; set; }        
        string ACT_SystemConfiguration_AppendingValues_Filename { get; set; }

        List<Interfaces.Common.I_CustomNameValueData> AdditionalData { get; set; }
    }
}