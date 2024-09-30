namespace AssetManagenetAPI.Models
{
    public abstract class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SerialNumber { get; set; }
        public int TypeId { get; set; }
        public AssetType Type { get; set; }
    }
}