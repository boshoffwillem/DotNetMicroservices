using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target
            _ = CreateMap<Platform, PlatformReadDto>();
            _ = CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
