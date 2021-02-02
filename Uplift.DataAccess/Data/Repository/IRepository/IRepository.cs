using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        T Get(int id);

        //returns ordered list
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null, //will use LINQ operation for filtering
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,  //for order by -> IQueryable
            string includeProperties = null
            );

        //returns only one
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        //adding or removing entities
        void Add(T entity);

        void Remove(int id);

        void Remove(T entity);


    }
    

        
}
