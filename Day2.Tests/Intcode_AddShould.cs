using NUnit.Framework;
using Day2;

namespace Day2.Tests
{
    [TestFixture]
    public class Intcode_AddShould
    {
        [TestCase(new int[] {1,2}, ExpectedResult = 3)]
        [TestCase(new int[] {1,3,1,2}, ExpectedResult = 7)]
        [TestCase(new int[] {1,0,0,0}, ExpectedResult = 1)]
        [TestCase(new int[] {1,1,2,5,1}, ExpectedResult = 10)]
        public int AddShould_ReturnExpectedResult(int[] input)
        {
            Intcode intcode = new Intcode();
            return intcode.Add(input);
        }
    }
}