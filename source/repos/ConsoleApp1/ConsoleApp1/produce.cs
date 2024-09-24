using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Produce : Product
{
    public string Datesold { get; set; }
    public string Categoryofproduct { get; set; }

    public Produce() : base() { }

    public Produce(string sku, string brand, string productname, int size, DateTime datestock, int shelflife, decimal baseretailPrice, string Datesold, string Categoryofproduct)
        : base(sku, brand, productname, size, datestock, shelflife, baseretailPrice)
    {
        Datesold = Datesold;
        Categoryofproduct = Categoryofproduct;
    }
}
