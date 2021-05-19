using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    // Generic Class
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        // For Get all Data
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        // Get Perticular ID Data
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity);
        void Remove(int id);
        void Remove(T entity); // Other way to remove
        void RemoveRange(IEnumerable<T> entity); // Remove Complete Range of Entity


    }
}