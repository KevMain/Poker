using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using CompatibleSoftware.Poker.DAL.Context;
using CompatibleSoftware.Poker.Domain.Models;

namespace CompatibleSoftware.Poker.DAL.Adapters
{
    /// <summary>
    /// Generic repo that handles basic CRUD for any object that has an ID field
    /// </summary>
    /// <typeparam name="T">The type of the object that inherits from BaseEntity</typeparam>
    public class GenericRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// The EF context
        /// </summary>
        private readonly PokerContext _dbContext;

        /// <summary>
        /// Main Constructor
        /// </summary>
        public GenericRepository()
        {
            _dbContext = new PokerContext();
            _dbContext.Configuration.ProxyCreationEnabled = false;
            _dbContext.Configuration.LazyLoadingEnabled = false;
        }

        /// <summary>
        /// Select all objects in the context
        /// </summary>
        /// <returns></returns>
        public IList<T> SelectAll()
        {
            return _dbContext.Set<T>().AsQueryable().ToList();
        }

        /// <summary>
        /// Select an object by Id
        /// </summary>
        /// <param name="id">The Id of the object</param>
        /// <returns>The matching object</returns>
        public T SelectById(int id)
        {
            return _dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Inserts a new object into the context
        /// </summary>
        /// <param name="obj">The object to insert</param>
        /// <returns>The added object</returns>
        public T Insert(T obj)
        {
            var newEntry = _dbContext.Set<T>().Add(obj);

            _dbContext.SaveChanges();

            return newEntry;
        }

        /// <summary>
        /// Updates an existing object in the context
        /// </summary>
        /// <param name="obj">The object to update</param>
        public void Update(T obj)
        {
            var entry = _dbContext.Entry(obj);
            _dbContext.Set<T>().Attach(obj);
            entry.State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Delete an object from the context
        /// </summary>
        /// <param name="id">The Id of the object to delete</param>
        public void Delete(int id)
        {
            var TObject = SelectById(id);
            _dbContext.Set<T>().Remove(TObject);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Find objects via an expression
        /// </summary>
        /// <param name="expression">The expression to use for filtering</param>
        /// <returns>A list of matching objects</returns>
        public IList<T> Find(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where<T>(expression).ToList();
        }
    }
}
