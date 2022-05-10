namespace ACT.Core.Interfaces.IO
{
    public interface I_CacheAble
    {
        /// <summary>
        /// Get Hash ID -- Calculated By Hashing the Object
        /// </summary>
        /// <value>The hash identifier.</value>
        string HashID { get; }

        /// <summary>
        /// If the memory is cached in the systems memory (NOT Load Balanced Safe)
        /// </summary>
        /// <value><c>true</c> if [memory cached]; otherwise, <c>false</c>.</value>
        bool MemoryCached { get; set; }

        /// <summary>
        /// Cache the object in the database
        /// </summary>
        /// <value><c>true</c> if [database cached]; otherwise, <c>false</c>.</value>
        bool DatabaseCached { get; set; }

        /// <summary>
        /// JSON Configuration Data
        /// </summary>
        /// <value>The configuration data.</value>
        string ConfigurationData { get; set; }

        /// <summary>
        /// Save Update the Cache based on the HashID and the Settings
        /// </summary>
        /// <returns>I_TestResult</returns>
        /// <seealso cref="Common.I_TestResult" />
        Common.I_Result SaveUpdate();

        /// <summary>
        /// Retrieve the object from cache if it exists
        /// </summary>
        /// <returns>object in cache</returns>
        object Retrieve(string HashID);
    }
}
