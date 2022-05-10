using ACT.Core.Interfaces.IO;

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
        T Import(T item);

        /// <summary>Export To JSON</summary>
        /// <returns>JSON String</returns>
        string ExportToJson();

        /// <summary>Import From JSON</summary>
        /// <returns>ClassS</returns>
        T ImportDataFromJson(string JSONString);

        /// <summary>Export To Custom</summary>
        /// <returns>String</returns>
        string CustomExport(string Identifier, string JSONString);

        /// <summary>Import From Custom</summary>
        /// <returns>Populated Class</returns>
        T CustomImport(string Identifier, string JSONString);


    }
}

