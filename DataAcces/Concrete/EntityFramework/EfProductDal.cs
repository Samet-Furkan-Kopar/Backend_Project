using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using DataAcces.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public void Get(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
