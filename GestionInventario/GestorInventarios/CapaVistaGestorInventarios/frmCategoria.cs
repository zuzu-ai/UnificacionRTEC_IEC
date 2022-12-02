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
	public partial class frmCategoria : Form
	{
		CapaControladorGestorInventarios.Controlador controlador = new CapaControladorGestorInventarios.Controlador();
		CapaControladorGestorInventarios.Global g = new CapaControladorGestorInventarios.Global();
		string accion = "";
		public frmCategoria()
		{
			InitializeComponent();
			deshabilitar();
			controlador.LlenarCA(cbxCategoria1, "categoria", "nombre", "1", "1");
			controlador.LlenarCA(cbxCategoria2, "categoria", "nombre", "2", "1");
			controlador.bloqueabotones(g.obtienenombretusuario, btnIngresar, btnEditar, btnGuardar, btnCancelar, btnEliminar, btnImprimir, btnActualizar, btnAyuda);
			rbnActivo.Checked = true;
			LlenarTabla();
		}
		private void txtTipo_TextChanged(object sender, EventArgs e)
		{
			string tipo = txtTipo.Text;
			switch (tipo)
			{
				case "1":
					chbxlistTipo.SelectedIndex = 0;
					chbxlistTipo.SetItemChecked(0, true);
					cbxCategoria1.Visible = true;
					cbxCategoria2.Visible = false;
					break;
				case "2":
					chbxlistTipo.SelectedIndex = 1;
					chbxlistTipo.SetItemChecked(1, true);
					cbxCategoria1.Visible = true;
					cbxCategoria2.Visible = false;
					break;
				case "3":
					chbxlistTipo.SelectedIndex = 2;
					chbxlistTipo.SetItemChecked(2, true);
					cbxCategoria1.Visible = false;
					cbxCategoria2.Visible = true;
					break;
				case "":
					//chbxlistTipo.SelectedIndex = ;
					chbxlistTipo.SetItemChecked(0, false);
					chbxlistTipo.SetItemChecked(1, false);
					chbxlistTipo.SetItemChecked(2, false);
					cbxCategoria1.Visible = false;
					cbxCategoria2.Visible = false;
					break;
			}
		}

		private void txtCategoria_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (txtTipo.Text == "1")
				{
					controlador.NombreID(cbxCategoria1, "categoria", "nombre", txtCategoria.Text);
				}
				else if (txtTipo.Text == "2")
				{
					controlador.NombreID(cbxCategoria1, "categoria", "nombre", txtCategoria.Text);
				}
				else if (txtTipo.Text == "3")
				{
					controlador.NombreID(cbxCategoria2, "categoria", "nombre", txtCategoria.Text);
				}
				else { }
			}
			catch (Exception excep) { }
		}

		private void dgvVistaPrevia_SelectionChanged(object sender, EventArgs e)
		{
			if (txtTipo.Text == "1")
			{
				chbxlistTipo.SelectedIndex = 0;
				chbxlistTipo.SetItemChecked(0, true);
				cbxCategoria1.Visible = true;
				cbxCategoria2.Visible = false;
				controlador.NombreID(cbxCategoria1, "categoria", "pkid", txtCategoria.Text);
			}
			else if (txtTipo.Text == "2")
			{
				chbxlistTipo.SelectedIndex = 1;
				chbxlistTipo.SetItemChecked(1, true);
				cbxCategoria1.Visible = true;
				cbxCategoria2.Visible = false;
				controlador.NombreID(cbxCategoria2, "categoria", "pkid", txtCategoria.Text);
			}
			else if (txtTipo.Text == "3")
			{
				chbxlistTipo.SelectedIndex = 2;
				chbxlistTipo.SetItemChecked(2, true);
				cbxCategoria1.Visible = false;
				cbxCategoria2.Visible = true;
				//controlador.NombreID(cbxCategoria3, "categoria", "pkid", txtCategoria.Text);
			}
			
		}

		private void rbnActivo_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnActivo.Checked == true)
			{
				txtEstado.Text = "1";
			}
		}

		private void rbnInactivo_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnInactivo.Checked == true)
			{
				txtEstado.Text = "0";
			}
		}

		private void txtEstado_TextChanged(object sender, EventArgs e)
		{
			if (txtEstado.Text == "1")
			{
				rbnActivo.Checked = true;
				rbnInactivo.Checked = false;
			}
			else if (txtEstado.Text == "0")
			{
				rbnActivo.Checked = false;
				rbnInactivo.Checked = true;
			}
		}

		private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (txtTipo.Text == "1")
			{
				controlador.IDCATE(txtCategoria, "categoria", "pkid", cbxCategoria1.Text, "1");
			}
			else if (txtTipo.Text == "2")
			{
				controlador.IDCATE(txtCategoria, "categoria", "pkid", cbxCategoria1.Text, "1");
			}
			else if (txtTipo.Text == "3")
			{
				controlador.IDCATE(txtCategoria, "categoria", "pkid", cbxCategoria2.Text, "1");
			}
			else { }
		}
		private void txtNombre_EnabledChanged(object sender, EventArgs e)
		{
			if (cbxCategoria1.Enabled == true)
			{
				chbxlistTipo.Enabled = true;
			}
			if (txtNombre.Text == "" && txtNombre.Enabled == true)
			{

				chbxlistTipo.SetItemChecked(0, false);
				chbxlistTipo.SetItemChecked(1, false);
				chbxlistTipo.SetItemChecked(2, false);
			}
			if (txtNombre.Text == "" && txtNombre.Enabled == true)
			{

				chbxlistTipo.Enabled = true;
			}
			else if (txtNombre.Text != "" && txtNombre.Enabled == true)
			{
				chbxlistTipo.Enabled = true;
			}
			else if (txtNombre.Text != "" && txtNombre.Enabled == false)
			{
				chbxlistTipo.Enabled = false;
			}

			if (chbxlistTipo.SelectedIndex == 0)
			{
				//txtTipo.Text = "1";
				controlador.LlenarCategoria(cbxCategoria1, "categoria", "nombre", "1","1");
			}
			else if (chbxlistTipo.SelectedIndex == 1)
			{
				//txtTipo.Text = "2";
				controlador.LlenarCategoria(cbxCategoria1, "categoria", "nombre", "1","1");
			}
			else if (chbxlistTipo.SelectedIndex == 2)
			{
				//txtTipo.Text = "3";
				controlador.LlenarCategoria(cbxCategoria1, "categoria", "nombre", "2","2");
			}
			else { }
		}

		private void chlistbxTipo_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void chbxlistTipo_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			for (int ix = 0; ix < chbxlistTipo.Items.Count; ++ix)
				if (ix != e.Index)
					chbxlistTipo.SetItemChecked(ix, false);
		}

		private void chbxlistTipo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (chbxlistTipo.SelectedIndex == 0)
			{
				txtTipo.Text = "1";
				txtCategoria.Text = "";
				cbxCategoria1.Visible = true;
				cbxCategoria2.Visible = false;
			}
			else if (chbxlistTipo.SelectedIndex == 1)
			{
				txtTipo.Text = "2";
				txtCategoria.Text = "";
				cbxCategoria1.Visible = true;
				cbxCategoria2.Visible = false;
			}
			else if (chbxlistTipo.SelectedIndex == 2)
			{
				txtTipo.Text = "3";
				txtCategoria.Text = "";
				cbxCategoria1.Visible = false;
				cbxCategoria2.Visible = true;
			}
			else
			{
				txtTipo.Text = "";
				cbxCategoria1.Visible = false;
				cbxCategoria2.Visible = false;
			}
			}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			DialogResult respuesta;
			respuesta = MessageBox.Show("¿Realmente desea salir?", "Salir",
		   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
			{
				try
				{
					this.Close();
				}
				catch
				{

				}
			}
			else { }
		}

		public void deshabilitar()
		{
			btnGuardar.Enabled = false;
			btnCancelar.Enabled = false;

			chbxlistTipo.Enabled = false;
			cbxCategoria1.Enabled = false;
			cbxCategoria2.Enabled = false;
			txtNombre.Enabled = false;
			accion = "";

			if (txtTipo.Text == "1")
			{
				cbxCategoria1.Visible = true;
				cbxCategoria2.Visible = false;
			}
			else if (txtTipo.Text == "2")
			{
				cbxCategoria1.Visible = true;
				cbxCategoria2.Visible = false;
			}
			else if (txtTipo.Text == "3")
			{
				cbxCategoria1.Visible = false;
				cbxCategoria2.Visible = true;
			}
			else
			{
				cbxCategoria1.Visible = false;
				cbxCategoria2.Visible = false;
			}
			txtCategoria.Text = "";
		}
		public void habilitar()
		{
			btnGuardar.Enabled = true;
			btnCancelar.Enabled = true;

			chbxlistTipo.Enabled = true;
			cbxCategoria1.Enabled = true;
			cbxCategoria2.Enabled = true;
			txtNombre.Enabled = true;
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			habilitar();
			chbxlistTipo.SetItemChecked(0, false);
			chbxlistTipo.SetItemChecked(1, false);
			chbxlistTipo.SetItemChecked(2, false);
			if (cbxCategoria1.Items.Count != 0 || cbxCategoria2.Items.Count!=0)
			{
				cbxCategoria1.SelectedIndex = 0;
				cbxCategoria2.SelectedIndex = 0;
			}
			else { }
			txtNombre.Text = "";rbnActivo.Checked = true;
			txtID.Text = (controlador.idSiguienteDeNuevoIngreso("categoria", "pkid")).ToString();
			accion = "1";
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (txtNombre.Text != "")
			{
				habilitar();
				//txtID.Text = (controlador.idSiguienteDeNuevoIngreso("categoria", "pkid")).ToString();
				accion = "2";
			}
			else
			{
				MessageBox.Show("No se ha seleccionado un registro para modificar");
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			deshabilitar();
			txtID.Text = "";
			txtTipo.Text = "";
			cbxCategoria1.Items.Clear();
			txtCategoria.Text = "";
			txtNombre.Text = "";
			chbxlistTipo.SetItemChecked(0, false);
			chbxlistTipo.SetItemChecked(1, false);
			chbxlistTipo.SetItemChecked(2, false);
			rbnActivo.Checked = true;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			string query = "";
			switch (accion)
			{
				case "1":
					try
					{
						query = "INSERT INTO categoria VALUES( '" + txtID.Text + "', '" + txtTipo.Text + "', '" + txtCategoria.Text + "', '" + txtNombre.Text + "', '" + txtEstado.Text + "');";
						controlador.metodoInsertar(query);
						MessageBox.Show("Registro guardado con éxito");
						deshabilitar();
						LlenarTabla();
					}
					catch (Exception excep) { deshabilitar(); }
					break;
				case "2":
					try
					{
						query = "UPDATE categoria SET tipo = '" + txtTipo.Text + "', catsup = '" + txtCategoria.Text + "', nombre = '" + txtNombre.Text + "', estado = '" + txtEstado.Text + "' WHERE pkid = '" + txtID.Text + "';";
						MessageBox.Show(query);
						controlador.metodoModificar(query);
						deshabilitar();
						LlenarTabla();
					}
					catch (Exception ex) { deshabilitar(); }
					break;
				case "":
					MessageBox.Show("No se ha seleccionado una acción");
					deshabilitar();
					break;
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (txtNombre.Text != "")
			{
				string query = query = "UPDATE categoria SET estado = 0 where pkid = '" + txtID.Text + "';";
				controlador.metodoDarBaja(query);
				LlenarTabla();
				deshabilitar();
			}
			else
			{
				MessageBox.Show("No se ha seleccionado un registro para eliminar");
			}
		}
		public void LlenarTabla() //Jaime López 0901-18-735
		{
			try
			{
				DataTable dt = controlador.ActualizarDGV("categoria");
				//dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dgvVistaPrevia.DataSource = dt;
			}
			catch
			{

			}
		}

		private void dgvVistaPrevia_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				txtID.Text = dgvVistaPrevia.CurrentRow.Cells[0].Value.ToString();
				txtTipo.Text = dgvVistaPrevia.CurrentRow.Cells[1].Value.ToString();
				txtCategoria.Text = dgvVistaPrevia.CurrentRow.Cells[2].Value.ToString();
				txtNombre.Text = dgvVistaPrevia.CurrentRow.Cells[3].Value.ToString();
				txtEstado.Text = dgvVistaPrevia.CurrentRow.Cells[4].Value.ToString();
			}
			catch (Exception exc) { }
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			controlador.LlenarCA(cbxCategoria1, "categoria", "nombre", "1","1");
			controlador.LlenarCA(cbxCategoria2, "categoria", "nombre", "2", "1");
			LlenarTabla();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			Reporte3 reporte = new Reporte3();
			reporte.Show();
		}

		private void cbxCategoria2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (txtTipo.Text == "1")
			{
				controlador.IDCATE(txtCategoria, "categoria", "pkid", cbxCategoria1.Text, "1");
			}
			else if (txtTipo.Text == "2")
			{
				controlador.IDCATE(txtCategoria, "categoria", "pkid", cbxCategoria1.Text, "1");
			}
			else if (txtTipo.Text == "3")
			{
				controlador.IDCATE(txtCategoria, "categoria", "pkid", cbxCategoria2.Text, "2");
			}
			else { }
		}
	}
}