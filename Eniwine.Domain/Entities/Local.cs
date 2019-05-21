
using System.Collections.Generic;

namespace Eniwine.Domain.Entities
{
	public class Local
	{
		#region Properties

		public int Id { get; set; }

		public string Nome { get; set; }

		public virtual IEnumerable<Misterio> Misterios { get; set; }

		#endregion
	}
}
