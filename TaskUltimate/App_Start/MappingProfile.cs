using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskUltimate.Dtos;
using TaskUltimate.Models;

namespace TaskUltimate.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<TraineeVM, TraineeDto>();
            CreateMap<TraineeDto, TraineeVM>();
        }
    }
}