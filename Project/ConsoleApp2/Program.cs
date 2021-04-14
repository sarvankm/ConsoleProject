using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Console.WriteLine("Music Gallery");
        label1:
            Console.WriteLine("\n1: Mehsullar uzerinde emeliyyat aparmaq");
            Console.WriteLine("2: Satislar uzerinde emeliyyat aparmaq");
            Console.WriteLine("3: Sistemden cixmaq");
            Console.Write("\nEmeliyyat seciminizi edin (1,2,3): ");
            string Choise = Console.ReadLine();
            if (Choise != "1" && Choise != "2" && Choise != "3") { goto label1; }
            if (Choise == "1")
            {
                Console.Clear();
            label2:
                Console.WriteLine("\n1: Yeni mehsul elave et");
                Console.WriteLine("2: Mehsul uzerinde duzelis et");
                Console.WriteLine("3: Mehsulu sil");
                Console.WriteLine("4: Butun mehsullari goster");
                Console.WriteLine("5: Categoriyasina gore mehsullari goster");
                Console.WriteLine("6: Qiymet araligina gore mehsullari goster");
                Console.WriteLine("7: Mehsullar arasinda ada gore axtaris et");
                Console.WriteLine("8: Geriye qayit");
                Console.Write("\nEtmek istediyiniz emeliyyati secin (1,2,3,4,5,6,7,8): ");
                string ChoiseInFirst = Console.ReadLine();
                if (ChoiseInFirst != "1" && ChoiseInFirst != "2" && ChoiseInFirst != "3" && ChoiseInFirst != "4" && ChoiseInFirst != "5" && ChoiseInFirst != "6" && ChoiseInFirst != "7" && ChoiseInFirst != "8") goto label2;

                switch (Convert.ToInt32(ChoiseInFirst))
                {
                    case 1:
                        try
                        {
                            Console.Write("\nMehsulun adini daxil edin: ");
                            string ProductName = Console.ReadLine();
                            if (String.IsNullOrEmpty(ProductName.Trim()))
                            {
                                Console.WriteLine("\nMehsul adsiz ola bilmez");
                                goto case 1;
                            }
                            Console.Write("Mehsulun qiymetini daxil edin (kesr ededdirse : 1599.99 kimi): ");
                            double ProductPrice;
                            string ProductPriceStr = Console.ReadLine();
                            if (!Double.TryParse(ProductPriceStr, out ProductPrice))
                            {
                                Console.WriteLine("Eded daxil edin");
                                goto case 1;
                            }
                            Console.Write("Mehsulun kodunu daxil edin: ");
                            string ProductCode = Console.ReadLine();
                            if (String.IsNullOrEmpty(ProductCode.Trim()))
                            {
                                Console.WriteLine("Kod bos ola bilmez");
                                goto case 1;
                            }
                            Console.Write("Mehsulun sayini daxil edin: ");
                            int ProductCount;
                            string ProductCountStr = Console.ReadLine();
                            if (!Int32.TryParse(ProductCountStr, out ProductCount))
                            {
                                Console.WriteLine("Tam eded daxil edin");
                                goto case 1;
                            }
                        label3:
                            Console.WriteLine("\nMehsulun kateqoriyasini secin (1,2,3,4)");
                            Console.WriteLine("1:" + " Telefon");
                            Console.WriteLine("2:" + " Planset");
                            Console.WriteLine("3:" + " Noutbuk");
                            Console.WriteLine("4:" + " Monitor");
                            var c1 = Categories.Telefon;
                            var c2 = Categories.Planset;
                            var c3 = Categories.Noutbuk;
                            var c4 = Categories.Monitor;
                            Console.Write("Seciminiz: ");
                            string inpcategory = Console.ReadLine();
                            if (inpcategory != "1" && inpcategory != "2" && inpcategory != "3" && inpcategory != "4") goto label3;
                            if (inpcategory == "1")
                            {
                                Product product1111 = new Product(ProductName, ProductPrice, ProductCode, ProductCount, c1);
                                shop.products.Add(product1111);

                            }
                            else if (inpcategory == "2")
                            {
                                Product product1111 = new Product(ProductName, ProductPrice, ProductCode, ProductCount, c2);
                                shop.products.Add(product1111);
                            }
                            else if (inpcategory == "3")
                            {
                                Product product1111 = new Product(ProductName, ProductPrice, ProductCode, ProductCount, c3);
                                shop.products.Add(product1111);
                            }
                            else if (inpcategory == "4")
                            {
                                Product product1111 = new Product(ProductName, ProductPrice, ProductCode, ProductCount, c4);
                                shop.products.Add(product1111);
                            }
                            Console.Clear();
                            Console.WriteLine("\nMehsul elave edildi\n");
                            goto label1;
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("\n" + e.Message);
                        labelexcp:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue1 = Console.ReadLine();
                            if (WantToContinue1 != "y" && WantToContinue1 != "n")
                            {
                                goto labelexcp;
                            }
                            else if (WantToContinue1 == "y")
                            {
                                goto case 1;
                            }
                            else
                            {
                                goto label2;
                            }
                        }
                    case 2:
                        try
                        {
                            Console.Write("\nMehsulun kodunu daxil edin: ");
                            string WillChangeProductCode = Console.ReadLine();
                            Console.Write("Yeni adi daxil edin: ");
                            string ChangeProductName = Console.ReadLine();
                            if (String.IsNullOrEmpty(ChangeProductName.Trim()))
                            {
                                Console.WriteLine("\nMehsul adsiz ola bilmez");
                                goto case 2;
                            }
                            Console.Write("Yeni meblegi daxil edin: ");
                            double ChangeProductPrice;
                            string ChangeProductPriceStr = Console.ReadLine();
                            if (!Double.TryParse(ChangeProductPriceStr, out ChangeProductPrice))
                            {
                                Console.WriteLine("Eded daxil edin");
                                goto case 2;
                            }
                            Console.Write("Yeni sayi daxil edin: ");
                            int ChangeProductCount;
                            string ChangeProductCountStr = Console.ReadLine();
                            if (!Int32.TryParse(ChangeProductCountStr, out ChangeProductCount))
                            {
                                Console.WriteLine("Tam eded daxil edin");
                                goto case 2;
                            }

                        label4:
                            Console.WriteLine("\nMehsulun kateqoriyasini secin (1,2,3,4)");
                            Console.WriteLine("1:" + " Telefon");
                            Console.WriteLine("2:" + " Planset");
                            Console.WriteLine("3:" + " Noutbuk");
                            Console.WriteLine("4:" + " Monitor");
                            var c1 = Categories.Telefon;
                            var c2 = Categories.Planset;
                            var c3 = Categories.Noutbuk;
                            var c4 = Categories.Monitor;
                            Console.Write("Seciminiz: ");
                            string inpcategory = Console.ReadLine();
                            if (inpcategory != "1" && inpcategory != "2" && inpcategory != "3" && inpcategory != "4") goto label4;
                            if (inpcategory == "1")
                            {
                                shop.ChangeProduct(WillChangeProductCode, ChangeProductName, ChangeProductPrice, ChangeProductCount, c1);
                            }
                            else if (inpcategory == "2")
                            {
                                shop.ChangeProduct(WillChangeProductCode, ChangeProductName, ChangeProductPrice, ChangeProductCount, c2);
                            }
                            else if (inpcategory == "3")
                            {
                                shop.ChangeProduct(WillChangeProductCode, ChangeProductName, ChangeProductPrice, ChangeProductCount, c3);
                            }
                            else if (inpcategory == "4")
                            {
                                shop.ChangeProduct(WillChangeProductCode, ChangeProductName, ChangeProductPrice, ChangeProductCount, c4);
                            }

                            Console.WriteLine("\nMehsul deyisdirildi");
                        labelexcp:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue2 = Console.ReadLine();
                            if (WantToContinue2 != "y" && WantToContinue2 != "n")
                            {
                                goto labelexcp;
                            }
                            else if (WantToContinue2 == "y")
                            {
                                goto case 2;
                            }
                            else
                            {
                                Console.Clear();
                                goto label2;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n" + e.Message);
                        labelexcp:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue3 = Console.ReadLine();
                            if (WantToContinue3 != "y" && WantToContinue3 != "n")
                            {
                                goto labelexcp;
                            }
                            else if (WantToContinue3 == "y")
                            {
                                goto case 2;
                            }
                            else
                            {
                                goto label2;
                            }
                        }
                    case 3:
                        try
                        {
                            Console.Write("Mehsulun kodunu daxil edin: ");
                            string RemoveProductCode = Console.ReadLine();
                            shop.RemoveProduct(RemoveProductCode);
                            Console.Clear();
                            Console.WriteLine("\nMehsul silindi");
                            goto label1;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n" + e.Message);
                        labelexcp:
                            Console.WriteLine("Davam etmek isteyirsiz: y/n");
                            string WantToContinue4 = Console.ReadLine();
                            if (WantToContinue4 != "y" && WantToContinue4 != "n")
                            {
                                goto labelexcp;
                            }
                            else if (WantToContinue4 == "y")
                            {
                                goto case 3;
                            }
                            else
                            {
                                Console.Clear();
                                goto label2;
                            }
                        }
                    case 4:
                        Console.WriteLine();
                        if (shop.products.Count == 0)
                        {
                            Console.WriteLine("Bazada mehsul yoxdur");
                            goto label1;
                        }
                        shop.ShowProducts();
                        goto label1;
                    case 5:
                        Console.WriteLine("Kateqoriyani daxil edin (1,2,3,4)");
                        Console.WriteLine("1:" + " Telefon");
                        Console.WriteLine("2:" + " Planset");
                        Console.WriteLine("3:" + " Noutbuk");
                        Console.WriteLine("4:" + " Monitor");
                        var category1 = Categories.Telefon;
                        var category2 = Categories.Planset;
                        var category3 = Categories.Noutbuk;
                        var category4 = Categories.Monitor;
                        Console.Write("Seciminiz: ");
                        string inpcat = Console.ReadLine();
                        if (inpcat != "1" && inpcat != "2" && inpcat != "3" && inpcat != "4") goto case 5;
                        if (inpcat == "1")
                        {
                            if (shop.FindProductsByCategory(category1).Count == 0)
                            {
                                Console.WriteLine("Bu kategoriyada mehsul tapilmadi");
                            labelexcp:
                                Console.WriteLine("Davam etmek isteyirsiz: y/n");
                                string WantToContinue4 = Console.ReadLine();
                                if (WantToContinue4 != "y" && WantToContinue4 != "n")
                                {
                                    goto labelexcp;
                                }
                                else if (WantToContinue4 == "y")
                                {
                                    goto case 5;
                                }
                                else
                                {
                                    Console.Clear();
                                    goto label2;
                                }
                            }
                            else
                            {
                                foreach (var item in shop.FindProductsByCategory(category1))
                                {
                                    Console.WriteLine($"Item name: {item.Name}/ Item category: {item.Category}/ Item price: {item.Price}/ Item count: {item.Count}/ Item code: {item.Code} ");
                                }
                            }
                        }
                        else if (inpcat == "2")
                        {
                            if (shop.FindProductsByCategory(category2).Count == 0)
                            {
                                Console.WriteLine("Bu kategoriyada mehsul tapilmadi");
                            labelexcp:
                                Console.WriteLine("Davam etmek isteyirsiz: y/n");
                                string a = Console.ReadLine();
                                if (a != "y" && a != "n")
                                {
                                    goto labelexcp;
                                }
                                else if (a == "y")
                                {
                                    goto case 5;
                                }
                                else
                                {
                                    Console.Clear();
                                    goto label2;
                                }
                            }
                            foreach (var item in shop.FindProductsByCategory(category2))
                            {
                                Console.WriteLine($"Item name: {item.Name}/ Item category: {item.Category}/ Item price: {item.Price}/ Item count: {item.Count}/ Item code: {item.Code} ");
                            }
                        }
                        else if (inpcat == "3")
                        {
                            if (shop.FindProductsByCategory(category3).Count == 0)
                            {
                                Console.WriteLine("Bu kategoriyada mehsul tapilmadi");
                            labelexcp:
                                Console.WriteLine("Davam etmek isteyirsiz: y/n");
                                string a = Console.ReadLine();
                                if (a != "y" && a != "n")
                                {
                                    goto labelexcp;
                                }
                                else if (a == "y")
                                {
                                    goto case 5;
                                }
                                else
                                {
                                    Console.Clear();
                                    goto label2;
                                }
                            }
                            foreach (var item in shop.FindProductsByCategory(category3))
                            {
                                Console.WriteLine($"Item name: {item.Name}/ Item category: {item.Category}/ Item price: {item.Price}/ Item count: {item.Count}/ Item code: {item.Code} ");
                            }
                        }
                        else if (inpcat == "4")
                        {
                            if (shop.FindProductsByCategory(category4).Count == 0)
                            {
                                Console.WriteLine("Bu kategoriyada mehsul tapilmadi");
                            labelexcp:
                                Console.WriteLine("Davam etmek isteyirsiz: y/n");
                                string a = Console.ReadLine();
                                if (a != "y" && a != "n")
                                {
                                    goto labelexcp;
                                }
                                else if (a == "y")
                                {
                                    goto case 5;
                                }
                                else
                                {
                                    Console.Clear();
                                    goto label2;
                                }
                            }
                            foreach (var item in shop.FindProductsByCategory(category4))
                            {
                                Console.WriteLine($"Item name: {item.Name}/ Item category: {item.Category}/ Item price: {item.Price}/ Item count: {item.Count}/ Item code: {item.Code} ");
                            }
                        }
                    labelexcppp:
                        Console.WriteLine("Davam etmek isteyirsiz: y/n");
                        string WantToContinue5 = Console.ReadLine();
                        if (WantToContinue5 != "y" && WantToContinue5 != "n")
                        {
                            goto labelexcppp;
                        }
                        else if (WantToContinue5 == "y")
                        {
                            goto case 5;
                        }
                        else
                        {
                            Console.Clear();
                            goto label2;
                        }
                    case 6:
                        try
                        {
                            Console.Write("1-ci qiymeti daxil edin: ");
                            double price1;
                            string priceStr1 = Console.ReadLine();
                            if (!Double.TryParse(priceStr1, out price1))
                            {
                                Console.WriteLine("Eded daxil edin\n");
                                goto case 6;
                            }
                        labelcheck:
                            Console.Write("2-ci qiymeti daxil edin: ");
                            double price2;
                            string priceStr2 = Console.ReadLine();
                            if (!Double.TryParse(priceStr2, out price2))
                            {
                                Console.WriteLine("Eded daxil edin\n");
                                goto labelcheck;
                            }
                            if (shop.FindProductByPriceRange(price1, price2).Count == 0)
                            {
                                Console.WriteLine("\nDaxil etdiyiniz qiymet araliginda mehsul yoxdur\n");
                            labelexcp:
                                Console.WriteLine("Davam etmek isteyirsiz: y/n");
                                string WantToContinue6 = Console.ReadLine();
                                if (WantToContinue6 != "y" && WantToContinue6 != "n")
                                {
                                    goto labelexcp;
                                }
                                else if (WantToContinue6 == "y")
                                {
                                    goto case 6;
                                }
                                else
                                {
                                    Console.Clear();
                                    goto label2;
                                }
                            }
                            else
                            {
                                foreach (var item in shop.FindProductByPriceRange(price1, price2))
                                {
                                    Console.WriteLine($"Item name: {item.Name}/ Item category: {item.Category}/ Item price: {item.Price}/ Item count: {item.Count}/ Item code: {item.Code} ");
                                }
                            labelexcp:
                                Console.WriteLine("Davam etmek isteyirsiz: y/n");
                                string WantToContinue7 = Console.ReadLine();
                                if (WantToContinue7 != "y" && WantToContinue7 != "n")
                                {
                                    goto labelexcp;
                                }
                                else if (WantToContinue7 == "y")
                                {
                                    goto case 6;
                                }
                                else
                                {
                                    Console.Clear();
                                    goto label2;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\n" + "Bazada mehsul yoxdur");
                        labelexcp:
                            Console.WriteLine("Davam etmek isteyirsiz: y/n");
                            string WantToContinue8 = Console.ReadLine();
                            if (WantToContinue8 != "y" && WantToContinue8 != "n")
                            {
                                goto labelexcp;
                            }
                            else if (WantToContinue8 == "y")
                            {
                                goto case 6;
                            }
                            else
                            {
                                goto label2;
                            }
                        }
                    case 7:
                        Console.WriteLine("\nAxtaris etmek istediyiniz mehsulun adini daxil edin: ");
                        string SearchProduct = Console.ReadLine();
                        if (shop.SearchByName(SearchProduct).Count == 0 || String.IsNullOrEmpty(SearchProduct.Trim()))
                        {
                            Console.WriteLine("Axtardiginiz mehsul yoxdur");
                        labelexcp:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue9 = Console.ReadLine();
                            if (WantToContinue9 != "y" && WantToContinue9 != "n")
                            {
                                goto labelexcp;
                            }
                            else if (WantToContinue9 == "y")
                            {
                                goto case 7;
                            }
                            else
                            {
                                Console.Clear();
                                goto label2;
                            }
                        }
                        else
                        {
                            foreach (var item in shop.SearchByName(SearchProduct.Trim()))
                            {
                                Console.WriteLine($"Item name: {item.Name}/ Item category: {item.Category}/ Item price: {item.Price}/ Item count: {item.Count}/ Item code: {item.Code} ");
                            }
                        }
                    labelexcpppp:
                        Console.WriteLine("Davam etmek isteyirsiz: y/n");
                        string WantToContinue10 = Console.ReadLine();
                        if (WantToContinue10 != "y" && WantToContinue10 != "n")
                        {
                            goto labelexcpppp;
                        }
                        else if (WantToContinue10 == "y")
                        {
                            goto case 7;
                        }
                        else
                        {
                            Console.Clear();
                            goto label2;
                        }
                    case 8:
                        goto label1;
                    default:
                        break;
                }
            }
            if (Choise == "2")
            {
                Console.Clear();
            label22:
                Console.WriteLine("\n1: Yeni satis elave etmek");
                Console.WriteLine("2: Satisdaki hansisa mehsulun geri qaytarilmasi(satisdan cixarilmasi)");
                Console.WriteLine("3: Satisin silinmesi");
                Console.WriteLine("4: Butun satislarin ekrana cixarilmasi (nomresi,meblegi,mehsul sayi,tarixi)");
                Console.WriteLine("5: Verilen tarix araligina gore satislarin gosterilmesi");
                Console.WriteLine("6: Verilen mebleg araligina gore satislarin gosterilmesi");
                Console.WriteLine("7: Verilmis bir tarixde olan satislarin gosterilmesi");
                Console.WriteLine("8: Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi");
                Console.WriteLine("9: Geriye qayit");
                Console.Write("\nEtmek istediyiniz emeliyyati secin (1,2,3,4,5,6,7,8,9): ");
                string ChoiseSale = Console.ReadLine();
                if (ChoiseSale != "1" && ChoiseSale != "2" && ChoiseSale != "3" && ChoiseSale != "4" && ChoiseSale != "5" && ChoiseSale != "6" && ChoiseSale != "7" && ChoiseSale != "8" && ChoiseSale != "9") goto label22;
                switch (Convert.ToInt32(ChoiseSale))
                {
                    case 1:
                        try
                        {
                            List<AddProduct> addProducts = new List<AddProduct>();

                        label223:
                            Console.WriteLine("Satis mehsulu daxil edilecek? y/n");
                            string Input = Console.ReadLine();
                            if (Input != "y" && Input != "n") goto label223;
                            if (Input == "y")
                            {
                                Console.Write("Mehsulun kodunu daxil edin: ");
                                string productcode = Console.ReadLine();
                                Console.Write("Almaq istediyiniz sayi daxil edin: ");
                                int itemcount;
                                string itemcountstr = Console.ReadLine();
                                if (!Int32.TryParse(itemcountstr, out itemcount))
                                {
                                    Console.WriteLine("Tam eded daxil edin\n");
                                    goto case 1;
                                }
                                if (shop.AddSaleItems(productcode) == null)
                                {
                                    Console.WriteLine("\nDaxil etdiyiniz kodda mehsul tapilmadi satis ugursuz oldu");
                                labelexcp:
                                    Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                                    string WantToContinue11 = Console.ReadLine();
                                    if (WantToContinue11 != "y" && WantToContinue11 != "n")
                                    {
                                        goto labelexcp;
                                    }
                                    else if (WantToContinue11 == "y")
                                    {
                                        goto case 7;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        goto label22;
                                    }
                                }
                                else if (itemcount > shop.AddSaleItems(productcode).Count)
                                {
                                    Console.WriteLine("Daxil etdiyiniz say qeder mehsulumuz yoxdur");
                                labelexcp:
                                    Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                                    string WantToContinue12 = Console.ReadLine();
                                    if (WantToContinue12 != "y" && WantToContinue12 != "n")
                                    {
                                        goto labelexcp;
                                    }
                                    else if (WantToContinue12 == "y")
                                    {
                                        goto case 1;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        goto label22;
                                    }
                                }
                                else
                                {
                                    AddProduct addProduct1 = new AddProduct(itemcount, shop.AddSaleItems(productcode));
                                    addProducts.Add(addProduct1);
                                    goto label223;
                                }
                            }
                            else if (Input == "n")
                            {
                                SaleItems saleItems1 = new SaleItems(addProducts);
                                Sale sale1 = new Sale(saleItems1);
                                shop.AddSale(sale1);
                            }
                            Console.Clear();
                            Console.WriteLine("Emeliyyat bitdi");
                            AddProduct addProduct = new AddProduct();
                            goto label22;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        labelexcp:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue14 = Console.ReadLine();
                            if (WantToContinue14 != "y" && WantToContinue14 != "n")
                            {
                                goto labelexcp;
                            }
                            else if (WantToContinue14 == "y")
                            {
                                goto case 1;
                            }
                            else
                            {
                                goto label22;
                            }
                        }
                    case 2:
                        try
                        {
                            Console.Write("Satisin nomresini daxil edin: ");
                            int SaleNo;
                            string SaleNoStr = Console.ReadLine();
                            if (!Int32.TryParse(SaleNoStr, out SaleNo))
                            {
                                Console.WriteLine("Tam eded daxil edin\n");
                                goto case 2;
                            }
                            Console.Write("Satis mehsulunun nomresini qeyd edin: ");
                            int SaleItemNo;
                            string SaleItemNoStr = Console.ReadLine();
                            if (!Int32.TryParse(SaleItemNoStr, out SaleItemNo))
                            {
                                Console.WriteLine("Tam eded daxil edin\n");
                                goto case 2;
                            }
                            Console.Write("Qaytarmaq istediyiniz mehsulun sayini daxil edin: ");
                            int SaleItemCount;
                            string SaleItemCountStr = Console.ReadLine();
                            if (!Int32.TryParse(SaleItemCountStr, out SaleItemCount))
                            {
                                Console.WriteLine("Tam eded daxil edin\n");
                                goto case 2;
                            }
                            if (shop.sales.Find(s=>s.SaleNo==SaleNo)==null)
                            {
                                Console.WriteLine("\nDaxil etdiyiniz nomrede satis movcud deyil\n");
                                goto case 2;
                            }
                            var a = shop.sales.Find(s => s.SaleNo == SaleNo);
                            var b = a.SaleItems.prods.Find(p => p.ItemNo == SaleItemNo);
                            if (SaleItemCount>b.ItemCount)
                            {
                                Console.WriteLine("\ndaxil etdiyiniz say daxil etdiyiniz nomreli satis mehsulunda olan mehsulun sayinnan coxdur \n");
                                goto case 2;
                            }
                            shop.RemoveSaleItem(SaleNo, SaleItemNo, SaleItemCount);
                            Console.WriteLine("Emeliyyat bitdi");
                        labelexcp:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue15 = Console.ReadLine();
                            if (WantToContinue15 != "y" && WantToContinue15 != "n")
                            {
                                goto labelexcp;
                            }
                            else if (WantToContinue15 == "y")
                            {
                                goto case 2;
                            }
                            else
                            {
                                Console.Clear();
                                goto label22;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\nDaxil etdiyiniz nomreli satisda daxil etdiyiniz nomreli satis mehsulu movcud deyil");
                        labelexcp:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue16 = Console.ReadLine();
                            if (WantToContinue16 != "y" && WantToContinue16 != "n")
                            {
                                goto labelexcp;
                            }
                            else if (WantToContinue16 == "y")
                            {
                                goto case 2;
                            }
                            else
                            {
                                goto label22;
                            }
                        }
                    case 3:
                        try
                        {
                            Console.Write("\nSilinecek satisin nomresini daxil edin: ");
                            int RemoveSaleNo;
                            string RemoveSaleNoStr = Console.ReadLine();
                            if (!Int32.TryParse(RemoveSaleNoStr, out RemoveSaleNo))
                            {
                                Console.WriteLine("Tam eded daxil edin\n");
                                goto case 3;
                            }
                            shop.RemoveSale(RemoveSaleNo);
                            Console.WriteLine("Emeliyyat bitdi");
                        labelexcp:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue17 = Console.ReadLine();
                            if (WantToContinue17 != "y" && WantToContinue17 != "n")
                            {
                                goto labelexcp;
                            }
                            else if (WantToContinue17 == "y")
                            {
                                goto case 3;
                            }
                            else
                            {
                                Console.Clear();
                                goto label22;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Daxil etdiyiniz nomrede satis yoxdur");
                        labelexcp:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue18 = Console.ReadLine();
                            if (WantToContinue18 != "y" && WantToContinue18 != "n")
                            {
                                goto labelexcp;
                            }
                            else if (WantToContinue18 == "y")
                            {
                                goto case 3;
                            }
                            else
                            {
                                goto label22;
                            }
                        }
                    case 4:
                        Console.WriteLine();
                        if (shop.sales.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Satis olunmuyub");
                        }
                        shop.ShowSales();
                        goto label1;
                    case 5:
                        try
                        {
                            Console.Write("1-ci tarixi daxil edin (2012,12,12 kimi): ");
                            DateTime dateTime1;
                            string dateTime1str = Console.ReadLine();
                            if (!DateTime.TryParse(dateTime1str, out dateTime1))
                            {
                                Console.WriteLine("Tarix daxil edin\n");
                                goto case 5;
                            }
                            Console.Write("2-ci tarixi daxil edin (2012,12,12 kimi): ");
                            DateTime dateTime2;
                            string dateTime2str = Console.ReadLine();
                            if (!DateTime.TryParse(dateTime2str, out dateTime2))
                            {
                                Console.WriteLine("Tarix daxil edin\n");
                                goto case 5;
                            }
                            if (shop.ReturnSalesByDateRange(dateTime1, dateTime2).Count == 0)
                            {
                                Console.WriteLine("\nDaxil etdiyiniz araliqda satis tapilmadi");
                            labelexcp:
                                Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                                string WantToContinue19 = Console.ReadLine();
                                if (WantToContinue19 != "y" && WantToContinue19 != "n")
                                {
                                    goto labelexcp;
                                }
                                else if (WantToContinue19 == "y")
                                {

                                    goto case 5;
                                }
                                else
                                {
                                    Console.Clear();
                                    goto label22;
                                }
                            }
                            else
                            {
                                foreach (var item in shop.ReturnSalesByDateRange(dateTime1, dateTime2))
                                {
                                    Console.WriteLine($"Satis nomresi: {item.SaleNo}/ Satis meblegi: {item.SaleAmount}/ Satis mehsullarinin sayi(umumi): {item.SaleItemCounts}/ Satis tarixi:{item.SaleDate} ");
                                }
                            }

                            Console.WriteLine("\nEmeliyyat bitdi");
                        labelexcp2:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue20 = Console.ReadLine();
                            if (WantToContinue20 != "y" && WantToContinue20 != "n")
                            {
                                goto labelexcp2;
                            }
                            else if (WantToContinue20 == "y")
                            {

                                goto case 3;
                            }
                            else
                            {
                                Console.Clear();
                                goto label22;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n" + e.Message);
                            goto case 5;
                        }
                    case 6:
                        try
                        {
                            Console.Write("1-ci meblegi daxil edin: ");
                            double SaleAmount1;
                            string SaleAmount1Str = Console.ReadLine();
                            if (!double.TryParse(SaleAmount1Str, out SaleAmount1))
                            {
                                Console.WriteLine("Eded daxil edin\n");
                                goto case 6;
                            }
                            Console.Write("2-ci meblegi daxil edin: ");
                            double SaleAmount2;
                            string SaleAmount2Str = Console.ReadLine();
                            if (!double.TryParse(SaleAmount2Str, out SaleAmount2))
                            {
                                Console.WriteLine("Eded daxil edin\n");
                                goto case 6;
                            }
                            if (shop.ReturnSalesBySaleAmountRange(SaleAmount1, SaleAmount2).Count == 0)
                            {
                                Console.WriteLine("\nDaxil etdiyiniz araliqda satis tapilmadi");
                            labelexcp3:
                                Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                                string WantToContinue21 = Console.ReadLine();
                                if (WantToContinue21 != "y" && WantToContinue21 != "n")
                                {
                                    goto labelexcp3;
                                }
                                else if (WantToContinue21 == "y")
                                {
                                    goto case 6;
                                }
                                else
                                {
                                    Console.Clear();
                                    goto label22;
                                }
                            }
                            foreach (var item in shop.ReturnSalesBySaleAmountRange(SaleAmount1, SaleAmount2))
                            {
                                Console.WriteLine($"Satis nomresi: {item.SaleNo}/ Satis meblegi: {item.SaleAmount}/ Satis mehsullarinin sayi: {item.SaleItemCounts}/ Satis tarixi:{item.SaleDate} ");
                            }
                            Console.WriteLine("\nEmeliyyat bitdi");
                        labelexcp2:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue22 = Console.ReadLine();
                            if (WantToContinue22 != "y" && WantToContinue22 != "n")
                            {
                                goto labelexcp2;
                            }
                            else if (WantToContinue22 == "y")
                            {
                                goto case 6;
                            }
                            else
                            {
                                Console.Clear();
                                goto label22;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        labelexcp2:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue23 = Console.ReadLine();
                            if (WantToContinue23 != "y" && WantToContinue23 != "n")
                            {
                                goto labelexcp2;
                            }
                            else if (WantToContinue23 == "y")
                            {
                                goto case 6;
                            }
                            else
                            {
                                goto label22;
                            }
                        }
                    case 7:
                        try
                        {
                            Console.Write("Satisin tarixini daxil edin (2020,12,12): ");
                            DateTime SaleDate;
                            string SaleDateStr = Console.ReadLine();
                            if (!DateTime.TryParse(SaleDateStr, out SaleDate))
                            {
                                Console.WriteLine("Tarix daxil edin\n");
                                goto case 7;
                            }
                            if (shop.ReturnSalesByDate(SaleDate).Count == 0)
                            {
                                Console.WriteLine("\nDaxil etdiyiniz tarixde satis tapilmadi");
                            labelexcp2:
                                Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                                string WantToContinue24 = Console.ReadLine();
                                if (WantToContinue24 != "y" && WantToContinue24 != "n")
                                {
                                    goto labelexcp2;
                                }
                                else if (WantToContinue24 == "y")
                                {
                                    goto case 7;
                                }
                                else
                                {
                                    Console.Clear();
                                    goto label22;
                                }
                            }
                            foreach (var item in shop.ReturnSalesByDate(SaleDate))
                            {
                                Console.WriteLine($"Satis nomresi: {item.SaleNo}/ Satis meblegi: {item.SaleAmount}/ Satis mehsullarinin sayi: {item.SaleItemCounts}/ Satis tarixi:{item.SaleDate} ");
                            }
                            Console.WriteLine("\nEmeliyyat bitdi");
                        labelexcp3:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue25 = Console.ReadLine();
                            if (WantToContinue25 != "y" && WantToContinue25 != "n")
                            {
                                goto labelexcp3;
                            }
                            else if (WantToContinue25 == "y")
                            {
                                goto case 7;
                            }
                            else
                            {
                                Console.Clear();
                                goto label22;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        labelexcp2:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue26 = Console.ReadLine();
                            if (WantToContinue26 != "y" && WantToContinue26 != "n")
                            {
                                goto labelexcp2;
                            }
                            else if (WantToContinue26 == "y")
                            {
                                goto case 7;
                            }
                            else
                            {
                                goto label22;
                            }
                        }
                    case 8:
                        try
                        {
                            Console.Write("\nSatis nomresini daxil edin: ");
                            int SaleNo;
                            string SaleNoStr = Console.ReadLine();
                            if (!Int32.TryParse(SaleNoStr, out SaleNo))
                            {
                                Console.WriteLine("Tarix daxil edin\n");
                                goto case 8;
                            }
                            var a = shop.ReturnSaleBySaleNo(SaleNo);
                            Console.WriteLine($"Satis nomresi: {a.SaleNo}/ Satis meblegi: {a.SaleAmount}/ Satis mehsullarinin sayi: {a.SaleItemCounts}/ Satis tarixi: {a.SaleDate}");
                            foreach (var item in shop.ReturnSaleBySaleNo(SaleNo).SaleItems.prods)
                            {
                                Console.WriteLine($"Satis mehsulunun nomresi: {item.ItemNo}/ Mehsulun adi: { item.Product.Name}/ Mehsulun sayi: { item.ItemCount}");
                            }
                            Console.WriteLine("\nEmeliyyat bitdi");
                        labelexcp2:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue27 = Console.ReadLine();
                            if (WantToContinue27 != "y" && WantToContinue27 != "n")
                            {
                                goto labelexcp2;
                            }
                            else if (WantToContinue27 == "y")
                            {
                                goto case 8;
                            }
                            else
                            {
                                Console.Clear();
                                goto label22;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        labelexcp2:
                            Console.WriteLine("\nDavam etmek isteyirsiz: y/n");
                            string WantToContinue28 = Console.ReadLine();
                            if (WantToContinue28 != "y" && WantToContinue28 != "n")
                            {
                                goto labelexcp2;
                            }
                            else if (WantToContinue28 == "y")
                            {
                                goto case 8;
                            }
                            else
                            {
                                goto label22;
                            }
                        }
                    case 9:
                        Console.Clear();
                        goto label1;
                    default:
                        break;
                }
            }
            if (Choise == "3") goto labelEnd;
            labelEnd: Console.WriteLine("\nSistemden cixildi");
        }
    }
}
