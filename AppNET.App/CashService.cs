using AppNET.Domain.Entities;
using AppNET.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.App
{
    public class CashService
    {
        public void SaveInvoiceToCash(Invoice invoice,int stock)
        {

            Cash cash = new Cash();
            Product product= new Product();
            product.Stock = stock;

            if (invoice.DocType == "Gelir")
                cash.MoneyAmount += (invoice.Price *  product.Stock);
            else
                cash.MoneyAmount -= (invoice.Price * product.Stock);
               
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
            SaveInvoiceToCash(invoice, stock);
            AddInvoiceToCashList(invoice);
        }

    }
}
