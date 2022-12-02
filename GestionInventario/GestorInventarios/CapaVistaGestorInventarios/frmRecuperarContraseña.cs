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

namespace CapaVistaGestorInventarios
{
	public partial class frmRecuperarContraseña : Form
	{
		string password = "";
		public frmRecuperarContraseña()
		{
			InitializeComponent();
			navegadorMantenimientos1.LlenarCombobox(cbxPregunta, "pregunta", "pkid", "pregunta", "estado");
			this.tltNombre.SetToolTip(this.btnAceptar, "Aceptar");
			this.tltNombre.SetToolTip(this.btnCancelar, "Cancelar");
		}
		Encriptar encript = new Encriptar();

		private void cbxPregunta_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegadorMantenimientos1.EnviarDatoComboaTextbox(cbxPregunta, txtIDPregunta);
		}

		private void mtxtConfirmarContraseña_Leave(object sender, EventArgs e)
		{
			if (mtxtContraseña.Text == "" && mtxtConfirmarContraseña.Text == "")
			{
				mtxtConfirmarContraseña.Text = "";
				mtxtContraseña.Text = "";
				mtxtContraseña.Focus();

			}
			if (mtxtConfirmarContraseña.Text != mtxtContraseña.Text)
			{
				DialogResult respuesta;
				respuesta = MessageBox.Show("Ingrese la misma contraseña en ambas cajas de texto.", "Error en contraseña",
			   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				if (respuesta == DialogResult.OK)
				{
					mtxtConfirmarContraseña.Text = "";
					mtxtContraseña.Text = "";
					mtxtContraseña.Focus();
				}
			}
			else
			{
				var key = "b14ca5898a4e4133bbce2ea2315a1916";
				Encriptar encriptar = new Encriptar();
				password = encriptar.metodoEncryptString(key, mtxtContraseña.Text);
				//txtContraseña.Text = password;
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult respuesta;
			respuesta = MessageBox.Show("¿Realmente desea cancelar?", "Salir",
		   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
			{
				cbxPregunta.Focus();
				//txtContraseña.Text = "";
				mtxtConfirmarContraseña.Text = "";
				mtxtContraseña.Text = "";
			}
			else { }
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			DialogResult respuesta;
			respuesta = MessageBox.Show("¿Realmente desea continuar?", "Salir",
		   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
			{
				var key = "b14ca5898a4e4133bbce2ea2315a1916";
				Encriptar encriptar = new Encriptar();
				password = encriptar.metodoEncryptString(key, mtxtContraseña.Text);

				CapaControladorGestorInventarios.Controlador controlador = new CapaControladorGestorInventarios.Controlador();
				string id = controlador.BuscaDato("usuario", "pkid", "usuario.usuario", txtUsuario.Text);
				controlador.CambioContrasena("usuario", password, id, txtUsuario.Text);
				this.Close();
			}
			else { }
		}

		private void btnPassword_Click(object sender, EventArgs e)
		{
			mtxtContraseña.UseSystemPasswordChar = false;
			mtxtConfirmarContraseña.UseSystemPasswordChar = false;
			btnPassword.Visible = false;
			btnPasswordn.Visible = true;
		}

		private void btnPasswordn_Click(object sender, EventArgs e)
		{
			mtxtContraseña.UseSystemPasswordChar = true;
			mtxtConfirmarContraseña.UseSystemPasswordChar = true;
			btnPassword.Visible = true;
			btnPasswordn.Visible = false;
		}
	}
}