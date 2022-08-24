namespace ACT.Core.Interfaces.Common
{
    /// <summary>
    /// I Configurable - reads JSON Into a Setting Dictionary
    /// </summary>
    public interface I_Configurable
    {
        bool LoadConfiguration(string jsonData);
        bool SaveConfiguration(string FilePath);
        Dictionary<string, string> ConfigurationSettings { get; set; }
    }
}
