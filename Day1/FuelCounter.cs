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
        static public void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
