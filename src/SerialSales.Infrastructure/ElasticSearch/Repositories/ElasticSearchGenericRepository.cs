using AutoMapper;
using Nest;
using SerialSales.Application.Interface.ElasticSearch;
using SerialSales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Infrastructure.ElasticSearch.Repositories
{
    public abstract class ElasticSearchGenericRepository<Entity, AddDto, UpdateDto> : IElasticSearchGenericRepository<Entity, AddDto, UpdateDto> where Entity : BaseEntity,new() where AddDto:Application.Dtos.AddDto where UpdateDto : Application.Dtos.UpdateDto
    {
        private readonly IElasticClient client;
        private readonly IMapper mapper;
        public abstract string IndexName { get; }


        public ElasticSearchGenericRepository(IElasticClient client, IMapper mapper)
        {
            this.client = client;
            this.mapper = mapper;

        }
        public async Task<bool> CreateIndexAsync()
        {
            if (!(await client.Indices.ExistsAsync(IndexName)).Exists)
            {
                await client.Indices.CreateAsync(IndexName, c =>
                {
                    c.Map<Entity>(p => p.AutoMap());
                    return c;
                });
            }
            return true;
        }
        public async virtual Task<Entity> Add(Entity entity)
        {
            var response = await client.CreateDocumentAsync(entity);

            if (!response.IsValid)
                throw new Exception(response.ServerError?.ToString(), response.OriginalException);

            return entity;
        }

        public async virtual Task<bool> Delete(Guid id)
        {
            await client.DeleteAsync<Entity>(new DocumentPath<Entity>(id));
            return true;
        }

        public async virtual Task<Entity> GetById(Guid id)
        {
            var response = await client.GetAsync<Entity>(id);
            var document = response.Source;
            return document;
        }

        public async virtual Task<List<Entity>> GetList()
        {
            var response = await client.SearchAsync<Entity>(x => x.Query(q => q.MatchAll()));
            var documents = response.Documents.ToList();
            return documents;
        }

        public async virtual Task<Entity> Update(Entity entity)
        {
            var result = await client.UpdateAsync<Entity>(entity.Id, u =>
                        u.Doc(entity).Index(IndexName));
            if (!result.IsValid)
            {
                throw new Exception(result.OriginalException.Message);
            }
            return entity;
        }
    }
}
