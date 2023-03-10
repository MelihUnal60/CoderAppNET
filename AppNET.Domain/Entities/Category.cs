﻿using AppNET.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.Domain.Entities
{
    // kimse kalıtım alamasın=sealed
    public sealed class Category:BaseEntity
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
