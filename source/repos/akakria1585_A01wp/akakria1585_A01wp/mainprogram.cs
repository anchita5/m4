/*
FILE        : mainprogram.cs
PROJECT     : ASSIGNMENT 01
PROGRAMMER  : ANCHITA KAKRIA
FIRST VERSION : 15 SEP 2024
DESCRIPTION :This file conmtains the main implementatuin of the code and shows use of diary,product, cereal info.
    
*/
using akakria1585_A01wp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestProgram
{
    static void Main(string[] args)
    {

        Diary dairy = new Diary("1100", "Activa", "Milk", 1000, DateTime.Now, 25, 5.99, "yes");
        Produce produce = new Produce("2200", "FarmerMarket", "Fruits", 2000, DateTime.Now, 10, 2.99, "Weight", "Fruit");
        Cereal cereal = new Cereal("3300", "oreo", "oreo", 500, DateTime.Now, 30, 3.99, 10);


        Console.WriteLine("\nINFO FOR DIARY PRODUCTS:"); //display info
        Console.WriteLine(dairy.GetProductInfo());
        Console.WriteLine($"Discounted Price: ${dairy.GetDiscountedPrice()}\n");

        Console.WriteLine("\nINFO FOR PRODUCE PRODUCTS:");
        Console.WriteLine(produce.GetProductInfo()); //info for discount
        Console.WriteLine($"Discounted Price: ${produce.GetDiscountedPrice()}\n");

        Console.WriteLine("\nINFO FOR CEREAL PRODUCTS:");
        Console.WriteLine(cereal.GetProductInfo());
        Console.WriteLine($"Discounted Price: ${cereal.GetDiscountedPrice()}\n");
    }
}