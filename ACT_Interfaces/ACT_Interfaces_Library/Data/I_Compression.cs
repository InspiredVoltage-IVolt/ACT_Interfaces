namespace ACT.Core.Interfaces.IO
{
    public interface I_Compression
    {
        string[] AvailableCompressionTypes { get; }
                
        int DeCompressFileToDisk(string FileToDeCompress, string Destination, string CompressionType);
        byte[] DeCompressData(byte[] Data, string CompressionType);

        byte[] CompressFile(string FileToCompress, string CompressionType);
        bool CompressFile(string FileToCompress, string DestinationFileName, string CompressionType);


        byte[] CompressData(byte[] Data, string CompressionType, Dictionary<string, byte[]> AdditionalInfo);
        byte[] CompressFolder(string FolderToCompress, string CompressionType, Dictionary<string, byte[]> AdditionalInfo);
        bool CompressFolder(string FolderToCompress, string DestinationFileName, string CompressionType, Dictionary<string, byte[]> AdditionalInfo);

        void AddFileToZip(string FilePathToAdd, string ZipFilePath, string CompressionType);
        void RemoveFileFromZip(string VirtualFilePathToRemove, string ZipFilePath, string CompressionType);
    }
}
