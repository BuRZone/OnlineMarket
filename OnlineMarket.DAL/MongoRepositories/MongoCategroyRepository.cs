using MongoDB.Driver;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.MongoRepositories
{
    public class MongoCategroyRepository : IBaseRepository<Category>
    {
        private readonly MongoClient _mongoClient;
        public MongoCategroyRepository()
        {
            _mongoClient = new MongoClient();
        }
        public async Task CreateAsync(Category entity)
        {
            var db = _mongoClient.GetDatabase("OnlineMarketMongoDb");
            var collection = db.GetCollection<Category>("Categories");
            if (await collection.CountDocumentsAsync("{}") == 0)
            {
                await collection.InsertManyAsync(new List<Category>
                    {
                    new Category { Id = 1, CategoryName = "Action" },
                    new Category { Id = 2, CategoryName = "SciFi" },
                    new Category { Id = 3, CategoryName = "History" }
                    });
            }
            using var cursor = await collection.FindAsync("{}");
            var result = cursor.ToList();
            var id = result.Select(c => c.Id).ToList().Max();
            entity.Id = id + 1;
            await collection.InsertOneAsync(entity);

        }

        public Task Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetAsync()
        {
            var db = _mongoClient.GetDatabase("OnlineMarketMongoDb");
            var collection = db.GetCollection<Category>("Categories");

            return collection.AsQueryable();
        }

        public Task UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
