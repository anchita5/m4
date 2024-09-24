/*
FILE        : Product.cs
PROJECT     : ASSIGNMENT 01
PROGRAMMER  : ANCHITA KAKRIA
FIRST VERSION : 15 SEP 2024
DESCRIPTION :This defines the product which is the base class that includes
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
    * NAME     : Product
    * Desc: This class contains all the retail properties for the assignment such as brand,size, prize etc.
    */
public class Product //default constructor
    {

        public string Sku { get; set; }
        public string Brand { get; set; }
        public string Productname { get; set; }
        public int Size { get; set; }
        public DateTime Datestock { get; set; }
        public int Shelflife { get; set; }

        public int Discount { get; set; }

        public int DiscountPrice { get; set; }
        public double Baseretailprice { get; set; }

        public Product()
        {
            Sku = string.Empty;
            Brand = string.Empty;
            Productname = string.Empty;
            Size = 0;
            Datestock = DateTime.MinValue;
            Shelflife = 0;
            Baseretailprice = 0;
            Discount = 0;
            DiscountPrice = 0;
        }


        public Product(string sku, string brand, string productname, int size, DateTime datestock, int shelflife, double baseretailprice)
        {
            Sku = sku;
            Brand = brand;
            Productname = productname;
            Size = size;
            Datestock = datestock;
            Shelflife = shelflife;
            Baseretailprice = baseretailprice;
        }

/*
* FUNCTION      : GetProductInfo
* DESCRIPTION   :  This method returns the details about the product.
* PARAMETERS    :   None
* RETURNS       :   string : Info of product.
*/
        public virtual string GetProductInfo()
        {
            return $"SKU: {Sku}, Brand: {Brand}, Name: {Productname}, Size: {Size}, Date Stocked: {Datestock.ToShortDateString()}, Shelf Life: {Shelflife} days, Base Price: {Baseretailprice:C}, Discount: {Discount}%, Discount Price: {DiscountPrice:C}";
        }

        // Method to get discounted price, to be overridden by derived classes
/*
* FUNCTION      : GetDiscountedPrice
* DESCRIPTION   :  This method will give the info about the discounted price of the product 
* PARAMETERS    :   None
* RETURNS       :   double : The discounted price of the product.
*/
        public virtual double GetDiscountedPrice()
        {
            return Baseretailprice; // Default, no discount applied
        }
    }
}

