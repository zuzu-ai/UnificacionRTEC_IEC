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
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
			TextBox[] alias = navegadorMantenimientos1.ClasificaTextboxsegunParent(this);
			navegadorMantenimientos1.ObtenerCamposdeTabla(alias, "vehiculo", "RTEC_IEC");
			navegadorMantenimientos1.MetodoSalirVista(this);
			navegadorMantenimientos1.LlenarCombobox(cbxTamañoMotor, "tamanomotor", "ID_Tamano_Motor", "nombre", "estado");
			navegadorMantenimientos1.LlenarCombobox(cbxTipoCombustible, "tipocombustible", "ID_Tipo_Combustible", "nombre", "estado");
			navegadorMantenimientos1.LlenarCombobox(cbxLinea, "linea", "ID_Linea", "nombre", "estado");
			navegadorMantenimientos1.LlenarCombobox(cbxMarca, "MarcaVehiculo", "ID_Marca_Vehiculo", "nombre", "estado");
			navegadorMantenimientos1.LlenarCombobox(cbxIdEmpresa, "Empresa", "ID_Empresa", "nombre", "estado");

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
		private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            navegadorMantenimientos1.ColocaAño(dtpModelo, txtModelo);
        }

		private void txtModelo_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.RecibeAño(dtpModelo, txtModelo);
		}

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxMarca, txtIdMarca);
		}

        private void txtIdMarca_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxMarca, txtIdMarca);
		}

        private void cbxLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxLinea, txtIdLinea);
		}

        private void txtIdLinea_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxLinea, txtIdLinea);
		}

        private void cbxTamañoMotor_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxTamañoMotor, txtIdTamañoMotor);
		}

        private void txtIdTamañoMotor_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxTamañoMotor, txtIdTamañoMotor);
		}
		       
        private void cbxTipoCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxTipoCombustible, txtIdTipoCombustible);
		}

        private void txtIdTipoCombustible_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxTipoCombustible, txtIdTipoCombustible);
		}

        private void cbxIdEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxIdEmpresa, txtIdEmpresa);
		}

        private void txtIdEmpresa_TextChanged(object sender, EventArgs e)
        {
			navegadorMantenimientos1.SeleccionarElementosenCombo(cbxIdEmpresa, txtIdEmpresa);
		}
    }
}
