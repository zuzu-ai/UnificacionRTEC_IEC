using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorProyecto;

namespace CapaVistaProyecto
{
    public partial class frmAsignaEquipo : Form
    {
		private Controlador cn = new Controlador();
		public frmAsignaEquipo()
        {
            InitializeComponent();
			TextBox[] alias = navegadorMantenimientos1.ClasificaTextboxsegunParent(this);
			navegadorMantenimientos1.ObtenerCamposdeTabla(alias, "equipoencabezado", "RTEC_IEC");
			navegadorMantenimientos1.MetodoSalirVista(this);
			navegadorMantenimientos1.LlenarCombobox(cbxIdEmpresa, "Empresa", "ID_Empresa", "nombre", "estado");
			//navegadorMantenimientos1.LlenarCombobox(cbxIpoCombustible, "tipocombustible", "idEmpresa", "nombre", "estatus");

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
		string tabla = "empleado";
		string tablaDetalle = "equipodetalle";
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
		void llenaTablaEmpleadosDisponibles()
        {
			DataTable dt = cn.llanarTblEmpleadoDisponibles(txtID.Text);
			dvgTodosEmpleados.DataSource = dt;
		}
		void llenarTablaEmpladosAsignados()
        {
			DataTable dt = cn.llanarTblEmpleadosAsignados(tabla,txtID.Text);
			dvgEmpleadosAsignados.DataSource = dt;
		}
        private void txtID_TextChanged(object sender, EventArgs e)
        {
			llenaTablaEmpleadosDisponibles();
			llenarTablaEmpladosAsignados();
		}
        private void btnAsignarUnEmpleado_Click(object sender, EventArgs e)
        {
			if (dvgTodosEmpleados.RowCount - 1 != 0)
			{
				try
				{
					txtCeldas.Text = dvgTodosEmpleados.CurrentRow.Cells[0].Value.ToString();
					string valor2 = txtCeldas.Text;
					cn.AsignarEmpleados(tablaDetalle, txtID.Text, valor2);
					llenaTablaEmpleadosDisponibles();
					llenarTablaEmpladosAsignados();
				}
				catch (Exception ex)
				{
					//  MessageBox.Show("Error al asignar empleado");               
				}
			}
			else if (dvgTodosEmpleados.RowCount - 1 == 0)
			{
				DialogResult respuesta;
				respuesta = MessageBox.Show("¡Todos los empleados estan asignados!", "Asignacion de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (respuesta == DialogResult.OK)
				{

				}
			}
		}
        private void btnAsignarTodosEmp_Click(object sender, EventArgs e)
        {
			if (dvgTodosEmpleados.RowCount-1 != 0)
			{
				string valor1 = txtID.Text;
				string valor2 = txtCeldas.Text;
				string str;

				cn.AsignarATodosLosEmpleados(tablaDetalle, valor1);
				llenarTablaEmpladosAsignados();

				int CantidadFilas = dvgTodosEmpleados.RowCount;

				for (int i = 0; i < CantidadFilas; i++)
				{
					dvgTodosEmpleados.CurrentCell = dvgTodosEmpleados.Rows[i].Cells[0];
					str = dvgTodosEmpleados.Rows[i].Cells[0].Value.ToString();

					txtCeldas.Text = str;

					cn.AsignarEmpleados(tablaDetalle, valor1, str);
					llenarTablaEmpladosAsignados();

				}
				llenaTablaEmpleadosDisponibles();
			}
			else if (dvgTodosEmpleados.RowCount-1 == 0)
			{
				DialogResult respuesta;
				respuesta = MessageBox.Show("¡Todos los empleados estan asignados!", "Asignacion de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (respuesta == DialogResult.OK)
				{

				}
			}
		}

		private void quitarunemp_Click(object sender, EventArgs e)
		{
			if (dvgEmpleadosAsignados.RowCount-1 != 0)
			{
				txtCeldas.Text = dvgEmpleadosAsignados.CurrentRow.Cells[0].Value.ToString();

				string valor1 = txtID.Text;
				string valor2 = txtCeldas.Text;
				cn.EliminarUnEmpleadoAsignado(tablaDetalle, valor1, valor2);
				llenaTablaEmpleadosDisponibles();
				llenarTablaEmpladosAsignados();
			}
			else if (dvgEmpleadosAsignados.RowCount-1 == 0)
			{
				DialogResult respuesta;
				respuesta = MessageBox.Show("¡Todos los empleados estan disponibles!", "Asignacion de empleados",MessageBoxButtons.OK ,MessageBoxIcon.Information);
				if (respuesta == DialogResult.OK)
				{
					
				}				
			}
		}

        private void quietatodosemp_Click(object sender, EventArgs e)
        {
			if (dvgEmpleadosAsignados.RowCount - 1 != 0)
			{
				string valor = txtID.Text;
				cn.EliminarTodasLasAsignacionesEmpleados(tablaDetalle, valor);
				llenaTablaEmpleadosDisponibles();
				llenarTablaEmpladosAsignados();
			}
			else if (dvgEmpleadosAsignados.RowCount - 1 == 0)
			{
				DialogResult respuesta;
				respuesta = MessageBox.Show("¡Todos los empleados estan disponibles!", "Asignacion de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (respuesta == DialogResult.OK)
				{

				}
			}
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
