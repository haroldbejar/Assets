using System.Collections.ObjectModel;
using AssetManagenetAPI.Data;
using AssetManagenetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetManagenetAPI.Repositories
{
    public class AssetRepository : IAssetRepository
    {
        private readonly AssetContext _context;
        public AssetRepository(AssetContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Asset asset)
        {
            _context.Assets.Add(asset);
            await _context.SaveChangesAsync();
        }

        public async Task<ReadOnlyCollection<Asset>> GetAllAsync()
        {
            var assets = await _context.Assets
                .Include(a => a.Type)
                .ToListAsync();

            return new ReadOnlyCollection<Asset>(assets);
        }
    }
}