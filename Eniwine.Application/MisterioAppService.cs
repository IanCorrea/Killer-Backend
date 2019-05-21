using Eniwine.Application.Interface;
using Eniwine.Domain.Entities;
using Eniwine.Domain.Interfaces.Services;

namespace Eniwine.Application
{
	public class MisterioAppService : AppServiceBase<Misterio>, IMisterioAppService
	{
		#region Properties

		private readonly IMisterioService _misterioService;

		#endregion

		#region Methods

		public MisterioAppService(IMisterioService misterioService)
			: base(misterioService)
		{
			_misterioService = misterioService;
		}

		#endregion
	}
}
