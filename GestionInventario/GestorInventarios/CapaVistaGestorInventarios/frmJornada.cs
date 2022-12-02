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
	public partial class frmJornada : Form
	{
		CapaControladorGestorInventarios.Controlador controlador = new CapaControladorGestorInventarios.Controlador();
		CapaControladorGestorInventarios.Global g = new CapaControladorGestorInventarios.Global();
		public frmJornada()
		{
			InitializeComponent();

			controlador.bloqueareporte(g.obtienenombretusuario, btnImprimir);
			//controlador.bloquearimagen(g.obtienenombretusuario, btnAyuda);
			navegadorMantenimientos1.bloquearBtn(g.obtienenombretusuario);

			TextBox[] alias = navegadorMantenimientos1.ClasificaTextboxsegunParent(this);
			navegadorMantenimientos1.ObtenerCamposdeTabla(alias, "jornada", "RTEC");
			navegadorMantenimientos1.MetodoSalirVista(this);
			//navegadorMantenimientos1.LlenarCombobox(cbxIDPuesto, "puesto", "pkIdPuesto", "nombre", "estado");
			//navegadorMantenimientos1.LlenarCombobox(cbxIDEmpresa, "empresa", "idEmpresa", "nombre", "estatus");

			//inicio de elementos para dar de baja
			navegadorMantenimientos1.campoEstado = "estado";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
			//navegadorMantenimientos1.idAplicacion = "2112";
			//navegadorMantenimientos1.idmodulo = "2";
			/* Inicio ID Aplicacion usada para reportes y ayudas */

			//inicio de elementos para ejecutar la ayuda
			//navegadorMantenimientos1.tablaAyuda = "Aplicacion";
			//navegadorMantenimientos1.campoAyuda = "pkId";
			//fin de elementos para ejecutar la ayuda


			// Inicio datos para ejecurar reportes
			//navegadorMantenimientos1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
			// Final datos para ejecutar reportes

			navegadorMantenimientos1.ObtenerNombreDGV(this.dgvVistaPrevia);
			navegadorMantenimientos1.LlenarTabla();
			navegadorMantenimientos1.ObtenerReferenciaFormActual(this);
			//String cadena = txtprueba.Text;
			//navegadorMantenimientos1.pruebaMensaje(cadena);
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

		private void dtpInicio_ValueChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.ColocaHora(dtpInicio,txtInicio);
		}

		private void txtInicio_TextChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.RecibeHora(dtpInicio, txtInicio);
		}

		private void dtpFin_ValueChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.ColocaHora(dtpFin, txtFin);
		}

		private void txtFin_TextChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.RecibeHora(dtpFin, txtFin);
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			Reporte7 reporte = new Reporte7();
			reporte.Show();
		}
	}
}
