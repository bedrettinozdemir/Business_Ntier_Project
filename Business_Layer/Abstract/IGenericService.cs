using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Abstract
{
    public interface IGenericService<T> where T:class
    {

        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetlist();
        T TGetById(int id);
    }
}
