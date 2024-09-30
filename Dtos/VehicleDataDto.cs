using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagenetAPI.Dtos
{
    public class VehicleDataDto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string ChassisNumber { get; set; }
        public bool IsActive { get; set; }
    }
}