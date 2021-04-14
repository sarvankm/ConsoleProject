using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Sale
    {
        public  int SaleNo { get; set; }
        private static int _saleNo;
        public  double SaleAmount { get; set; }
        public DateTime SaleDate { get; set; }
        public SaleItems SaleItems { get; set; }
        public int SaleItemCounts { get; set; }
        public Sale(SaleItems saleitemproduct)
        {
            _saleNo++;
            SaleNo = _saleNo;
            this.SaleDate = DateTime.Now.Date;
            this.SaleItems = saleitemproduct;
    
            for (int i = 0; i < saleitemproduct.prods.Count; i++)
            {
                SaleAmount += saleitemproduct.prods[i].Product.Price * saleitemproduct.prods[i].ItemCount;
            }
            for (int i = 0; i < SaleItems.prods.Count; i++)
            {
                SaleItemCounts += SaleItems.prods[i].ItemCount;
            }
        }
    }
}
