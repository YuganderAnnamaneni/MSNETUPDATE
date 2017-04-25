using System;
using ParkingSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    using System.Collections;
    using System.Runtime.CompilerServices;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to parking system console app, type help to get some help!");

            Console.WriteLine("Enter 1 to know Available Parking Slots in Floor No 1");
            Console.WriteLine("Enter 2 to know Available Parking Slots in Floor No 2");
            Console.WriteLine("Enter 3 to know Available Parking Slots in Floor No 3");

            var floors = GetFloors();

            while (true)
            {
                string input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "EXIT":
                        {
                            return;
                        }
                    case "HELP":
                        {
                            Console.WriteLine("- enter EXIT to exit this application");
                            Console.WriteLine("- 1 to know Available Parking Slots in Floor No 1");
                            Console.WriteLine("- 2 to know Available Parking Slots in Floor No 2");
                            Console.WriteLine("- 3 to know Available Parking Slots in Floor No 3");
                            break;
                        }
                    case "CLS":
                        {
                            Console.Clear();
                            break;
                        }
                    case "1":
                        {
                            try
                            {
                                var firstFloor = floors.SingleOrDefault(f => f.FloorNo == 1);
                                var availableSlots = firstFloor.Slots.Where(s => s.IsAvailable == true).ToList();

                                Console.WriteLine("Available Slots in Floor-1");
                                foreach (var slot in availableSlots)
                                {
                                    Console.WriteLine("Slot Id:" + slot.Name);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("!!! Parameter not valid");
                            }

                            break;
                        }
                    case "2":
                        {
                            try
                            {
                                var secondFloor = floors.SingleOrDefault(f => f.FloorNo == 2);
                                var availableSlots = secondFloor.Slots.Where(s => s.IsAvailable == true).ToList();

                                Console.WriteLine("Available Slots in Floor-2");
                                foreach (var slot in availableSlots)
                                {
                                    Console.WriteLine("Slot Id:" + slot.Name);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("!!! Parameter not valid");
                            }

                            break;
                        }

                    case "3":
                        {
                            try
                            {
                                var thirdFloor = floors.SingleOrDefault(f => f.FloorNo == 3);
                                var availableSlots = thirdFloor.Slots.Where(s => s.IsAvailable == true).ToList();

                                Console.WriteLine("Available Slots in Floor-3");
                                foreach (var slot in availableSlots)
                                {
                                    Console.WriteLine("Slot Id:" + slot.Name);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("!!! Parameter not valid");
                            }

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("!!! Bad command");
                            break;
                        }
                }
            }
        }

        public static List<Floor> GetFloors()
        {

            return new List<Floor>()
                       {
                           new Floor()
                               {
                                   Id = 1,
                                   Name = "P1 Floor",
                                   FloorNo = 1,
                                   Slots =  new List<ParkingSlot>()
                                                {
                                                    new ParkingSlot()
                                                        {
                                                            Id = 1,
                                                            Name = "P1 - 1",
                                                            IsAvailable =  false,
                                                            AllotedCar = new Car()
                                                                             {
                                                                                 Brand = "BMW",
                                                                                 MobileNumber = "1234567890",
                                                                                 RegistrationNo = "AP 01 KL 1234",
                                                                                 ParkingTime = DateTime.Now
                                                                             }
                                                        },
                                                    new ParkingSlot()
                                                        {
                                                            Id = 2,
                                                            Name = "P1 - 2",
                                                            IsAvailable = true
                                                        },
                                                    new ParkingSlot()
                                                        {
                                                            Id = 3,
                                                            Name = "P1 - 3",
                                                            IsAvailable = true
                                                        },
                                                    new ParkingSlot()
                                                        {
                                                            Id = 4,
                                                            Name = "P1 - 4",
                                                            IsAvailable = true
                                                        }
                                                }
                               },
                           new Floor()
                               {
                                   Id = 2,
                                   Name = "P2 Floor",
                                   FloorNo = 2,
                                   Slots =  new List<ParkingSlot>()
                                                {
                                                    new ParkingSlot()
                                                        {
                                                            Id = 1,
                                                            Name = "P2 - 1",
                                                            IsAvailable =  false,
                                                            AllotedCar = new Car()
                                                                             {
                                                                                 Brand = "BMW",
                                                                                 MobileNumber = "1134567890",
                                                                                 RegistrationNo = "AP 11 KL 1234",
                                                                                 ParkingTime = DateTime.Now
                                                                             }
                                                        },
                                                    new ParkingSlot()
                                                        {
                                                            Id = 2,
                                                            Name = "P2 - 2",
                                                            IsAvailable = true
                                                        },
                                                    new ParkingSlot()
                                                        {
                                                            Id = 3,
                                                            Name = "P2 - 3",
                                                            IsAvailable = true
                                                        },
                                                    new ParkingSlot()
                                                        {
                                                            Id = 4,
                                                            Name = "P2 - 4",
                                                            IsAvailable = true
                                                        }
                                                }
                               },
                           new Floor()
                               {
                                   Id = 3,
                                   Name = "P3 Floor",
                                   FloorNo = 3,
                                   Slots =  new List<ParkingSlot>()
                                                {
                                                    new ParkingSlot()
                                                        {
                                                            Id = 1,
                                                            Name = "P3 - 1",
                                                            IsAvailable =  false,
                                                            AllotedCar = new Car()
                                                                             {
                                                                                 Brand = "BMW",
                                                                                 MobileNumber = "1234567890",
                                                                                 RegistrationNo = "AP 01 KL 1234",
                                                                                 ParkingTime = DateTime.Now
                                                                             }
                                                        },
                                                    new ParkingSlot()
                                                        {
                                                            Id = 2,
                                                            Name = "P3 - 2",
                                                            IsAvailable = true
                                                        },
                                                    new ParkingSlot()
                                                        {
                                                            Id = 3,
                                                            Name = "P3 - 3",
                                                            IsAvailable = true
                                                        },
                                                    new ParkingSlot()
                                                        {
                                                            Id = 4,
                                                            Name = "P3 - 4",
                                                            IsAvailable = true
                                                        }
                                                }
                               }

                       };
        }
    }
}
