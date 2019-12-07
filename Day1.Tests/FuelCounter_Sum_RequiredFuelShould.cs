using NUnit.Framework;
using Day1;

namespace Day1.Tests
{
    [TestFixture]
    public class FuelCounter_Sum_RequiredFuelShould
    {
        [TestCase(new double[]{12.0f}, ExpectedResult = 2)]
        [TestCase(new double[]{14.0f}, ExpectedResult = 2)]
        [TestCase(new double[]{1969.0f}, ExpectedResult = 654)]
        [TestCase(new double[]{100756.0f}, ExpectedResult = 33583)]
        public int Sum_RequiredFuel_ReturnsExpectedSum(double[] ModuleMass)
        {
            FuelCounter fuelCounter = new FuelCounter();

            return fuelCounter.Sum_RequiredFuel(ModuleMass);
        }
    }
}