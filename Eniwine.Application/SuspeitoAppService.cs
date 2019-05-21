using Eniwine.Application.Interface;
using Eniwine.Domain.Entities;
using Eniwine.Domain.Interfaces.Services;

namespace Eniwine.Application
{
	public class SuspeitoAppService : AppServiceBase<Suspeito>, ISuspeitoAppService
	{
		#region Properties

		private readonly ISuspeitoService _suspeitoService;

		#endregion

		#region Methods

		public SuspeitoAppService(ISuspeitoService suspeitoService)
			: base(suspeitoService)
		{
			_suspeitoService = suspeitoService;
		}

		#endregion
	}
}
