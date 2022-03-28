using SerialSales.Application.Helpers;
using SerialSales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application.Interface.Service
{
    public interface IGenericService<Entity, AddDto, UpdateDto> where Entity : BaseEntity, new() where AddDto : Application.Dtos.AddDto where UpdateDto : Application.Dtos.UpdateDto
    {
        Task<Response<Entity>> Add(AddDto dto);
        Task<Response<Entity>> Update(Entity entity);
        Task<Response<bool>> Delete(Guid id);
        Task<Response<List<Entity>>> GetList();
        Task<Response<Entity>> GetById(Guid id);
    }
}
