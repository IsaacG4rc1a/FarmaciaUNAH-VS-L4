using Farmacia.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Farmacia.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {
		ProductosBL _productoBL;
		public ProductosController()
		{
			_productoBL = new ProductosBL();
		}
        // GET: Productos
        public ActionResult Index()
        {
			var listaProductos = _productoBL.ObtenerProducto();

			return View(listaProductos);
        }
    }
}