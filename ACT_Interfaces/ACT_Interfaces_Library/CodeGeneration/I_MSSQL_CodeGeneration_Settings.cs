namespace ACT.Core.Interfaces.CodeGeneration
{
    /// <summary>
    /// Defines the Code Generation Settings
    /// </summary>
    public interface I_MSSQL_CodeGeneration_Settings
    {
        /// <summary>
        /// Gets or sets the database connection string.
        /// </summary>
        /// <value>The database connection string.</value>
        string DatabaseConnectionString { get; set; }
        /// <summary>
        /// Gets or sets the name of the database connection.
        /// </summary>
        /// <value>The name of the database connection.</value>
        string DatabaseConnectionName { get; set; }
        /// <summary>
        /// Gets or sets the settings file location.
        /// </summary>
        /// <value>The settings file location.</value>
        string SettingsFileLocation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [generate basic actprocs].
        /// </summary>
        /// <value><c>true</c> if [generate basic actprocs]; otherwise, <c>false</c>.</value>
        bool Generate_Basic_ACTPROCS { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [execute after generation].
        /// </summary>
        /// <value><c>true</c> if [execute after generation]; otherwise, <c>false</c>.</value>
        bool Execute_After_Generation { get; set; }

    }
}
