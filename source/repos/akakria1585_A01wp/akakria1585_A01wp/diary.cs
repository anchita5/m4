/*
FILE        :   Diary.cs
PROJECT     : ASSIGNMENT 01
PROGRAMMER  : ANCHITA KAKRIA
FIRST VERSION : 15 SEP 2024
DESCRIPTION : This file implements the diary class which is also a subclass and contains information
for all the diary products.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akakria1585_A01wp
{
    /*
    * NAME     : Diary
    * PURPOSE  : The Diary class shows dairy products.
    *            It includes an additional attribute for lactose content.
    *            */
    public class Diary : Product
    {
        public string Lactose { get; set; } //info for lactose

        public Diary() : base()
        {
            Lactose = "no"; //default value
        }

        public Diary(string sku, string brand, string productname, int size, DateTime datestock, int shelflife, double baseretailPrice, string lactose)
           : base(sku, brand, productname, size, datestock, shelflife, baseretailPrice)
        {
            Lactose = lactose;

        }
        /*
* FUNCTION      : GetDiscountedPrice
* DESCRIPTION   :  This method will give the info about the discounted price of the product 
* PARAMETERS    :   None
* RETURNS       :   double : The discounted price of the product.
*/
        // Override to calculate discounted price for dairy products
        public override double GetDiscountedPrice()
        {
            int daysToExpire = (Datestock.AddDays(Shelflife) - DateTime.Now).Days;
            if (daysToExpire <= 5)
            {
                return Baseretailprice * 0.5; // 50% off if 5 or fewer days to expiration
            }
            return Baseretailprice;
        }
        /*
* FUNCTION      : GetProductInfo
* DESCRIPTION   :  This method returns the details about the product.
* PARAMETERS    :   None
* RETURNS       :   string : Info of product.
*/
        public override string GetProductInfo()
        {
            return base.GetProductInfo() + $", Lactose: {Lactose}";
        }


    }
}
