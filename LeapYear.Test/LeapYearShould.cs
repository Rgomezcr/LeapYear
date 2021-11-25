using Xunit;

namespace LeapYear.Test
{
    public class LeapYearShould
    {
        [Theory]
        [InlineData(2000)]
        [InlineData(400)]
        public void BeDivisibleByFourHundred(int year)
        {
            bool result = LeapYearCalculator.IsLeapYear(year);
            Assert.True(result);
        }
        
        [Theory]
        [InlineData(1000)]
        [InlineData(700)]
        public void NotBeDivisibleByFourHundred(int year)
        {
            bool result = LeapYearCalculator.IsLeapYear(year);
            Assert.False(result);
        }
        
        [Theory]
        [InlineData(100)]
        [InlineData(200)]
        public void NotBeDivisibleByFourHundredAndBeDivisibleByOneHundred(int year)
        {
            bool result = LeapYearCalculator.IsLeapYear(year);
            Assert.False(result);
        }
        
        [Theory]
        [InlineData(16)]
        [InlineData(2440)]
        public void BeDivisibleByFourAndNotBeDivisibleByOneHundred(int year)
        {
            bool result = LeapYearCalculator.IsLeapYear(year);
            Assert.True(result);
        }

        
    }
}