using UnityEngine;

public class Calculator 
{
    public float GetSumm(float all, float level)
    {
        return all + level;
    }  
   
   

    public float GetMinus(float all, float level)
    {
        return all - level;
    }

    public float GetSumm(Slagaemie slag)
    {
        return slag.All + slag.Level;
    }  
}

public class Slagaemie
{
    public float All;
    public float Level;

   
}

