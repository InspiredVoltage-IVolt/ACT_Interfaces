namespace ACT.Core.Interfaces.CodeGeneration
{
    public interface I_ACTCodeGeneration_UpdateEnums
    {
        string[] LocateEnums(System.Reflection.Assembly asm);
        //string[] UpdateCode(string[] CodeFiles, System.Reflection.Assembly )
    }

    /// <summary>
    /// Defines the Code Generation Settings
    /// </summary>
    public interface I_CodeGenerationSettings
    {
        //string DatabaseConnectionString { get; set; }
        string DatabaseConnectionName { get; set; }
        bool CompileBaseLayer { get; set; }
        bool CompileUserLayer { get; set; }
        bool OutPutCSProject { get; set; }
        string OutPutDirectory { get; set; }
        string DLLName { get; set; }
        string NameSpace { get; set; }
        bool GenerateBaseLayer { get; set; }
        bool GenerateUserLayer { get; set; }
        bool GenerateStoredProcedures { get; set; }
        bool GenerateWebServices { get; set; }
        bool GenerateViewAccess { get; set; }

    }

    /// <summary>
    /// Defines The Code Generation Output
    /// </summary>
    public interface I_GeneratedCode
    {
        string FileName { get; set; }
        string Path { get; set; }
        string Code { get; set; }
        string UserCode { get; set; }
        string WebServiceCode { get; set; }
        string WebServiceSoapCode { get; set; }
        string WebServiceSoapASMX { get; set; }
        string TableName { get; set; }

        string DatabaseConnectionString { get; set; }
        string DatabaseConnectionName { get; set; }

    }

    /// <summary>
    /// Defines the Actual Code Generation Class
    /// </summary>
    public interface I_CodeGenerator : Common.I_Plugin
    {
        List<I_GeneratedCode> GenerateCode(I_CodeGenerationSettings CodeSettings);
        List<I_GeneratedCode> GenerateCode(DataAccess.I_Db Database, ACT.Core.Interfaces.CodeGeneration.I_CodeGenerationSettings CodeSettings);
        List<I_GeneratedCode> GenerateWebFormCode(I_CodeGenerationSettings CodeSettings);

    }
}
