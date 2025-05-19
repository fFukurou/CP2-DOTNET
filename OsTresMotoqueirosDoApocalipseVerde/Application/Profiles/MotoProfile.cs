using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OsTresMotoqueirosDoApocalipseVerde.Application.DTOs;
using OsTresMotoqueirosDoApocalipseVerde.Domain.Entities;

namespace OsTresMotoqueirosDoApocalipseVerde.Application.Profiles
{
    public class MotoProfile : Profile
    {
        public MotoProfile()
        {
            CreateMap<CreateMotoDto, Moto>();
            CreateMap<Moto, ReadMotoDto>();
            CreateMap<UpdateMotoDto, Moto>();

        }
    }
}
