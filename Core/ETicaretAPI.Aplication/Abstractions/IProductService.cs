﻿using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Aplication.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
