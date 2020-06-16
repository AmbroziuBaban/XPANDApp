using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XPANDApp
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RobotForCreationDto, Robot>();
           
            CreateMap<DescriptionRobotDto, DescriptionRobot>();
            CreateMap<DescriptionRobot, DescriptionRobotDto>();

            CreateMap<DescriptionRobotForCreationDto, DescriptionRobot>();
            
            CreateMap<DescriptionDto, Description>();
            CreateMap<Description, DescriptionDto>();

            CreateMap<DescriptionForCreactionDto, Description>();

            CreateMap<PlanetForCreationDto, Planet>();
            
        }
    }
}
