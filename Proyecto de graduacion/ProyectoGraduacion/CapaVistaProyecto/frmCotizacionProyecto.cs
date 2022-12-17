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
using CapaVistaProyecto;

namespace CapaVistaGestorInventarios
{
	public partial class frmCotizacionProyecto : Form
	{
		Controlador controlador = new Controlador();
		Global g = new Global();
		string accionE = "";
		string accionD = "";
		string seleccionE = "";
		string seleccionD = "";
		public frmCotizacionProyecto()
		{
			InitializeComponent();

			deshabilitar();
			controlador.bloqueabotones(g.obtienenombretusuario, btnIngresar, btnEditar, btnGuardar, btnCancelar, btnEliminar, btnImprimir, btnActualizar, btnAyuda, btnSalir);
			rbnActivoE.Checked = true;
			rbnActivoD.Checked = true;
			txtTotal.Text = "0.00";
			txtCantidad.Value = 0;
			LlenarTabla();
			controlador.LlenarCBX(cbxInventario, "inventarioe", "Nombre");
		}
		public void deshabilitar()
		{
			txtProyecto.Enabled = false;
			dtpFecha.Enabled = false;

			cbxInventario.Enabled = false;
			cbxProducto.Enabled = false;
			txtCantidad.Enabled = false;
			txtCantidad.Value = 0;
			seleccionE = "";
			seleccionD = "";
		}
		public void deshabilitarE()
		{
			txtProyecto.Enabled = false;
			dtpFecha.Enabled = false;
		}
		public void habilitarE()
		{
			txtProyecto.Enabled = true;
			dtpFecha.Enabled = true;
		}
		public void deshabilitarD()
		{
			cbxInventario.Enabled = false;
			cbxProducto.Enabled = false;
			txtCantidad.Enabled = false;
			txtCombustible.Enabled = false;
			txtManodeobra.Enabled = false;
			txtHospedaje.Enabled = false;
			txtPeaje.Enabled = false;
			txtOtros.Enabled = false;
		}
		public void habilitarD()
		{
			cbxInventario.Enabled = true;
			cbxProducto.Enabled = true;
			txtCantidad.Enabled = true;
			txtCombustible.Enabled = true;
			txtManodeobra.Enabled = true;
			txtHospedaje.Enabled = true;
			txtPeaje.Enabled = true;
			txtOtros.Enabled = true;
		}
		public void limpiarE()
		{
			txtIDE.Text = "";
			txtProyecto.Text = "";
			dtpFecha.Value = DateTime.Now;
			txtTotal.Text = "0.00";
			rbnActivoE.Checked = true;
		}
		public void limpiarD()
		{
			txtIDD.Text = "";
			cbxInventario.Text = "";
			cbxProducto.Text = "";
			txtDisponibilidad.Text = "";
			txtPrecio.Text = "";
			txtSubtotal.Text = "";
			accionE = "";
			txtInventario.Text = "";
			txtProducto.Text = "";
			rbnActivoD.Checked = true;
			txtCantidad.Value = 0;
			txtCombustible.Text = "0";
			txtManodeobra.Text = "0";
			txtHospedaje.Text = "0";
			txtPeaje.Text = "0";
			txtOtros.Text = "0";
		}
		public void actualizar()
		{
			controlador.LlenarCBX(cbxInventario, "inventarioe", "Nombre");

			if (seleccionE != "" && seleccionD != "")
			{
				try
				{
					LlenarTabla();
					dgvCotizaciones.Rows[Convert.ToInt32(seleccionE)].Selected = true;
					LlenarDetalles();
					dgvDetalles.Rows[Convert.ToInt32(seleccionD)].Selected = true;
				}
				catch (Exception i) { }
			}
			else if (seleccionE != "" && seleccionD == "")
			{
				try
				{
					LlenarTabla();
					dgvCotizaciones.Rows[Convert.ToInt32(seleccionE)].Selected = true;
					LlenarDetalles();
				}
				catch (Exception i) { }
			}
			else if (seleccionE == "" && seleccionD != "") { LlenarTabla(); }
			else if (seleccionE == "" && seleccionD == "") { LlenarTabla(); }
		}
		public void LlenarDetalles() 
		{
			try
			{
				DataTable dt = controlador.ActualizaDetalles("CotizacionProyectoD", txtIDE.Text);
				dgvDetalles.DataSource = dt;
			}
			catch
			{

			}
		}
		public void LlenarTabla() 
		{
			try
			{
				DataTable dt = controlador.ActualizarDGV("CotizacionProyectoE");
				dgvCotizaciones.DataSource = dt;
			}
			catch
			{

			}
		}
		public void actualizarSeleccionEncabezado()
		{
			seleccionE = dgvCotizaciones.CurrentRow.Index.ToString();
			try
			{
				txtIDE.Text = dgvCotizaciones.CurrentRow.Cells[0].Value.ToString();
				txtProyecto.Text = dgvCotizaciones.CurrentRow.Cells[1].Value.ToString();
				txtFecha.Text = dgvCotizaciones.CurrentRow.Cells[2].Value.ToString();
				txtTotal.Text = dgvCotizaciones.CurrentRow.Cells[3].Value.ToString();
				txtEstadoE.Text = dgvCotizaciones.CurrentRow.Cells[4].Value.ToString();

				LlenarDetalles();
			}
			catch (Exception exc) { }
		}
		private void dtpFecha_ValueChanged(object sender, EventArgs e)
		{
			controlador.convertirFechaDTP(dtpFecha, txtFecha);
		}
		private void txtFecha_TextChanged(object sender, EventArgs e)
		{
			controlador.convertirFechaMySQL(dtpFecha, txtFecha);
		}
		private void rbnActivoE_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnActivoE.Checked == true)
			{
				txtEstadoE.Text = "1";
			}
		}
		private void rbnInactivoE_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnInactivoE.Checked == true)
			{
				txtEstadoE.Text = "0";
			}
		}
		private void txtEstadoE_TextChanged(object sender, EventArgs e)
		{
			if (txtEstadoE.Text == "1")
			{
				rbnActivoE.Checked = true;
			}
			else if (txtEstadoE.Text == "0")
			{
				rbnInactivoE.Checked = true;
			}
		}
		private void btnIngresar_Click(object sender, EventArgs e)
		{
			limpiarE();
			actualizar();
			habilitarE();
			txtIDE.Text = (controlador.idSiguienteDeNuevoIngreso("CotizacionProyectoE", "ID_Encabezado")).ToString();
			accionE = "1";
		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			accionE = "";
			deshabilitarE();
			limpiarE();
			actualizar();
			txtIDE.Text = (controlador.idSiguienteDeNuevoIngreso("CotizacionProyectoE", "ID_Encabezado")).ToString();
		}

		private void cbxInventario_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCombo(txtInventario, "inventarioe", "ID_Encabezado", cbxInventario.Text);
			if (txtInventario.Text != "")
			{
				try{
					controlador.LlenarCBXProducto(cbxProducto, "inventariod", "Nombre", txtInventario.Text);
				}
				catch (Exception exx) {
					cbxProducto.Items.Clear();
				}
			}
		}

		private void txtInventario_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxInventario, "inventarioe", "Nombre", txtInventario.Text);
			controlador.LlenarCBXProducto(cbxProducto, "inventariod", "Nombre", txtInventario.Text);
		}

		private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxProducto.Text != "")
			{
				controlador.IDProducto(txtProducto, "inventariod", "ID_Detalle", cbxProducto.Text, txtInventario.Text);
				txtDisponibilidad.Text = controlador.BuscaDato("inventariod", "Cantidad", "ID_Detalle", txtProducto.Text);
				txtPrecio.Text = controlador.BuscaDato("inventariod", "Precio_Venta", "ID_Detalle", txtProducto.Text);
								
				string preciounitario = txtPrecio.Text;				
				string cantidad = txtCantidad.Text;
				txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad)).ToString();
			}
			else
			{
				txtProducto.Text = "";
				txtDisponibilidad.Text = "";
				txtPrecio.Text = "";
				txtCantidad.Value = 0;
				txtSubtotal.Text = "";
			}
		}
		private void rbnActivoD_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnActivoD.Checked == true)
			{
				txtEstadoD.Text = "1";
			}
		}
		private void rbnInactivoD_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnInactivoD.Checked == true)
			{
				txtEstadoD.Text = "0";
			}
		}
		private void txtEstadoD_TextChanged(object sender, EventArgs e)
		{
			if (txtEstadoD.Text == "1")
			{
				rbnActivoD.Checked = true;
			}
			else if (txtEstadoD.Text == "0")
			{
				rbnInactivoD.Checked = true;
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
		private void btnActualizar_Click(object sender, EventArgs e)
		{
			actualizar();
		}
		private void dgvCotizaciones_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			seleccionE = dgvCotizaciones.CurrentRow.Index.ToString();
			try
			{
				txtIDE.Text = dgvCotizaciones.CurrentRow.Cells[0].Value.ToString();
				txtProyecto.Text = dgvCotizaciones.CurrentRow.Cells[1].Value.ToString();
				txtFecha.Text = dgvCotizaciones.CurrentRow.Cells[2].Value.ToString();
				txtTotal.Text = dgvCotizaciones.CurrentRow.Cells[3].Value.ToString();
				txtEstadoE.Text = dgvCotizaciones.CurrentRow.Cells[4].Value.ToString();

				LlenarDetalles();
			}
			catch (Exception exc) { }
		}
		private void txtProducto_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreIDProducto(cbxProducto, "inventariod","Nombre", txtProducto.Text, txtInventario.Text);
		}
		private void btnIngresarD_Click(object sender, EventArgs e)
		{
			if (txtProyecto.Text != "")
			{
				limpiarD();
				actualizar();
				habilitarD();
				txtIDD.Text = (controlador.idSiguienteDeNuevoIngreso("CotizacionProyectoD", "ID_Detalle")).ToString();
				accionD = "1";
			}
			else
			{
				MessageBox.Show("No se ha seleccionado ninguna cotización para ingresar detalles");
			}
		}
		private void btnCancelarD_Click(object sender, EventArgs e)
		{
			try
			{
				accionD = "";
				deshabilitarD();
				limpiarD();
				actualizar();
				txtIDD.Text = (controlador.idSiguienteDeNuevoIngreso("CotizacionProyectoD", "ID_Detalle")).ToString();
				LlenarTabla();
				dgvCotizaciones.Rows[Convert.ToInt32(seleccionE)].Selected = true;
			}
			catch (Exception excepp) { }
		}
		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (txtProyecto.Text != "")
			{
				habilitarE();
				//txtID.Text = (controlador.idSiguienteDeNuevoIngreso("inventariod", "pkid")).ToString();
				accionE = "2";
			}
			else { MessageBox.Show("No hay ningún registro seleccionado para modificar."); }
		}
		private void btnEditarD_Click(object sender, EventArgs e)
		{
			if (txtInventario.Text != "")
			{
				habilitarD();
				accionD = "2";
			}
			else { MessageBox.Show("No hay ningún registro seleccionado para modificar."); }
		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			string query = "";
			switch (accionE)
			{
				case "1":
					try
					{
						query = "INSERT INTO CotizacionProyectoE VALUES( '" + txtIDE.Text + "', '" + txtProyecto.Text + "', '" + txtFecha.Text + "', '" + txtTotal.Text + "', '" + txtEstadoE.Text + "');";
						controlador.metodoInsertar(query);
					}
					catch (Exception excep)
					{
						MessageBox.Show("Error al guardar el registro");
					}
					deshabilitarE();
					limpiarE();
					actualizar();
					break;
				case "2":
					try
					{
						query = "UPDATE CotizacionProyectoE SET Proyecto ='" + txtProyecto.Text + "', Fecha_Emision='" + txtFecha.Text + "', Total ='" + txtTotal.Text + "', Estado='" + txtEstadoE.Text + "' WHERE ID_Encabezado = '" + txtIDE.Text + "';";
						
						string estadoinicial = controlador.BuscaDato("CotizacionProyectoE", "estado", "ID_Encabezado", txtIDE.Text);
						string nuevoestado = txtEstadoD.Text;
						if (estadoinicial != nuevoestado)
						{
							if (nuevoestado == "1")
							{

								string querymodifica = "UPDATE CotizacionProyectoD SET estado ='" + nuevoestado + "' where ID_Detalle = '" + txtIDE.Text + "';";
								controlador.metodoModificar(querymodifica);
							}
						}

							controlador.metodoModificar(query);
						deshabilitarE();
						actualizar();
					}
					catch (Exception ex) { MessageBox.Show("Error al editar el registro"); deshabilitar(); }
					break;
				case "":
					MessageBox.Show("No se ha seleccionado una acción");
					deshabilitar();
					break;
			}
		}
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (txtProyecto.Text != "")
			{
				try
				{
					string query = query = "UPDATE CotizacionProyectoE SET estado = 0 where ID_Encabezado = '" + txtIDE.Text + "';";
					controlador.metodoDarBaja(query);
					string query2 = query = "UPDATE CotizacionProyectoD SET estado = 0 where Fk_Encabezado = '" + txtIDE.Text + "';";
					controlador.metodoDarBaja(query2);
					actualizar();
					deshabilitarE();
					limpiarE();
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

		private void btnEliminarD_Click(object sender, EventArgs e)
		{
			if (txtInventario.Text != "")
			{
				try
				{
					string query = query = "UPDATE cotizaciond SET estado = 0 where ID_Detalle = '" + txtIDD.Text + "';";

					string totalcotizacion = controlador.BuscaDato("cotizacione", "total", "ID_Encabezado", txtIDE.Text);
					string modificar = txtSubtotal.Text;
					string querymodifica = "";
					string nueva = (Convert.ToInt32(totalcotizacion) - Convert.ToInt32(modificar)).ToString();
					querymodifica = "UPDATE cotizacione SET total ='" + nueva + "' where ID_Encabezado = '" + txtIDE.Text + "';";
					controlador.metodoModificar(querymodifica);
					controlador.metodoDarBaja(query);
					actualizar();
					actualizarSeleccionEncabezado();
					deshabilitarD();
					limpiarD();
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

		private void btnGuardarD_Click(object sender, EventArgs e)
		{
			string query = "";
			switch (accionD)
			{
				case "1":
					try
					{
						query = "INSERT INTO cotizacionD VALUES( '" + txtIDD.Text + "', '" + txtIDE.Text + "', '" + txtInventario.Text + "', '" + txtProducto.Text + "', '" + txtCantidad.Text + "', '" + txtPrecio.Text + "', '" + txtManodeobra.Text + "', '" + txtCombustible.Text + "', '" + txtHospedaje.Text + "', '" + txtPeaje.Text + "', '" + txtOtros.Text + "', '" + txtSubtotal.Text + "', '" +/* txtDescuento.Text + "', '" + txtGanancia.Text + "', '" +*/ txtEstadoD.Text + "');";

						string totalcotizacion = controlador.BuscaDato("cotizacione", "total", "ID_Encabezado", txtIDE.Text);
						string modificar = txtSubtotal.Text;
						string querymodifica = "";
						controlador.metodoInsertar(query);
						string pretotal = controlador.BuscaDato("cotizacione", "total", "ID_Encabezado", txtIDE.Text);
						string nuevototal = (Convert.ToDouble(pretotal) + Convert.ToDouble(txtSubtotal.Text)).ToString();
						string query2 = "UPDATE cotizacione SET total ='" + nuevototal + "' WHERE ID_Encabezado = '" + txtIDE.Text + "';";
						controlador.metodoModificar(query2);
					}
					catch (Exception excep)
					{
						MessageBox.Show("Error al guardar el registro");
					}
					deshabilitarD();
					limpiarD();
					actualizar();
					actualizarSeleccionEncabezado();
					break;
				case "2":
					try
					{
						query = "UPDATE cotizaciond SET fkinventarioe ='" + txtInventario.Text + "', fkinventariod ='" + txtProducto.Text + "', cantidad ='" + txtCantidad.Text + "', precio ='" + txtPrecio.Text + "', manodeobra ='" + txtManodeobra.Text + "', combustible='" + txtCombustible.Text + "', hospedaje ='" + txtHospedaje.Text + "', peaje ='" + txtPeaje.Text + "', otros='" + txtOtros.Text + "', subtotal ='" + txtSubtotal.Text + "', estado='" + txtEstadoD.Text + "' WHERE pkid = '" + txtIDD.Text + "';";

						string totalcotizacion = controlador.BuscaDato("cotizacione", "total", "pkid", txtIDE.Text);
						string inicial = controlador.BuscaDato("cotizacionD", "subtotal", "pkid", txtIDD.Text);
						string modificar = txtSubtotal.Text;
						string querymodifica = "";
						string estadoinicial = controlador.BuscaDato("cotizacionD", "estado", "pkid", txtIDD.Text);
						string nuevoestado = txtEstadoD.Text;
						if (inicial != modificar)
						{
							if (Convert.ToInt32(inicial) > Convert.ToInt32(modificar))
							{
								string nueva = ((Convert.ToInt32(totalcotizacion)) - (Convert.ToInt32(inicial) - Convert.ToInt32(modificar))).ToString();
								querymodifica = "UPDATE cotizacione SET total ='" + nueva + "' where pkid = '" + txtIDE.Text + "';";
								controlador.metodoModificar(querymodifica);
							}
							else if (Convert.ToInt32(inicial) < Convert.ToInt32(modificar))
							{
								string nueva = ((Convert.ToInt32(totalcotizacion)) + (Convert.ToInt32(modificar) - Convert.ToInt32(inicial))).ToString();
								querymodifica = "UPDATE cotizacione SET total ='" + nueva + "' where pkid = '" + txtIDE.Text + "';";
								controlador.metodoModificar(querymodifica);
							}
						}
						else if (estadoinicial != nuevoestado)
						{
							
							if (nuevoestado == "1")
							{
								string nueva = (Convert.ToInt32(totalcotizacion) + Convert.ToInt32(modificar)).ToString();
								querymodifica = "UPDATE ccotizacione SET total ='" + nueva + "' where pkid = '" + txtIDE.Text + "';";
								controlador.metodoModificar(querymodifica);
							}
							else { }
						}
						else { }
						controlador.metodoModificar(query);
					}
					catch (Exception ex) { MessageBox.Show("Error al editar el registro"); deshabilitar(); }
					deshabilitarD();
					limpiarD();
					actualizar();
					actualizarSeleccionEncabezado();
					break;
				case "":
					MessageBox.Show("No se ha seleccionado una acción");
					deshabilitar();
					break;
			}
		}

		private void txtCantidad_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (txtCantidad.Text != "" )
				{
					string preciounitario = txtPrecio.Text;					
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad)+ Convert.ToDouble(manodeobra)+ Convert.ToDouble(combustible)+ Convert.ToDouble(hospedaje)+ Convert.ToDouble(peaje)+ Convert.ToDouble(otros)).ToString();
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}
				}
			}
			catch (Exception exception) { }
		}

		private void txtCantidad_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtCantidad.Text != "")
				{
					string preciounitario = txtPrecio.Text;
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}					
				}
			}
			catch (Exception exception) { }
		}
		private void txtCantidad_Scroll(object sender, ScrollEventArgs e)
		{
			try
			{
				if (txtCantidad.Text != "" )
				{
					string preciounitario = txtPrecio.Text;					
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}					
				}
			}
			catch (Exception exception) { }
		}

		private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (txtCantidad.Text != "" )
				{
					string preciounitario = txtPrecio.Text;					
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}					
				}
			}
			catch (Exception exception) { }
		}

		private void txtCantidad_MouseClick(object sender, MouseEventArgs e)
		{
			try
			{
				if (txtCantidad.Text != "")
				{
					string preciounitario = txtPrecio.Text;					
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}					
				}
			}
			catch (Exception exception) { }
		}

		private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (txtCantidad.Text != "" /*&& txtPorcentaje.Text != ""*/)
				{
					string preciounitario = txtPrecio.Text;
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
				    txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}
				}
			}
			catch (Exception exception) { }
		}

		private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				if (txtCantidad.Text != "" /*&& txtPorcentaje.Text != ""*/)
				{
					string preciounitario = txtPrecio.Text;
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();

				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}
				}
			}
			catch (Exception exception) { }
		}
		private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (txtCantidad.Text != "" /*&& txtPorcentaje.Text != ""*/)
				{
					string preciounitario = txtPrecio.Text;
					//string valor = txtPorcentaje.Text;
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					//string porcentaje = ((Convert.ToDouble(valor) * 1) / 100).ToString();

					//string sumar = (Convert.ToDouble(preciounitario) * Convert.ToDouble(porcentaje)).ToString();
					//string nuevopreciou = (Convert.ToDouble(preciounitario) + Convert.ToDouble(sumar)).ToString();
					//string nuevosubtotal = (Convert.ToDouble(nuevopreciou) * Convert.ToDouble(cantidad)).ToString();
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();

					//txtSubtotal.Text = nuevosubtotal;
					//txtPrecio.Text = nuevopreciou;
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}
					//else if (txtDescuento.Text == "")
					//{
					//txtPrecio.Text = controlador.BuscaDato("inventariod", "preciov", "pkid", txtProducto.Text);
					//}
				}
			}
			catch (Exception exception) { }
		}

		private void txtPorcentaje_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (txtCantidad.Text != "" /*&& txtPorcentaje.Text != ""*/)
				{
					string preciounitario = txtPrecio.Text;
					//string valor = txtPorcentaje.Text;
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					//string porcentaje = ((Convert.ToDouble(valor) * 1) / 100).ToString();

					//string sumar = (Convert.ToDouble(preciounitario) * Convert.ToDouble(porcentaje)).ToString();
					//string nuevopreciou = (Convert.ToDouble(preciounitario) + Convert.ToDouble(sumar)).ToString();
					//string nuevosubtotal = (Convert.ToDouble(nuevopreciou) * Convert.ToDouble(cantidad)).ToString();
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();

					//txtSubtotal.Text = nuevosubtotal;
					//txtPrecio.Text = nuevopreciou;
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}
					//else if (txtDescuento.Text == "")
					//{
					//txtPrecio.Text = controlador.BuscaDato("inventariod", "preciov", "pkid", txtProducto.Text);
					//}
				}
			}
			catch (Exception exception) { }
		}

		private void dgvDetalles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			seleccionD = dgvDetalles.CurrentRow.Index.ToString();
			try
			{
				txtIDD.Text = dgvDetalles.CurrentRow.Cells[0].Value.ToString();
				txtIDE.Text = dgvDetalles.CurrentRow.Cells[1].Value.ToString();
				txtInventario.Text = dgvDetalles.CurrentRow.Cells[2].Value.ToString();
				txtProducto.Text = dgvDetalles.CurrentRow.Cells[3].Value.ToString();
				txtCantidad.Text = dgvDetalles.CurrentRow.Cells[4].Value.ToString();
				txtPrecio.Text = dgvDetalles.CurrentRow.Cells[5].Value.ToString();
				txtManodeobra.Text = dgvDetalles.CurrentRow.Cells[6].Value.ToString();
				txtCombustible.Text = dgvDetalles.CurrentRow.Cells[7].Value.ToString();
				txtHospedaje.Text = dgvDetalles.CurrentRow.Cells[8].Value.ToString();
				txtPeaje.Text = dgvDetalles.CurrentRow.Cells[9].Value.ToString();
				txtOtros.Text = dgvDetalles.CurrentRow.Cells[10].Value.ToString();

				txtSubtotal.Text= dgvDetalles.CurrentRow.Cells[11].Value.ToString();
				txtEstadoD.Text = dgvDetalles.CurrentRow.Cells[12].Value.ToString();
			}
			catch (Exception exc) { }
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			try
			{
				Reporte1 form = new Reporte1();
				form.MdiParent = this;
				form.Show();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

        private void txtManodeobra_TextChanged(object sender, EventArgs e)
        {
			try
			{
				if (txtCantidad.Text != "" /*&& txtPorcentaje.Text != ""*/)
				{
					string preciounitario = txtPrecio.Text;
					//string valor = txtPorcentaje.Text;
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					//string porcentaje = ((Convert.ToDouble(valor) * 1) / 100).ToString();

					//string sumar = (Convert.ToDouble(preciounitario) * Convert.ToDouble(porcentaje)).ToString();
					//string nuevopreciou = (Convert.ToDouble(preciounitario) + Convert.ToDouble(sumar)).ToString();
					//string nuevosubtotal = (Convert.ToDouble(nuevopreciou) * Convert.ToDouble(cantidad)).ToString();
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();

					//txtSubtotal.Text = nuevosubtotal;
					//txtPrecio.Text = nuevopreciou;
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}
					//else if (txtDescuento.Text == "")
					//{
					//txtPrecio.Text = controlador.BuscaDato("inventariod", "preciov", "pkid", txtProducto.Text);
					//}
				}
			}
			catch (Exception exception) { }
		}

        private void txtCombustible_TextChanged(object sender, EventArgs e)
        {
			try
			{
				if (txtCantidad.Text != "" /*&& txtPorcentaje.Text != ""*/)
				{
					string preciounitario = txtPrecio.Text;
					//string valor = txtPorcentaje.Text;
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					//string porcentaje = ((Convert.ToDouble(valor) * 1) / 100).ToString();

					//string sumar = (Convert.ToDouble(preciounitario) * Convert.ToDouble(porcentaje)).ToString();
					//string nuevopreciou = (Convert.ToDouble(preciounitario) + Convert.ToDouble(sumar)).ToString();
					//string nuevosubtotal = (Convert.ToDouble(nuevopreciou) * Convert.ToDouble(cantidad)).ToString();
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();

					//txtSubtotal.Text = nuevosubtotal;
					//txtPrecio.Text = nuevopreciou;
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}
					//else if (txtDescuento.Text == "")
					//{
					//txtPrecio.Text = controlador.BuscaDato("inventariod", "preciov", "pkid", txtProducto.Text);
					//}
				}
			}
			catch (Exception exception) { }
		}

        private void txtHospedaje_TextChanged(object sender, EventArgs e)
        {
			try
			{
				if (txtCantidad.Text != "" /*&& txtPorcentaje.Text != ""*/)
				{
					string preciounitario = txtPrecio.Text;
					//string valor = txtPorcentaje.Text;
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					//string porcentaje = ((Convert.ToDouble(valor) * 1) / 100).ToString();

					//string sumar = (Convert.ToDouble(preciounitario) * Convert.ToDouble(porcentaje)).ToString();
					//string nuevopreciou = (Convert.ToDouble(preciounitario) + Convert.ToDouble(sumar)).ToString();
					//string nuevosubtotal = (Convert.ToDouble(nuevopreciou) * Convert.ToDouble(cantidad)).ToString();
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();

					//txtSubtotal.Text = nuevosubtotal;
					//txtPrecio.Text = nuevopreciou;
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}
					//else if (txtDescuento.Text == "")
					//{
					//txtPrecio.Text = controlador.BuscaDato("inventariod", "preciov", "pkid", txtProducto.Text);
					//}
				}
			}
			catch (Exception exception) { }
		}

        private void txtPeaje_TextChanged(object sender, EventArgs e)
        {
			try
			{
				if (txtCantidad.Text != "" /*&& txtPorcentaje.Text != ""*/)
				{
					string preciounitario = txtPrecio.Text;
					//string valor = txtPorcentaje.Text;
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					//string porcentaje = ((Convert.ToDouble(valor) * 1) / 100).ToString();

					//string sumar = (Convert.ToDouble(preciounitario) * Convert.ToDouble(porcentaje)).ToString();
					//string nuevopreciou = (Convert.ToDouble(preciounitario) + Convert.ToDouble(sumar)).ToString();
					//string nuevosubtotal = (Convert.ToDouble(nuevopreciou) * Convert.ToDouble(cantidad)).ToString();
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();

					//txtSubtotal.Text = nuevosubtotal;
					//txtPrecio.Text = nuevopreciou;
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}
					//else if (txtDescuento.Text == "")
					//{
					//txtPrecio.Text = controlador.BuscaDato("inventariod", "preciov", "pkid", txtProducto.Text);
					//}
				}
			}
			catch (Exception exception) { }
		}

        private void txtOtros_TextChanged(object sender, EventArgs e)
        {
			try
			{
				if (txtCantidad.Text != "" /*&& txtPorcentaje.Text != ""*/)
				{
					string preciounitario = txtPrecio.Text;
					//string valor = txtPorcentaje.Text;
					string cantidad = txtCantidad.Text;
					string manodeobra = txtManodeobra.Text;
					string combustible = txtCombustible.Text;
					string hospedaje = txtHospedaje.Text;
					string peaje = txtPeaje.Text;
					string otros = txtOtros.Text;
					//string porcentaje = ((Convert.ToDouble(valor) * 1) / 100).ToString();

					//string sumar = (Convert.ToDouble(preciounitario) * Convert.ToDouble(porcentaje)).ToString();
					//string nuevopreciou = (Convert.ToDouble(preciounitario) + Convert.ToDouble(sumar)).ToString();
					//string nuevosubtotal = (Convert.ToDouble(nuevopreciou) * Convert.ToDouble(cantidad)).ToString();
					txtSubtotal.Text = (Convert.ToDouble(preciounitario) * Convert.ToDouble(cantidad) + Convert.ToDouble(manodeobra) + Convert.ToDouble(combustible) + Convert.ToDouble(hospedaje) + Convert.ToDouble(peaje) + Convert.ToDouble(otros)).ToString();

					//txtSubtotal.Text = nuevosubtotal;
					//txtPrecio.Text = nuevopreciou;
				}
				else
				{
					if (txtCantidad.Text == "")
					{
						txtSubtotal.Text = "";
					}
					//else if (txtDescuento.Text == "")
					//{
					//txtPrecio.Text = controlador.BuscaDato("inventariod", "preciov", "pkid", txtProducto.Text);
					//}
				}
			}
			catch (Exception exception) { }
		}
    }
}
