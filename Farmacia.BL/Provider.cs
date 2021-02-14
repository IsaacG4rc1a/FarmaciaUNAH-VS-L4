using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.BL
{
	public class Provider
	{
		public int provId { get; set; }
		public string providerName { get; set; }
		public string direction { get; set; }
		public string cellPhone { get; set; }
		public bool Activo { get; set; }

		public Provider()
		{
			Activo = true;
		}
	}
}
