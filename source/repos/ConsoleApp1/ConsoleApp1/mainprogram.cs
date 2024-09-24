using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestProgram
{
    static void Main(string[] args)
    {

        Dairy dairy = new Dairy("1100", "Activa", "Milk", 1000, DateTime.Now, 25, 5.99m, true);
        Produce produce = new Produce("2200", "FarmerMarket", "Fruits", 2000, DateTime.Now, 10, 2.99m, "Weight", "Fruit");
        Cereal cereal = new Cereal("3300", "oreo", "oreo", 500, DateTime.Now, 30, 3.99m, 10);


        Console.WriteLine("\nINFO FOR DIARY PRODUCTS:");
        Console.WriteLine(dairy.());

        Console.WriteLine("\nINFO FOR PRODUCE PRODUCTS:");
        Console.WriteLine(produce.());

        Console.WriteLine("\nINFO FOR CEREAL PRODUCTS:");
        Console.WriteLine(cereal.())
            }
}