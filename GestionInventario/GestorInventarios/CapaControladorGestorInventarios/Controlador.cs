using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloGestorInventarios;

namespace CapaControladorGestorInventarios
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();

        public void EnviarContratoDespido(DateTimePicker date, TextBox textoDate, CheckBox check)
        {
            sn.EnviarContratoDespido(date, textoDate, check);
        }
        public void RecibirContratoDespido(DateTimePicker date, TextBox textoDate, CheckBox check)
        {
            sn.RecibirContratoDespido(date, textoDate, check);
        }
        public void bloqueareporte(string tipousuario, Button reporte)
        {
            sn.bloqueareporte(tipousuario, reporte);
        }
        public void bloquearimagen(string tipousuario, Button imagen)
        {
            sn.bloqueaimagen(tipousuario, imagen);
        }
        public void CambioContrasena(string tabla, string contrasena, string id, string usuario)
        {
            sn.CambioContrasena(tabla, contrasena, id, usuario);
        }
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
        public void bloquearañadirprov(string tipousuario, Button anadirprov)
        {
            sn.bloqueaañadirprov(tipousuario, anadirprov);
        }
        public void bloqueabotones(string tipousuario, Button btnIngresar, Button btnEditar, Button btnGuardar, Button btnCancelar, Button btnEliminar, Button btnImprimir, Button btnActualizar, Button btnAyuda)
        {
            sn.bloqueabotones(tipousuario, btnIngresar, btnEditar, btnGuardar, btnCancelar, btnEliminar, btnImprimir, btnActualizar, btnAyuda);
        }
        public void LlenarCombo(ComboBox cbx, string tabla, string campobuscado, string catsup)
        {
            try
            {
                sn.LlenarCombo(cbx, tabla, campobuscado, catsup);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
        }
        public void LlenarCategoria(ComboBox cbx, string tabla, string campobuscado, string tipo, string catsup)
        {
            try
            {
                sn.LlenarCategoria(cbx, tabla, campobuscado, tipo, catsup);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
        }
        public void LlenarCA(ComboBox cbx, string tabla, string campobuscado, string tipo, string nocatsup)
        {
            try
            {
                sn.LlenarCA(cbx, tabla, campobuscado, tipo, nocatsup);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
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
        public void NombreID(ComboBox combo, string tabla, string campobuscado, string nombre, string campoid)
        {
            try
            {
                sn.NombreID(combo, tabla, campobuscado, nombre, campoid);
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
        public DataTable ActualizarDGV(string tablaDB, string campoid)
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return sn.ActualizarDGV(tablaDB, campoid);
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
        public void LlenarCat(ComboBox cbx, string tabla, string campobuscado, string tipo, string catsup)
        {
            try
            {
                sn.LlenarCat(cbx, tabla, campobuscado, tipo, catsup);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
        }
        public void LlenarUbicacion(ComboBox cbx, string tabla, string campobuscado, string bodega)
        {
            try
            {
                sn.LlenarUbicacion(cbx, tabla, campobuscado, bodega);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
        }
        public DataTable LlenarProveedores(string tablaDB)
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return sn.LlenarProveedores(tablaDB);
        }
        public void IDCAT(TextBox textbox, string tabla, string campobuscado, string nombre, string tipo, string catsup)
        {
            sn.IDCAT(textbox, tabla, campobuscado, nombre, tipo, catsup);
        }
        public void IDCATE(TextBox textbox, string tabla, string campobuscado, string nombre, string tipo)
        {
            sn.IDCATE(textbox, tabla, campobuscado, nombre, tipo);
        }
        public Boolean encuentraProveedor(string fkproveedore, string fkproveedor, string nombre)
        {
            Boolean chequeado = false;
            chequeado = sn.encuentraProveedor(fkproveedore, fkproveedor, nombre);
            return chequeado;
        }
        public Boolean idcoincidente(string tabla, string pkid, string campoid)
        {
            Boolean chequeado = false;
            chequeado = sn.idcoincidente(tabla, pkid, campoid);
            return chequeado;
        }
        public Boolean registroexiste(string tabla, string fkproveedores, string fkproveedore)
        {
            Boolean chequeado = false;
            chequeado = sn.registroexiste(tabla, fkproveedores, fkproveedore);
            return chequeado;
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
        public void convertirFechaDTP(DateTimePicker dtp, TextBox txt)
        {
            sn.convertirFechaDTP(dtp, txt);
        }
        public void convertirFechaMySQL(DateTimePicker dtp, TextBox txt)
        {
            sn.convertirFechaMySQL(dtp, txt);
        }
        public string BuscaDato(string tabla, string campo, string campobuscado, string datoreferencia)
        {
            string dato = "";
            dato = sn.BuscaDato(tabla, campo, campobuscado, datoreferencia);
            return dato;
        }
        public DataTable ActualizaDetalles(string tablaDB, string cotizacion)
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return sn.ActualizaDetalles(tablaDB, cotizacion);
        }
        public DataTable ObtenerDetalles(string cotizacion, string total)
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return sn.ObtenerDetalles(cotizacion, total);
        }
        public DataTable CargarRecordatorio(string sql)
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return sn.CargarRecordatorio(sql);
        }
        public DataTable ObtenerProveedores(string encabezado)
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return sn.ObtenerProveedores(encabezado);
        }
        public void autocompletar(TextBox txt, string texto)
        {
            sn.autocompletar(txt, texto);
        }
        public DataTable LlenarProductos()
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return sn.LlenarProductos();
        }
    }
}
