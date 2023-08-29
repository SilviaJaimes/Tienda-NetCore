using APITienda.Dtos;
using AutoMapper;
using Core.Entities;

namespace APITienda.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Pais, PaisDto>().ReverseMap();
    }
}