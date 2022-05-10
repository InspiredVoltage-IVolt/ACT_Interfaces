namespace ACT.Core.Types.PluginPackage
{
    public interface I_PaymentGateway : Interfaces.Plugins.I_Plugin
    {
        string Plugin_Files_RootPath { get; set; }
        string Dll_Filename { get; set; }
               
        string EncryptionMethod { get; set; }        
        bool? EncryptSystemConfigurationValuesFile { get; set; }        

        bool? Append_System_ConfigurationValues { get; set; }        
        string ACT_SystemConfiguration_AppendingValues_Filename { get; set; }

        List<Interfaces.Data.I_NameValue_Data> AdditionalData { get; set; }
    }
}