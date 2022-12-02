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
	public partial class frmTransaccion : Form
	{
		CapaControladorGestorInventarios.Controlador controlador = new CapaControladorGestorInventarios.Controlador();
		CapaControladorGestorInventarios.Global g = new CapaControladorGestorInventarios.Global();
		public frmTransaccion()
		{
			InitializeComponent();

			controlador.bloqueareporte(g.obtienenombretusuario, btnImprimir);
			navegadorMantenimientos1.bloquearBtn(g.obtienenombretusuario);

			TextBox[] alias = navegadorMantenimientos1.ClasificaTextboxsegunParent(this);
			navegadorMantenimientos1.ObtenerCamposdeTabla(alias, "tipotransac", "RTEC_IEC");
			navegadorMantenimientos1.MetodoSalirVista(this);
			//navegador1.LlenarCombobox(cbxIDPuesto, "puesto", "pkIdPuesto", "nombre", "estado");
			//navegador1.LlenarCombobox(cbxIDEmpresa, "empresa", "idEmpresa", "nombre", "estatus");

			//inicio de elementos para dar de baja
			navegadorMantenimientos1.campoEstado = "Estado";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
			navegadorMantenimientos1.idAplicacion = "2016";
			navegadorMantenimientos1.idmodulo = "2";
			/* Inicio ID Aplicacion usada para reportes y ayudas */

			//inicio de elementos para ejecutar la ayuda
			navegadorMantenimientos1.tablaAyuda = "Aplicacion";
			navegadorMantenimientos1.campoAyuda = "pkId";
			//fin de elementos para ejecutar la ayuda


			// Inicio datos para ejecurar reportes
			//navegadorMantenimientos1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
			// Final datos para ejecutar reportes

			navegadorMantenimientos1.ObtenerNombreDGV(this.dgvVistaPrevia);
			navegadorMantenimientos1.LlenarTabla();
			navegadorMantenimientos1.ObtenerReferenciaFormActual(this);
			//String cadena = txtprueba.Text;
			//navegador1.pruebaMensaje(cadena);
		}

		private void rbnActivo_CheckedChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.CambioEstadoTextbox(txtEstado, rbnActivo, "1");
		}

		private void rbnInactivo_CheckedChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.CambioEstadoTextbox(txtEstado, rbnInactivo, "0");
		}

		private void txtEstado_TextChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.ActivaRadiobtn(rbnActivo, rbnInactivo, txtEstado);
		}

		private void dgvVistaPrevia_SelectionChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.SelecciondeFilaDGV(dgvVistaPrevia);
		}

		private void cbxAccion_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxAccion.SelectedIndex == 0)
			{
				txtIdAccion.Text = "1";
			}
			else if (cbxAccion.SelectedIndex == 1)
			{
				txtIdAccion.Text = "2";
			}
		}

		private void txtIdAccion_TextChanged(object sender, EventArgs e)
		{
			if (txtIdAccion.Text == "1")
			{
				cbxAccion.SelectedIndex = 0;
			}
			else if (txtIdAccion.Text == "2")
			{
				cbxAccion.SelectedIndex = 1;
			}
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
		}
	}
}
