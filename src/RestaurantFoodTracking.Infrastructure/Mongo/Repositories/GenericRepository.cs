﻿using AutoMapper;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SerialSales.Application.Interface.Mongo;
using SerialSales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SerialSales.Infrastructure.Mongo.Repositories
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : BaseEntity,new()
    {
        private readonly IMongoCollection<Entity> Collection;
        public GenericRepository(MongoOptions options, IMapper mapper)
        {
            var client = new MongoClient(options.ConnectionString);
            var db = client.GetDatabase(options.Database);
            this.Collection = db.GetCollection<Entity>(typeof(Entity).Name);
        }

        public async Task<Entity> AddAsync(Entity entity)
        {
            await Collection.InsertOneAsync(entity);
            return entity;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            await Collection.FindOneAndDeleteAsync(x => x.Id == id);
            return true;
        }

        public async Task<Entity> GetAsync(Expression<Func<Entity, bool>> filter)
        {
            return await Collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<List<Entity>> GetAllAsync(Expression<Func<Entity, bool>> filter = null)
        {
            return await Collection.Find(x => true).ToListAsync<Entity>();
        }

        public async Task<Entity> UpdateAsync(Entity entity)
        {
            var result = await Collection.FindOneAndReplaceAsync(x => x.Id == entity.Id, entity);
            return entity;
        }
    }
}