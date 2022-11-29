using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);//hata olursa bu satırda idataresult yoktu
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
