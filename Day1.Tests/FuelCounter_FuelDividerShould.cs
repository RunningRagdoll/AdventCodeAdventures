using NUnit.Framework;
using Day1;

namespace Day1.Tests
{
    [TestFixture]
    public class FuelCounter_FuelDividerShould
    {
        [TestCase(14, ExpectedResult = 2)]
        [TestCase(1969, ExpectedResult = 966)]
        [TestCase(100756, ExpectedResult = 50346)]
        public int FuelDivider_ReturnsExpectedResult(int mass)
        {
            FuelCounter fuelCounter = new FuelCounter();
            
            return fuelCounter.FuelDivider(mass);
        }
    }
}