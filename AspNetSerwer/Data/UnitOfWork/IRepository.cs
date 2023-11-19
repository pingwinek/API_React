using System.Runtime.CompilerServices;

namespace AspNetSerwer.Data.UnitOfWork
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> FetchAll();
        IQueryable<TEntity> Query { get; }
        Task Add(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }
}
