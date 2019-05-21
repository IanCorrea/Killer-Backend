using Eniwine.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Eniwine.Infra.Data.EntityConfig
{
	public class SuspeitoConfiguration : EntityTypeConfiguration<Suspeito>
	{
		#region Methods

		public SuspeitoConfiguration()
		{
			HasKey(a => a.Id);

			Property(a => a.Nome)
				.IsRequired()
				.HasMaxLength(255);
		}

		#endregion
	}
}
