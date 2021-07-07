using Avanade.SubTCS.Projeto.Domain;
using Avanade.SubTCS.Projeto.Domain.Aggregates;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Avanade.SubTCS.Projeto.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        private readonly IMongoCollection<TEntity> _collection;

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);
            return entity;
        }

        public virtual async Task<TEntity> FindById(TId id)
        {
            throw new System.NotImplementedException();
        }
    }
}
