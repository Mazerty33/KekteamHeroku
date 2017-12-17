using MongoDB.Bson.Serialization.Attributes;

namespace Backend.Models
{
    public class Gps
    {
        [BsonElement("lat")]
        public double Latitude { get; set; }

        [BsonElement("lng")]
        public double Longitude { get; set; }
    }
}