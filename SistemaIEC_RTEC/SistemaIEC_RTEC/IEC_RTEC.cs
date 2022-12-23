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
    }
}
