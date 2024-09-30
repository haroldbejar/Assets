using System.Collections.ObjectModel;
using AssetManagenetAPI.Models;

namespace AssetManagenetAPI.Repositories
{
    public interface IAssetRepository
    {
        Task AddAsync(Asset asset);
        Task<ReadOnlyCollection<Asset>> GetAllAsync();
    }
}