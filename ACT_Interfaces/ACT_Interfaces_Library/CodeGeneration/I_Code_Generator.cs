namespace ACT.Core.Interfaces.CodeGeneration
{

    /// <summary>
    /// Defines the Actual Code Generation Class
    /// Implements the <see cref="ACT.Core.Interfaces.Plugins. Plugins.I_Plugin " />
    /// </summary>
    /// <seealso cref="ACT.Core.Interfaces.Plugins. Plugins.I_Plugin " />
    public interface I_Code_Generator : ACT.Core.Interfaces.Plugins.I_Plugin 
    {
        /// <summary>
        /// Generates the code.
        /// </summary>
        /// <param name="CodeSettings">The code settings.</param>
        /// <returns>List&lt;I_GeneratedCode&gt;.</returns>
        List<I_Generated_Code> GenerateCode(ACT.Core.Interfaces.CodeGeneration.I_Code_Generation_Settings CodeSettings);
        /// <summary>
        /// Generates the code.
        /// </summary>
        /// <param name="Database">The database.</param>
        /// <param name="CodeSettings">The code settings.</param>
        /// <returns>List&lt;I_GeneratedCode&gt;.</returns>
        List<I_Generated_Code> GenerateCode(ACT.Core.Interfaces.DataAccess.I_Db Database, ACT.Core.Interfaces.CodeGeneration.I_Code_Generation_Settings CodeSettings);
        /// <summary>
        /// Generates the web form code.
        /// </summary>
        /// <param name="CodeSettings">The code settings.</param>
        /// <returns>List&lt;I_GeneratedCode&gt;.</returns>
        List<I_Generated_Code> GenerateWebFormCode(ACT.Core.Interfaces.CodeGeneration.I_Code_Generation_Settings CodeSettings);

        /// <summary>
        /// Generate Code
        /// </summary>
        /// <param name="CodeSettings">The code settings.</param>
        /// <returns>List&lt;I_GeneratedCode&gt;.</returns>
        List<I_Generated_Code> GenerateCode(ACT.Core.Interfaces.CodeGeneration.I_MSSQL_CodeGeneration_Settings CodeSettings);

        /// <summary>
        /// Generate Code
        /// </summary>
        /// <param name="ConnectionName">Name of the connection.</param>
        /// <returns>System.String.</returns>
        string GenerateBasicStoredProcCode(string ConnectionName);

        /// <summary>
        /// Generate Code
        /// </summary>
        /// <param name="ConnectionName">Name of the connection.</param>
        /// <returns>System.String.</returns>
        string GenerateBasicViewsCode(string ConnectionName);
    }
}
