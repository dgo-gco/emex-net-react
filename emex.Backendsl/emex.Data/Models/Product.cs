using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emex.Data.Models;

public class Product
{
    public int ID { get; set; }
    public string ProductName { get; set; }
    public string Manufacturer { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public int Quantity { get; set; }
    public string ImageUrl { get; set; }
    public int Status { get; set; }
}
