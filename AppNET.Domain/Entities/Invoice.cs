using AppNET.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.Domain.Entities
{
    public sealed class Invoice:BaseEntity
    {
        public string DocType { get; set; }

        public decimal Price { get; set; }

        public DateTime DocDate { get; set; }

        public string Description { get; set; }
    }
}
