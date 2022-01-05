namespace ACT.Core.Interfaces.Common
{
    /// <summary>
    /// I Configurable - reads JSON Into a Setting Dictionary
    /// </summary>
    public interface I_Configurable
    {
        bool LoadConfiguration(string JSONData);
        bool SaveConfiguration(string FilePath);
        Dictionary<string, string> ConfigurationSettings { get; set; }
    }
}
