namespace LeapYear
{
    public static class LeapYearCalculator
    {
        public static bool IsLeapYear(int number) => number % 400 == 0 || number % 4 == 0 && number % 100 != 0;
    }
}