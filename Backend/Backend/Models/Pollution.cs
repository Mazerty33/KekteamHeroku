using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Pollution
    {
        [BsonElement("co2")]
        public Double? Co2 { get; set; }

        [BsonElement("co")]
        public Double? Co { get; set; }

        [BsonElement("nox")]
        public Double? Nox { get; set; }
    }
}
