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
	public partial class frmRecordatorios : Form
	{
		CapaControladorGestorInventarios.Global g = new CapaControladorGestorInventarios.Global();
		CapaControladorGestorInventarios.Controlador controlador = new CapaControladorGestorInventarios.Controlador();
		public frmRecordatorios()
		{
			InitializeComponent();

			string SQL1IM = "select inventariod.nombre as 'Producto', inventariod.cantidad as 'Existencias', inventariod.inventario_minimo as 'I.M.' from inventarioe,inventariod where inventariod.Fk_Encabezado = inventarioe.ID_Encabezado and inventarioe.Fk_Empresa='1' and inventariod.cantidad between inventario_minimo+1 and inventario_minimo+20;";
			DataTable IM1 = new DataTable();
			IM1 = controlador.CargarRecordatorio(SQL1IM);
			dgvIM1.DataSource = IM1;
			string SQL2IM = "select inventariod.nombre as 'Producto', inventariod.cantidad as 'Existencias', inventariod.inventario_minimo as 'I.M.' from inventarioe,inventariod where inventariod.Fk_Encabezado = inventarioe.ID_Encabezado and inventarioe.Fk_Empresa='1' and inventariod.cantidad = inventariod.inventario_minimo;";
			DataTable IM2 = new DataTable();
			IM2 = controlador.CargarRecordatorio(SQL2IM);
			dgvIM2.DataSource = IM2;
			string SQL3IM = "select inventariod.nombre as 'Producto', inventariod.cantidad as 'Existencias', inventariod.inventario_minimo as 'I.M.' from inventarioe,inventariod where inventariod.Fk_Encabezado = inventarioe.ID_Encabezado and inventarioe.Fk_Empresa='1' and inventariod.cantidad < inventariod.inventario_minimo;";
			DataTable IM3 = new DataTable();
			IM3 = controlador.CargarRecordatorio(SQL3IM);
			dgvIM3.DataSource = IM3;
		}

		private void dgvIM1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}