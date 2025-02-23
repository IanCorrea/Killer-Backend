﻿using Eniwine.Domain.Interfaces.Repositories;
using Eniwine.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Eniwine.Infra.Data.Repositories
{
	public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
	{
		#region Properties

		protected EniwineContext Db = new EniwineContext();

		#endregion

		#region Methods

		public void Add(TEntity obj)
		{
			Db.Set<TEntity>().Add(obj);
			Db.SaveChanges();
		}

		public TEntity GetById(int id)
		{
			return Db.Set<TEntity>().Find(id);
		}

		public TEntity GetById(Guid id)
		{
			return Db.Set<TEntity>().Find(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return Db.Set<TEntity>().ToList();
		}

		public void Update(TEntity obj)
		{
			Db.Entry(obj).State = EntityState.Modified;
			Db.SaveChanges();
		}

		public void Remove(TEntity obj)
		{
			Db.Set<TEntity>().Remove(obj);
			Db.SaveChanges();
		}

		public void Dispose()
		{
			Db.Dispose();
		}

		#endregion
	}
}
