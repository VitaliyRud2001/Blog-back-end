using Application.Dtos;
using AutoMapper;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserInformationDto>();
        }
    }
}
