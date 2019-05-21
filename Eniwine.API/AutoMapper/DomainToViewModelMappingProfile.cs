using AutoMapper;
using Eniwine.Domain.Entities;
using EniwineAPI.ViewModels;

namespace EniwineAPI.AutoMapper
{
	public class DomainToViewModelMappingProfile : Profile
	{
		public override string ProfileName
		{
			get { return "ViewModelToDomainMappings"; }
		}

		public DomainToViewModelMappingProfile()
		{
			CreateMap<SuspeitoViewModel, Suspeito>();
			CreateMap<ArmaViewModel, Arma>();
			CreateMap<LocalViewModel, Local>();
			CreateMap<MisterioViewModel, Misterio>();
		}
	}
}