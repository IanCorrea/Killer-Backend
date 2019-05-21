using Eniwine.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Eniwine.Infra.Data.EntityConfig
{
	public class LocalConfiguration : EntityTypeConfiguration<Local>
	{
		#region Methods

		public LocalConfiguration()
		{
			HasKey(a => a.Id);

			Property(a => a.Nome)
				.IsRequired()
				.HasMaxLength(255);
		}

		#endregion
	}
}
