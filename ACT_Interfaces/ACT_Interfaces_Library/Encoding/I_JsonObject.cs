namespace ACT.Core.Interfaces.Encoding
{
    public interface I_JsonObject<T>
    {
        string ToJson();
        T FromJson();
    }
}
