using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOne
{
    public class ProductName
    {
        public string Name { get; set; }

    }

    public class ProductBarCode
    {
        public int BarCode { get; set; }

    }

    public class Price 
    { 
        public decimal price { get; set; }

    }

    public class Product
    {
        public int Id { get; set; }

        public ProductName Name { get; set; } = new ProductName();

        public Price price { get; set; } = new Price();

        public ProductBarCode BarCode { get; set; } = new ProductBarCode();

    }

 }