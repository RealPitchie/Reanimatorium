using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Re.Core.Extensions
{
    public static class IncludeAllExtenxion
    {
        public static IQueryable<T> IncludeAll<T>(this IQueryable<T> queryable) where T : class
        {
            var type = typeof(T);
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var isVirtual = property.GetGetMethod().IsVirtual;
                if (isVirtual)
                {
                    queryable = queryable.Include(property.Name);
                }
            }
            return queryable;
        }
    }
}