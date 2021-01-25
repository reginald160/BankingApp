﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EasyBanking.Services.IRepository
{
    public interface IGenericServices<T> where T : class
    {
        T Get(Guid id);

        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null);

        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null);

        void Add(T entity);

        void Remove(Guid id);
        void Remove(T entity);
    }
}
