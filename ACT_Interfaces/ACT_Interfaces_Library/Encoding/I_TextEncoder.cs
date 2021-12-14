namespace ACT.Core.Interfaces.Encoding
{
    /// <summary>
    /// Basic Encoding Only
    /// </summary>
    public interface I_TextEncoder
    {
        string[] AvailableEncodingFormats { get; }
        string EncodeText(string Input, string Format, I_EncoderRules Rules);
    }

    /// <summary>
    /// Currently Only Supporting Simple Character Replacement
    /// </summary>
    public interface I_EncoderRules
    {
        Dictionary<string, string> ReplacementCharacters { get; }
        Dictionary<string, string> RegExStartAppend { get; }
        string[] ReservedKeywords { get; }
        string ReservedKeywordsReplacementText { get; }
    }
}
