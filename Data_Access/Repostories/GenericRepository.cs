using Data_Access.Abstract;
using Data_Access.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access.Repostories
{
    public class GenericRepository<T> : IGenericDal<T> where T: class
    {
        

        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new Context();
           
                return c.Set<T>().Find(id);
                c.SaveChanges();
            
        }

        public List<T> Getlist()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
