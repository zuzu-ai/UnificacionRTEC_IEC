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
			navegadorMantenimientos1.bloquearBtn(g.obtienenombretusuario);

			TextBox[] alias = navegadorMantenimientos1.ClasificaTextboxsegunParent(this);
			navegadorMantenimientos1.ObtenerCamposdeTabla(alias, "jornada", "RTEC");
			navegadorMantenimientos1.MetodoSalirVista(this);
			navegadorMantenimientos1.campoEstado = "estado";

			navegadorMantenimientos1.ObtenerNombreDGV(this.dgvVistaPrevia);
			navegadorMantenimientos1.LlenarTabla();
			navegadorMantenimientos1.ObtenerReferenciaFormActual(this);
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

		private void frmJornada_Load(object sender, EventArgs e)
		{

		}
	}
}
