using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Models
{
    public class Floor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int FloorNo { get; set; }

        public IList<ParkingSlot> Slots { get; set; }

    }
}
