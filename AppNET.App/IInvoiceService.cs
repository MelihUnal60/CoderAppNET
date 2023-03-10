using AppNET.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.App
{
    public interface IInvoiceService
    {
        void SaveInvoice(int invoiceId, string docType, decimal price, string description);

        bool DeleteInvoice(int invoiceId);

        IReadOnlyCollection<Invoice> GetInvoices();

    }   
}
