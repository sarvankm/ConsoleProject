using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class SaleItems
    {
        public List<AddProduct> prods = new List<AddProduct>();
        public SaleItems(List <AddProduct> product1)
        {
            prods = product1;
        }
    }
}
