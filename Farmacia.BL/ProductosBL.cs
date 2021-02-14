using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.BL
{
	public class ProductosBL
	{
		public List<Product> ObtenerProducto()
		{
			Product prod1 = new Product();
			prod1.productId = 1;
			prod1.description = "Acetaminofén";
			prod1.purchasePrice = 30;
			prod1.salePrice = 35;
			prod1.expirationDate = DateTime.Now;
			prod1.stock = 1500;

			Product prod2 = new Product();
			prod2.productId = 2;
			prod2.description = "Predin";
			prod2.purchasePrice = 30;
			prod2.salePrice = 80;
			prod2.expirationDate = DateTime.Now;
			prod1.stock = 200;

			var ListaProductos = new List<Product>();
			ListaProductos.Add(prod1);
			ListaProductos.Add(prod2);

			return ListaProductos;
		}
	}
}
