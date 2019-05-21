using AutoMapper;
using Eniwine.Application.Interface;
using Eniwine.Domain.Entities;
using EniwineAPI.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace Eniwine.API.Controllers
{
    public class CriminososController : ApiController
    {
		private readonly ISuspeitoAppService _suspeitoApp;

		public CriminososController(ISuspeitoAppService suspeitoApp)

		{
			_suspeitoApp = suspeitoApp;
		}

		// GET api/criminosos
		public IEnumerable<SuspeitoViewModel> Get()
		{
			var suspeitoviewmodel = Mapper.Map<IEnumerable<Suspeito>, IEnumerable<SuspeitoViewModel>>(_suspeitoApp.GetAll());
			return suspeitoviewmodel;
		}
	}
}
