using System.Linq;
using AutoMapper;
using DateMatchApp.API.DTO;
using DateMatchApp.API.Models;

namespace DateMatchApp.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Load only match obj in User and UserForListDto
            CreateMap<User, UserForListDto>()
            // Mapping To Get Photo Url
                .ForMember(dest => dest.PhotoUrl, 
                    opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
            // Mapping To Get Age From Dateofbirth
                .ForMember(dest => dest.Age, 
                    opt => opt.MapFrom(
                    src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailedDto>()
                .ForMember(dest => dest.PhotoUrl, 
                    opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age, 
                    opt => opt.MapFrom(
                    src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotosForDetailedDto>();
            CreateMap<UserForUpdateDto, User>();
        }
    }
}