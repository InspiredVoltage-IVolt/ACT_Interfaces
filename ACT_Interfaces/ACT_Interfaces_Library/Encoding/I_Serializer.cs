namespace ACT.Core.Interfaces.Encoding
{
    public interface I_Serializer
    {
        string SerializeToString();
        byte[] SerializeToByteArray();

        void DeserializeFromString(string SerializedData);
        void DeserializeFromByteArray(byte[] SerializedData);

    }
}
