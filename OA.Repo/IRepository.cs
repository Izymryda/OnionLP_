using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;

namespace OA.Repo
{
    public interface IRepository<T> where T:BaseUserEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
