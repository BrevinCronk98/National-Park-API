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
            return _db.Parks.ToList();
        }

        // GET api/Parks/5
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
           return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
        }

        // POST api/Parks/5
        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
