using SerialSales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application.Interface.ElasticSearch
{
    public interface IElasticSearchGenericRepository<Entity,AddDto,UpdateDto> where Entity:BaseEntity,new() where AddDto : Application.Dtos.AddDto where UpdateDto : Application.Dtos.UpdateDto
    {
        string IndexName { get;}
        Task<Entity> Add(Entity dto);
        Task<bool> Delete(Guid id);
        Task<Entity> Update(UpdateDto dto);
        Task<List<Entity>> GetList();
        Task<Entity> GetById(Guid id);
        Task<bool> CreateIndexAsync();
    }
}
