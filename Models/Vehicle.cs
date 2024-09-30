namespace AssetManagenetAPI.Models
{
    public class Vehicle : Asset
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string ChassisNumber { get; set; }
        public bool IsActive { get; set; }

    }
}