using System;
using System.Collections.Generic;

namespace Eniwine.Domain.Interfaces.Services
{
	public interface IServiceBase<TEntity> where TEntity : class
	{
		#region Methods

		void Add(TEntity obj);

		TEntity GetById(int id);

		TEntity GetById(Guid id);

		IEnumerable<TEntity> GetAll();

		void Update(TEntity obj);

		void Remove(TEntity obj);

		void Dispose(); 

		#endregion
	}
}
