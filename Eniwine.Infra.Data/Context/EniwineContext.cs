using Eniwine.Domain.Entities;
using Eniwine.Infra.Data.EntityConfig;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Eniwine.Infra.Data.Context
{
	public class EniwineContext : DbContext
	{
		public EniwineContext()
		  : base("Eniwine")
		{

		}
		public DbSet<Suspeito> Suspeitos { get; set; }

		public DbSet<Arma> Armas { get; set; }

		public DbSet<Local> Locais { get; set; }

		public DbSet<Misterio> Misterios { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();			

			modelBuilder.Properties()
				.Where(p => p.Name == p.ReflectedType.Name + "Id")
				.Configure(p => p.IsKey());

			modelBuilder.Properties<string>()
				.Configure(p => p.HasColumnType("varchar"));

			modelBuilder.Properties<string>()
				.Configure(p => p.HasMaxLength(100));

			modelBuilder.Configurations.Add(new SuspeitoConfiguration());
			modelBuilder.Configurations.Add(new ArmaConfiguration());
			modelBuilder.Configurations.Add(new LocalConfiguration());
			modelBuilder.Configurations.Add(new MisterioConfiguration());

			modelBuilder.Entity<Misterio>().Property(x => x.IdMisterio).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			base.OnModelCreating(modelBuilder);
		}

		public override int SaveChanges()
		{
			//foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
			//{
			//	if (entry.State == EntityState.Added)
			//	{
			//		entry.Property("DataCadastro").CurrentValue = DateTime.Now;
			//	}

			//	if (entry.State == EntityState.Modified)
			//	{
			//		entry.Property("DataCadastro").IsModified = false;
			//	}
			//}
			return base.SaveChanges();
		}
	}
}
