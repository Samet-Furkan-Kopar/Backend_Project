using Core.DataAcces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        void Get(Func<object, bool> p);
    }
}
