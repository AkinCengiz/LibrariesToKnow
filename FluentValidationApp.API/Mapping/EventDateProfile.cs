using AutoMapper;
using FluentValidationApp.API.DTOs;
using FluentValidationApp.API.Models;

namespace FluentValidationApp.API.Mapping;

public class EventDateProfile : Profile
{
	public EventDateProfile()
	{
		CreateMap<EventDateDto, EventDate>()
			.ForMember(dest => dest.Date, opt => opt.MapFrom(src => new DateTime(src.Year, src.Month, src.Day)));
		CreateMap<EventDate, EventDateDto>()
			.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Date.Year))
			.ForMember(dest => dest.Month, opt => opt.MapFrom(src => src.Date.Month))
			.ForMember(dest => dest.Day, opt => opt.MapFrom(src => src.Date.Day));
	}
}
