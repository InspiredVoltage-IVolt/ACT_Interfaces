namespace ACT.Core.Interfaces.IO
{
    public interface I_Saveable
    {
        /// <summary>
        /// Save using Internal Settings
        /// </summary>
        /// <returns>Common.I_Result.</returns>
        ACT.Core.Interfaces.Common.I_Result Save();

        /// <summary>
        /// Save Using Specified Location / FileName
        /// </summary>
        /// <param name="Location">The location.</param>
        /// <param name="FileName">Name of the file.</param>
        /// <param name="OverWrite">if set to <c>true</c> [over write].</param>
        /// <param name="CreateBackup">if set to <c>true</c> [create backup].</param>
        /// <returns>Common.I_Result.</returns>
        Common.I_Result Save(string Location, string FileName = "", bool OverWrite = false, bool CreateBackup = false);

        /// <summary>
        /// Save to Multiple Locations
        /// </summary>
        /// <param name="Locations">The locations.</param>
        /// <param name="FileName">Name of the file.</param>
        /// <param name="OverWrite">if set to <c>true</c> [over write].</param>
        /// <param name="CreateBackup">if set to <c>true</c> [create backup].</param>
        /// <returns>Common.I_Result.</returns>
        Common.I_Result Save(List<string> Locations, string FileName = "", bool OverWrite = false, bool CreateBackup = false);
    }
}
