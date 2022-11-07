using HEG.Northwind.Core.Entities;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Core.Repository
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        int GetCount(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T GetLastIndex(Expression<Func<T, bool>> filter = null);
        List<T> TakeCount(int count, Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Delete(T entity);
        void AddRange(IEnumerable<T> entities);
        void AddRangeWithDelete(IEnumerable<T> Addentities, IEnumerable<T> Deleteentities);
        void DeleteRange(IEnumerable<T> entities);
        void DeleteWithCond(Expression<Func<T, bool>> filter = null);

        List<T> CacheGetList(IMemoryCache _IMemoryCache, int minute, bool Status);
        void CacheAdd(IMemoryCache _IMemoryCache, T entity);
        bool CacheRemove(IMemoryCache _IMemoryCache);
    }
}
