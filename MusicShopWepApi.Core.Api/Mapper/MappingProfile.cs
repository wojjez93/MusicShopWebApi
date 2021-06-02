using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MusicShopWepApi.Core.Api.Dto;



namespace MusicShopWepApi.Core.Api.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MusicShopWebApi.Core.Domain.Entieties.Producer, ProducerDto>();
        }
    }
}
