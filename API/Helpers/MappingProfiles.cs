using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities;
using API.Dtos;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d=>d.ProductBrand,s=>s.MapFrom(p=>p.ProductBrand.Name))
                .ForMember(d => d.ProductType, s => s.MapFrom(p => p.ProductType.Name))
                .ForMember(d=>d.PictureUrl,s=>s.MapFrom<ProductUrlResolver>());
        }
    }
}
