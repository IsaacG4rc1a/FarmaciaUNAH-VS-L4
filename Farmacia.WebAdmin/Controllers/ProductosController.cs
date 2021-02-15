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
        // GET: Productos
        public ActionResult Index()
        {

			var productos = new ProductosBL();
			var listaProductos = productos.ObtenerProducto();

			return View(listaProductos);
        }
    }
}