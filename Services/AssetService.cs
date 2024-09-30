using AssetManagenetAPI.Models;
using AssetManagenetAPI.Repositories;

namespace AssetManagenetAPI.Services
{
    public class AssetService : IAssetService
    {
        private readonly IAssetRepository _repository;

        public AssetService(IAssetRepository repository)
        {
            _repository = repository;
        }
        public async Task AddAsync(Asset asset)
        {
           await _repository.AddAsync(asset);
        }

        public async Task<IReadOnlyCollection<Asset>> GetAllAsync()
        {
            return await _repository.GetAllAsync();

        }
    }
}