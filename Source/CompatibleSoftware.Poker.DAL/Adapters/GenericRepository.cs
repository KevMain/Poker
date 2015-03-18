using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using CompatibleSoftware.Poker.DAL.Context;
using CompatibleSoftware.Poker.Domain.Models;

namespace CompatibleSoftware.Poker.DAL.Adapters
{
    internal class GenericRepository<T> where T : BaseEntity
    {
        private readonly PokerContext _dbContext;

        public GenericRepository()
        {
            _dbContext = new PokerContext();
            _dbContext.Configuration.ProxyCreationEnabled = false;
            _dbContext.Configuration.LazyLoadingEnabled = false;
        }

        public IList<T> SelectAll()
        {
            return _dbContext.Set<T>().AsQueryable().ToList();
        }

        public T SelectById(int id)
        {
            return _dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public T Insert(T obj)
        {
            var newEntry = _dbContext.Set<T>().Add(obj);

            _dbContext.SaveChanges();

            return newEntry;
        }

        public void Update(T obj)
        {
            var entry = _dbContext.Entry(obj);
            _dbContext.Set<T>().Attach(obj);
            entry.State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> Find(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where<T>(expression).ToList();
        }
    }
}
