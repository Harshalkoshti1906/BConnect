using AutoMapper;
using Bconnect.data.Entity;
using Bconnect.service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BConnectService.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BusinessCard, BusinessCardViewModel>().ReverseMap();
            CreateMap<ResponseModel, ResponseViewModel>().ReverseMap();
        }
    }
}
