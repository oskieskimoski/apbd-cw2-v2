// See https://aka.ms/new-console-template for more information

using Tutorial2;

StatisticsHelper s = new StatisticsHelper();

Console.WriteLine("StatisticsHelper created");

int[] val2 = [2,3];
Console.WriteLine(CalculateAverage(val2));


float CalculateAverage(int[] values)
{
    if (values.Length == 0)
    {
        return 0;
    }
    return (float) values.Sum() / values.Length ;
}
int CalculateMax(int[] values)
{
    return values.Max();
}

int CalculateMin(int[] values)
{
    
    
    return values.Min();
}