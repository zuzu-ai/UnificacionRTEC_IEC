using CapaVistaGestorInventarios;
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
using CapaVistaSeguridad;
using Proyecto_IEC;

namespace CapaVistaProyecto
{
    public partial class frmMDI : Form
    {
        Global g = new Global();
        Controlador controlador = new Controlador();
        public frmMDI()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Realmente desea salir?", "Salir",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
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

        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPuesto form = new frmPuesto();
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

        private void tipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTipoUsuario form = new frmTipoUsuario();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmVehiculo form = new frmVehiculo();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMarca form = new frmMarca();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLinea form = new frmLinea();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tamañoDeMotorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTamañoMotor form = new frmTamañoMotor();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tipoDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTipoCombustible form = new frmTipoCombustible();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void asignaciónDeEsquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAsignaEquipo form = new frmAsignaEquipo();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void cotizaciónProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCotizacionProyecto form = new frmCotizacionProyecto();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();

            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                txtId.Text = form.id();
                Global global = new Global();
                global.obtieneusuario = txtUsuario.Text;
                global.obtieneid = txtId.Text;
                txtidtusuario.Text = controlador.BuscaDato("usuario", "fktipousuario", "pkid", txtId.Text);
                txtnombretusuario.Text = controlador.BuscaDato("tipousuario", "nombre", "pkid", txtidtusuario.Text);
                global.obtieneidtusuario = txtidtusuario.Text;
                global.obtienenombretusuario = txtnombretusuario.Text;
            }
            else
            {
                this.Close();
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuario form = new frmUsuario();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void asiganacionDeProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAsignaProyecto form = new frmAsignaProyecto();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void empresaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpresaCliente form = new frmEmpresaCliente();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSucursalCliente form = new frmSucursalCliente();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();

            if (form.ShowDialog() == DialogResult.OK)
            {
               
            }
            else
            {
                this.Close();
            }
        }

        private void cotizacionesDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte1 form = new Reporte1();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
            
        }

        private void proyectosAsignadosToolStripMenuItem_Click(object sender, EventArgs e)
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
