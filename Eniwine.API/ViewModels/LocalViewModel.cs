using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EniwineAPI.ViewModels
{
	public class LocalViewModel
	{
		#region Properties

		public int Id { get; set; }

		[DisplayName("Nome Suspeito")]
		[Required(ErrorMessage = "Preencha o campo Nome Completo")]
		[MaxLength(255, ErrorMessage = "Máximo {1} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {1} caracteres")]
		public string Nome { get; set; }

		//public virtual IEnumerable<MisterioViewModel> Misterios { get; set; }

		#endregion
	}
}