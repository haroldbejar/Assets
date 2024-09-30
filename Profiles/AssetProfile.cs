using AssetManagenetAPI.Dtos;
using AssetManagenetAPI.Models;
using AutoMapper;

namespace AssetManagenetAPI.Profiles
{
    public class AssetProfile : Profile
    {
        public AssetProfile()
        {
            CreateMap<Asset, AssetDto>();
            CreateMap<AssetDto, Asset>();
        }
    }
}