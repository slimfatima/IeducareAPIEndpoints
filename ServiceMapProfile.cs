
using AutoMapper;
using IEduCare.Domain.DataModel;
using IEduCare.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace IEduCare.Service
{
    public class ServiceMapProfile : AutoMapper.Profile
    {
        public ServiceMapProfile()
        {          

            CreateMap<LicenseType, LicenseTypeDto>();
           
        }
    }
}
