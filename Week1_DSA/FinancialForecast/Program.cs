class Program
{
    static void Main()
    {
        double presentValue = 10000; // e.g. Rs. 10,000
        double rate = 0.05;          // 5% growth rate
        int years = 5;               // forecast for 5 years

        double futureValue = Forecast.FutureValue(presentValue, rate, years);
        Console.WriteLine($"Future Value after {years} years: {futureValue:C}");
    }
}
