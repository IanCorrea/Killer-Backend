using Eniwine.Domain.Entities;
using Eniwine.Domain.Interfaces.Repositories;
using Eniwine.Domain.Interfaces.Services;

namespace Eniwine.Domain.Services
{
	public class ArmaService : ServiceBase<Arma>, IArmaService
	{
		private readonly IArmaRepository _armaRepository;

		public ArmaService(IArmaRepository armaRepository)
			: base(armaRepository)
		{
			_armaRepository = armaRepository;
		}
	}
}
