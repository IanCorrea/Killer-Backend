using System;

namespace Eniwine.Domain.Entities
{
	public class Misterio
	{
		#region Properties

		public Guid IdMisterio { get; set; }

		public int IdSuspeito { get; set; }

		public virtual Suspeito Suspeito { get; set; }

		public int IdArma { get; set; }

		public virtual Arma Arma { get; set; }

		public int IdLocal { get; set; }

		public virtual Local Local { get; set; }

		#endregion
	}
}
