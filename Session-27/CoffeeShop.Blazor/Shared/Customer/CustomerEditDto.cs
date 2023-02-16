﻿using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Blazor.Shared.Customer
{
    public class CustomerEditDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
