using NUnit.Framework;
using Day1;

namespace Day1.Tests
{
    [TestFixture]
    public class FuelCounter_LoadModuleMassShould
    {
        [Test]
        public void LoadModuleMass_InputFileDoesNotExist_ThrowExeption()
        {
            FuelCounter fuelCounter = new FuelCounter();
            
            Assert.That(() => fuelCounter.LoadModuleMass(@"c:/invalid_path.txt"), Throws.Exception);
        }

        [Test]
        public void LoadModuleMass_InputFileExist_ReturnStringArray()
        {
            FuelCounter fuelCounter = new FuelCounter();
            string input_path = @"D:\Adam\Scripting\Advent\AdventCodeAdventures\Day1\input.txt";

            var Masses = fuelCounter.LoadModuleMass(input_path);  

            Assert.That(Masses, Is.Not.Null);
        }
    }
}