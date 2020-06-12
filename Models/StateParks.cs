using System.Collections.Generic;

namespace NationalParkAPI.Models
{
    public class StatePark
    {
        public int StateParkId { get; set; }
        public int StateId { get; set; }
        public int ParkId { get; set; }
        public Park Park { get; set; }
        public State State { get; set; }
    }
}