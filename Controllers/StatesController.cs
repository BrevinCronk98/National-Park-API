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

        [HttpGet]
        public ActionResult<State> Get(int id)
        {
            var thisState = _db.States
                .Include(state => state.Parks)
                .ThenInclude(join.join.Park)
                .FirstOrDefault(state => state.StateId == id);

                return thisState;
        }
        
    }
}