using AppNET.Domain.Entities;
using AppNET.Domain.Entities.Base;
using AppNET.Domain.Interfaces;
using AppNET.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.App
{
    public class CashService
    {
        private readonly InvoiceService invoiceService;
        private readonly IRepository<Invoice> _repositoryInvoice;

        public CashService()
        {
            invoiceService= IOCContainer.Resolve<InvoiceService>();
            _repositoryInvoice = IOCContainer.Resolve<IRepository<Invoice>>();
        }

        public void SaveInvoiceToCash(Invoice invoice)
        {

            Cash cash = new Cash();
            decimal shopPrice = invoice.Price;

            if (invoice.DocType == "Gelir")
                cash.MoneyAmount += (invoice.Price *  shopPrice);
            else
                cash.MoneyAmount -= (invoice.Price * shopPrice);
               
        }

        public List<Invoice> AddInvoiceToCashList(Invoice invoice)
        {
            Cash cash= new Cash();
            List<Invoice> listOfInvoice= new List<Invoice>();

            listOfInvoice.Add(invoice);

            return cash.Invoices = listOfInvoice;
        }

        public void SaveOutcome(decimal productPrice, int stock,string productName)
        {
            Invoice invoice = new Invoice();
            invoice.Description = productName + " " + "ürününden" + " " + stock + " " + "miktarda satın alındı.";
            invoice.Price = productPrice * stock;
            invoice.DocDate = DateTime.Now;
            invoice.DocType = "Gider";
            _repositoryInvoice.Add(invoice);
            
        }

        public void SaveIncome(decimal productPrice,int stock,string productName)
        {
            Invoice invoice= new Invoice();
            invoice.Description = productName + " " + "ürününden" + " " + stock + " " + "miktarda satıldı.";
            invoice.Price = productPrice * stock;
            invoice.DocDate = DateTime.Now;
            invoice.DocType = "Gelir";
           _repositoryInvoice.Add(invoice);
           
        }
    }
}
