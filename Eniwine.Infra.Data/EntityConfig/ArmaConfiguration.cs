using Eniwine.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Eniwine.Infra.Data.EntityConfig
{
	public class ArmaConfiguration : EntityTypeConfiguration<Arma>
	{
		#region Methods

		public ArmaConfiguration()
		{
			HasKey(a => a.Id);

			Property(a => a.Nome)
				.IsRequired()
				.HasMaxLength(255);
		}

		#endregion
	}
}
