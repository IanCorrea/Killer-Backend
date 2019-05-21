using Eniwine.Application.Interface;
using Eniwine.Domain.Entities;
using Eniwine.Domain.Interfaces.Services;

namespace Eniwine.Application
{
	public class ArmaAppService : AppServiceBase<Arma>, IArmaAppService
	{
		#region Properties

		private readonly IArmaService _armaService;

		#endregion

		#region Methods

		public ArmaAppService(IArmaService armaService)
			: base(armaService)
		{
			_armaService = armaService;
		}

		#endregion
	}
}
