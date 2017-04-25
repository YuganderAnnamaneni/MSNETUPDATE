using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Models
{
    public class ParkingSlot
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsAvailable { get; set; }

        public Car AllotedCar { get; set; }

        public DateTime AllocatedTime { get; set; }
    }
}
