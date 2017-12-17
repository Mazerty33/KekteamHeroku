using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using MongoDB.Bson;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Backend.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Cars")]
    public class CarsController : Controller
    {
        DataAccess objds;

        public CarsController(DataAccess d)
        {
            objds = d;
        }

        // GET: api/Cars
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return objds.GetCars();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/Cars/Search")]
        public IEnumerable<Car> SearchCars()
        {
            return null;
        }

        // POST: api/Cars
        [HttpPost]
        public void Post([FromBody]Car value)
        {
            objds.Create(value);
        }
        
        // PUT: api/Cars
        [HttpPut]
        public void Put([FromBody]JObject value)
        {
            ObjectId objid = ParseObjectId((JObject)value["id"]);
            Car car = value.ToObject<Car>();
            car.Id = objid;
            objds.Update(objid, car);
        }
        
        // DELETE: api/Cars
        [HttpDelete]
        public void Delete([FromBody] JObject id)
        {
            objds.Remove(ParseObjectId(id));
        }

        private static ObjectId ParseObjectId(JObject objId)
        {
            int timestamp = objId["timestamp"].ToObject<int>();
            int machine = objId["machine"].ToObject<int>();
            short pid = objId["pid"].ToObject<short>(); ;
            int increment = objId["increment"].ToObject<int>(); ;
            return new ObjectId(timestamp, machine, pid, increment);
        }

    }
}
