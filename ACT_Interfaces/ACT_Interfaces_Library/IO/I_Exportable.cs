namespace ACT.Core.Interfaces.IO
{
    /// <summary>
    /// I_Exportable is a general purpose interface to allow for dynamic importing and exporting.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface I_Exportable<T>
    {
        /// <summary>
        /// Export to the defined object type
        /// </summary>
        /// <returns>T.</returns>
        T Export();

        /// <summary>
        /// Import the Defined Object Type Into this Obejct
        /// </summary>
        /// <param name="item">The item.</param>
        void Import(T item);
    }
}
