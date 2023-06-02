﻿using AutoMapper;
using WebAPI.Models.Clases;
using WebAPI.Models.Dto;

namespace WebAPI.Models.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Waiters, WaitersDto>().ReverseMap();
        }
    }
}