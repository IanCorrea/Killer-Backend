using Eniwine.Domain.Entities;
using Eniwine.Domain.Interfaces.Repositories;
using Eniwine.Domain.Interfaces.Services;

namespace Eniwine.Domain.Services
{
	public class MisterioService : ServiceBase<Misterio>, IMisterioService
	{
		private readonly IMisterioRepository _misterioRepository;

		public MisterioService(IMisterioRepository misterioRepository)
			: base(misterioRepository)
		{
			_misterioRepository = misterioRepository;
		}
	}
}
