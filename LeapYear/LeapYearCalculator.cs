namespace LeapYear
{
    public class LeapYearCalculator
    {
        public static bool IsLeapYear(int number)
        {
            if (number % 100 == 0 && number % 400 != 0)
                return false;
            if (number % 400 == 0)
                return true;
            if (number % 4 == 0 && number % 100 != 0)
                return true;

            return false;

        }
    }
}