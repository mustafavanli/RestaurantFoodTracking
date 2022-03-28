using SerialSales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application.Interface.Mongo
{
    public interface IGenericRepository<Entity> where Entity : BaseEntity,new()
    {
        Task<List<Entity>> GetAllAsync(Expression<Func<Entity, bool>> filter = null);
        Task<Entity> GetAsync(Expression<Func<Entity, bool>> filter);
        Task<Entity> AddAsync(Entity entity);
        Task<Entity> UpdateAsync(Entity entity);
        Task<bool> DeleteAsync(Guid id);
    }
}
