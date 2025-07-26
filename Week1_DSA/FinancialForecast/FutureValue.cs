using System;

public class Forecast
{
    
    public static double FutureValue(double presentValue, double rate, int years)
    {
        
        if (years == 0)
            return presentValue;

       
        return (1 + rate) * FutureValue(presentValue, rate, years - 1);
    }
}
