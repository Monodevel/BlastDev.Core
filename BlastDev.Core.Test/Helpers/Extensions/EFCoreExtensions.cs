using BlastDev.Core.Abstractions;
using BlastDev.Core.Models.Pager;
using Microsoft.EntityFrameworkCore;

namespace BlastDev.Core.Test.Helpers.Extensions
{
    public static class EFCoreExtensions
    {
        public static async Task<Pager<TEntity>> ToPageAsync<TEntity>(this IQueryable<TEntity> query, int currentPage, int pageSize) where TEntity : IEntityBase
        {
            if (currentPage < 1 || pageSize < 1)
                return default;

            var totalItems = await query.CountAsync();

            var skip = (currentPage - 1) * pageSize;

            var data = await query.Skip(skip).Take(pageSize).ToListAsync();

            return new Pager<TEntity>(totalItems, data, currentPage, pageSize);
        }

    }
}
