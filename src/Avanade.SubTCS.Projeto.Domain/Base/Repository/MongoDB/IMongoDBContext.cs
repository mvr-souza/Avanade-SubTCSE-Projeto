using MongoDB.Driver;

namespace Avanade.SubTCS.Projeto.Domain.Base.Repository.MongoDB
{
    public interface IMongoDBContext
    {
        IMongoCollection<TEntity> GetCollection<TEntity>(string collection);
    }
}
