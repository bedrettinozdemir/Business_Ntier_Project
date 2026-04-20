using Business_Layer.Abstract;
using Data_Access.Abstract;
using Data_Access.EntityFramework;
using Data_Access.Repostories;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {

            _categoryDal = categoryDal;
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> TGetlist()
        {
            return _categoryDal.Getlist();
        }

        public void TInsert(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }


}
