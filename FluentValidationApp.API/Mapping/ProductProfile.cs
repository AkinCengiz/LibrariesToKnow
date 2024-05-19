using AutoMapper;
using FluentValidationApp.API.DTOs;
using FluentValidationApp.API.Models;

namespace FluentValidationApp.API.Mapping;

public class ProductProfile : Profile
{
	public ProductProfile()
	{
		CreateMap<Product, ProductDto>()
			.ForMember(dest => dest.Name, options => options.MapFrom(x => x.ProductName))
			.ForMember(dest => dest.StockAmount, opt => opt.MapFrom(x => x.Stock))
			.ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(x => x.Price)).ReverseMap();
	}
}
