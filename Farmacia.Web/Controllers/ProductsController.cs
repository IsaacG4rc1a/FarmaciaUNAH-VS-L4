using Farmacia.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Farmacia.Web.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
			var productoBL = new ProductosBL();

			var listaProducto = productoBL.ObtenerProducto();

            return View(listaProducto);
        }
    }
}