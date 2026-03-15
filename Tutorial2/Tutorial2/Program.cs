// See https://aka.ms/new-console-template for more information

using Tutorial2;

StatisticsHelper s = new StatisticsHelper();

Console.WriteLine("StatisticsHelper created");

int[] val = [2,3];
Console.WriteLine(CalculateAverage(val));

float CalculateAverage(int[] values)
{ 
    return (float) values.Sum() / values.Length ;
}