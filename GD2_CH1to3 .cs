public class GD1_CH5to6
{
    public static long NthFibonacci(long p)
    {
        long fibonacci = 1;
        long addon = 0;
        long memory = 0;
        if (p == 0)
        {
            return -1;
        }
        if (p == 1)
        {
            return 0;
        }
        else
        {

            for (int i = 1; i < p - 1; i++)
            {
                memory = fibonacci;
                fibonacci += addon;
                addon = memory;
            }
            return fibonacci;
        }

    }

    public static bool IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int DaysInMonth(int month, int year)
    {
        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            return 31;
        }

        else if ((month == 4 || month == 6 || month == 9 || month == 11))
        {
            return 30;
        }

        else if ((month == 2))
        {
            if (IsLeapYear(year))
            {
                return 29;
            }
            else return 28;
        }
        else
        {
            return 0;
        }
    }


    public static int DaysBetween(int startMonth, int startDay, int startYear, int endMonth, int endDay, int endYear)
    {
        int totalDays = 0;

        if (startYear == endYear)
        {
            for (int month = startMonth; month < endMonth; month++)
            {
                totalDays += DaysInMonth(month, startYear);
            }
            totalDays += endDay - startDay;
            return totalDays;
        }

        for (int month = startMonth; month <= 12; month++)
        {
            if (month == startMonth)
            {
                totalDays += DaysInMonth(month, startYear) - startDay;
            }
            else
            {
                totalDays += DaysInMonth(month, startYear);
            }
        }

        for (int month = 1; month < endMonth; month++)
        {
            totalDays += DaysInMonth(month, endYear);
        }
        totalDays += endDay;

        for (int year = startYear + 1; year < endYear; year++)
        {
            totalDays += IsLeapYear(year) ? 366 : 365;
        }

        return totalDays;
    }

}