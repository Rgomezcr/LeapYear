using Xunit;

namespace LeapYear.Test
{
    public class LeapYearShould
    {
        [Fact]
        public void BeDivisibleTwoThousandByFourHundred()
        {
            bool result = LeapYearCalculator.IsLeapYear(2000);
            Assert.True(result);
        }
        
        [Fact]
        public void BeDivisibleFourHundredByFourHundred()
        {
            bool result = LeapYearCalculator.IsLeapYear(400);
            Assert.True(result);
        }
        [Fact]
        public void NotBeDivisibleOneThousandByFourHundred()
        {
            bool result = LeapYearCalculator.IsLeapYear(1000);
            Assert.False(result);
        }
        
        [Fact]
        public void NotBeDivisibleOneHundredByFourHundredAndBeDivisibleByOneHundred()
        {
            bool result = LeapYearCalculator.IsLeapYear(100);
            Assert.False(result);
        }
        
        [Fact]
        public void NotBeDivisibleTwoHundredByFourHundredAndBeDivisibleByOneHundred()
        {
            bool result = LeapYearCalculator.IsLeapYear(100);
            Assert.False(result);
        }
        
        [Fact]
        public void BeDivisibleFourByFourAndNotBeDivisibleByOneHundred()
        {
            bool result = LeapYearCalculator.IsLeapYear(4);
            Assert.True(result);
        }

        
    }
}