﻿using System;
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
	public partial class frmPregunta : Form
	{
		CapaControladorGestorInventarios.Controlador controlador = new CapaControladorGestorInventarios.Controlador();
		CapaControladorGestorInventarios.Global g = new CapaControladorGestorInventarios.Global();
		public frmPregunta()
		{
			InitializeComponent();

			controlador.bloqueareporte(g.obtienenombretusuario, btnImprimir);
			navegadorMantenimientos1.bloquearBtn(g.obtienenombretusuario);

			TextBox[] alias = navegadorMantenimientos1.ClasificaTextboxsegunParent(this);
			navegadorMantenimientos1.ObtenerCamposdeTabla(alias, "pregunta", "RTEC_IEC");
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
	}
}
