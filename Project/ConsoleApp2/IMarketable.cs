using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    
    interface IMarketable
    {
        List<Product> products { get; set; }
        public void AddProduct(Product product);
        public void ChangeProduct(string code, string name, double price, int count, Categories category);
        public List<Product> FindProductsByCategory(Categories category);
        public List<Product> FindProductByPriceRange(double price1,double price2);
        public List<Product> SearchByName(string name);
        List<Sale> sales { get; set; }
        public void AddSale(Sale sale);
        public void RemoveSaleItem(int saleno, int saleitemno, int saleitemcount);
        public void RemoveSale(int saleno);
        public List<Sale> ReturnSalesByDateRange(DateTime startdate,DateTime enddate);
        public List<Sale> ReturnSalesByDate(DateTime dateTime);
        public List<Sale> ReturnSalesBySaleAmountRange(double amount1, double amount2);
        public Sale ReturnSaleBySaleNo(int saleno);
    }
}
