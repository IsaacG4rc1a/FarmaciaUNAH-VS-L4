using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.BL
{
	public class Context: DbContext
	{
		public Context(): base(@"Data Source = (LocalDb)\MSSQLLocalDB; AttachDBFilename=" +
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ProyectoFarmacia.DB.mdf")
		{

		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
		public	DbSet<Product> Productos { get; set; }
	}
}
