﻿using EasyBanking.DataAccess;
using EasyBanking.Services.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyBanking.Services.Repository
{
    public class GenericServices<T> : IGenericServices<T> where T : class
    {

        protected readonly ApplicationDbContext Context;

        internal DbSet<T> dbSet;

        public GenericServices(ApplicationDbContext context)
        {
            Context = context;
            this.dbSet = context.Set<T>();
        }

        public async Task Add(T entity)
        {
          await  dbSet.AddAsync(entity);

        }

        public T Get(Guid id)
        {
            return dbSet.Find(id);
        }

     

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            //include properties will be comma seperated
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();

            }
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            //include properties will be comma seperated
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return query.FirstOrDefault();

        }

        public async Task Remove(Guid id)
        {
            T entityToRemove = await dbSet.FindAsync(id);
           await Remove(entityToRemove);
        }

        public async Task Remove(T entity)
        {
          dbSet.Remove(entity);
           
        }
    }
}  
