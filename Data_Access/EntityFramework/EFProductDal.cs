using Data_Access.Abstract;
using Data_Access.Repostories;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access.EntityFramework
{
    public class EFProductDal:GenericRepository<Product> , IProductDal
    {
    }
}
