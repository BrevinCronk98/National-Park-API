using System.Collections.Generic;

namespace NationalParkAPI.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public virtual ICollection<StatePark> Parks { get; }

        public State()
        {
            this.Parks = new HashSet<StatePark>();
        }
    }
}