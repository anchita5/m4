/*
FILE        : Produce.cs
PROJECT     : ASSIGNMENT 01
PROGRAMMER  : ANCHITA KAKRIA
FIRST VERSION : 15 SEP 2024
DESCRIPTION :This defines the produce which is subclass that includes
constructors,methods and requirements according to standard
    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akakria1585_A01wp
{
    /*
    * NAME     : Produce
    * PURPOSE  : The Produce class shows the product 
    *            such as fruits or vegetables.
    */
    public class Produce : Product
    {
        public string Datesold { get; set; }
        public string Categoryofproduct { get; set; }

        public Produce() : base()
        {
            Datesold = string.Empty;
            Categoryofproduct = string.Empty;
        }

        public Produce(string sku, string brand, string productname, int size, DateTime datestock, int shelflife, double baseretailPrice, string datesold, string categoryofproduct)
            : base(sku, brand, productname, size, datestock, shelflife, baseretailPrice)
        {
            Datesold = datesold;
            Categoryofproduct = categoryofproduct;
        }
        /*
* FUNCTION      : GetDiscountedPrice
* DESCRIPTION   :  This method will give the info about the discounted price of the product 
* PARAMETERS    :   None
* RETURNS       :   double : The discounted price of the product.
*/
        // Override to calculate discounted price for produce
        public override double GetDiscountedPrice()
        {
            int daysToExpire = (Datestock.AddDays(Shelflife) - DateTime.Now).Days;
            if (daysToExpire <= 5)
            {
                return Baseretailprice * 0.5; // 50% off if less than 5 days
            }
            else if (daysToExpire <= 10)
            {
                return Baseretailprice * 0.8; // 20% off if 5-10 days to expiration
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
            return base.GetProductInfo() + $", Date Sold: {Datesold}, Category: {Categoryofproduct}";
        }
    }

}
