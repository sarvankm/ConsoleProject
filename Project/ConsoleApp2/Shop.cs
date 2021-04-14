using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Shop : IMarketable
    {
        public List<Product> products { get; set; }
        public List<Sale> sales { get; set; }


        public Shop()
        {
            products = new List<Product>();
            sales = new List<Sale>();
        }
        #region Product
        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new NullReferenceException2("Obyekt Null gonderile bilmez");
            }

            products.Add(product);
        }

        public void ChangeProduct(string code, string name, double price, int count, Categories category)
        {
            var product = products.Find(p => p.Code == code);
            if (product == null)
            {
                throw new NullReferenceException1("Bu kodda item tapilmadi");
            }
            product.Name = name;
            product.Price = price;
            product.Count = count;
            product.Category = category;
        }

        public List<Product> FindProductsByCategory(Categories category)
        {
            var product = products.FindAll(p => p.Category == category);


            return product;
        }

        public List<Product> FindProductByPriceRange(double price1, double price2)
        {
            List<Product> products2 = null;

            if (price1 <= price2)
            {
                var product = products.FindAll(p => price1 <= p.Price && price2 >= p.Price);
                products2 = product;

            }
            else if (price1 >= price2)
            {
                var product = products.FindAll(p => price2 <= p.Price && price1 >= p.Price);
                products2 = product;
            }
            return products2;
        }

        public List<Product> SearchByName(string name)
        {
            var product = products.FindAll(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            return product;
        }
        public void RemoveProduct(string code)
        {
            var product = products.Find(p => p.Code == code);
            if (product == null)
            {
                throw new NullReferenceException1("Bu kodda item tapilmadi\n");
            }
            products.Remove(product);
        }
        public void ShowProducts()
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Item name: {item.Name}/ Item category: {item.Category}/ Item price: {item.Price}/ Item count: {item.Count}/ Item code: {item.Code} ");
            }
        }
        #endregion
        #region Sale
        public void AddSale(Sale sale)
        {
            sales.Add(sale);
        }
        public Product AddSaleItems(string productcode)
        {
            var a = products.Find(p => p.Code == productcode);
            return a;
        }
        public void RemoveSaleItem(int saleno, int saleitemno, int saleitemcount)
        {
            
            var a = sales.Find(s => s.SaleNo == saleno);
            var b = a.SaleItems.prods.Find(p => p.ItemNo == saleitemno);
            a.SaleAmount -= b.ItemCount * b.Product.Price;
            b.ItemCount -= saleitemcount;
            var c = products.Find(p => p == b.Product);
            c.Count += saleitemcount;
            if (b.ItemCount==0)
            {
                a.SaleItems.prods.Remove(b);
            }
        }
        public void RemoveSale(int saleno)
        {
                
            var ab = sales.Find(s => s.SaleNo == saleno);
            foreach (var item in ab.SaleItems.prods)
            {
                var a = products.Find(p => p == item.Product);
                a.Count += item.ItemCount;
            }
            sales.Remove(ab);
        }
        public void ShowSales()
        {
            foreach (var item in sales)
            {
                Console.WriteLine($"Satis nomresi:{item.SaleNo}/ Satis meblegi:{item.SaleAmount}/ Satis sayi:{item.SaleItemCounts}/ Satis tarixi:{item.SaleDate}");
            }
        }
        public List<Sale> ReturnSalesByDateRange(DateTime startdate, DateTime enddate)
        {
            List<Sale> saless = null;
            if (enddate <= startdate)
            {
                var a = sales.FindAll(s => s.SaleDate >= enddate && s.SaleDate <= startdate);
                saless = a;
            }
            else if (startdate >= enddate)
            {
                var a = sales.FindAll(s => s.SaleDate >= startdate && s.SaleDate <= enddate);
                saless = a;
            }
            return saless;
        }
        public List<Sale> ReturnSalesByDate(DateTime dateTime)
        {
            var a = sales.FindAll(s => s.SaleDate == dateTime);
            return a;
        }
        public List<Sale> ReturnSalesBySaleAmountRange(double amount1, double amount2)
        {
            List<Sale> saless = null;
            if (amount1 < amount2)
            {
                var a = sales.FindAll(s => s.SaleAmount >= amount1 && s.SaleAmount <= amount2);
                saless = a;
            }
            else if (amount1 > amount2)
            {
                var a = sales.FindAll(s => s.SaleAmount >= amount2 && s.SaleAmount <= amount1);
                saless = a;
            }
            return saless;
        }

        public Sale ReturnSaleBySaleNo(int saleno)
        {
            
            var a = sales.Find(s => s.SaleNo == saleno);
            return a;
        }
        #endregion
        
    }
}
