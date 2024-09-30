using AssetManagenetAPI.Dtos;
using AssetManagenetAPI.Models;

namespace AssetManagenetAPI.Factory
{
    public class AssetFactory : IAssetFactory
    {
        public Asset CreateAsset(AssetCreationDto assetDto) 
        {
            return assetDto.Type.ToLower() switch
            {
                "Vehicle" => CreateVehicle(assetDto),
                "Equipment" => CreateEquipment(assetDto),
                _ => throw new ArgumentException("Invalid asset type")
            };
        }

        private Vehicle CreateVehicle(AssetCreationDto assetDto)
        {
            return new Vehicle
            {
                Name = assetDto.Name,
                Cost = assetDto.Cost,
                PurchaseDate = assetDto.PurchaseDate,
                SerialNumber = assetDto.SerialNumber,
                TypeId = assetDto.TypeId,
                Brand = assetDto.VehicleData.Brand,
                Model = assetDto.VehicleData.Model,
                Year = assetDto.VehicleData.Year,
                Color = assetDto.VehicleData.Color,
                ChassisNumber = assetDto.VehicleData.ChassisNumber,
                IsActive = assetDto.VehicleData.IsActive
            };
        }

        private Equipment CreateEquipment(AssetCreationDto assetDto)
        {
            return new Equipment
            {
                Name = assetDto.Name,
                Cost = assetDto.Cost,
                PurchaseDate = assetDto.PurchaseDate,
                SerialNumber = assetDto.SerialNumber,
                TypeId = assetDto.TypeId,
                WarrentyPerioInMonths = assetDto.EquipmentData.WarrentyPerioInMonths
            };
        }
    }
}