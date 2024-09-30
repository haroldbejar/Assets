using AssetManagenetAPI.Dtos;
using AssetManagenetAPI.Factory;
using AssetManagenetAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagenetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetService _service;
        private readonly IAssetFactory _factory;

        public AssetsController(IAssetService service, IAssetFactory factory)
        {
            _service = service;
            _factory = factory;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try 
            {
                var assets = await _service.GetAllAsync();
                return Ok(assets);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] AssetCreationDto assetDto)
        {
            try 
            {
                var asset = _factory.CreateAsset(assetDto);
                await _service.AddAsync(asset);
                return Ok(asset);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}