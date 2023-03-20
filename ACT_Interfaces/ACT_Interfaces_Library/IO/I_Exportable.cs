using ACT.Core.Interfaces.IO;

namespace ACT.Core.Interfaces.IO
{
   /// <summary>
   /// I_Exportable is a general purpose interface to allow for dynamic importing and exporting.
   /// </summary>
   /// <typeparam name="T"></typeparam>
   public interface I_Exportable
   {
      /// <summary>
      /// Export to the defined object type
      /// </summary>
      /// <returns>T.</returns>
      object Export();

      /// <summary>
      /// Import the Defined Object Type Into this Obejct
      /// </summary>
      /// <param name="item">The item.</param>
      object Import(object item);

      /// <summary>Export To JSON</summary>
      /// <returns>JSON String</returns>
      string ExportToJson();

      /// <summary>Import From JSON</summary>
      /// <returns>ClassS</returns>
      object ImportDataFromJson(string jsonString);

      /// <summary>Export To Custom</summary>
      /// <returns>String</returns>
      string CustomExport(string Identifier, string jsonString);

      /// <summary>Import From Custom</summary>
      /// <returns>Populated Class</returns>
      object CustomImport(string Identifier, string jsonString);


   }
}

