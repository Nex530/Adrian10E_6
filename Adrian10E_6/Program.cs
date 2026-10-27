using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adrian10E_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Audi", 12.0, "gray", 2021, "R8");
            double price = car1.CalculatePriceTravel(2.50, 50);
            Console.WriteLine("The price is: {0}", price);

            Console.ReadKey();
            /*List<Car> database = new List<Car>();
            database.Add(new Car("Pontiac", 8.8, "yellow", 1977, "Freebird"));
            database.Add(new Car("Audi", 8.8, "darkBlue", 2026, "A6"));
            database.Add(new Car("Porsche", 8.8, "white", 2022, "911Targa4S"));
            // POST -> CREATE
            for (int index = 0; index < database.Count; index++)
            {
                Console.WriteLine(database[index].ToString());
            }
            Console.WriteLine();*/
            // GET -> READ

        }
    }
}
