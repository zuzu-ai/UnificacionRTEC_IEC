using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorIEC_RTEC;


namespace SistemaIEC_RTEC
{
	public partial class IEC_RTEC : Form
	{
		//variables globales
		private Controlador controlador = new Controlador();
		private Global g = new Global();
		public IEC_RTEC()
		{
			InitializeComponent();
		}
        //Ventanas generales
        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmPuesto form = new Proyecto_IEC.frmPuesto();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void jornadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmJornada form = new Proyecto_IEC.frmJornada();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmEmpleado form = new Proyecto_IEC.frmEmpleado();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        //Ventanas Horas trabajadas
        private void dispositivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmDispositivo form = new Proyecto_IEC.frmDispositivo();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmGestion form = new Proyecto_IEC.frmGestion();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tipoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmTipoPago form = new Proyecto_IEC.frmTipoPago();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tipoAusenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmTipoAusencia form = new Proyecto_IEC.frmTipoAusencia();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void gastosEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmPagoEmpleado form = new Proyecto_IEC.frmPagoEmpleado();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void ausenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmAusencias form = new Proyecto_IEC.frmAusencias();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void calculoMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmCalculoMensual form = new Proyecto_IEC.frmCalculoMensual();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmConsulta form = new Proyecto_IEC.frmConsulta();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void importarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proyecto_IEC.frmImportarArchivo form = new Proyecto_IEC.frmImportarArchivo();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaProyecto.frmEmpresaCliente form = new CapaVistaProyecto.frmEmpresaCliente();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void sucursalDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaProyecto.frmSucursalCliente form = new CapaVistaProyecto.frmSucursalCliente();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void gestionDeVehículosToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaProyecto.frmVehiculo form = new CapaVistaProyecto.frmVehiculo();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaProyecto.frmLinea form = new CapaVistaProyecto.frmLinea();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void marcaToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaProyecto.frmMarca form = new CapaVistaProyecto.frmMarca();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void tamañoMotorToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaProyecto.frmTamañoMotor form = new CapaVistaProyecto.frmTamañoMotor();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void tipoCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaProyecto.frmTipoCombustible form = new CapaVistaProyecto.frmTipoCombustible();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void asignacionDeProyectoToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaProyecto.frmAsignaProyecto form = new CapaVistaProyecto.frmAsignaProyecto();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void cotizacionDeProyectoToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
               // CapaVistaProyecto.frmCotizacionProyecto form = new CapaVistaProyecto.frmCotizacionProyecto();
               // form.MdiParent = this;
               // form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void gestionDeGruposDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaProyecto.frmAsignaEquipo form = new CapaVistaProyecto.frmAsignaEquipo();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmBodega form = new CapaVistaGestorInventarios.frmBodega();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void clasificaciónDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmUbicacion form = new CapaVistaGestorInventarios.frmUbicacion();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmMarca form = new CapaVistaGestorInventarios.frmMarca();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmProveedor form = new CapaVistaGestorInventarios.frmProveedor();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmSucursal form = new CapaVistaGestorInventarios.frmSucursal();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmCategoria form = new CapaVistaGestorInventarios.frmCategoria();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void clasificaciónDeInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmClasificacion form = new CapaVistaGestorInventarios.frmClasificacion();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmInventario form = new CapaVistaGestorInventarios.frmInventario();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void tipoAlmacenamientoToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmAlmacenamiento form = new CapaVistaGestorInventarios.frmAlmacenamiento();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void tipoTransacciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmTransaccion form = new CapaVistaGestorInventarios.frmTransaccion();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void ingresoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmProducto form = new CapaVistaGestorInventarios.frmProducto();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void gestiónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmGestor form = new CapaVistaGestorInventarios.frmGestor();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void consultaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmConsultaProducto form = new CapaVistaGestorInventarios.frmConsultaProducto();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                CapaVistaGestorInventarios.frmCotizacion form = new CapaVistaGestorInventarios.frmCotizacion();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

		private void preguntaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
