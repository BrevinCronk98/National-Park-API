using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace NationalParkAPI.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string ParkName { get; set; }
        public string ParkLocation { get; set; }
        public string ParkDescription { get; set; }
        public string ParkFauna { get; set; }
        public string ParkFlora { get; set; }
        public virtual ICollection<StatePark> States{ get; }

        public Park()
        {
            this.States = new HashSet<StatePark>();
            
        }
    }
}