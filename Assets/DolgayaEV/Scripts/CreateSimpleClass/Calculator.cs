public class Calculator
{
    public float GetSum(float all, float level)
    {
        return all + level;
    }
    
    public float GetSum(Slagaemoe slog)
    {
        return slog.All + slog.Level;
    }

    public float GetDiff(float all, float level)
    {
        return all - level;
    }



}

public class Slagaemoe
{

    public float All;
    public float Level;

}