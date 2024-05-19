using AutoMapper;
using FluentValidationApp.API.DTOs;
using FluentValidationApp.API.Models;

namespace FluentValidationApp.API.Mapping;

public class CategoryProfile : Profile
{
	public CategoryProfile()
	{
		CreateMap<Category, CategoryDto>().ReverseMap();
	}
}
