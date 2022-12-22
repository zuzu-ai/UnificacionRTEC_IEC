using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloProyecto
{
    public class Sentencias
    {
        DataTable tabla = new DataTable();
        private Conexion cn = new Conexion();
        //Foto
        public byte[] obtenerByte(string id)
        {
            int bufferSize = 100; byte[] bytefoto = new byte[bufferSize];
            byte[] binary = null;
            try
            {
                string insertQuery = "SELECT * FROM foto WHERE pkId ='" + id + "';";
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

        public void insertaFoto(string id, byte[] foto)
        {
            try
            {
                string insertQuery = "UPDATE foto SET fotografia=? where pkId='" + id + "';";
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
        public int idSiguienteDeNuevoIngreso(string tabla, string campoB)
        {
            string ultimoEntero = ""; int enteroSumado = 0; OdbcDataReader leer = null;
            string sql = "select" + " " + "(" + campoB + "*1" + ")" + " " + "as" + " " + campoB + " " + "FROM" + " " + tabla + " " + "ORDER BY" + " " + campoB + " " + "DESC Limit 1";
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

        public int idEncabezadoActual(string tabla, string campoB)
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
                    enteroSumado = int.Parse(ultimoEntero);
                }
            }
            catch (OdbcException ex)
            { MessageBox.Show("Error al cargar los datos" + ex.Message); }
            { cn.desconexion(conect); }
            return enteroSumado;
        }

        //Asignación de equipos

        //LLenata tabla empleados disponibles
        public DataTable llanarTblEmpleadoDisponibles(string dato)
        {
            DataTable table = new DataTable(); OdbcConnection conect = cn.conexion();
            try
            {
                //Obtiene todos los empleados
                string sql = "SELECT ID_Empleado, nombre FROM empleado  WHERE empleado.ID_Empleado NOT IN(SELECT Fk_Empleado FROM equipodetalle where equipodetalle.Fk_Encabezado = '" + dato + "');";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conect);
                dataTable.Fill(table);
                //MessageBox.Show(sql);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tabla disponibles" + ex);
                return table;
            }
            finally
            {
                cn.desconexion(conect);
            }
        }

        //Llena tabla empleados asignados

        public DataTable llanarTblEmpleadoAsignados(string tabla, string dato)
        {
            DataTable table = new DataTable(); OdbcConnection conect = cn.conexion();
            try
            {
                //Obtiene todos los conceptos asignados a un emepleado especifico
                string sql = "SELECT empleado.ID_Empleado, empleado.nombre FROM " + tabla + " LEFT JOIN equipodetalle ON empleado.ID_Empleado= equipodetalle.Fk_Empleado LEFT JOIN equipoencabezado ON equipodetalle.Fk_Encabezado = equipoencabezado.ID_Encabezado WHERE equipoencabezado.ID_Encabezado = '" + dato + "' ORDER BY empleado.ID_Empleado;";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conect);
                dataTable.Fill(table);
               // MessageBox.Show(sql);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tabla asignados" + ex);
                return table;
            }
            finally
            {
                cn.desconexion(conect);
            }
        }

        //Asigna un empleado
        public void AsignarEmpleados(string tabla, string valor1, string valor2)
        {
            OdbcConnection conect = cn.conexion();
            try
            {
                string sql = "INSERT INTO " + tabla + " (Fk_Encabezado, Fk_Empleado) Values( '" + valor1 + "', '" + valor2 + "');";
                OdbcCommand consulta = new OdbcCommand(sql, conect);
                consulta.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
              //  MessageBox.Show("Error al asignar empleado");               
            }
            finally
            {
                cn.desconexion(conect);
            }
        }
        public void AsignarATodosLosEmpleados(string tabla, string valor)
        {
            OdbcConnection conect = cn.conexion();
            try
            {
                string sql = "DELETE FROM " + tabla + " WHERE Fk_Encabezado= '" + valor + "';";
                OdbcCommand consulta = new OdbcCommand(sql, conect);
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Error al asignar empleados");
            }
            finally
            {
                cn.desconexion(conect);
            }
        }
        //Se elima a un empleado asignado al concepto
        public void EliminarUnEmpleadoAsignado(string tabla, string valor1, string valor2)
        {
            OdbcConnection conect = cn.conexion();
            try
            {
                string sql = "DELETE FROM " + tabla + " WHERE Fk_Encabezado = '" + valor1 + "' AND Fk_Empleado='" + valor2 + "';";
                OdbcCommand consulta = new OdbcCommand(sql, conect);
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar empleados");
            }
            finally
            {
                cn.desconexion(conect);
            }
        }

        //Se eliminan todos los empleados asignados al concepto
        public void EliminarTodasLasAsignacionesEmpleados(string tabla, string valor)
        {
            OdbcConnection conect = cn.conexion();
            try
            {
                string sql = "DELETE FROM " + tabla + " WHERE Fk_Encabezado = '" + valor + "';";
                OdbcCommand consulta = new OdbcCommand(sql, conect);
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar empleados");
            }
            finally
            {
                cn.desconexion(conect);
            }
        }

        //Cotización

        public void bloqueabotones(string tipousuario, Button btnIngresar, Button btnEditar, Button btnGuardar, Button btnCancelar, Button btnEliminar, Button btnImprimir, Button btnActualizar, Button btnAyuda, Button btnSalir)
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
                btnSalir.Enabled = true;
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
                btnSalir.Enabled = true;
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
                btnSalir.Enabled = true;
            }
        }

        public void LlenarCBX(ComboBox cbx, string tabla, string campobuscado)
        {
            string dato = "";
            try
            {
                cbx.Items.Clear();
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1';";
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    // throw new Exception("No hay dato guardado.");
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

        public DataTable ActualizaDetalles(string tabla, string cotizacion)// metodo  que obtinene el contenio de una tabla
        {
            Conexion cn = new Conexion();
            string sql = "select * from " + tabla + " where Fk_Encabezado = '" + cotizacion + "' ORDER BY ID_Detalle;";
            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
            cn.desconexion(conn);
            /* se trajo el código del procesamiento de la data ODBC a esta parte 
             * para aumentar la seguridad, antes estaba en la capa Controlador*/
            DataTable table = new DataTable();
            dataTable.Fill(table);
            return table;
        }

        public DataTable ActualizarDGV(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            Conexion cn = new Conexion();
            string sql = "select * from " + tabla + " " + "ORDER BY ID_Encabezado;";
            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
            cn.desconexion(conn);
            /* se trajo el código del procesamiento de la data ODBC a esta parte 
             * para aumentar la seguridad, antes estaba en la capa Controlador*/
            DataTable table = new DataTable();
            dataTable.Fill(table);
            return table;
        }

        public void convertirFechaDTP(DateTimePicker dtp, TextBox txt)
        {
            DateTime date = new DateTime();

            date = dtp.Value;
            string fecha = dtp.Value.ToString("yyyy-MM-dd");
            txt.Text = fecha;
        }

        public void convertirFechaMySQL(DateTimePicker dtp, TextBox txt)
        {
            DateTime fecha = new DateTime();
            fecha = Convert.ToDateTime(txt.Text);
            dtp.Value = fecha.Date;
        }

        public void IDcombo(TextBox textbox, string tabla, string campobuscado, string nombre)
        {
            string dato = "";
            try
            {
                textbox.Text = "";
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND nombre = '" + nombre + "';";
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    // throw new Exception("No hay dato guardado.");
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

        public void LlenarCBXProducto(ComboBox cbx, string tabla, string campobuscado, string inventario)
        {
            string dato = "";
            try
            {
                cbx.Items.Clear();
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND Fk_Encabezado = '" + inventario + "';";
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    // throw new Exception("No hay dato guardado.");
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

        public void NombreID(ComboBox combo, string tabla, string campobuscado, string pkid)
        {
            string dato = "";
            try
            {
                //textbox.Text = "";
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND ID_Encabezado = '" + pkid + "';";
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    // throw new Exception("No hay dato guardado.");
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

        public void IDProducto(TextBox textbox, string tabla, string campobuscado, string nombre, string inventario)
        {
            string dato = "";
            try
            {
                textbox.Text = "";
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND nombre = '" + nombre + "' AND Fk_Encabezado = '" + inventario + "';";
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    // throw new Exception("No hay dato guardado.");
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

        public string BuscaDato(string tabla, string campo, string campobuscado, string datoreferencia)
        {
            string dato = "";
            try
            {
                string insertQuery = "SELECT * FROM " + tabla + " WHERE " + campobuscado + " = '" + datoreferencia + "';";
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    // throw new Exception("No hay dato guardado.");
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

        public void NombreIDProducto(ComboBox combo, string tabla, string campobuscado, string pkid, string inventario)
        {
            string dato = "";
            try
            {
                //textbox.Text = "";
                string insertQuery = "SELECT * FROM " + tabla + " WHERE estado = '1' AND ID_Detalle = '" + pkid + "' AND Fk_Encabezado = '" + inventario + "';";
                //MessageBox.Show(insertQuery);
                OdbcConnection conect = cn.conexion();
                OdbcCommand command = new OdbcCommand(insertQuery, conect);
                command.ExecuteNonQuery(); OdbcDataReader busquedac;
                busquedac = command.ExecuteReader();
                if (!busquedac.HasRows)
                {
                    // throw new Exception("No hay dato guardado.");
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

        public void metodoInsertar(string query)
        {
            int ret;
            try
            {

                OdbcCommand consulta = new OdbcCommand(query, cn.conexion());
                consulta.ExecuteNonQuery();
                ret = 1;
                //MessageBox.Show("Registro guardado con éxito");
            }

            catch (OdbcException ex)
            {
                //MessageBox.Show("Error al guardar el registro: " + ex.Message);
                ret = 0;
            }
        }
        public void metodoModificar(string query)
        {
            int ret;
            try
            {

                OdbcCommand consulta = new OdbcCommand(query, cn.conexion());
                consulta.ExecuteNonQuery();
                ret = 1;
                // MessageBox.Show("Registro editado con éxito");
            }

            catch (OdbcException ex)
            {
                //MessageBox.Show("Error al editar el registro: " + ex.Message);
                ret = 0;
            }
        }

        public void metodoDarBaja(string query)
        {
            int ret;
            try
            {

                OdbcCommand consulta = new OdbcCommand(query, cn.conexion());
                consulta.ExecuteNonQuery();
                ret = 1;
                //MessageBox.Show("Registro dado de baja");
            }

            catch (OdbcException ex)
            {
                //MessageBox.Show("Error al dar de baja el registro: " + ex.Message);
                ret = 0;
            }
        }
        public void metodoEliminar(string query)
        {
            int ret;
            try
            {

                OdbcCommand consulta = new OdbcCommand(query, cn.conexion());
                consulta.ExecuteNonQuery();
                ret = 1;
            }

            catch (OdbcException ex)
            {
                //MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                ret = 0;
            }
        }

        public DataTable ObtenerDetalles(string cotizacion, string total)// metodo  que obtinene el contenio de una tabla
        {
            Conexion cn = new Conexion();
            string sql = "select cotizaciond.cantidad as 'Cantidad', inventariod.nombre as 'Producto', cotizaciond.precio as 'Precio Unitario', cotizaciond.subtotal as 'Subtotal' from cotizaciond inner join inventariod where cotizaciond.fkinventarioD = inventariod.pkid and fkcotizacionE = '" + cotizacion + "';";
            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
            cn.desconexion(conn);
            /* se trajo el código del procesamiento de la data ODBC a esta parte 
             * para aumentar la seguridad, antes estaba en la capa Controlador*/
            DataTable table = new DataTable();
            dataTable.Fill(table);

            return table;
        }

        //Bloquear Botones

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
    }
}
