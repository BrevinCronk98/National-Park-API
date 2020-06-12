using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParkAPI.Models;

namespace NationalParkAPI.Controllers
{
    [Route("api/StateParks")]
    [ApiController]

    public class JoinController : ControllerBase
    {
        private readonly ParkAPIContext _db;
        public JoinController(ParkAPIContext db)
        {
            _db = db;
        }

        // GET api/StateParks
        [HttpGet]
        public ActionResult<IEnumerable<StatePark>> Get(int stateId, int parkId)
        {
            var query = _db.StatePark.AsQueryable();
            if( stateId != 0)
            {
                query.Where(entry => entry.StateId == stateId);
            }
            if(parkId != 0)
            {
                query.Where(entry => entry.ParkId == parkId);
            }
            return query.ToList();
        }

        // GET api/StateParks/3
        [HttpGet("{id}")]
        public ActionResult<StatePark> Get(int id)
        {
            return _db.StatePark.FirstOrDefault(entry => entry.StateParkId == id);
        }

        // POST api/StateParks
        [HttpPost]
        public void Post([FromBody] StatePark statePark)
        {
            _db.StatePark.Add(statePark);
            _db.SaveChanges();
        }

        // PUT api/StateParks/6
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StatePark statePark)
        {
            statePark.StateParkId = id;
            _db.Entry(statePark).State = EntityState.Modified;
            _db.SaveChanges();
        }
        // DELETE api/StateParks/6
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var spToDelete = _db.StatePark.FirstOrDefault(entry => entry.StateParkId == id);
            _db.StatePark.Remove(spToDelete);
            _db.SaveChanges();
        }
    }
}