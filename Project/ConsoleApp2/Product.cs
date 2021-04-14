using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string Code { get; set; }
        public Categories Category { get; set; }
        public Product(string name,double price,string code,int count,Categories category)
        {
            this.Name = name;
            this.Price = price;
            this.Code = code;
            this.Count = count;
            this.Category = category;
        }

    }
}
