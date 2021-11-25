namespace LeapYear
{
    public class LeapYearCalculator
    {
        public static bool IsLeapYear(int number)
        {
            if (number % 400 == 0)
                return true;
            return number % 4 == 0 && number % 100 != 0;
        }
    }
}