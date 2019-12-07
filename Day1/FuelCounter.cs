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
            int Sum = 0;
            int ModuleFuel = 0;
            double mass = 0.0d;

            for (int i = 0; i < ModuleMasses.Length; i++)
            {
                mass = ModuleMasses[i];
                ModuleFuel = Convert.ToInt32(Math.Floor(mass/3.0d) - 2);
                Sum += ModuleFuel;
            }
            return Sum;
        } 

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }
}
