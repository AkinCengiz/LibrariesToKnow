﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DependencyInversion;
public interface IProductRepository
{
    List<Product> GetList();
}
