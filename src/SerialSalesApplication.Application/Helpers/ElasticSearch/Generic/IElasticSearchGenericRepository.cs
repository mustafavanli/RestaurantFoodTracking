using SerialSales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application.Helpers.ElasticSearch
{
    public interface IElasticSearchGenericRepository<Entity,AddDto,UpdateDto> where Entity:BaseEntity where AddDto : Dtos.AddDto where UpdateDto : Dtos.UpdateDto
    {
        public Task<Response<Entity>> Add(AddDto dto);
        public Task<bool> Delete(Guid id);
        public Task<Response<UpdateDto>> Update(UpdateDto dto);
        public Task<Response<List<Entity>>> GetList();
    }
}
