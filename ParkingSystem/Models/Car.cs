using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Models
{
    public class Car
    {
        public string RegistrationNo { get; set; }

        public string Brand { get; set; }

        public DateTime ParkingTime { get; set; }

        public string MobileNumber { get; set; }
    }
}
