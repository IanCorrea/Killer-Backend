using Eniwine.Application.Interface;
using Eniwine.Domain.Entities;
using Eniwine.Domain.Interfaces.Services;

namespace Eniwine.Application
{
	public class LocalAppService : AppServiceBase<Local>, ILocalAppService
	{
		#region Properties

		private readonly ILocalService _localService;

		#endregion

		#region Methods

		public LocalAppService(ILocalService localService)
			: base(localService)
		{
			_localService = localService;
		}

		#endregion
	}
}
