﻿using ETicaretAPI.Aplication.Repostories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repostories
{
    public class CustomerReadRepostory : ReadRepostory<Customer>, ICustomerReadRepostory
    {
        public CustomerReadRepostory(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
