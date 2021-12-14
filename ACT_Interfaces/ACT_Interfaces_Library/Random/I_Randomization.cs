namespace ACT.Core.Interfaces.Random
{
    public interface I_Randomization
    {
        int Next(int minValue, int maxValue);
        int Next();
        int Next(int maxValue);
        double NextDouble();

    }
}
