using AutoMapper;
using GLC.Domain.Entities;

namespace GLC.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
