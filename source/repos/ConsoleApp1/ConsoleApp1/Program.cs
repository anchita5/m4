using System;

public class Product
{
    public string Sku { get; set; }
    public string Brand { get; set; }
    public string Productname { get; set; }
    public int Size { get; set; }
    public DateTime Datestock { get; set; }
    public int Shelflife { get; set; }
    public decimal Baseretailprice { get; set; }
    public Product() { }

    public Product(string sku, string brand, string productname, int size, DateTime datestock, int shelflife, decimal baseretailprice)
    {
        Sku = sku;
        Brand = brand;
        Productname = productname;
        Size = size;
        Datestock = datestock;
        Shelflife = shelflife;
        Baseretailprice = baseretailprice;
    }
}