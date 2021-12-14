namespace ACT.Core.Interfaces.IO
{
    public interface I_Compression
    {
        string[] AvailableCompressionTypes { get; }

        byte[] CompressFile(string FileToCompress, string CompressionType, Dictionary<string, dynamic> AdditionalInfo);
        byte[] DeCompressFile(string FileToDeCompress, string CompressionType, Dictionary<string, dynamic> AdditionalInfo);
        byte[] CompressData(byte[] Data, string CompressionType, Dictionary<string, dynamic> AdditionalInfo);
        byte[] DeCompressData(byte[] Data, string CompressionType, Dictionary<string, dynamic> AdditionalInfo);

        byte[] CompressFolder(string FolderToCompress, string CompressionType, Dictionary<string, dynamic> AdditionalInfo);
        bool CompressFolder(string FolderToCompress, string OutputFileNameFullPath, string CompressionType, Dictionary<string, dynamic> AdditionalInfo);
        void AddFileToZip(string FileToAdd, string ZipFile, string CompressionType, Dictionary<string, dynamic> AdditionalInfo);
        void RemoveFileFromZip(string FileToRemove, string ZipFile, string CompressionType, Dictionary<string, dynamic> AdditionalInfo);
    }
}
