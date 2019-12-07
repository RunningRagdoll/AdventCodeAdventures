using System;
using System.IO;

namespace Day1
{
    public class FuelCounter
    {
        public string[] LoadModuleMass(string ListOfModules)
        {
            if (File.Exists(ListOfModules) == false)
            {
                //System.Console.WriteLine("Path: {0}", ListOfModules);
                throw new FileNotFoundException();
            }
            else
            {
                return System.IO.File.ReadAllLines(ListOfModules);
            };
        }

        private double[] ConvertArray_StringToDouble(string[] Array)
        {
            double[] doubleArray = new double[Array.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                doubleArray[i] = Convert.ToDouble(Array[i]);
            }

            return doubleArray;
        }

        public int Sum_RequiredFuel(double[] ModuleMasses)
        {
            throw new NotImplementedException("Please create a test first.");
        } 

        static public void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
