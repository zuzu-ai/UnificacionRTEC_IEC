using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloGestorInventarios
{
    public class Sentencias
    {
        //variables globales
        private Conexion cn = new Conexion();
        //funcion para enviar la fecha de contrato/despido
        public void EnviarContratoDespido(DateTimePicker date, TextBox textoDate, CheckBox check)
        {
            String dt = "";
            if (check.Checked == true)
            {
                textoDate.Text = "";
            }
            else if (check.Checked == false)
            {
                dt = date.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
                textoDate.Text = dt;
            }
        }
        //funcion para recibir la fecha de contrato/despido
        public void RecibirContratoDespido(DateTimePicker date, TextBox textoDate, CheckBox check)
        {
            if (check.Checked == true)
            {
            }
            else if (check.Checked == false)
            {
                if (textoDate.Text != "")
                {
                    date.Value = Convert.ToDateTime(textoDate.Text.ToString());
                }
            }
        }
        //función para bloquear el botón de reporte
        public void bloqueareporte(string tipousuario, Button reporte)
        {
            if (tipousuario == "admin" || tipousuario == "Admin" || tipousuario == "ADMIN" || tipousuario == "administrador" || tipousuario == "Administrador" || tipousuario == "ADMINISTRADOR")
            {
                reporte.Enabled = true;
            }
            else if (tipousuario == "supervisor" || tipousuario == "Supervisor" || tipousuario == "SUPERVISOR")
            {
                reporte.Enabled = true;
            }
            else if (tipousuario == "visitante" || tipousuario == "Visitante" || tipousuario == "VISITANTE")
            {
                reporte.Enabled = false;
            }
        }
        //función para bloquear el botón de imagen
        public void bloqueaimagen(string tipousuario, Button imagen)
        {
            if (tipousuario == "admin" || tipousuario == "Admin" || tipousuario == "ADMIN" || tipousuario == "administrador" || tipousuario == "Administrador" || tipousuario == "ADMINISTRADOR")
            {
                imagen.Enabled = true;
            }
            else if (tipousuario == "supervisor" || tipousuario == "Supervisor" || tipousuario == "SUPERVISOR")
            {
                imagen.Enabled = false;
            }
            else if (tipousuario == "visitante" || tipousuario == "Visitante" || tipousuario == "VISITANTE")
            {
                imagen.Enabled = false;
            }
        }
        //función para cambiar la contraseña
        public void CambioContrasena(string tabla, string contrasena, string id, string usuario)
        {
            try
            {
                string cadena = "UPDATE " + tabla + " SET contrasena = '" + contrasena + "' " + "WHERE ID_Usuario='" + id + "' AND usuario.usuario='" + usuario + "';";
                OdbcConnection conect = cn.conexion();

                OdbcCommand consulta = new OdbcCommand(cadena,conect);
                consulta.ExecuteNonQuery();
                MessageBox.Show("La contraseña se ha actualizado");
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Asignación:" + ex);
            }
        }
        //función para obtener el id del siguiente registro
        public int idSiguienteDeNuevoIngreso(string tabla, string campoB)
        {
            string ultimoEntero = ""; int enteroSumado = 0; OdbcDataReader leer = null;
            string sql = "select (" + campoB + "*1" + ") as '" + campoB + "' FROM " + tabla + " ORDER BY " + campoB + " DESC Limit 1;";
            OdbcConnection conect = cn.conexion();
            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    ultimoEntero = leer.GetString(0);
                    enteroSumado = int.Parse(ultimoEntero) + 1;
                }
            }
            catch (OdbcException ex)
            { MessageBox.Show("Error al cargar los datos" + ex.Message); }
            finally
            { cn.desconexion(conect); }
            if (enteroSumado == 0)
            { enteroSumado = 1; }

            return enteroSumado;
        }
        //función para obtener el byte de una imagen
        public byte[] obtenerByte(string id)
        {
            int bufferSize = 100; byte[] bytefoto = new byte[bufferSize];
            byte[] binary = null;
            try
            {
                string insertQuery = "SELECT * FROM foto WHERE ID_Fotografia ='" + id + "';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    throw new Exception("No hay fotografia guardada.");
                }
                if (busquedac.Read())
                {
                    binary = (byte[])busquedac["fotografia"];
                }
                cn.desconexion(conect);
                return binary;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar imagen" + ex);
                return null;
            }
        }
        //función para insertar una nueva foto en la base de datos en un registro preexistente
        public void insertaNuevaFoto(string id, byte[] foto)
        {
            try
            {
                string insertQuery = "INSERT INTO foto VALUES ('" + id + "',?);";
                OdbcConnection conect = cn.conexion(); //conect.Open();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                OdbcParameter prm = new OdbcParameter("@img", OdbcType.Binary, foto.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, foto);
                command.Parameters.Add(prm);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Foto cargada", "Aviso");
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar imagen" + ex);
            }
        }
        //función para insertar una foto nueva
        public void insertaFoto(string id, byte[] foto)
        {
            try
            {
                string insertQuery = "UPDATE foto SET fotografia=? where id_fotografia='" + id + "';";
                OdbcConnection conect = cn.conexion(); //conect.Open();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                OdbcParameter prm = new OdbcParameter("@img", OdbcType.Binary, foto.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, foto);
                command.Parameters.Add(prm);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Foto cargada", "Aviso");
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar imagen" + ex);
            }
        }
        //función para llenar combobox de categoria con categoria superior
        public void LlenarCategoria(ComboBox cbx, string tabla, string campobuscado, string tipo, string catsup)
        {
            string dato = "";
            try
            {
                cbx.Items.Clear();
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND fk_tipo_categoria = '" + tipo + "' AND fk_categoria_superior ='" + catsup + "' AND Fk_Empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    cbx.Items.Add(dato);
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //función para llenar categoria sin categoria superior
        public void LlenarCA(ComboBox cbx, string tabla, string campobuscado, string tipo, string nocatsup)
        {
            string dato = "";
            try
            {
                cbx.Items.Clear();
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND fk_tipo_categoria = '" + tipo + "' AND fk_empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    cbx.Items.Add(dato);
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //función para obtener el ID del dato seleccionado en el combobox
        public void IDcombo(TextBox textbox, string tabla, string campobuscado, string nombre)
        {
            string dato = "";
            try
            {
                textbox.Text = "";
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND nombre = '" + nombre + "' AND fk_empresa= '1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    textbox.Text = dato;
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //función para obtener el nombre que corresponde al ID en el combobox
        public void NombreID(ComboBox combo, string tabla, string campobuscado, string pkid, string campoid)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND " + campoid + " = '" + pkid + "' AND fk_Empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    combo.SelectedItem = dato;
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //función para bloquear botones del navegador
        public void bloqueabotones(string tipousuario, Button btnIngresar, Button btnEditar, Button btnGuardar, Button btnCancelar, Button btnEliminar, Button btnImprimir, Button btnActualizar, Button btnAyuda)
        {
            if (tipousuario == "admin" || tipousuario == "Admin" || tipousuario == "ADMIN" || tipousuario == "administrador" || tipousuario == "Administrador" || tipousuario == "ADMINISTRADOR")
            {
                btnIngresar.Enabled = true;
                btnEditar.Enabled = true;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEliminar.Enabled = true;
                btnImprimir.Enabled = true;
                btnActualizar.Enabled = true;
                btnAyuda.Enabled = true;
            }
            else if (tipousuario == "supervisor" || tipousuario == "Supervisor" || tipousuario == "SUPERVISOR")
            {
                btnIngresar.Enabled = false;
                btnEditar.Enabled = false;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = false;
                btnImprimir.Enabled = true;
                btnActualizar.Enabled = true;
                btnAyuda.Enabled = true;
            }
            else if (tipousuario == "visitante" || tipousuario == "Visitante" || tipousuario == "VISITANTE")
            {
                btnIngresar.Enabled = false;
                btnEditar.Enabled = false;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = false;
                btnImprimir.Enabled = true;
                btnActualizar.Enabled = false;
                btnAyuda.Enabled = true;
            }
        }
        //función para insertar en la base de datos
        public void metodoInsertar(string query)
        {
            int ret;
            try
            {
                OdbcConnection conect = cn.conexion();
                OdbcCommand consulta = new OdbcCommand(query, conect);
                consulta.ExecuteNonQuery();
                ret = 1;
                cn.desconexion(conect);
            }
            catch (OdbcException ex)
            {
                ret = 0;
            }
        }
        //función para modificar registros en la base de datos
        public void metodoModificar(string query)
        {
            int ret;
            try
            {
                OdbcConnection conect = cn.conexion();
                OdbcCommand consulta = new OdbcCommand(query, cn.conexion());
                consulta.ExecuteNonQuery();
                ret = 1;
                cn.desconexion(conect);
            }
            catch (OdbcException ex)
            {
                ret = 0;
            }
        }
        //función para dar de baja un registro
        public void metodoDarBaja(string query)
        {
            int ret;
            try
            {
                OdbcConnection conect = cn.conexion();
                OdbcCommand consulta = new OdbcCommand(query, cn.conexion());
                consulta.ExecuteNonQuery();
                ret = 1;
                cn.desconexion(conect);
            }
            catch (OdbcException ex)
            {
                ret = 0;
            }
        }
        //función para eliminar registros de la base de datos
        public void metodoEliminar(string query)
        {
            int ret;
            try
            {
                OdbcConnection conect = cn.conexion();
                OdbcCommand consulta = new OdbcCommand(query, cn.conexion());
                consulta.ExecuteNonQuery();
                ret = 1;
                cn.desconexion(conect);
            }
            catch (OdbcException ex)
            {
                ret = 0;
            }
        }
        //función para actualizar/mostrar los datos en el DataGridView
        public DataTable ActualizarDGV(string tabla, string campoid)
        {
            Conexion cn = new Conexion();
            string sql = "select * from " + tabla + "  WHERE fk_Empresa='1' " + "ORDER BY " + campoid + ";";
            OdbcConnection conect = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conect);
            cn.desconexion(conect);
            DataTable table = new DataTable();
            dataTable.Fill(table);
            return table;
        }
        //función para llenar combobox con consulta simple
        public void LlenarCBX(ComboBox cbx, string tabla, string campobuscado)
        {
            string dato = "";
            try
            {
                cbx.Items.Clear();
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND fk_Empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    cbx.Items.Add(dato);
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //función para llenar categoria con categoria superior
        public void LlenarCat(ComboBox cbx, string tabla, string campobuscado, string tipo, string catsup)
        {
            string dato = "";
            try
            {
                cbx.Items.Clear();
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND fk_tipo_categoria = '" + tipo + "' AND fk_categoria_superior = '" + catsup + "' AND fk_Empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    cbx.Items.Add(dato);
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //llenar combobox con ubicación de la bodega
        public void LlenarUbicacion(ComboBox cbx, string tabla, string campobuscado, string bodega)
        {
            string dato = "";
            try
            {
                cbx.Items.Clear();
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND fk_bodega = '" + bodega + "' AND fk_Empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    cbx.Items.Add(dato);
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //función para llenar la tabla de proveedores
        public DataTable LlenarProveedores(string tabla)
        {
            Conexion cn = new Conexion();
            string sql = "select id_proveedor, nombre from " + tabla + " AND fk_Empresa='1' " + "ORDER BY id_proveedor;";
            OdbcConnection conect = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conect);
            cn.desconexion(conect);

            DataTable table = new DataTable();
            dataTable.Fill(table);
            return table;
        }
        //función para obtener el ID de categoria con categoria superior
        public void IDCAT(TextBox textbox, string tabla, string campobuscado, string nombre, string tipo, string catsup)
        {
            string dato = "";
            try
            {
                textbox.Text = "";
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND nombre = '" + nombre + "' AND fk_tipo_categoria = '" + tipo + "' AND fk_categoria_superior = '" + catsup + "' AND fk_Empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    textbox.Text = dato;
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //función para obtener el id de categoria sin categoria superior
        public void IDCATE(TextBox textbox, string tabla, string campobuscado, string nombre, string tipo)
        {
            string dato = "";
            try
            {
                textbox.Text = "";
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND nombre = '" + nombre + "' AND fk_tipo_categoria = '" + tipo + "' AND fk_Empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    textbox.Text = dato;
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //función para encontrar los proveedores de un producto
        public Boolean encuentraProveedor(string fkproveedore, string fkproveedor, string nombre)
        {
            string dato = ""; Boolean chequeado= false;
            try
            {
                string insertQuery = "SELECT * FROM proveedord, proveedore, proveedor where proveedord.fk_encabezado = '" + fkproveedore + "' AND proveedord.fk_proveedor = '" + fkproveedor + "' AND proveedore.id_encabezado = proveedord.fk_encabezado AND proveedor.id_proveedor = proveedord.fk_proveedor AND proveedor.nombre = '" + nombre + "';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    chequeado = false;
                }
                while (busquedac.Read())
                {
                    chequeado = true;
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
            return chequeado;
        }
        //función para obtener el id coincidente
        public Boolean idcoincidente(string tabla, string pkid, string  campoid)
        {
            string dato = ""; Boolean chequeado = false;
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " where " + campoid + " = '" + pkid + "';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    chequeado = false;
                }
                while (busquedac.Read())
                {
                    chequeado = true;
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
            return chequeado;
        }
        //función para obtener el registro existente
        public Boolean registroexiste(string tabla, string fkproveedores, string fkproveedore)
        {
            string dato = ""; Boolean chequeado = false;
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " where  fk_proveedor = '" + fkproveedores + "' and fk_encabezado = '" + fkproveedore + "' AND fk_Empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    chequeado = false;
                }
                while (busquedac.Read())
                {
                    chequeado = true;
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
            return chequeado;
        }
        //función para llenar el combobox de producto
        public void LlenarCBXProducto(ComboBox cbx, string tabla, string campobuscado, string inventario)
        {
            string dato = "";
            try
            {
                cbx.Items.Clear();
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND fk_encabezado = '" + inventario + "' AND fk_Empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    cbx.Items.Add(dato);
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //función para obtener el id de producto
        public void IDProducto(TextBox textbox, string tabla, string campobuscado, string nombre, string inventario)
        {
            string dato = "";
            try
            {
                textbox.Text = "";
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND nombre = '" + nombre + "' AND fk_encabezado = '" + inventario + "' AND fk_Empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    textbox.Text = dato;
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //obtener el nombre del producto
        public void NombreIDProducto(ComboBox combo, string tabla,string campobuscado, string pkid, string inventario)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND ID_Detalle = '" + pkid + "' AND fk_encabezado = '" + inventario + "' AND fk_Empresa='1';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                while (busquedac.Read())
                {
                    dato = busquedac[campobuscado].ToString();
                    combo.SelectedItem = dato;
                }
                cn.desconexion(conect);
            }
            catch (Exception ex)
            {
            }
        }
        //funcion para convertir la fecha de DateTimePicker a Mysql
        public void convertirFechaDTP(DateTimePicker dtp, TextBox txt)
        {
            DateTime date = new DateTime();

            date = dtp.Value;
            string fecha = dtp.Value.ToString("yyyy-MM-dd");
            txt.Text = fecha;
        }
        //función para convertir la fecha MySQL a DateTimePicker
        public void convertirFechaMySQL(DateTimePicker dtp, TextBox txt)
        {
            DateTime fecha = new DateTime();
            fecha = Convert.ToDateTime(txt.Text);
            dtp.Value = fecha.Date;
        }
        //función para buscar dato
        public string BuscaDato(string tabla, string campo, string campobuscado, string datoreferencia)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " WHERE " + campobuscado + " = '" + datoreferencia + "';";
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                }
                if (busquedac.Read())
                {
                    dato = busquedac[campo].ToString();
                }
                cn.desconexion(conect);
                return dato;
            }
            catch (Exception ex)
            {
                return dato;
            }
        }
        //función para actualizar los detalles de cotización
        public DataTable ActualizaDetalles(string tabla, string cotizacion)
        {
            Conexion cn = new Conexion();
            string sql = "select * from " + tabla + " where fk_encabezado = '" + cotizacion + "';";
            OdbcConnection conect = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conect);
            cn.desconexion(conect);
            DataTable table = new DataTable();
            dataTable.Fill(table);
            return table;
        }
        //función para obtener los detalles de cotización
        public DataTable ObtenerDetalles(string cotizacion, string total)
        {
            Conexion cn = new Conexion();
            string sql = "select cotizaciond.cantidad as 'Cantidad', inventariod.nombre as 'Producto', cotizaciond.precio as 'Precio Unitario', cotizaciond.subtotal as 'Subtotal' from cotizaciond inner join inventariod where cotizaciond.fk_producto = inventariod.id_detalle and cotizaciond.fk_encabezado = '" + cotizacion + "';";
            OdbcConnection conect = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conect);
            cn.desconexion(conect);
            DataTable table = new DataTable();
            dataTable.Fill(table);

            return table;
        }
        //función para cargar recordatorios de productos en su inventario mínimo
        public DataTable CargarRecordatorio(string sql)
        {
            Conexion cn = new Conexion();
            OdbcConnection conect = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conect);
            cn.desconexion(conect);
            DataTable table = new DataTable();
            dataTable.Fill(table);

            return table;
        }
        //función para obtener los proveedores de un producto
        public DataTable ObtenerProveedores(string encabezado)
        {
            string sql = "select nombre from proveedor, proveedord where proveedor.ID_Proveedor = proveedord.Fk_Proveedor and proveedor.Fk_Empresa='1' and proveedord.Fk_Encabezado= '" + encabezado + "';";
            OdbcConnection conect = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conect);
            DataTable table = new DataTable();
            dataTable.Fill(table);
            cn.desconexion(conect);
            return table;
        }
        //funcion para autocompletar una consulta
        public void autocompletar(TextBox txt, string texto)
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

            string sql = "select inventariod.Nombre from inventariod,inventarioe where inventariod.fk_encabezado = inventarioe.id_encabezado and inventarioe.fk_empresa = '1' and inventariod.Nombre like '%" + texto + "%';";
            OdbcConnection conect = cn.conexion();
            OdbcDataAdapter adaptador = new OdbcDataAdapter(sql, conect);
            DataTable table = new DataTable();
            adaptador.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                lista.Add(table.Rows[i]["Nombre"].ToString());
            }
            txt.AutoCompleteCustomSource = lista;
        }
        //funcion para llenar la tabla de productos
        public DataTable LlenarProductos()
        {
            Conexion cn = new Conexion();
            string sql = "select inventariod.Nombre as 'Producto', inventariod.Precio_Venta as 'Precio Venta', inventariod.Precio_Compra as 'Precio Compra', inventariod.Cantidad as 'Disponibilidad', Marca.Nombre as 'Marca', inventariod.Serie as 'Serie' from inventarioe, inventariod, marca where marca.ID_Marca = inventariod.Fk_Marca and inventarioe.Fk_Empresa='1';";
            OdbcConnection conect = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conect);
            cn.desconexion(conect);
            DataTable table = new DataTable();
            dataTable.Fill(table);
            return table;
        }
    }
}
