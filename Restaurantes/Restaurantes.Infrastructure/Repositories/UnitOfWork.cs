﻿using Restaurantes.Domain.Interfaces;
using Restaurantes.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        

        public async Task Commit()
        {
           await _context.SaveChangesAsync();
        }
    }
}
