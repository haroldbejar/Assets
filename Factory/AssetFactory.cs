using AssetManagenetAPI.Dtos;
using AssetManagenetAPI.Models;

namespace AssetManagenetAPI.Factory
{
    public class AssetFactory : IAssetFactory
    {
        public Asset CreateAsset(AssetCreationDto assetDto) 
        {
            Asset asset;
            switch (assetDto.Type) 
            { 
                   case "Vehicle" :
                        asset = CreateVehicle(assetDto);
                        break;
                   case "Equipment" :
                        asset = CreateEquipment(assetDto);
                        break;
                   default:
                        throw new ArgumentException($"Invalid asset type: {assetDto.Type}");
            }

            return asset;
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