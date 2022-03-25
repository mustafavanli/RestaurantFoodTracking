using AutoMapper;
using SerialSales.Application.Helpers;
using SerialSales.Application.Interface.ElasticSearch;
using SerialSales.Application.Interface.Mongo;
using SerialSales.Application.Interface.Service;
using SerialSales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Application.Services
{
    public abstract class GenericService<Entity, AddDto, UpdateDto,MongoRepository, ElasticRepository> where Entity : BaseEntity, new() where AddDto : Application.Dtos.AddDto where UpdateDto : Application.Dtos.UpdateDto where 
        MongoRepository:IGenericRepository<Entity,AddDto,UpdateDto>
        where ElasticRepository : IElasticSearchGenericRepository<Entity,AddDto,UpdateDto>, IGenericService<Entity, AddDto, UpdateDto>
    {
        private readonly IMapper mapper;
        private readonly ElasticRepository elasticRepository;
        private readonly MongoRepository mongoRepository;
        
        public GenericService(IMapper mapper, ElasticRepository elasticRepository, MongoRepository mongoRepository)
        {
            this.mapper = mapper;
            this.elasticRepository = elasticRepository;
            this.mongoRepository = mongoRepository;

        }


        public virtual async Task<Response<Entity>> Add(AddDto dto)
        {
            try
            {
                var entity = mapper.Map<Entity>(dto);
                var result = await mongoRepository.AddAsync(dto);
                await elasticRepository.Add(result);
                return Response<Entity>.Success(result);
            }
            catch (Exception ex)
            {
                return Response<Entity>.Fail(ex.Message);
            }
        }

        public virtual async Task<Response<bool>> Delete(Guid id)
        {
            try
            {
                var entity = await mongoRepository.GetAsync(x=>x.Id == id);
                if (entity==null)
                {
                    return Response<bool>.Fail("Böyle bir entity bulunamadı!");
                }
                var result = await mongoRepository.DeleteAsync(id);
                //await elasticRepository.Delete(id);
                return Response<bool>.Success(result);
            }
            catch (Exception ex)
            {
                return Response<bool>.Fail(ex.Message);
            }
        }

        public virtual async Task<Response<List<Entity>>> GetAll()
        {
            try
            {
                var entities = await elasticRepository.GetList();
                //var entities = await mongoRepository.GetAllAsync();
                return Response<List<Entity>>.Success(entities);
            }
            catch (Exception ex)
            {
                return Response<List<Entity>>.Fail(ex.Message);
            }
        }
        public virtual async Task<Response<Entity>> GetById(Guid id)
        {
            try
            {
                //var entity = await mongoRepository.GetAsync(x=>x.Id == id);
                var entity = await elasticRepository.GetById(id);
                if (entity==null)
                {
                    return Response<Entity>.Fail($"böyle bir {typeof(Entity).Name} bulunamadı");

                }
                return Response<Entity>.Success(entity);
            }
            catch (Exception ex)
            {
                return Response<Entity>.Fail(ex.Message);
            }
        }

        public virtual async Task<Response<Entity>> Update(UpdateDto dto)
        {
            try
            {
                var entity = await mongoRepository.UpdateAsync(dto);
                var response = await elasticRepository.Update(dto);
                if (entity == null)
                {
                    return Response<Entity>.Fail($"böyle bir {typeof(Entity).Name} bulunamadı");
                }
                var upt = mapper.Map<Entity>(dto);
                return Response<Entity>.Success(entity);
            }
            catch (Exception ex)
            {
                return Response<Entity>.Fail(ex.Message);
            }
        }
    }
}
