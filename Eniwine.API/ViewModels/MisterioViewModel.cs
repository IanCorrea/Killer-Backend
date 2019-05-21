using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EniwineAPI.ViewModels
{
	public class MisterioViewModel
	{
		#region Properties

		public Guid IdMisterio { get; set; }

		[DisplayName("Criminoso")]
		[Required(ErrorMessage = "Selecione um Criminoso")]
		public int IdSuspeito { get; set; }

		//public virtual SuspeitoViewModel Suspeito { get; set; }

		[DisplayName("Arma")]
		[Required(ErrorMessage = "Selecione uma Arma")]
		public int IdArma { get; set; }

		//public virtual ArmaViewModel Arma { get; set; }

		[DisplayName("Local")]
		[Required(ErrorMessage = "Selecione um Local")]
		public int IdLocal { get; set; }

		//public virtual LocalViewModel Local { get; set; }

		#endregion
	}
}