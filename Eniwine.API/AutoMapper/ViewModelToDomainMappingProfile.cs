using AutoMapper;
using Eniwine.Domain.Entities;
using EniwineAPI.ViewModels;

namespace EniwineAPI.AutoMapper
{
	public class ViewModelToDomainMappingProfile : Profile
	{
		public override string ProfileName
		{
			get { return "DomainToViewModelMappings"; }
		}

		public ViewModelToDomainMappingProfile()
		{
			CreateMap<Suspeito, SuspeitoViewModel>();
			CreateMap<Arma, ArmaViewModel>();
			CreateMap<Local, LocalViewModel>();
			CreateMap<Misterio, MisterioViewModel>();
		}
	}
}