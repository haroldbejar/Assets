using AssetManagenetAPI.Models;

namespace AssetManagenetAPI.Services
{
    public interface IAssetService
    {
        Task AddAsync(Asset asset);
        Task<IReadOnlyCollection<Asset>> GetAllAsync();
    }
}