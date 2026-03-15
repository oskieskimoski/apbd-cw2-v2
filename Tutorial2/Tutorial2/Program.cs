// See https://aka.ms/new-console-template for more information

using Tutorial2;

StatisticsHelper s = new StatisticsHelper();

Console.WriteLine("StatisticsHelper created");

int[] val = [2,3];
Console.WriteLine(CalculateAverage(val));


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