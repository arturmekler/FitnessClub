using AutoMapper;
using FitnessClub.DTO;
using FitnessClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessClub.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LoginDTO, User>();
            CreateMap<RegisterDTO, User>();
        }
    }
}
