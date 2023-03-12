using AppNET.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.Domain.Entities
{
    public sealed class Product:AuditEntity
    {
        public string Name { get; set; }

        public int Stock { get; set; }

        public string CategoryName { get; set; }

        public decimal BuyPrice { get; set; }

        public decimal SellPrice { get; set; }
        //public int CategoryId { get; set; }
    }
}
