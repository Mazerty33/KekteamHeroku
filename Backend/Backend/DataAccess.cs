using MongoDB.Driver;
using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using Microsoft.Extensions.Configuration;

namespace Backend
{
    public class DataAccess
    {
        MongoClient _client;
        IMongoDatabase _db;

        public DataAccess(IConfiguration config)
        {
            string connectionString = "mongodb://" + config["MongoDB:User"] + ':' + config["MongoDB:Password"] + '@' + config["MongoDB:Host"] + ':' + 44577 + '/' + config["MongoDB:Base"];
            _client = new MongoClient(connectionString);
            _db = _client.GetDatabase("cake");
        }

        public IEnumerable<Car> GetCars()
        {
            return _db.GetCollection<Car>("cars").Find(new BsonDocument()).ToList();
        }

        public Car GetCar(ObjectId id)
        {
            FilterDefinition<Car> filter = Builders<Car>.Filter.Where(c => c.Id == id);
            return _db.GetCollection<Car>("cars").Find(filter).First();
        }

        public Car Create(Car p)
        {
            _db.GetCollection<Car>("cars").InsertOne(p);
            return p;
        }

        public void Update(ObjectId id, Car p)
        {
            FilterDefinition<Car> filter = Builders<Car>.Filter.Where(c => c.Id == id);
            _db.GetCollection<Car>("cars").ReplaceOne(filter, p);
        }

        public void Remove(ObjectId id)
        {
            _db.GetCollection<Car>("cars").DeleteOne(c => c.Id == id);
        }
    }
}
