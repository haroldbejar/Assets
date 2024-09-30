using AssetManagenetAPI.Dtos;
using AssetManagenetAPI.Models;

namespace AssetManagenetAPI.Factory
{
    public interface IAssetFactory
    {
        Asset CreateAsset(AssetCreationDto assetDto);
    }
}