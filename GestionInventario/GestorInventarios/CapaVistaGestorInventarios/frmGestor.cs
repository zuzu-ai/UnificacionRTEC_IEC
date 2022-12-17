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
	public partial class frmGestor : Form
	{
		CapaControladorGestorInventarios.Controlador controlador = new CapaControladorGestorInventarios.Controlador();
		CapaControladorGestorInventarios.Global g = new CapaControladorGestorInventarios.Global();
		string accion = "";
		public frmGestor()
		{
			InitializeComponent();
			deshabilitar();
			controlador.bloqueabotones(g.obtienenombretusuario, btnIngresar, btnEditar, btnGuardar, btnCancelar, btnEliminar, btnImprimir, btnActualizar, btnAyuda);
			rbnActivo.Checked = true;
			LlenarTabla();
			controlador.LlenarCBX(cbxInventario, "inventarioe", "Nombre");
			controlador.LlenarCBX(cbxTransaccion, "tipotransac", "Nombre");
		}
		public void deshabilitar()
		{
			cbxInventario.Enabled = false;
			cbxProducto.Enabled = false;
			cbxTransaccion.Enabled = false;
			dtpFecha.Enabled = false;
			txtCantidad.Enabled = false;
			txtPrecio.Enabled = false;
		}
		public void habilitar()
		{
			cbxInventario.Enabled = true;
			cbxProducto.Enabled = true;
			cbxTransaccion.Enabled = true;
			dtpFecha.Enabled = true;
			txtCantidad.Enabled = true;
			txtPrecio.Enabled = true;
		}
		public void limpiar()
		{
			cbxInventario.Text = "";
			cbxProducto.Text = "";
			cbxTransaccion.Text = "";
			dtpFecha.Value = DateTime.Now;
			txtCantidad.Text = "";
			txtPrecio.Text = "";
			txtEstado.Text = "1";
			txtInventario.Text = "";
			txtProducto.Text = "";
			txtTransaccion.Text = "";
			lblProducto.Text = "";
			lblCantidad.Text = "";
			lblPrecioc.Text = "";
			lblPreciov.Text = "";
			lbTitulo.Visible = false;
		}
		public void actualizar()
		{
			controlador.LlenarCBX(cbxInventario, "inventarioe", "Nombre");
			controlador.LlenarCBX(cbxTransaccion, "tipotransac", "Nombre");
			LlenarTabla();
		}
		public void LlenarTabla()
		{
			try
			{
				DataTable dt = controlador.ActualizarDGV("transacciones", "id_transacciones");
				dgvVistaPrevia.DataSource = dt;
			}
			catch
			{

			}
		}

		private void cbxInventario_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCombo(txtInventario, "inventarioe", "ID_Transacciones", cbxInventario.Text);
			try
			{
				if (txtInventario.Text != "")
				{
					controlador.LlenarCBXProducto(cbxProducto, "inventariod", "Nombre", txtInventario.Text);
				}
				else
				{
					cbxProducto.Items.Clear();
				}
			} catch (Exception excepti) { }
		}

		private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDProducto(txtProducto, "inventariod", "ID_Detalle", cbxProducto.Text, txtInventario.Text);

			if (cbxProducto.Text != "")
			{
				lblProducto.Text = controlador.BuscaDato("inventariod", "Nombre", "ID_Detalle", txtProducto.Text);
				lblCantidad.Text = "Disponibilidad: " + controlador.BuscaDato("inventariod", "Cantidad", "ID_Detalle", txtProducto.Text);
				lblPrecioc.Text = "Ultimo Precio de Compra: " + controlador.BuscaDato("inventariod", "Precio_Compra", "ID_Detalle", txtProducto.Text);
				lblPreciov.Text = "Ultimo Precio de Venta: " + controlador.BuscaDato("inventariod", "Precio_Venta", "ID_Detalle", txtProducto.Text);
				lbTitulo.Visible = true;
			}
			else
			{
				lblProducto.Text = "";
				lblCantidad.Text = "";
				lblPrecioc.Text = "";
				lblPreciov.Text = "";
				lbTitulo.Visible = false;
			}
		}

		private void cbxTransaccion_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCombo(txtTransaccion, "tipotransac", "ID_Transacciones", cbxTransaccion.Text);
		}

		private void txtProducto_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreIDProducto(cbxProducto, "inventariod", "Nombre", txtProducto.Text, txtInventario.Text);
		}

		private void dtpFecha_ValueChanged(object sender, EventArgs e)
		{
			controlador.convertirFechaDTP(dtpFecha, txtFecha);
		}

		private void txtFecha_TextChanged(object sender, EventArgs e)
		{
			controlador.convertirFechaMySQL(dtpFecha, txtFecha);
		}

		private void rbnActivo_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnActivo.Checked == true)
			{
				txtEstado.Text="1";
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
			}
			else if (txtEstado.Text == "0")
			{
				rbnInactivo.Checked = true;
			}
		}

		private void dgvVistaPrevia_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				txtID.Text = dgvVistaPrevia.CurrentRow.Cells[0].Value.ToString();
				txtInventario.Text = dgvVistaPrevia.CurrentRow.Cells[1].Value.ToString();
				txtProducto.Text = dgvVistaPrevia.CurrentRow.Cells[2].Value.ToString();
				txtTransaccion.Text = dgvVistaPrevia.CurrentRow.Cells[3].Value.ToString();
				txtFecha.Text = dgvVistaPrevia.CurrentRow.Cells[4].Value.ToString();
				txtCantidad.Text = dgvVistaPrevia.CurrentRow.Cells[5].Value.ToString();
				txtPrecio.Text = dgvVistaPrevia.CurrentRow.Cells[6].Value.ToString();
				txtEstado.Text = dgvVistaPrevia.CurrentRow.Cells[7].Value.ToString();
			}
			catch (Exception exc) { }
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			limpiar();
			actualizar();
			habilitar();
			txtID.Text = (controlador.idSiguienteDeNuevoIngreso("transacciones", "ID_Transacciones")).ToString();
			accion = "1";
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (txtInventario.Text != "")
			{
				habilitar();
				accion = "2";
			}
			else { MessageBox.Show("No hay ningún registro seleccionado para modificar."); }
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			accion = "";
			deshabilitar();
			limpiar();
			actualizar();
			txtID.Text = (controlador.idSiguienteDeNuevoIngreso("transacciones", "ID_Transacciones")).ToString();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (txtInventario.Text != "")
			{
				try
				{
					string query = query = "UPDATE transacciones SET Estado = 0 where ID_Transacciones = '" + txtID.Text + "';";
					string inicial = controlador.BuscaDato("inventariod", "Cantidad", "ID_Detalle", txtProducto.Text);
					string eliminar = txtCantidad.Text;
					string nueva = ((Convert.ToInt32(inicial)) - (Convert.ToInt32(eliminar))).ToString();
					string queryresta = "UPDATE inventariod SET Cantidad ='" + nueva + "' where ID_Detalle = '" + txtProducto.Text + "';";
					controlador.metodoModificar(queryresta);
					controlador.metodoDarBaja(query);
					actualizar();
					deshabilitar();
					limpiar();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al dar de baja el registro");
				}
			}
			else
			{
				MessageBox.Show("No se ha seleccionado un registro para eliminar");
			}
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			actualizar();
			LlenarTabla();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			string query = "";
			switch (accion)
			{
				case "1":
					try
					{
						query = "INSERT INTO transacciones VALUES( '" + txtID.Text + "', '" + txtInventario.Text + "', '" + txtProducto.Text + "', '" + txtTransaccion.Text + "', '" + txtFecha.Text + "', '" + txtCantidad.Text + "', '" + txtPrecio.Text + "', '" + txtEstado.Text + "');";
						string acciontransac = controlador.BuscaDato("tipotransac","Accion","ID_Transacciones",txtTransaccion.Text);
						string precio = "";
						if (acciontransac == "1")
						{
							precio = controlador.BuscaDato("inventariod", "Precio_Compra", "ID_Detalle", txtProducto.Text);
							string inicial = controlador.BuscaDato("inventariod", "Cantidad", "ID_Detalle", txtProducto.Text);
							string añadir = txtCantidad.Text;
							string nueva = ((Convert.ToInt32(inicial)) + (Convert.ToInt32(añadir))).ToString();
							string queryañadir = "UPDATE inventariod SET Cantidad ='" + nueva + "' where ID_Detalle = '" + txtProducto.Text + "';";
							controlador.metodoModificar(queryañadir);
						}
						else if (acciontransac == "2")
						{
							precio = controlador.BuscaDato("inventariod", "Precio_Venta", "ID_Detalle", txtProducto.Text);
							string inicial = controlador.BuscaDato("inventariod", "Cantidad", "ID_Detalle", txtProducto.Text);
							string restar = txtCantidad.Text;
							string nueva = ((Convert.ToInt32(inicial)) - (Convert.ToInt32(restar))).ToString();
							string queryrestar = "UPDATE inventariod SET Cantidad ='" + nueva + "' where ID_Detalle = '" + txtProducto.Text + "';";
							controlador.metodoModificar(queryrestar);
						}

						if (acciontransac == "1")
						{
							string nuevoprecio = txtPrecio.Text;
							if (nuevoprecio != precio)
							{
								string querynuevoprecio = "UPDATE inventariod SET Precio_Compra ='" + nuevoprecio + "' where ID_Detalle = '" + txtProducto.Text + "';";
								controlador.metodoModificar(querynuevoprecio);
							}
							else { }
						}
						else if (acciontransac == "2")
						{
							string nuevoprecio = txtPrecio.Text;
							if (nuevoprecio != precio)
							{
								string querynuevoprecio = "UPDATE inventariod SET Precio_Venta ='" + nuevoprecio + "' where ID_Detalle = '" + txtProducto.Text + "';";
								controlador.metodoModificar(querynuevoprecio);
							}
							else { }
						}
						controlador.metodoInsertar(query);

						deshabilitar();
						actualizar();
						LlenarTabla();
					}
					catch (Exception excep)
					{
						MessageBox.Show("Error al guardar el registro");
					}
					deshabilitar();
					limpiar();
					actualizar();
					break;
				case "2":
					try
					{
						query = "UPDATE transacciones SET Fk_Encabezado = '" + txtInventario.Text + "', Fk_Detalle ='" + txtProducto.Text + "', Fk_Tipo_Transaccion ='" + txtTransaccion.Text + "', Fecha_Transaccion ='" + txtFecha.Text + "', Cantidad ='" + txtCantidad.Text + "', Precio ='" + txtPrecio.Text + "', Estado='" + txtEstado.Text + "' WHERE ID_Transacciones = '" + txtID.Text + "';";
						string acciontransac = controlador.BuscaDato("tipotransac", "Accion", "Fk_Tipo_Transaccion", txtTransaccion.Text);
						string precio = "";
						if (acciontransac == "1")
						{
							precio = controlador.BuscaDato("inventariod", "Precio_Compra", "ID_Detalle", txtProducto.Text);
							string cantransac = controlador.BuscaDato("transacciones", "cantidad", "ID_Transaccion", txtID.Text);
							string inicial = controlador.BuscaDato("inventariod", "cantidad", "ID_Detalle", txtProducto.Text);
							string modificar = txtCantidad.Text;
							string querymodifica = "";
							if (cantransac != modificar)
							{
								if (Convert.ToInt32(cantransac) > Convert.ToInt32(modificar))
								{
									string nueva = ((Convert.ToInt32(inicial)) - (Convert.ToInt32(cantransac) - Convert.ToInt32(modificar))).ToString();
									querymodifica = "UPDATE inventariod SET cantidad ='" + nueva + "' where ID_Detalle = '" + txtProducto.Text + "';";
									controlador.metodoModificar(querymodifica);
								}
								else if (Convert.ToInt32(cantransac) < Convert.ToInt32(modificar))
								{
									string nueva = ((Convert.ToInt32(inicial)) + (Convert.ToInt32(modificar) - Convert.ToInt32(cantransac))).ToString();
									querymodifica = "UPDATE inventariod SET cantidad ='" + nueva + "' where ID_Detalle = '" + txtProducto.Text + "';";
									controlador.metodoModificar(querymodifica);
								}
							}
							else { }
							
						}
						else if (acciontransac == "2")
						{
							precio = controlador.BuscaDato("inventariod", "Precio_Venta", "ID_Detalle", txtProducto.Text);
							string cantransac = controlador.BuscaDato("transacciones", "cantidad", "ID_Transaccion", txtID.Text);
							string inicial = controlador.BuscaDato("inventariod", "cantidad", "ID_Detalle", txtProducto.Text);
							string modificar = txtCantidad.Text;
							string querymodifica = "";
							if (cantransac != modificar)
							{
								if (Convert.ToInt32(cantransac) > Convert.ToInt32(modificar))
								{
									string nueva = ((Convert.ToInt32(inicial)) + (Convert.ToInt32(cantransac) - Convert.ToInt32(modificar))).ToString();
									querymodifica = "UPDATE inventariod SET cantidad ='" + nueva + "' where ID_Detalle = '" + txtProducto.Text + "';";
									controlador.metodoModificar(querymodifica);
								}
								else if (Convert.ToInt32(cantransac) < Convert.ToInt32(modificar))
								{
									string nueva = ((Convert.ToInt32(inicial)) - (Convert.ToInt32(modificar) - Convert.ToInt32(cantransac))).ToString();
									querymodifica = "UPDATE inventariod SET cantidad ='" + nueva + "' where ID_Detalle = '" + txtProducto.Text + "';";
									controlador.metodoModificar(querymodifica);
								}
							}
							else { }
						}

						if (acciontransac == "1")
						{
							string nuevoprecio = txtPrecio.Text;
							if (nuevoprecio != precio)
							{
								string querynuevoprecio = "UPDATE inventariod SET Precio_Compra ='" + nuevoprecio + "' where ID_Detalle = '" + txtProducto.Text + "';";
								controlador.metodoModificar(querynuevoprecio);
							}
							else { }
						}
						else if (acciontransac == "2")
						{
							string nuevoprecio = txtPrecio.Text;
							if (nuevoprecio != precio)
							{
								string querynuevoprecio = "UPDATE inventariod SET Precio_Venta ='" + nuevoprecio + "' where ID_Detalle = '" + txtProducto.Text + "';";
								controlador.metodoModificar(querynuevoprecio);
							}
							else { }
						}
						controlador.metodoModificar(query);
						deshabilitar();
						LlenarTabla();
					}
					catch (Exception ex) { MessageBox.Show("Error al editar el registro"); deshabilitar(); }
					break;
				case "":
					MessageBox.Show("No se ha seleccionado una acción");
					deshabilitar();
					break;
			}
		}

		private void txtInventario_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxInventario, "inventarioe", "Nombre", txtInventario.Text, "id_encabezado");
		}

		private void txtTransaccion_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxTransaccion, "tipotransac", "Nombre", txtTransaccion.Text, "id_tipo_transaccion");
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			Reporte14 reporte = new Reporte14();
			reporte.Show();
		}
	}
}
