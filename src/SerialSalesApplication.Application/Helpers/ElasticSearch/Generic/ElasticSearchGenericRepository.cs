using AutoMapper;
using Nest;
using SerialSales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application.Helpers.ElasticSearch.Generic
{
    public class ElasticSearchGenericRepository<Entity, AddDto, UpdateDto> : IElasticSearchGenericRepository<Entity, AddDto, UpdateDto> where Entity : BaseEntity where AddDto : Dtos.AddDto where UpdateDto : Dtos.UpdateDto
    {
        private readonly IElasticClient client;
        private readonly IMapper mapper;

        public ElasticSearchGenericRepository(IElasticClient client, IMapper mapper)
        {
            this.client = client;
            this.mapper = mapper;
            //
        }

        public async Task<Response<Entity>> Add(AddDto dto)
        {
            var entity = mapper.Map<Entity>(dto);
            var result = await client.CreateDocumentAsync<Entity>(entity);
            return Response<Entity>.Success(entity);
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<Entity>>> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<Response<UpdateDto>> Update(UpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
