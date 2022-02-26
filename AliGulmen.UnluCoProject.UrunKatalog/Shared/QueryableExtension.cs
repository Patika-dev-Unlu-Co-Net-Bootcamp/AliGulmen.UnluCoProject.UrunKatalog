﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Shared
{
    public static class QueryableExtension
    {
      
            public static async Task<PaginatedResult<T>> ToPaginatedListAsync<T>(this IQueryable<T> source, int pageNumber, int pageSize) where T : class
            {
                if (source == null) throw new Exception();
                pageNumber = pageNumber == 0 ? 1 : pageNumber;
                pageSize = pageSize == 0 ? 10 : pageSize;
                int count = await source.CountAsync();
                pageNumber = pageNumber <= 0 ? 1 : pageNumber;
                List<T> items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
                return PaginatedResult<T>.Success(items, count, pageNumber, pageSize);
            }

        
    }
}
