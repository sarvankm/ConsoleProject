using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class AddProduct
    {
        public int ItemCount;
        public Product Product;
        public int ItemNo;
        private static int _itemno;
        public AddProduct(int itemcount,Product productt)
        {
            ItemCount = itemcount;
            Product = productt;
            _itemno++;
            ItemNo = _itemno;
            if (itemcount>productt.Count && productt.Count==0)
            {
                Console.WriteLine("Yanlis melumat daxil edilib");
            }
            else
            {
                productt.Count -= itemcount;
            }
        }
        public AddProduct()
        {
            _itemno = 0;
        }
    }
}
