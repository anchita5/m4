/*
* FILE          : Cereal.cs
* PROJECT       : Assignment 01
* PROGRAMMER    : Anchita Kakria
* FIRST VERSION : 15 sept 2024
* DESCRIPTION   : this file contains info for cereal class and represents info for packaged products and discountd and sugar content
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akakria1585_A01wp
{
    /*
    * NAME     : Cereal
    * PURPOSE  : The Cereal class shows packaged cereals.
    *            It also shows the for sugar content.
    */
    public class Cereal : Product
    {
        public int Sugar { get; set; }

        public Cereal() : base() { } //default constructor

        public Cereal(string sku, string brand, string productname, int size, DateTime datestock, int shelflife, double baseretailPrice, int sugar)
            : base(sku, brand, productname, size, datestock, shelflife, baseretailPrice)
        {
            Sugar = sugar;
        }
        /*
* FUNCTION      : GetDiscountedPrice
* DESCRIPTION   :  This method will give the info about the discounted price of the product 
* PARAMETERS    :   None
* RETURNS       :   double : The discounted price of the product.
*/
        // Override to calculate discounted price for cereal
        public override double GetDiscountedPrice()
        {
            int daysToExpire = (Datestock.AddDays(Shelflife) - DateTime.Now).Days;
            if (daysToExpire < 0)
            {
                return Baseretailprice * 0.5; // 50% off if past expiration date
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
            // Call the base class GetInfo method and append the additional details
            return base.GetProductInfo() + $", Sugar: {Sugar} grams";
        }

    }
}
