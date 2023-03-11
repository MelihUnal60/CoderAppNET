using AppNET.Domain.Entities;
using AppNET.Domain.Interfaces;
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

        public void SellProduct(string name,int stock,decimal price)
        {
            Product soldProduct = new Product();
            soldProduct.Name = name;
            soldProduct.Price = price;
            soldProduct.Stock = stock;
            if (ControlStockForSale(name, stock))
                _productsRepository.Remove(soldProduct);
            else
                throw new Exception("Satış işlemi gerçekleştirilemedi!!");

        }

        public bool ControlStockForSale(string saledProduct,int sellAmount)
        {
            Product productForSale = new Product();
            
            productForSale = _productsRepository.GetList().FirstOrDefault(p => p.Name== saledProduct);

            if (sellAmount < productForSale.Stock)
            {
                throw new Exception("En fazla" + " " + productForSale.Stock + " " + "ürün satılabilir!!");
                return false;
            }
            else
                return true;
        }
    }
}
