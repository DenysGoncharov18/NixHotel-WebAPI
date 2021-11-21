using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebApplication.DAL.EF;
using WebApplication.DAL.Interfaces;

namespace WebApplication.DAL.Repositories
{
    abstract class Repository<T> : IRepository<T> where T : class
    {
        protected HotelDbContext db;
        protected DbSet<T> dbSet;
        public Repository(HotelDbContext db, DbSet<T> dbSet)
        {
            this.db = db;
            this.dbSet = dbSet;
        }

        public IEnumerable<T> GetAll()
        {
            return this.dbSet;
        }
        public T Get(Guid id)
        {
            return this.dbSet.Find(id);
        }
        public void Create(T item)
        {
            this.dbSet.Add(item);
        }
        public void Update(T item)
        {
            this.db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void Delete(Guid id)
        {
            var item = Get(id);
            if (item != null)
            {
                this.dbSet.Remove(item);
            }
        }
    }
}
