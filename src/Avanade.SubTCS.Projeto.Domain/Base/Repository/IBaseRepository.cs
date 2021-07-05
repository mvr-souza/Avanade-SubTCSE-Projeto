﻿using Avanade.SubTCS.Projeto.Domain.Aggregates;
using System.Threading.Tasks;

namespace Avanade.SubTCS.Projeto.Domain
{
    public interface IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> FindById(TId id);
        
    }
}
