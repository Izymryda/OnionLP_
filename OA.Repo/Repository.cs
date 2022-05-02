using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace OA.Repo
{
    public class Repository<T> : IRepository<T> where T : BaseUserEntity
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();            
        }

        public T Get(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }
    }
}
