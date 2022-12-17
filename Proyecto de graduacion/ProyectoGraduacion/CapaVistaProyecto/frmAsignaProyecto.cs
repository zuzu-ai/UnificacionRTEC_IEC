using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaProyecto
{
    public partial class frmAsignaProyecto : Form
    {
        public frmAsignaProyecto()
        {
            InitializeComponent();
			TextBox[] alias = navegadorMantenimientos1.ClasificaTextboxsegunParent(this);
			navegadorMantenimientos1.ObtenerCamposdeTabla(alias, "asignaproyecto", "IEC");
			navegadorMantenimientos1.MetodoSalirVista(this);
			navegadorMantenimientos1.LlenarCombobox(cbxCliente, "sucursalcliente", "pkid", "nombre", "estado");
			navegadorMantenimientos1.LlenarCombobox(cbxEquipo, "equipoencabezado", "pkid", "nombre", "estado");
			navegadorMantenimientos1.LlenarCombobox(cbxVehiculo, "vehiculo", "pkid", "placa", "estado");
			navegadorMantenimientos1.LlenarCombobox(cbxCotizacion, "cotizacione", "pkid", "proyecto", "estado");

			//inicio de elementos para dar de baja
			navegadorMantenimientos1.campoEstado = "estado";
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
		private void txtEstado_TextChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.ActivaRadiobtn(rbnEstatusamodulo, rbnEstatusimodulo, txtEstado);
		}

		private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.CambioEstadoTextbox(txtEstado, rbnEstatusamodulo, "1");
		}

		private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.CambioEstadoTextbox(txtEstado, rbnEstatusimodulo, "0");
		}

		private void dgvVistaPrevia_SelectionChanged(object sender, EventArgs e)
		{

			navegadorMantenimientos1.SelecciondeFilaDGV(dgvVistaPrevia);

		}

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxCliente, txtIdCliente);
		}

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxCliente, txtIdCliente);
		}

        private void cbxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxEquipo, txtIdEquipo);
		}

        private void txtIdEquipo_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxEquipo, txtIdEquipo);
		}

        private void cbxVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxVehiculo, txtIdVehiculo);
		}

        private void txtIdVehiculo_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxVehiculo, txtIdVehiculo);
		}

        private void cbxCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxCotizacion, txtIdCotizacion);
		}

        private void txtIdCotizacion_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxCotizacion, txtIdCotizacion);
		}

        private void btnImprimir_Click(object sender, EventArgs e)
        {
			try
			{
				Reporte2 form = new Reporte2();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}
    }
}
