namespace ACT.Core.Interfaces.CodeGeneration
{
    /// <summary>
    /// Defines the Code Generation Settings
    /// </summary>
    public interface I_Code_Generation_Settings
    {
        #region Database Settings
        /// <summary>
        /// Gets or sets the database connection string.
        /// </summary>
        /// <value>The database connection string.</value>
        string Database_ConnectionString { get; set; }
        /// <summary>
        /// Gets or sets the name of the database connection.
        /// </summary>
        /// <value>The name of the database connection.</value>
        string Database_ConnectionName { get; set; }
        /// <summary>
        /// Gets or sets the DB object age maximum.
        /// </summary>
        /// <value>The object age maximum.</value>
        int Database_ObjectAgeMax { get; set; }

        #endregion

        #region Path Definitions

        /// <summary>
        /// Gets or sets the root output directory.
        /// </summary>
        /// <value>The root output directory.</value>
        string RootOutput_Directory { get; set; }

        /// <summary>
        /// Gets or sets the project update directory.
        /// </summary>
        /// <value>The project update directory.</value>
        string Project_UpdateDirectory { get; set; }

        /// <summary>
        /// Gets or sets the base folder path.
        /// </summary>
        /// <value>The base output folder path.</value>
        string BaseOutput_FolderPath { get; set; }

        /// <summary>
        /// Gets or sets the base folder name.
        /// </summary>
        /// <value>The base folder name.</value>
        string BaseFolderName { get; set; }

        /// <summary>
        /// Gets or sets the user folder name.
        /// </summary>
        /// <value>The user folder name.</value>
        string UserFolderName { get; set; }

        /// <summary>
        /// Gets or sets the ACT Settings file override Path.
        /// </summary>
        /// <value>The settings file location.</value>
        string ACTSettings_Override_Path { get; set; }

        #endregion

        #region Generator Settings
        /// <summary>
        /// Gets or sets the output language.
        /// </summary>
        /// <value>The output language.</value>
        ACT.Core.Enums.Programming.Programming_Language OutputLanguage { get; set; }

        /// <summary>
        /// Sets the Dot Net Version If Needed
        /// </summary>
        ACT.Core.Enums.Programming.DOTNET_VERSIONS DotNet_TargetVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [compile code].
        /// </summary>
        /// <value><c>true</c> if [compile code]; otherwise, <c>false</c>.</value>
        bool CompileCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [generate base layer].
        /// </summary>
        /// <value><c>true</c> if [generate base layer]; otherwise, <c>false</c>.</value>
        bool Generate_BaseLayer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [generate user layer].
        /// </summary>
        /// <value><c>true</c> if [generate user layer]; otherwise, <c>false</c>.</value>
        bool Generate_UserLayer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [generate stored procedures].
        /// </summary>
        /// <value><c>true</c> if [generate stored procedures]; otherwise, <c>false</c>.</value>
        bool Generate_StoredProcedures { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [generate web services].
        /// </summary>
        /// <value><c>true</c> if [generate web services]; otherwise, <c>false</c>.</value>
        bool Generate_Web_Services { get; set; }

        /// <summary>
        /// JSON string 
        /// <seealso cref="ACT.Core.Types.PluginPackage.ACT_Plugin_Package_Definition"/>
        /// </summary>
        string Web_Service_Plugin_Generator { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [generate view access].
        /// </summary>
        /// <value><c>true</c> if [generate view access]; otherwise, <c>false</c>.</value>
        bool Generate_ViewAccess { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [namespace driven procedures].
        /// </summary>
        /// <value><c>true</c> if [namespace driven procedures]; otherwise, <c>false</c>.</value>
        bool Namespace_Driven_Procedure_Logic { get; set; }

        /// <summary>
        /// Gets or sets the namespace driven procedures delimiter.
        /// </summary>
        /// <value>The namespace driven procedures delimiter.</value>
        string Namespace_Driven_StoredProcedure_Delimiter { get; set; }

        /// <summary>
        /// Gets or sets the name of the DLL.
        /// </summary>
        /// <value>The name of the DLL.</value>
        string DLL_Output_Name { get; set; }

        /// <summary>
        /// Gets or sets the name space.
        /// </summary>
        /// <value>The name space.</value>
        string Base_Namespace { get; set; }

        /// <summary>
        /// Gets or sets the base code name space.
        /// </summary>
        /// <value>The base code name space.</value>
        string BaseCode_Namespace_Appendage_Name { get; set; }

        /// <summary>
        /// Gets or sets the user code name space.
        /// </summary>
        /// <value>The user code name space.</value>
        string UserCode_Namespace_Appendage_Name { get; set; }

        /// <summary>
        /// Gets or sets the stored procedure namespace method path.
        /// TODO RESEARCH
        /// </summary>
        /// <value>The stored procedure namespace method path.</value>
        string StoredProcedure_Namespace { get; set; }

        #endregion

        #region Events

        /// <summary>
        /// Gets or sets a value indicating whether [notify when project code is updated].  TODO
        /// </summary>
        /// <value><c>true</c> if [notify when project code is updated]; otherwise, <c>false</c>.</value>
        bool NotifyWhenProjectCodeIsUpdated { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [notify when code is generated].
        /// </summary>
        /// <value><c>true</c> if [notify when code is generated]; otherwise, <c>false</c>.</value>
        bool NotifyWhenCodeIsGenerated { get; set; }

        /// <summary>
        /// Notification Method
        /// </summary>
        Enums.Communication.Communication_Methods NotificationMethod { get; set; }

        /// <summary>
        /// Notification Implementation Information Data
        /// </summary>
        string Notification_Information_Information_JSON { get; set; }

        #endregion

        #region Visual Studio Related

        /// <summary>
        /// Gets or sets a value indicating whether [backup project code before deployment].
        /// </summary>
        /// <value><c>true</c> if [backup project code before deployment]; otherwise, <c>false</c>.</value>
        bool VisualStudio_BackupProject_Before_Update { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [output solution with project].
        /// </summary>
        /// <value><c>true</c> if [output solution with project]; otherwise, <c>false</c>.</value>
        bool VisualStudio_GenerateSolution { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [output solution with project].
        /// </summary>
        /// <value><c>true</c> if [output solution with project]; otherwise, <c>false</c>.</value>
        bool VisualStudio_GenerateClassLibrary_Project { get; set; }

        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        /// <value>The name of the project.</value>
        string VisualStudio_ProjectName { get; set; }

        /// <summary>
        /// Gets or sets the name of the solution.
        /// </summary>
        /// <value>The name of the solution.</value>
        string VisualStudio_SolutionName { get; set; }

        /// <summary>
        /// Gets or sets the name of the solution.
        /// </summary>
        /// <value>The name of the solution.</value>
        bool VisualStudio_IncludeSharedProject { get; set; }

        #endregion

        #region Nuget Publish Information

        string APIKeyIfNew { get; set; }
        string PackageName { get; set; }
        string Version { get; set; }
        Types.JSON.NameValue_Information PackageInformation { get; set; }

        #endregion
    }
}
