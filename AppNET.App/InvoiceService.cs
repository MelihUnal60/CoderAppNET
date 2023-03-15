using AppNET.Domain.Entities;
using AppNET.Domain.Interfaces;
using AppNET.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.App
{
    public class InvoiceService : IInvoiceService
    {
        
        private readonly IRepository<Invoice> _repositoryInvoice;
        //private readonly CashService cashService;

        public InvoiceService()
        {
            _repositoryInvoice = IOCContainer.Resolve<IRepository<Invoice>>();
            //cashService = IOCContainer.Resolve<CashService>();
        }

        public bool DeleteInvoice(int invoiceId)
        {
           
          return _repositoryInvoice.Remove(invoiceId);
        }

        public IReadOnlyCollection <Invoice> GetInvoices()
        {
            return _repositoryInvoice.GetList().ToList().AsReadOnly();
        }

        public void SaveInvoice(int invoiceId, string docType, decimal price,string description)
        {
            if(string.IsNullOrEmpty(docType) || price == null)
                throw new ArgumentException("Lütfen işlem tipi ve fiyat alanlarını eksiksiz doldurunuz!!");
            
            var oldInvoiceId = _repositoryInvoice.GetList().FirstOrDefault(i => i.Id == invoiceId);
            if (oldInvoiceId != null)
                return;

            Invoice invoice = new Invoice();
            invoice.Id = invoiceId;
            invoice.DocType= docType;
            invoice.DocDate = DateTime.Now;
            invoice.Price = price;
            invoice.Description = description;
            _repositoryInvoice.Add(invoice);

            //cashService.SaveInvoiceToCash(invoice);
            //cashService.AddInvoiceToCashList(invoice);

        }

        
    }
}
