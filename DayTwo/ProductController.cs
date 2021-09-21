using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOne
{
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        public static List<Product> ProductList = new List<Product>();

        [HttpGet("get")]
        public List<Product> Get()
        {
            return ProductList;
        }

        [HttpGet("getbyid")]
        public Product Get([FromQuery] int id)
        {
            return ProductList.Where(x => x.Id == id).First();
        }

        [HttpPost("upsert")]
        public Product Upsert([FromBody] Product product)
        {
            if (product.Id == 0)
            {
                product.Id = ProductList.Count + 1;
                ProductList.Add(product);
            }
            else
            {
                var existProduct = ProductList.Where(x => x.Id == product.Id).First();

                existProduct.Name = product.Name;

            }

            return product;
        }

        [HttpDelete("delete")]
        public void Delete(int id)
        {
            var existProduct = ProductList.Where(x => x.Id == id).First();
            ProductList.Remove(existProduct);
        }
    }
}