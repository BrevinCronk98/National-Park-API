using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParkAPI.Models;

namespace NationalParkAPI.Controllers
{
    [Route("api/[controller]")]
    public class StatesController : ControllerBase
    {
        private readonly ParkAPIContext _db;
        
        public StatesController(ParkAPIContext db)
        {
            _db = db;
        }


        // GET api/States
        [HttpGet]
        public ActionResult<State> Get(int id)
        {
            var thisState = _db.States
                .Include(state => state.Parks)
                .ThenInclude(join.join.Park)
                .FirstOrDefault(state => state.StateId == id);

                return thisState;
        }

        // GET api/States/3
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<State>> Get(string stateName)
        {
            var query = _db.States.ASQueryable();
            If(stateName != null)
            {
                query = query.Where(entry => entry.StateName == stateName);
            }
            return query.ToList();
        }

        // POST api/States
        [HttpPost]
        public void Post([FromBody] State state)
        {
            _db.Locations.Add(state);
            _db.SaveChanges();
        }
        // No Need for PUT or DELETE. States will remain Constant
        
    }
}