using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloProyecto;

namespace CapaControladorProyecto
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();
        //Foto
        public byte[] obtenerByte(string id)
        {
            byte[] imagen = sn.obtenerByte(id);
            return imagen;
        }
        public void insertaNuevaFoto(string id, byte[] foto)
        {
            sn.insertaNuevaFoto(id, foto);
        }
        public void insertaFoto(string id, byte[] foto)
        {
            sn.insertaFoto(id, foto);
        }
        public int idSiguienteDeNuevoIngreso(string tabla, string campoB)
        {
            int id = sn.idSiguienteDeNuevoIngreso(tabla, campoB);
            return id;
        }

        //Asignación de equipos

        public DataTable llanarTblEmpleadoDisponibles(string dato)
        {
            DataTable table = new DataTable();
            table = sn.llanarTblEmpleadoDisponibles(dato);
            return table;
        }
        public DataTable llanarTblEmpleadosAsignados(string tabla, string dato)
        {
            DataTable table = new DataTable();
            table = sn.llanarTblEmpleadoAsignados(tabla, dato);
            return table;
        }

        public void AsignarEmpleados(string tabla, string valor1, string valor2)
        {
            sn.AsignarEmpleados(tabla, valor1, valor2);
        }
        public void AsignarATodosLosEmpleados(string tabla, string valor)
        {
            sn.AsignarATodosLosEmpleados(tabla, valor);
        }
        public void EliminarUnEmpleadoAsignado(string tabla, string valor1, string valor2)
        {
            sn.EliminarUnEmpleadoAsignado(tabla, valor1, valor2);
        }
        //Se eliminan todos los empleados asignados al concepto
        public void EliminarTodasLasAsignacionesEmpleados(string tabla, string valor)
        {
            sn.EliminarTodasLasAsignacionesEmpleados(tabla, valor);
        }

        //Cotizacion 
        public void bloqueabotones(string tipousuario, Button btnIngresar, Button btnEditar, Button btnGuardar, Button btnCancelar, Button btnEliminar, Button btnImprimir, Button btnActualizar, Button btnAyuda, Button btnSalir)
        {
            sn.bloqueabotones(tipousuario, btnIngresar, btnEditar, btnGuardar, btnCancelar, btnEliminar, btnImprimir, btnActualizar, btnAyuda, btnSalir);
        }

        public void LlenarCBX(ComboBox cbx, string tabla, string campobuscado)
        {
            try
            {
                sn.LlenarCBX(cbx, tabla, campobuscado);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
        }

        public DataTable ActualizaDetalles(string tablaDB, string cotizacion)
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return sn.ActualizaDetalles(tablaDB, cotizacion);
        }

        public DataTable ActualizarDGV(string tablaDB)
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return sn.ActualizarDGV(tablaDB);
        }

        public void convertirFechaDTP(DateTimePicker dtp, TextBox txt)
        {
            sn.convertirFechaDTP(dtp, txt);
        }

        public void convertirFechaMySQL(DateTimePicker dtp, TextBox txt)
        {
            sn.convertirFechaMySQL(dtp, txt);
        }

        public void IDCombo(TextBox textbox, string tabla, string campobuscado, string nombre)
        {
            try
            {
                sn.IDcombo(textbox, tabla, campobuscado, nombre);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
        }

        public void LlenarCBXProducto(ComboBox cbx, string tabla, string campobuscado, string inventario)
        {
            try
            {
                sn.LlenarCBXProducto(cbx, tabla, campobuscado, inventario);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCBXProducto");
            }
        }

        public void NombreID(ComboBox combo, string tabla, string campobuscado, string nombre)
        {
            try
            {
                sn.NombreID(combo, tabla, campobuscado, nombre);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
        }

        public void IDProducto(TextBox textbox, string tabla, string campobuscado, string nombre, string inventario)
        {
            try
            {
                sn.IDProducto(textbox, tabla, campobuscado, nombre, inventario);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
        }

        public string BuscaDato(string tabla, string campo, string campobuscado, string datoreferencia)
        {
            string dato = "";
            dato = sn.BuscaDato(tabla, campo, campobuscado, datoreferencia);
            return dato;
        }

        public void NombreIDProducto(ComboBox combo, string tabla, string campobuscado, string pkid, string inventario)
        {
            try
            {
                sn.NombreIDProducto(combo, tabla, campobuscado, pkid, inventario);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
        }

        public void metodoInsertar(string query)
        {
            sn.metodoInsertar(query);
        }

        public void metodoModificar(string query)
        {
            sn.metodoModificar(query);
        }

        public void metodoDarBaja(string query)
        {
            sn.metodoDarBaja(query);
        }
        public void metodoEliminar(string query)
        {
            sn.metodoEliminar(query);
        }
        public DataTable ObtenerDetalles(string cotizacion, string total)
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return sn.ObtenerDetalles(cotizacion, total);
        }

        //Bloquear Botones 

        public void bloqueareporte(string tipousuario, Button reporte)
        {
            sn.bloqueareporte(tipousuario, reporte);
        }
    }

}
