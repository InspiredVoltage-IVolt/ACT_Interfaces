namespace ACT.Core.Interfaces.Encoding
{
    /// <summary>
    /// Common Serializer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface I_Serializer<T>
    {
        string SerializeToString();
        byte[] SerializeToByteArray();

        void DeserializeFromString(string SerializedData);
        void DeserializeFromByteArray(byte[] SerializedData);
        T FromString(string SerializedData);
        T FromByteArray(string SerializedData);

    }
}
