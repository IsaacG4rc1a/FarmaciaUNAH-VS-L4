using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.BL
{
	public class Context: DbContext
	{
		public Context(): base("FarmaciaBD")
		{

		}
		public	DbSet<Product> Productos { get; set; }
	}
}
