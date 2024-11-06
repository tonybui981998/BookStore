﻿using System.Linq.Expressions;

namespace BookStore.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // T-Category
        IEnumerable<T> GetAll();
        T GetFirstOrDefault();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        //void Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entity);

    }
}
