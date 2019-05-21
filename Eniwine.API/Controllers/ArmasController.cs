using AutoMapper;
using Eniwine.Application.Interface;
using Eniwine.Domain.Entities;
using EniwineAPI.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace Eniwine.API.Controllers
{
    public class ArmasController : ApiController
    {
		private readonly IArmaAppService _armaApp;

		public ArmasController(IArmaAppService armaApp)

		{
			_armaApp = armaApp;
		}

		// GET api/armas
		public IEnumerable<ArmaViewModel> Get()
		{
			var armaviewmodel = Mapper.Map<IEnumerable<Arma>, IEnumerable<ArmaViewModel>>(_armaApp.GetAll());
			return armaviewmodel;
		}
	}
}
