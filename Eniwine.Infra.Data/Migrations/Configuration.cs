namespace Eniwine.Infra.Data.Migrations
{
	using Eniwine.Domain.Entities;
	using System;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<Context.EniwineContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(Context.EniwineContext context)
		{
			context.Suspeitos.AddOrUpdate(a => a.Id,
				new Suspeito() { Id = 1, Nome = "Esqueleto" },
				new Suspeito() { Id = 2, Nome = "Khan" },
				new Suspeito() { Id = 3, Nome = "Darth Vader" },
				new Suspeito() { Id = 4, Nome = "Sideshow Bob" },
				new Suspeito() { Id = 5, Nome = "Coringa" },
				new Suspeito() { Id = 6, Nome = "Duende Verde" },
				new Suspeito() { Id = 7, Nome = "Zé do Caixão" },
				new Suspeito() { Id = 8, Nome = "Muh-Ha" },
				new Suspeito() { Id = 9, Nome = "Vetor" },
				new Suspeito() { Id = 10, Nome = "Bizarro" }

			);

			context.Armas.AddOrUpdate(a => a.Id,
			  new Arma() { Id = 1, Nome = "Cajado Devastador" },
			  new Arma() { Id = 2, Nome = "Phaser" },
			  new Arma() { Id = 3, Nome = "Peixeira" },
			  new Arma() { Id = 4, Nome = "Trezoitão" },
			  new Arma() { Id = 5, Nome = "Sabre de Luz" },
			  new Arma() { Id = 6, Nome = "Bomba" },
			  new Arma() { Id = 7, Nome = "Pistola de Peixe-Piranha" },
			  new Arma() { Id = 8, Nome = "Marreta" },
			  new Arma() { Id = 9, Nome = "Visão de Calor" },
			  new Arma() { Id = 10, Nome = "Anel do Poder" }
		  );

			context.Locais.AddOrUpdate(a => a.Id,
			  new Local() { Id = 1, Nome = "Etérnia" },
			  new Local() { Id = 2, Nome = "Vulcano" },
			  new Local() { Id = 3, Nome = "Tatooine" },
			  new Local() { Id = 4, Nome = "Springfield" },
			  new Local() { Id = 5, Nome = "Gotham" },
			  new Local() { Id = 6, Nome = "Nova York" },
			  new Local() { Id = 7, Nome = "Sibéria" },
			  new Local() { Id = 8, Nome = "Machu Picchu" },
			  new Local() { Id = 9, Nome = "Acre" },
			  new Local() { Id = 10, Nome = "São Paulo" }
		  );

			MysteryPossibilities(context);

			context.SaveChanges();
		}

		private void MysteryPossibilities(Context.EniwineContext context)
		{
			for (int s = 1; s <= 10; s++)
			{
				for (int a = 1; a <= 10; a++)
				{
					for (int l = 1; l <= 10; l++)
					{
						context.Misterios.AddOrUpdate(m => m.IdMisterio,
							new Misterio() { IdMisterio = new Guid(), IdSuspeito = s, IdArma = a, IdLocal = l }
						);
					}
				}
			}
		}
	}
}
