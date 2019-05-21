using Eniwine.Domain.Entities;
using Eniwine.Domain.Interfaces.Repositories;
using Eniwine.Domain.Interfaces.Services;

namespace Eniwine.Domain.Services
{
	public class LocalService : ServiceBase<Local>, ILocalService
	{
		private readonly ILocalRepository _localRepository;

		public LocalService(ILocalRepository localRepository)
			: base(localRepository)
		{
			_localRepository = localRepository;
		}
	}
}
