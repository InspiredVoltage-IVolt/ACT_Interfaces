

namespace ACT.Core.Interfaces.CodeGeneration
{
    /// <summary>
    /// Interface I_CodeGeneration_UpdateEnums
    /// </summary>
    public interface I_Code_Generation_Update_Enums
    {
        /// <summary>
        /// Locates the enums.
        /// </summary>
        /// <param name="asm">The asm.</param>
        /// <returns>System.String[].</returns>
        string[] LocateEnums(System.Reflection.Assembly asm);
    }
}
