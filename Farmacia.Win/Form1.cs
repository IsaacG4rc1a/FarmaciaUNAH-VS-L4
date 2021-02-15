using Farmacia.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Win
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void saludo_Click(object sender, EventArgs e)
		{
			var producto = new ProductosBL();
			var listaProductos = producto.ObtenerProducto();

			foreach (var prod in listaProductos)
			{
				MessageBox.Show(prod.description);
			}
		}
	}
}
