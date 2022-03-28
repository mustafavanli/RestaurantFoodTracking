using RestaurantFoodTracking.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Application.Interface.ElasticSearch
{
    public interface IElasticSearchGenericRepository<Entity> where Entity:BaseEntity,new()
    {
        Task<Entity> AddAsync(Entity dto);
        Task<bool> DeleteAsync(Guid id);
        Task<Entity> UpdateAsync(Entity entity); 
        Task<List<Entity>> GetListAsync();
        Task<Entity> GetByIdAsync(Guid id);
        Task<bool> CreateIndexAsync();
    }
}
