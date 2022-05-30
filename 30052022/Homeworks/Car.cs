using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;

        public void Drive(double km)
        {
            if (CurrentFuel >= km * FuelFor1Km)
            {
                Millage += km;
                CurrentFuel -= km * FuelFor1Km;
            }
            else
            {
                Console.WriteLine("Benzin kifayet deyil!");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - CurrentFuel: {CurrentFuel}  Millage: {Millage}");
        }
    }
}
