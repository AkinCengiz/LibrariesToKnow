using AutoMapper;
using FluentValidationApp.API.DTOs;
using FluentValidationApp.API.Models;

namespace FluentValidationApp.API.Mapping;

public class CustomerProfile : Profile
{
	public CustomerProfile()
	{
		CreateMap<Customer, CustomerDto>().ReverseMap();
	}
}
