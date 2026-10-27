using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adrian10E_6
{
    public class Car
    {
        private string brand;
        private double fuelConsumation;
        private string color;
        private int year;
        private string model;

        public Car(string brand, double fuelConsumation, string color, int year, string model)
        {
            this.brand = brand;
            this.fuelConsumation = fuelConsumation;
            this.color = color;
            this.year = year;
            this.model = model;
        }

        public string Brand { get => brand; set => brand = value; }
        public double FuelConsumation { get => fuelConsumation; set => fuelConsumation = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public string Model { get => model; set => model = value; }

        public double CalculatePriceTravel(double gasPrice, double distanceTravelled)
        {
            double travelCost = 0;
            travelCost = gasPrice * this.fuelConsumation;
            return travelCost;
        }
        public override string ToString()
        {
            return string.Format("Brand: {0}, FuelConsumation: {1}, Color: {2}, Year: {3}, Model: {4}",this.brand, this.FuelConsumation, this.color, this.year,this.model);
        }
    }
}
