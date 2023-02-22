using FuelStation.Model;

namespace FuelStation.EF.Repositories
{
    public interface IEntityRepo<TEntity>
    {
        IList<TEntity> GetAll();
        TEntity? GetById(int id);
        void Create(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
