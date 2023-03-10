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
        public void SaveInvoiceToCash(Invoice invoice)
        {

            Cash cash = new Cash();

            if (invoice.DocType == "Gelir")
                cash.MoneyAmount += invoice.Price;
            else
                cash.MoneyAmount -= invoice.Price;
               
        }

    }
}
