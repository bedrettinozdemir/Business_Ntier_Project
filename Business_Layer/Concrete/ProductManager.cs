using Business_Layer.Abstract;
using Data_Access.Abstract;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Concrete
{
    public class ProductManager:IProductService

    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)

        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);

        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetlist()
        {
            return _productDal.Getlist();
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
