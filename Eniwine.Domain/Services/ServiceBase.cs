using Eniwine.Domain.Interfaces.Repositories;
using Eniwine.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eniwine.Domain.Services
{
	public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
	{
		#region Properties

		private readonly IRepositoryBase<TEntity> _repository;

		#endregion

		#region Methods

		public ServiceBase(IRepositoryBase<TEntity> repository)
		{
			_repository = repository;
		}
		public void Add(TEntity obj)
		{
			_repository.Add(obj);
		}
		public TEntity GetById(int id)
		{
			return _repository.GetById(id);
		}

		public TEntity GetById(Guid id)
		{
			return _repository.GetById(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _repository.GetAll();
		}
		public void Update(TEntity obj)
		{
			_repository.Update(obj);
		}

		public void Remove(TEntity obj)
		{
			_repository.Remove(obj);
		}

		public void Dispose()
		{
			_repository.Dispose();
		} 

		#endregion
	}
}
