using AutoMapper;
using Eniwine.Application.Interface;
using Eniwine.Domain.Entities;
using EniwineAPI.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace Eniwine.API.Controllers
{
    public class LocaisController : ApiController
    {
		private readonly ILocalAppService _localApp;

		public LocaisController(ILocalAppService localApp)

		{
			_localApp = localApp;
		}

		// GET api/locais
		public IEnumerable<LocalViewModel> Get()
		{
			var localviewmodel = Mapper.Map<IEnumerable<Local>, IEnumerable<LocalViewModel>>(_localApp.GetAll());
			return localviewmodel;
		}
	}
}