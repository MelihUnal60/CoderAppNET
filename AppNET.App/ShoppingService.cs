using AppNET.Domain.Entities;
using AppNET.Domain.Interfaces;
using AppNET.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.App
{
    public class ShoppingService
    {
        private readonly IRepository<Product> _productsRepository;
        private readonly CashService cashService;
        private readonly ProductService productService;
        private readonly InvoiceService invoiceService;

        public ShoppingService()
        {
            _productsRepository = IOCContainer.Resolve<IRepository<Product>>();
            cashService = IOCContainer.Resolve<CashService>();
            productService= IOCContainer.Resolve<ProductService>();
            invoiceService= IOCContainer.Resolve<InvoiceService>();
        }

        public void SellProduct(string name,int stock,decimal price)
        {
            Product soldProduct = new Product();
            soldProduct.Name = name;
            soldProduct.SellPrice = price;
            soldProduct.Stock = stock;
            if (ControlStockForSale(name, stock))
            {

                var soldStock = _productsRepository.GetList().FirstOrDefault(p => p.Name == soldProduct.Name);
                soldStock.Stock -= soldProduct.Stock;
                soldStock.SellPrice = soldProduct.SellPrice;
                soldStock.UpdatedDate= DateTime.Now;
                _productsRepository.Update(soldStock.Id, soldStock);
                cashService.SaveIncome(price, stock, name);
            }
            else
                throw new Exception("Satış işlemi gerçekleştirilemedi!!");

        }

        public bool ControlStockForSale(string saledProduct,int sellAmount)
        {
            Product productForSale = new Product();
            
            productForSale = _productsRepository.GetList().FirstOrDefault(p => p.Name== saledProduct);

            if (sellAmount > productForSale.Stock)
            {
                throw new Exception("En fazla" + " " + productForSale.Stock + " " + "ürün satılabilir!!");
                return false;
            }
            else
                return true;
        }

        public void BuyProduct(string name,int stock,decimal price)
        {
            int shopPrice = ((int)(stock * price));
            Product boughtProduct = new Product();
            Invoice savedInvoice = new Invoice();
            boughtProduct = _productsRepository.GetList().FirstOrDefault(b =>b.Name == name);
            if (boughtProduct != null)
            {
                productService.Update(boughtProduct.Id, boughtProduct.CategoryName, name, boughtProduct.Stock + stock, price, boughtProduct.SellPrice);
                cashService.SaveOutcome(shopPrice, stock, name);
            }

            else
            {
                productService.Created(999, "Yeni eklenen ürün", name, stock, price, 999);
                
            }
            
            
            
            
        }
    }
}
