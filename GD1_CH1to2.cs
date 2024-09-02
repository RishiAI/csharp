public class GD1_CH1to2
{
    public static int TotalServings(int cupCakes, int eightInch, int sheetCakes)
    {
    return cupCakes+18*eightInch+58*sheetCakes; 
    }


    public static void TimeDifference(int startTime, int endTime, out int hours, out int minutes)
    {

        int startminutes = startTime % 100;
        int endminutes = endTime % 100;
        minutes = endminutes - startminutes;
        int starthours = (startTime - startminutes) / 100;
        int endhours = (endTime - endminutes) / 100;
        hours = endhours - starthours;
        if (minutes < 0)
        {
            hours--;
            minutes = 60 + minutes;
        }

    }

}