namespace AssetManagenetAPI.Dtos
{
    public class AssetCreationDto
    {
        public string Type { get; set; } 
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SerialNumber { get; set; }
        public int TypeId { get; set; }

        public VehicleDataDto VehicleData { get; set; }
        public EquipmentDataDto EquipmentData { get; set; }
    }
}