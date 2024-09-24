using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cereal : Product
{
    public int Sugar { get; set; }

    public Cereal() : base() { }

    public Cereal(string sku, string brand, string productname, int size, DateTime datestock, int shelflife, decimal baseretailPrice, decimal sugar)
        : base(sku, brand, productname, size, datestock, shelflife, baseretailPrice)
    {
        Sugar = Sugar;
    }
}