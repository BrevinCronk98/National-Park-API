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

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
