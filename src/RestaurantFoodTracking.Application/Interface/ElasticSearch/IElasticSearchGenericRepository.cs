using SerialSales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application.Interface.ElasticSearch
{
    public interface IElasticSearchGenericRepository<Entity> where Entity:BaseEntity,new()
    {
        Task<Entity> Add(Entity dto);
        Task<bool> Delete(Guid id);
        Task<Entity> Update(Entity entity); 
        Task<List<Entity>> GetList();
        Task<Entity> GetById(Guid id);
        Task<bool> CreateIndexAsync();
    }
}
