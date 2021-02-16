using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.BL
{
	public class Product
	{
		//Código
		public int productId { get; set; }
		//Descripción
		public string description { get; set; }
		//precio de compra
		public double purchasePrice { get; set; }
		//Precio de venta
		public double salePrice { get; set; }
		//Fecha de vencimiento
		public DateTime expirationDate { get; set; }
		//Existencias
		public int stock { get; set; }
		////Llave forane con tabla Categoria
		//public int cateId { get; set; }
		//public Category Categoria { get; set; }

		////Llave forane con tabla Presentación
		//public int presentId { get; set; }
		//public Presentation Presentacion { get; set; }

		////Llave forane con tabla Proveedor
		//public int provId { get; set; }
		//public Provider Proveedor { get; set; }

		//Campo de inactivo y activo
		public bool Active { get; set; }

		//Constructor Activo = True;
		public Product()
		{
			Active = true;
		}
	}
}
