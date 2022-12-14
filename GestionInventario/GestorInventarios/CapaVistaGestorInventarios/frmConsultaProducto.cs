using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaGestorInventarios
{
	public partial class frmConsultaProducto : Form
	{
		string texto = "";
		CapaControladorGestorInventarios.Controlador controlador = new CapaControladorGestorInventarios.Controlador();
		public frmConsultaProducto()
		{
			InitializeComponent();
			controlador.autocompletar(txtBusqueda,texto);
			DataTable tablaproveedores = new DataTable();
			tablaproveedores=controlador.LlenarProductos();
			dgvVistaPrevia.DataSource = tablaproveedores;
		}

		private void txtBusqueda_TextChanged(object sender, EventArgs e)
		{
			texto = txtBusqueda.Text;
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			consultarProductos();
		}

		private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;//elimina el sonido
				consultarProductos();
			}
		}
		public void consultarProductos()
		{
			texto = txtBusqueda.Text;
			lblProducto.Text = controlador.BuscaDato("inventariod", "nombre", "nombre", texto);
			lblPreciov.Text = "Precio Venta: " + controlador.BuscaDato("inventariod", "precio_venta", "nombre", texto);
			lblPrecioc.Text = "Precio Compra: " + controlador.BuscaDato("inventariod", "precio_compra", "nombre", texto);
			lblCantidad.Text = "Disponibilidad: " + controlador.BuscaDato("inventariod", "precio_venta", "nombre", texto);
			string idmarca = "";
			idmarca = controlador.BuscaDato("inventariod", "fk_marca", "nombre", texto);
			lblMarca.Text = "Marca: " + controlador.BuscaDato("marca", "nombre", "id_marca", idmarca);
			lblSerie.Text = "Serie: " + controlador.BuscaDato("inventariod", "serie", "nombre", texto);
			lblTituloProveedor.Text = "Proveedor (es):";
			string idproveedor = "";
			idproveedor = controlador.BuscaDato("inventariod", "fk_proveedores", "nombre", texto);

			DataTable proveedoresobtenidos = new DataTable();
			proveedoresobtenidos = controlador.ObtenerProveedores(idproveedor);
			string proveedores = "";

			for (int i = 0; i < proveedoresobtenidos.Rows.Count; i++)
			{
				if (i < proveedoresobtenidos.Rows.Count - 1)
				{
					proveedores = proveedores + proveedoresobtenidos.Rows[i][0] + ", ";
				}
				else
				{
					proveedores = proveedores + proveedoresobtenidos.Rows[i][0];
				}
			}

			lblListaProveedor.Text = proveedores;
		}

		private void dgvVistaPrevia_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				lblProducto.Text = dgvVistaPrevia.CurrentRow.Cells[0].Value.ToString();
				lblPreciov.Text = "Precio Venta: " + dgvVistaPrevia.CurrentRow.Cells[1].Value.ToString();
				lblPrecioc.Text = "Precio Compra: " + dgvVistaPrevia.CurrentRow.Cells[2].Value.ToString();
				lblCantidad.Text = "Disponibilidad: " + dgvVistaPrevia.CurrentRow.Cells[3].Value.ToString();
				lblMarca.Text = "Marca: " + dgvVistaPrevia.CurrentRow.Cells[4].Value.ToString();
				lblSerie.Text = "Serie: " + dgvVistaPrevia.CurrentRow.Cells[5].Value.ToString();
				lblTituloProveedor.Text = "Proveedores:";
				string idproveedor = "";
				idproveedor = controlador.BuscaDato("inventariod", "fk_proveedores", "nombre", lblProducto.Text);

				DataTable proveedoresobtenidos = new DataTable();
				proveedoresobtenidos = controlador.ObtenerProveedores(idproveedor);

				string proveedores = "";

				for (int i = 0; i < proveedoresobtenidos.Rows.Count; i++)
				{
					if (i < proveedoresobtenidos.Rows.Count - 1)
					{
						proveedores = proveedores + proveedoresobtenidos.Rows[i][0] + ", ";
					}
					else
					{
						proveedores = proveedores + proveedoresobtenidos.Rows[i][0];
					}
				}

				lblListaProveedor.Text = proveedores;
			}
			catch (Exception exc) { }
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			lblProducto.Text = "";
			lblPrecioc.Text = "";
			lblPreciov.Text = "";
			lblCantidad.Text = "";
			lblListaProveedor.Text = "";
			lblMarca.Text = "";
			lblSerie.Text = "";
			lblTituloProveedor.Text = "";
			txtBusqueda.Text = "";
		}
	}
}
