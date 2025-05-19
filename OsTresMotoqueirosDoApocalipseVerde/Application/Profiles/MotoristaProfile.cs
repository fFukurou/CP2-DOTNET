using AutoMapper;
using OsTresMotoqueirosDoApocalipseVerde.Application.DTOs;
using OsTresMotoqueirosDoApocalipseVerde.Domain.Entities;

namespace OsTresMotoqueirosDoApocalipseVerde.Application.Profiles
{
    public class MotoristaProfile : Profile
    {
        public MotoristaProfile()
        {
            CreateMap<CreateMotoristaDto, Motorista>();

            CreateMap<Motorista, ReadMotoristaDto>()
                .ForMember(dest => dest.Moto, opt => opt.MapFrom(src => src.Moto));

            CreateMap<UpdateMotoristaDto, Motorista>();
        }
    }
}
