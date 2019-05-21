using Eniwine.Application.Interface;
using Eniwine.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Eniwine.Application
{
	public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
	{
		#region Properties

		private readonly IServiceBase<TEntity> _serviceBase;

		#endregion

		#region Methods

		public AppServiceBase(IServiceBase<TEntity> serviceBase)
		{
			_serviceBase = serviceBase;
		}

		public void Add(TEntity obj)
		{
			_serviceBase.Add(obj);
		}

		public TEntity GetById(int id)
		{
			return _serviceBase.GetById(id);
		}

		public TEntity GetById(Guid id)
		{
			return _serviceBase.GetById(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _serviceBase.GetAll();
		}
		public void Update(TEntity obj)
		{
			_serviceBase.Update(obj);
		}

		public void Remove(TEntity obj)
		{
			_serviceBase.Remove(obj);
		}

		public void Dispose()
		{
			_serviceBase.Dispose();
		}

		#endregion
	}
}
