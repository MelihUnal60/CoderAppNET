using AppNET.Domain.Entities;
using AppNET.Domain.Interfaces;
using AppNET.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using AppNET.Infrastructure.Controls;

namespace AppNET.App
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly CashService cashService;
        private readonly ILogService logService;

        public ProductService()
        {
            _productRepository = IOCContainer.Resolve<IRepository<Product>>();
            cashService = IOCContainer.Resolve<CashService>();
            logService= IOCContainer.Resolve<ILogService>();
            
        }
        public void Created(int id, string categoryName, string productName, int productStock,
            decimal buyPrice, decimal sellPrice)
        {
            if (string.IsNullOrWhiteSpace(productName))
            { logService.ErrorLog("HATA : ÜRÜN İSMİ BOŞ");
                throw new ArgumentException("Ürün İsmi Boş Olamaz");
            }
            var oldProductName = _productRepository.GetList().FirstOrDefault(p => p.Name == productName);
            if (oldProductName != null)
                return;

            Product product=new Product();
            product.Id = id;
            product.Name = MyExtensions.FirstLetterUppercase(productName);
            product.CategoryName =Convert.ToString(categoryName);
            product.CreatedDate = DateTime.Now;
            product.BuyPrice = buyPrice;
            product.SellPrice = sellPrice;
            product.Stock = productStock;
            _productRepository.Add(product);
            var savedProduct = _productRepository.GetList().FirstOrDefault(p => p.Id == id);
            cashService.SaveOutcome(savedProduct.BuyPrice, savedProduct.Stock, savedProduct.Name);
            logService.SuccessLog("BAŞARILI İŞLEM : ÜRÜN BAŞARIYLA OLUŞTURULDU.");
            
            
        }

        

        public bool Deleted(int productId)
        {
            logService.SuccessLog("BAŞARILI İŞLEM : ÜRÜN BAŞARIYLA SİLİNDİ.");
           return _productRepository.Remove(productId);
            
        }
 

        public IReadOnlyCollection<Product> GetAllProduct()
        {
            return _productRepository.GetList().ToList().AsReadOnly();
        }

        public Product Update(int productId,string categoryName, string newProductName,int stock,decimal buyPrice,decimal sellPrice)
        {
            if (string.IsNullOrWhiteSpace(newProductName))
                throw new ArgumentException("Ürün İsmi Boş Olamaz");

            Product product=new Product();
            product.Id=productId;
            product.Name = MyExtensions.FirstLetterUppercase(newProductName);
            product.CategoryName = categoryName;
            product.Stock = stock;
            product.BuyPrice = buyPrice;
            product.SellPrice = sellPrice;
            logService.SuccessLog("BAŞARILI İŞLEM : ÜRÜN BAŞARIYLA GÜNCELLENDİ.");
            return _productRepository.Update(productId, product);
            

        }

        public bool DeleteProductsByCategory(string categoryName)
        {
            var list = _productRepository.GetList().Where(x => x.CategoryName == categoryName).ToList();
            foreach (var item in list)
            {
                _productRepository.Remove(item.Id);
                logService.InfoLog("BİLGİ : ÜRÜN SİLİNDİ.");
            }
            
            return true;
        }

         
    }
}
