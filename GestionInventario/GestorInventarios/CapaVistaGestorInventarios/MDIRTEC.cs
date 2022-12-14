using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorGestorInventarios;
using CapaVistaSeguridad;


namespace CapaVistaGestorInventarios
{
	public partial class MDIRTEC : Form
	{
		private Controlador controlador = new Controlador();
		private Global g = new Global();
		public MDIRTEC()
		{
			InitializeComponent();
		}

		private void MDIRTEC_Load(object sender, EventArgs e)
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

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLogin form = new frmLogin();
			if (form.ShowDialog() == DialogResult.OK)
			{
			}
			else
			{ this.Close(); }
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

		private void jornadaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmJornada form = new frmJornada();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmBodega form = new frmBodega();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmEmpleado form = new frmEmpleado();
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

		private void clasificaciónDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmClasificacion form = new frmClasificacion();
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

		private void preguntaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmPregunta form = new frmPregunta();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void ubicaciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmUbicacion form = new frmUbicacion();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmProveedor form = new frmProveedor();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmCategoria form = new frmCategoria();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void tipoTransacciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmTransaccion form = new frmTransaccion();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void tipoAlmacenamientoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmAlmacenamiento form = new frmAlmacenamiento();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmInventario form = new frmInventario();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}
		private void productoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmSucursal form = new frmSucursal();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void ingresoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmProducto form = new frmProducto();
				form.MdiParent = this;
				form.Show();
					try
					{
						frmRecordatorios frm = new frmRecordatorios();
						frm.MdiParent = this;
						frm.Show();
					}
					catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			
		}

		private void gestiónDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmGestor form = new frmGestor();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmCotizacion form = new frmCotizacion();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void consultaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frmConsultaProducto form = new frmConsultaProducto();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}
	}
}
