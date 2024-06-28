﻿using Restaurantes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> Create(T  entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);

        Task<T> Get(int? id);
        Task<IEnumerable<T>> GetAll();

    }
}
