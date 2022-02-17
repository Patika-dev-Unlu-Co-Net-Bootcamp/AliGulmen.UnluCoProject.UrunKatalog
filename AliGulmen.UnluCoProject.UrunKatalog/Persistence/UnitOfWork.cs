﻿using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UrunKatalogDbContext _context;

        public UnitOfWork(UrunKatalogDbContext context)
        {
            _context = context;
        }


        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}