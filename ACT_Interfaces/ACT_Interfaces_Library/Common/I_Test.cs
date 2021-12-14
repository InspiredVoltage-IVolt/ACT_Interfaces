namespace ACT.Core.Interfaces.Common
{
    public interface I_Test
    {
        Dictionary<string, List<string>> Messages { get; }
        bool OverallSuccess { get; }
        Dictionary<string, bool> MethodTestResults { get; }

        List<string> MethodNames { get; }

        //   Dictionary<string, ACT.Core.Common.Code.CodeSignature> MethodDefinitions { get; }

        //  void ExecuteTests(List<ACT.Core.Common.Code.CodeSignature> TestsToPerform);
        void ExecuteTests();
        void ExecuteTests(List<string> TestsToPerform);
    }
}
