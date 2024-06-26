﻿using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformProfiles : Profile
    {
        public PlatformProfiles()
        {
            //source -> target
            CreateMap<Platform,PlatformCreateDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }



    }
}
