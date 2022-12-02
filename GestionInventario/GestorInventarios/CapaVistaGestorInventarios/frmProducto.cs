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
	public partial class frmProducto : Form
	{
		CapaControladorGestorInventarios.Controlador controlador = new CapaControladorGestorInventarios.Controlador();
		CapaControladorGestorInventarios.Global g = new CapaControladorGestorInventarios.Global();
		string accion = "";
		DataTable tablalimpiar = new DataTable();
		public frmProducto()
		{
			InitializeComponent();
			deshabilitar();
			controlador.bloqueabotones(g.obtienenombretusuario, btnIngresar, btnEditar, btnGuardar, btnCancelar, btnEliminar, btnImprimir, btnActualizar, btnAyuda);
			rbnActivo.Checked = true;
			LlenarTabla();
			controlador.LlenarCBX(cbxInventario,"inventarioe","nombre");
			controlador.LlenarCBX(cbxMarca, "marca", "nombre");
			controlador.LlenarCBX(cbxAlmacenamiento, "tipoalmacen", "nombre");
			controlador.LlenarCat(cbxCat1, "categoria", "nombre", "1", "1");
			controlador.LlenarCBX(cbxSucursal, "sucursal", "nombre");
			controlador.LlenarCBX(cbxBodega, "bodega", "nombre");
			LlenarProveedores();

			if (dgvVistaPrevia.DataSource != null && txtIdProveedores.Text != "")
			{
				chequearProveedores();
			}
			else { }
		}
		public void deshabilitar()
		{
			btnGuardar.Enabled = false;
			btnCancelar.Enabled = false;

			cbxInventario.Enabled = false;
			txtPrecio.Enabled = false;
			txtPVenta.Enabled = false;
			txtSerie.Enabled = false;
			txtNombre.Enabled = false;
			txtDescripcion.Enabled = false;
			txtCantidad.Enabled = false;
			cbxMarca.Enabled = false;
			cbxAlmacenamiento.Enabled = false;
			cbxCat1.Enabled = false;
			cbxCat2.Enabled = false;
			cbxCat3.Enabled = false;
			cbxSucursal.Enabled = false;
			cbxBodega.Enabled = false;
			cbxUbicacion.Enabled = false;
			txtMin.Enabled = false;
			txtMax.Enabled = false;
			accion = "";
			dgvProveedores.Enabled = false;
		}
		public void habilitar()
		{
			btnGuardar.Enabled = true;
			btnCancelar.Enabled = true;

			txtPVenta.Enabled = true;
			cbxInventario.Enabled = true;
			txtPrecio.Enabled = true;
			txtSerie.Enabled = true;
			txtNombre.Enabled = true;
			txtDescripcion.Enabled = true;
			txtCantidad.Enabled = true;
			cbxMarca.Enabled = true;
			cbxAlmacenamiento.Enabled = true;
			cbxCat1.Enabled = true;
			cbxCat2.Enabled = true;
			cbxCat3.Enabled = true;
			cbxSucursal.Enabled = true;
			cbxBodega.Enabled = true;
			cbxUbicacion.Enabled = true;
			txtMin.Enabled = true;
			txtMax.Enabled = true;
			dgvProveedores.Enabled = true;
		}
		public void LlenarTabla() //Jaime López 0901-18-735
		{
			try
			{
				DataTable dt = controlador.ActualizarDGV("inventariod");
				//dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dgvVistaPrevia.DataSource = dt;
			}
			catch
			{

			}
		}
		public void LlenarProveedores() //Jaime López 0901-18-735
		{
			try
			{
				DataTable dt = controlador.LlenarProveedores("proveedor");
				//dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dgvProveedores.DataSource = dt;
				//dgvProveedores.Columns.Add("Añadir", "Añadir");

				DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
				dgvCmb.ValueType = typeof(bool);
				dgvCmb.Name = "Añadir";
				dgvCmb.HeaderText = "";
				dgvProveedores.Columns.Add(dgvCmb);

				/*DataGridViewCheckBoxColumn ChbxDetalle = dgvProveedores.Columns["Añadir"] as DataGridViewCheckBoxColumn;

				int cantidad = dgvProveedores.Rows.Count;

				for (int i = 0; i < cantidad; i++)
				{
					dgvProveedores["Añadir",i]
				}*/
			}
			catch
			{

			}
		}
		public void compruebaProveedores()
		{
			foreach (DataGridViewRow row in dgvProveedores.Rows)
			{
				if (accion == "1")
				{

					bool bChecked = Convert.ToBoolean(row.Cells["Añadir"].Value);
					string idproveedor = row.Cells["pkid"].Value.ToString();
					if (bChecked)
					{
						try
						{
							Boolean coincide = controlador.idcoincidente("proveedore", txtIdProveedores.Text);
							if (coincide == false)
							{
								string query1 = "INSERT INTO proveedore VALUES('" + txtIdProveedores.Text + "', '1');";
								controlador.metodoInsertar(query1);

								string pkid = controlador.idSiguienteDeNuevoIngreso("proveedord", "ID_Detalle").ToString();
								string query2 = "INSERT INTO proveedord VALUES('" + pkid + "', '" + txtIdProveedores.Text + "', '" + idproveedor + "', '1');";
								controlador.metodoInsertar(query2);
							}
							else if (coincide == true)
							{
								string pkid = controlador.idSiguienteDeNuevoIngreso("proveedord", "ID_Detalle").ToString();
								string query2 = "INSERT INTO proveedord VALUES('" + pkid + "', '" + txtIdProveedores.Text + "', '" + idproveedor + "', '1');";
								controlador.metodoInsertar(query2);
							}
						}
						catch (Exception except) { }
					}
				}
				else if (accion == "2")
				{
						bool bChecked = Convert.ToBoolean(row.Cells["Añadir"].Value);
						//bool bChecked = (bool)dgvProveedores.Rows[2].Cells["Añadir"].EditedFormattedValue;
						string idproveedor = row.Cells["ID_Proveedor"].Value.ToString();

						if (bChecked == true)
						{
							try
							{
								Boolean coincide = controlador.registroexiste("proveedord", idproveedor, txtIdProveedores.Text);
								if (coincide == false)
								{
									string pkid = controlador.idSiguienteDeNuevoIngreso("proveedord", "ID_Detalle").ToString();
									string query2 = "INSERT INTO proveedord VALUES('" + pkid + "', '" + txtIdProveedores.Text + "', '" + idproveedor + "', '1');";
									controlador.metodoInsertar(query2);
								}
								else if (coincide == true)
								{ }
							}
							catch (Exception except) { }
						}
						else if (bChecked == false)
						{
						/*if (dgvProveedores.Rows[2].Cells["Pagar"].EditedFormattedValue != null)
						{*/
							try
							{
								Boolean coincide = controlador.registroexiste("proveedord", idproveedor, txtIdProveedores.Text);
								if (coincide == false)
								{ }
								else if (coincide == true)
								{
									string query2 = "DELETE FROM proveedord WHERE Fk_Proveedor = '" + idproveedor + "' AND Fk_Encabezado ='" + txtIdProveedores.Text + "';";
									controlador.metodoEliminar(query2);
								}
							}
							catch (Exception except) { }
						//}
					}
				}
			}
		}
		private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnActivo.Checked == true)
			{
				txtEstado.Text = "1";
			}
		}

		private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
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

		private void dgvVistaPrevia_SelectionChanged(object sender, EventArgs e)
		{
			
		}

		private void txtIdInventario_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxInventario, "inventarioe", "nombre", txtIdInventario.Text);
		}

		private void txtIdMarca_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxMarca, "marca", "nombre", txtIdMarca.Text);
		}

		private void txtIdAlmacenamiento_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxAlmacenamiento, "tipoalmacen", "nombre", txtIdAlmacenamiento.Text);
		}

		private void txtIdSucursal_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxSucursal, "sucursal", "nombre", txtIdSucursal.Text);
		}

		private void txtIdUbicacion_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxUbicacion, "ubicacion", "nombre", txtIdUbicacion.Text);
		}

		private void txtIdCat1_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxCat1, "categoria", "nombre", txtIdCat1.Text);
		}

		private void txtIdCat2_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxCat2, "categoria", "nombre", txtIdCat2.Text);
		}

		private void txtIdCat3_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxCat3, "categoria", "nombre", txtIdCat3.Text);
		}
		private void cbxCat1_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCAT(txtIdCat1, "categoria", "ID_Categoria", cbxCat1.Text, "1","1");
			if (txtIdCat1.Text == "")
			{
				cbxCat2.Items.Clear();
				cbxCat3.Items.Clear();
			}
			else
			{
				controlador.LlenarCat(cbxCat2, "categoria", "nombre", "2", txtIdCat1.Text);
			}

		}

		private void cbxCat2_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCAT(txtIdCat2, "categoria", "ID_Categoria", cbxCat2.Text,"2",txtIdCat1.Text);
			if (txtIdCat2.Text == "")
			{
				cbxCat3.Items.Clear();
			}
			else
			{
				controlador.LlenarCat(cbxCat3, "categoria", "nombre", "3", txtIdCat2.Text);
			}
		}

		private void txtIdProveedores_TextChanged(object sender, EventArgs e)
		{

		}
		private void cbxInventario_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCombo(txtIdInventario, "inventarioe", "ID_Encabezado", cbxInventario.Text);
		}

		private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCombo(txtIdMarca, "marca", "ID_Marca", cbxMarca.Text);
		}

		private void cbxAlmacenamiento_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCombo(txtIdAlmacenamiento, "tipoalmacen", "ID_Tipo_Almacenamiento", cbxAlmacenamiento.Text);
		}

		private void cbxCat3_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCAT(txtIdCat3, "categoria", "ID_Categoria", cbxCat3.Text, "3", txtIdCat2.Text);
			if (txtIdCat3.Text == "")
			{
				cbxCat3.Items.Clear();
			}
		}

		private void cbxSucursal_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCombo(txtIdSucursal, "sucursal", "ID_Sucursal", cbxSucursal.Text);
		}

		private void cbxBodega_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCombo(txtIdBodega, "bodega", "ID_Bodega", cbxBodega.Text);
			if (txtIdBodega.Text != "")
			{
				controlador.LlenarUbicacion(cbxUbicacion, "ubicacion", "nombre", txtIdBodega.Text);
			}
			else { }
		}

		private void txtIdBodega_TextChanged(object sender, EventArgs e)
		{
			controlador.NombreID(cbxBodega, "bodega", "nombre", txtIdBodega.Text);
		}

		private void cbxUbicacion_SelectedIndexChanged(object sender, EventArgs e)
		{
			controlador.IDCombo(txtIdUbicacion, "ubicacion", "ID_Ubicacion", cbxUbicacion.Text);
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			limpiar();
			actualizar();
			habilitar();
			txtID.Text = (controlador.idSiguienteDeNuevoIngreso("inventariod", "ID_Detalle")).ToString();
			accion = "1";
			txtIdProveedores.Text = controlador.idSiguienteDeNuevoIngreso("proveedore", "ID_Encabezado").ToString();
			deschequear();
			txtPrecio.Text = "0.00";
			txtPVenta.Text = "0.00";
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (txtNombre.Text != "")
			{
				habilitar();
				//txtID.Text = (controlador.idSiguienteDeNuevoIngreso("inventariod", "pkid")).ToString();
				accion = "2";
			}
			else { MessageBox.Show("No hay ningún registro seleccionado para modificar."); }
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			string query = "";
			switch (accion)
			{
				case "1":
					try
					{
						compruebaProveedores();

						query = "INSERT INTO inventariod VALUES( '" + txtID.Text + "', '" + txtIdInventario.Text + "', '" + txtSerie.Text + "', '" + txtNombre.Text + "', '" + txtDescripcion.Text + "', '" + txtCantidad.Text + "', '" + txtPrecio.Text + "', '" + txtPVenta.Text + "', '" + txtIdMarca.Text + "', '" + txtIdAlmacenamiento.Text + "', '" + txtIdCat1.Text + "', '" + txtIdCat2.Text + "', '" + txtIdCat3.Text + "', '" + txtIdSucursal.Text + "', '" + txtIdBodega.Text + "', '" + txtIdUbicacion.Text + "', '" + txtIdProveedores.Text + "', '" + txtMin.Text + "','" + txtMax.Text + "', '" + txtEstado.Text + "');";
						controlador.metodoInsertar(query);
						
						deshabilitar();
						actualizar();
						txtIdProveedores.Text = controlador.idSiguienteDeNuevoIngreso("proveedore", "ID_Encabezado").ToString();
						deschequear();
						LlenarTabla();
					}
					catch (Exception excep) {
						string querydetalles = "delete from proveedord where Fk_Encabezado = '" + txtIdProveedores.Text + "';";
						string queryencabezado = "delete from proveedore where ID_Encabezado = '" + txtIdProveedores.Text + "';";

						controlador.metodoEliminar(querydetalles);
						controlador.metodoEliminar(queryencabezado);

						MessageBox.Show("Error al guardar el registro");
					}
					deshabilitar();
					limpiar();
					actualizar();
					txtIdProveedores.Text = controlador.idSiguienteDeNuevoIngreso("proveedore", "ID_Encabezado").ToString();
					deschequear();
					break;
				case "2":
					try
					{
						query = "UPDATE inventariod SET Fk_Encabezado = '" + txtIdInventario.Text + "', serie ='" + txtSerie.Text + "', nombre ='" + txtNombre.Text + "', descipcion ='" + txtDescripcion.Text + "', cantidad ='" + txtCantidad.Text + "', precio_compra ='" + txtPrecio.Text + "', precio_venta ='" + txtPVenta.Text + "', fk_marca='" + txtIdMarca.Text + "', fk_tipo_almacenamiento='" + txtIdAlmacenamiento.Text + "', fk_categoria_1='" + txtIdCat1.Text + "', fk_categoria_2='" + txtIdCat2.Text + "', fk_categoria_3='" + txtIdCat3.Text + "', fk_sucursal='" + txtIdSucursal.Text + "', fk_bodega ='" + txtIdBodega.Text + "', fk_ubicacion='" + txtIdUbicacion.Text + "', fk_proveedores='" + txtIdProveedores.Text + "', inventario_minimo='" + txtMin.Text + "', inventario_maximo='" + txtMax.Text + "', estado='" + txtEstado.Text + "' WHERE ID_Detalle = '" + txtID.Text + "';";
						controlador.metodoModificar(query);
						compruebaProveedores();
						deshabilitar();
						txtIdProveedores.Text = controlador.idSiguienteDeNuevoIngreso("proveedore", "ID_Encabezado").ToString();
						deschequear();
						LlenarTabla();
					}
					catch (Exception ex) { MessageBox.Show("Error al editar el registro"); deshabilitar();}
					break;
				case "":
					MessageBox.Show("No se ha seleccionado una acción");
					deshabilitar();
					break;
			}

			if (dgvVistaPrevia.DataSource != null && txtIdProveedores.Text != "")
			{
				chequearProveedores();
			}
			else { }
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			accion = "";
			deshabilitar();
			limpiar();

			actualizar();
			txtID.Text = (controlador.idSiguienteDeNuevoIngreso("inventariod", "ID_Detalle")).ToString();
			txtIdProveedores.Text = controlador.idSiguienteDeNuevoIngreso("proveedore", "ID_Encabezado").ToString();
			deschequear();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (txtNombre.Text != "")
			{
				try
				{
					string query = query = "UPDATE inventariod SET estado = 0 where ID_Detalle = '" + txtID.Text + "';";
					controlador.metodoDarBaja(query);
					actualizar();
					deshabilitar();
					txtIdProveedores.Text = controlador.idSiguienteDeNuevoIngreso("proveedore", "ID_Encabezado").ToString();
					deschequear();
					if (dgvVistaPrevia.DataSource != null && txtIdProveedores.Text != "")
					{
						chequearProveedores();
					}
					else { }
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
			txtIdProveedores.Text = controlador.idSiguienteDeNuevoIngreso("proveedore", "ID_Encabezado").ToString();
			deschequear();
			if (dgvVistaPrevia.DataSource != null && txtIdProveedores.Text != "")
			{
				chequearProveedores();
			}
			else { }
		}
		private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
		public void actualizar()
		{
			LlenarTabla();
			cbxInventario.Items.Clear(); cbxMarca.Items.Clear();cbxAlmacenamiento.Items.Clear();
			cbxCat1.Items.Clear(); cbxSucursal.Items.Clear(); cbxBodega.Items.Clear();
			controlador.LlenarCBX(cbxInventario, "inventarioe", "nombre");
			controlador.LlenarCBX(cbxMarca, "marca", "nombre");
			controlador.LlenarCBX(cbxAlmacenamiento, "tipoalmacen", "nombre");
			controlador.LlenarCat(cbxCat1, "categoria", "nombre", "1", "1");
			controlador.LlenarCBX(cbxSucursal, "sucursal", "nombre");
			controlador.LlenarCBX(cbxBodega, "bodega", "nombre");
		}
		public void deschequear() {
			foreach (DataGridViewRow row in dgvProveedores.Rows)
			{
					row.Cells["Añadir"].Value = false;
			}
		}
		public void chequearProveedores()
		{
			if (txtIdProveedores.Text != "")
			{
				foreach (DataGridViewRow row in dgvProveedores.Rows)
				{
					string fkproveedor = row.Cells["ID_Proveedor"].Value.ToString();
					string nombre = row.Cells["nombre"].Value.ToString();
					Boolean chequeado = false;
					chequeado = controlador.encuentraProveedor(txtIdProveedores.Text, fkproveedor, nombre);
					bool bChecked = Convert.ToBoolean(row.Cells["Añadir"].Value);
					if (chequeado == true)
					{
						row.Cells["Añadir"].Value = true;
					}
					else
					{
						row.Cells["Añadir"].Value = false;
					}
				}
			}
			else { }
		}

		private void dgvVistaPrevia_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				txtID.Text = dgvVistaPrevia.CurrentRow.Cells[0].Value.ToString();
				txtIdInventario.Text = dgvVistaPrevia.CurrentRow.Cells[1].Value.ToString();
				txtSerie.Text = dgvVistaPrevia.CurrentRow.Cells[2].Value.ToString();
				txtNombre.Text = dgvVistaPrevia.CurrentRow.Cells[3].Value.ToString();
				txtDescripcion.Text = dgvVistaPrevia.CurrentRow.Cells[4].Value.ToString();
				txtCantidad.Text = dgvVistaPrevia.CurrentRow.Cells[5].Value.ToString();
				txtPrecio.Text = dgvVistaPrevia.CurrentRow.Cells[6].Value.ToString();
				txtPVenta.Text = dgvVistaPrevia.CurrentRow.Cells[7].Value.ToString();
				txtIdMarca.Text = dgvVistaPrevia.CurrentRow.Cells[8].Value.ToString();
				txtIdAlmacenamiento.Text = dgvVistaPrevia.CurrentRow.Cells[9].Value.ToString();
				txtIdCat1.Text = dgvVistaPrevia.CurrentRow.Cells[10].Value.ToString();
				txtIdCat2.Text = dgvVistaPrevia.CurrentRow.Cells[11].Value.ToString();
				txtIdCat3.Text = dgvVistaPrevia.CurrentRow.Cells[12].Value.ToString();
				txtIdSucursal.Text = dgvVistaPrevia.CurrentRow.Cells[13].Value.ToString();
				txtIdBodega.Text = dgvVistaPrevia.CurrentRow.Cells[14].Value.ToString();
				txtIdUbicacion.Text = dgvVistaPrevia.CurrentRow.Cells[15].Value.ToString();
				txtIdProveedores.Text = dgvVistaPrevia.CurrentRow.Cells[16].Value.ToString();
				txtMin.Text = dgvVistaPrevia.CurrentRow.Cells[17].Value.ToString();
				txtMax.Text = dgvVistaPrevia.CurrentRow.Cells[18].Value.ToString();
				txtEstado.Text = dgvVistaPrevia.CurrentRow.Cells[19].Value.ToString();

				chequearProveedores();
			}
			catch (Exception exc) { }
		}
		public void limpiar()
		{
			accion = "";
			txtIdInventario.Text = "";
			txtSerie.Text = "";
			txtNombre.Text = "";
			txtDescripcion.Text = "";
			txtCantidad.Text = "";
			txtIdMarca.Text = "";
			txtIdAlmacenamiento.Text = "";
			txtIdCat1.Text = "";
			txtIdCat2.Text = "";
			txtIdCat3.Text = "";
			txtIdSucursal.Text = "";
			txtIdBodega.Text = "";
			txtIdUbicacion.Text = "";
			txtMin.Text = "";
			txtMax.Text = "";
			txtEstado.Text = "1";
			txtPrecio.Text = "";
			txtPVenta.Text = "";

			cbxInventario.Text=""; cbxMarca.Text = ""; cbxAlmacenamiento.Text = "";
			cbxCat1.Text = ""; cbxSucursal.Text=""; cbxBodega.Text = ""; cbxCat2.Text = "";
			cbxCat3.Text = "";cbxUbicacion.Text = "";
			actualizar();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			Reporte13 reporte = new Reporte13();
			reporte.Show();
		}
	}
}
