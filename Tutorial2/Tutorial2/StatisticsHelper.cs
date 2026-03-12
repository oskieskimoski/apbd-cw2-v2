namespace Tutorial2;

public class StatisticsHelper
{
    private int a = 0; 
    private int b = 0;
    
     public StatisticsHelper()
    {
        try
        {
             a = int.Parse( Console.ReadLine());
             b = int.Parse( Console.ReadLine());
        }
        catch (Exception e)
        {
            throw (e);
            a = 0;
            b = 0;
        }
     
    }
}