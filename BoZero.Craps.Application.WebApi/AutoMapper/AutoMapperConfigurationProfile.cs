using AutoMapper;
using BoZero.Craps.Application.WebApi.Models;
using BoZero.Craps.Business.Core.Entities;

namespace BoZero.Craps.Application.WebApi.AutoMapper
{
	public class AutoMapperConfigurationProfile : Profile
	{
		public AutoMapperConfigurationProfile()
		{
			CreateMap<Roll, RollModel>();
		}
	}
}
