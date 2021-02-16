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
		}
		public List<Product> ObtenerProducto()
		{
			_listProducts = _context.Productos.ToList();
			return _listProducts;
		}
	}
}
