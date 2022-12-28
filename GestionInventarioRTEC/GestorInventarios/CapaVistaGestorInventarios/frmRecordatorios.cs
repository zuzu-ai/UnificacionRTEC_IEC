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

			string SQL1IM = "select nombre as 'Producto', cantidad as 'Existencias', inventario_minimo as 'I.M.' from inventariod where cantidad between inventario_minimo+1 and inventario_minimo+20;";
			DataTable IM1 = new DataTable();
			IM1 = controlador.CargarRecordatorio(SQL1IM);
			dgvIM1.DataSource = IM1;
			string SQL2IM = "select nombre as 'Producto', cantidad as 'Existencias', inventario_minimo as 'I.M.' from inventariod where cantidad = inventario_minimo;";
			DataTable IM2 = new DataTable();
			IM2 = controlador.CargarRecordatorio(SQL2IM);
			dgvIM2.DataSource = IM2;
			string SQL3IM = "select nombre as 'Producto', cantidad as 'Existencias', inventario_minimo as 'I.M.' from inventariod where cantidad < inventario_minimo;";
			DataTable IM3 = new DataTable();
			IM3 = controlador.CargarRecordatorio(SQL3IM);
			dgvIM3.DataSource = IM3;
		}
	}
}
