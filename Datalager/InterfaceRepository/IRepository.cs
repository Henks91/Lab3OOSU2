using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace DataLayer.InterfaceRepository
{
    public interface IRepository<T> where T : class
    {

        // Create Read Update Delete (CRUD)

        // Create
        T Add(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);

        // Read
        T Find(int id);
        T FirstOrDefault(Func<T, bool> predicate);
        IEnumerable<T> Find(Func<T, bool> predicate);
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null!,
                           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null!,
                           params Expression<Func<T, object>>[] includes);
        IEnumerable<T> Query(Func<IQueryable<T>, IQueryable<T>> query);

        // Update
        void Update(T entity);
        T Update(T oldEntity, T newEntity);
        void UpdateRange(IEnumerable<T> entities);

        // Delete
        void Delete(int id);
        T Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);


        //T Get(int id);
        //IEnumerable<T> GetAll();
        //IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        //void Add(T entity);
        //void AddRange(IEnumerable<T> entities);

        //void Remove(T entity);
        //void RemoveRange(IEnumerable<T> entities);
    }
}
