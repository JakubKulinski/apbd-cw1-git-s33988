public static class StatisticsHelper
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }
    
    public static double Average(int a, int b)
    {
        return (a + b) / 2.0;
    }
    
    public static double CalculateAverage(int[] values)
    {
        int sum = 0;

        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }

        return (double)sum / values.Length;
    }
    
    public static int CalculateMax(int[] values)
    {
        int max = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }

        return max;
    }
    
    public static int CalculateMin(int[] values)
    {
        return values[0];
    }
}