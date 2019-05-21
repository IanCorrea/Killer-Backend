using Eniwine.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Eniwine.Infra.Data.EntityConfig
{
	public class MisterioConfiguration : EntityTypeConfiguration<Misterio>
	{
		#region Methods

		public MisterioConfiguration()
		{
			HasKey(a => a.IdMisterio);

			HasRequired(a => a.Suspeito)
				.WithMany()
				.HasForeignKey(a => a.IdSuspeito);

			HasRequired(a => a.Arma)
				.WithMany()
				.HasForeignKey(a => a.IdArma);

			HasRequired(a => a.Local)
				.WithMany()
				.HasForeignKey(a => a.IdLocal);
		}

		#endregion
	}
}
