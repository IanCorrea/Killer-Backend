using AutoMapper;
using Eniwine.Application.Interface;
using Eniwine.Domain.Entities;
using EniwineAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Eniwine.API.Controllers
{
	public class DescubraoassassinoController : ApiController
	{
		private readonly IMisterioAppService _misteriooApp;

		public DescubraoassassinoController(IMisterioAppService misteriooApp)

		{
			_misteriooApp = misteriooApp;
		}

		// GET api/descubraoassassino
		public MisterioGuidViewModel Get()
		{
			var misterioViewModelList = Mapper.Map<IEnumerable<Misterio>, IEnumerable<MisterioViewModel>>(_misteriooApp.GetAll());

			Random random = new Random();

			var index = random.Next(misterioViewModelList.Count());
			var misterioGuid = misterioViewModelList.ElementAt(index).IdMisterio;

			MisterioGuidViewModel misterio = new MisterioGuidViewModel { MisterioId = misterioGuid };

			return misterio;
		}

		public IHttpActionResult Post(MisterioViewModel misterio)
		{
			var misterioViewModel = Mapper.Map<Misterio,
				MisterioViewModel>(_misteriooApp.GetById(misterio.IdMisterio));

			List<int> tryReturn = new List<int>();

			if (misterioViewModel != null)
			{
				if (misterio.IdSuspeito != misterioViewModel.IdSuspeito) tryReturn.Add(1);
				if (misterio.IdArma != misterioViewModel.IdArma) tryReturn.Add(3);
				if (misterio.IdLocal != misterioViewModel.IdLocal) tryReturn.Add(2);

				if (tryReturn.Count != 0 && tryReturn?.Count != null)
				{
					Random random = new Random();

					var index = random.Next(tryReturn.Count());
					return Ok(tryReturn.ElementAt(index));
				}
				else
				{
					return Ok(0);
				}
			}

			return NotFound();
		}
	}
}
