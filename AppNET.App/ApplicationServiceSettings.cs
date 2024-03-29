﻿using AppNET.Domain.Entities;
using AppNET.Domain.Entities.LogAggregate;
using AppNET.Domain.Interfaces;
using AppNET.Infrastructure;
using AppNET.Infrastructure.EFCore;
using AppNET.Infrastructure.IOToTXT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.App
{

    // Form.Cs de bu class çağırılacak.Burada Infrastructure katmanındaki IOCContainer clasındaki Register metodunu çağırıp kayıt edilir.
    public class ApplicationServiceSettings
    {
        public static void RegisterAllService()
        {
            #region Temp
            //IOCContainer.Register("bir", 1);
            //IOCContainer.Register("bir", 11);
            //IOCContainer.Register("iki", 2);
            //IOCContainer.Register("üç", 3);
            //IOCContainer.Register("dört", 4); 
            #endregion

            IOCContainer.Register<IRepository<Category>>(()=>new TextFileRepository<Category>());
            IOCContainer.Register<IRepository<Product>>(()=> new TextFileRepository<Product>());
            IOCContainer.Register<IRepository<Invoice>>(() => new TextFileRepository<Invoice>());
            //IOCContainer.Register<IRepository<Category>>(() => new EFCoreRepository<Category>());
            IOCContainer.Register<ICategoryService>(()=> new CategoryService());
            IOCContainer.Register<IProductService>(() => new ProductService());
            IOCContainer.Register<IInvoiceService>(() => new InvoiceService());
            IOCContainer.Register<ShoppingService>(()=> new ShoppingService());
            IOCContainer.Register<CashService>(()=> new CashService());
            IOCContainer.Register<InvoiceService>(()=> new InvoiceService());
            IOCContainer.Register<ProductService>(()=> new ProductService());
            IOCContainer.Register<IRepository<Log>>(()=>new TextFileRepository<Log>());
            IOCContainer.Register<ILogService>(()=>new LogService());
            IOCContainer.Register<SendInfoMailService>(()=>new SendInfoMailService());
        }

        //public static IRepository<Category> Metod()
        //{
        //    return new TextFileRepository<Category>();
        //}
    }
}
