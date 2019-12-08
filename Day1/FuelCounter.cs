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

        public int FuelDivider(int mass)
        {
            int fuel = mass;
            if (mass <= 0)
            {
                return 0;
            }
            else
            {
                fuel = Convert.ToInt32(Math.Floor(mass/3.0d) - 2);
                if (fuel < 0)
                {
                    fuel = 0;
                }
                return fuel += FuelDivider(fuel);
            }
        }

        private int Sum_RequiredFuel_recursion(double[] ModuleMasses)
        {
            int Sum = 0;
            int ModuleFuel = 0;
            double mass = 0.0d;

            for (int i = 0; i < ModuleMasses.Length; i++)
            {
                mass = ModuleMasses[i];
                ModuleFuel = FuelDivider(Convert.ToInt32(mass));
                Sum += ModuleFuel;
            }
            return Sum;
        } 

        static void Main(string[] args)
        {
            string[] ModuleMasses;
            string input_file = Path.Combine(Directory.GetCurrentDirectory(), "input.txt");

            double[] doubleModuleMasses;
            int FuelRequirement, FuelRequirementRecursion;

            FuelCounter fuelCounter = new FuelCounter();
            ModuleMasses = fuelCounter.LoadModuleMass(input_file);

            doubleModuleMasses = fuelCounter.ConvertArray_StringToDouble(ModuleMasses);
            FuelRequirement = fuelCounter.Sum_RequiredFuel(doubleModuleMasses);

            FuelRequirementRecursion = fuelCounter.Sum_RequiredFuel_recursion(doubleModuleMasses);

            Console.WriteLine("Fuel required: {0}", FuelRequirement);
            Console.WriteLine("Fuel required for recursion: {0}", FuelRequirementRecursion);
        }
    }
}
