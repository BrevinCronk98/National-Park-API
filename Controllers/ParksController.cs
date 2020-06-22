using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NationalParkAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace NationalParkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {

        private ParkAPIContext _db;

        public ParksController(ParkAPIContext db)
        {
            _db = db;
        }


        // GET api/Parks
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get(string parkName, string parkLocation, string parkDescription, string parkFauna, string parkFlora)
        {
            var query = _db.Parks.AsQueryable();
            if(parkName != null)
            {
                query = query.Where(entry => entry.ParkName == parkName);
            }
            if(parkLocation != null)
            {
                query = query.Where(entry => entry.ParkLocation == parkLocation);
            }
           return query.ToList();
        }

        // GET api/Parks/5
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
           return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
        }

        // Get api/Parks/randompark
        [HttpGet("randompark")]
        public ActionResult<Park> GetRandom()
        {
            Random rand = new Random();
            int toSkip = rand.Next(0, _db.Parks.Count());
            return _db.Parks.OrderBy(r => Guid.NewGuid()).Skip(toSkip).Take(1).First();
        }

        // POST api/Parks/5
        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }

        // PUT api/Parks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park park)
        {
            park.ParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/Parks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            _db.Parks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}
