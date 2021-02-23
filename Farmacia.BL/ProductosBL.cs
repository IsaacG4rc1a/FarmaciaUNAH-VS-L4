using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.BL
{
	public class ProductosBL
	{
		Context _context;
		public List<Product> _listProducts { get; set; }
		public ProductosBL()
		{
			_context = new Context();
			_listProducts = new List<Product>();
		}
		public List<Product> ObtenerProducto()
		{
			_listProducts = _context.Productos.ToList();
			return _listProducts;
		}

		public void GuardarProducto(Product producto)
		{
			if (producto.productId == 0)
			{
				_context.Productos.Add(producto);
			}
			_context.SaveChanges();
		}
	}
}
