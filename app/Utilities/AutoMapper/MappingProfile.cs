using AutoMapper;
using domain.Dtos;
using domain.Models;

namespace app.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryDto>();
            CreateMap<SupplierCategory, SupplierCategoryDto>();
        }
    }
}
