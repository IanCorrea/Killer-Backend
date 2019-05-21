using Eniwine.Domain.Entities;
using Eniwine.Domain.Interfaces.Repositories;
using Eniwine.Domain.Interfaces.Services;

namespace Eniwine.Domain.Services
{
	public class SuspeitoService : ServiceBase<Suspeito>, ISuspeitoService
	{
		private readonly ISuspeitoRepository _suspeitoRepository;

		public SuspeitoService(ISuspeitoRepository suspeitoRepository)
			: base(suspeitoRepository)
		{
			_suspeitoRepository = suspeitoRepository;
		}
	}
}
