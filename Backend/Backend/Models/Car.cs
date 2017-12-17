using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Car
    {
        public ObjectId Id { get; set; }

        [BsonElement("brand")]
        public string Brand { get; set; }

        [BsonElement("model")]
        public string Model { get; set; }

        [BsonElement("horsePower")]
        public int HorsePower { get; set; }

        [BsonElement("price")]
        public int Price { get; set; }

        [BsonElement("color")]
        public string Color { get; set; }

        [BsonElement("nbDoors")]
        public int NbDoors { get; set; }

        [BsonElement("km")]
        public int Km { get; set; }

        [BsonElement("options")]
        public string Options { get; set; }

        [BsonElement("year")]
        public int Year { get; set; }

        [BsonElement("pollution")]
        public Pollution Pollution { get; set; }

        [BsonElement("store")]
        public Store Store { get; set; }

    }
}
