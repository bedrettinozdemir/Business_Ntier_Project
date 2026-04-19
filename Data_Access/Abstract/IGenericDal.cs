using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access.Abstract
{
    public interface IGenericDal<T> where T : class
    {

        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> Getlist();
        T GetById(int id);
    }
}
