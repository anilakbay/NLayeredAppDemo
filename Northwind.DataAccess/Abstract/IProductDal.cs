﻿using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<Product> GetAll(Expression<Func<Product, bool>> filter = null);
    }
}
