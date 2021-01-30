using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyBanking.Services.IRepository
{
    public interface IGenericServices<T> where T : class
    {
        T Get(Guid id);

        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null);

        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null);

        Task Add(T entity);

        Task Remove(Guid id);
        Task Remove(T entity);
    }
}
