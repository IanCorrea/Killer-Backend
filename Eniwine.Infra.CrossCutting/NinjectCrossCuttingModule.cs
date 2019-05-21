using Eniwine.Application;
using Eniwine.Application.Interface;
using Eniwine.Domain.Interfaces.Repositories;
using Eniwine.Domain.Interfaces.Services;
using Eniwine.Domain.Services;
using Eniwine.Infra.Data.Repositories;
using Ninject.Modules;

namespace Eniwine.Infra.CrossCutting
{
	public class NinjectCrossCuttingModule : NinjectModule
	{
		public override void Load()
		{
			Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
			Bind<ISuspeitoAppService>().To<SuspeitoAppService>();
			Bind<IArmaAppService>().To<ArmaAppService>();
			Bind<ILocalAppService>().To<LocalAppService>();
			Bind<IMisterioAppService>().To<MisterioAppService>();

			Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
			Bind<ISuspeitoService>().To<SuspeitoService>();
			Bind<IArmaService>().To<ArmaService>();
			Bind<ILocalService>().To<LocalService>();
			Bind<IMisterioService>().To<MisterioService>();

			Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
			Bind<ISuspeitoRepository>().To<SuspeitoRepository>();
			Bind<IArmaRepository>().To<ArmaRepository>();
			Bind<ILocalRepository>().To<LocalRepository>();
			Bind<IMisterioRepository>().To<MisterioRepository>();
		}
	}
}
