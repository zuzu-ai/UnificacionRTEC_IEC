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
        //Variables globales
        private Sentencias sn = new Sentencias();

        //Función para enviar la fecha de contrato/despido
        public void EnviarContratoDespido(DateTimePicker date, TextBox textoDate, CheckBox check)
        {
            sn.EnviarContratoDespido(date, textoDate, check);
        }
        //Función para recibir la fecha de contrato/despido
        public void RecibirContratoDespido(DateTimePicker date, TextBox textoDate, CheckBox check)
        {
            sn.RecibirContratoDespido(date, textoDate, check);
        }
        //Función para bloquear el botón de reporte
        public void bloqueareporte(string tipousuario, Button reporte)
        {
            sn.bloqueareporte(tipousuario, reporte);
        }
        //Función para bloquear el botón de imagen
        public void bloquearimagen(string tipousuario, Button imagen)
        {
            sn.bloqueaimagen(tipousuario, imagen);
        }
        //Función para enviar el cambio de contraseña
        public void CambioContrasena(string tabla, string contrasena, string id, string usuario)
        {
            sn.CambioContrasena(tabla, contrasena, id, usuario);
        }
        //Función para obtener el byte de una imagen
        public byte[] obtenerByte(string id)
        {
            byte[] imagen = sn.obtenerByte(id);
            return imagen;
        }
        //función para insertar una imagen en la base de datos en un registro preexistente
        public void insertaNuevaFoto(string id, byte[] foto)
        {
            sn.insertaNuevaFoto(id, foto);
        }
        //función para insertar la foto en un nuevo registro
        public void insertaFoto(string id, byte[] foto)
        {
            sn.insertaFoto(id, foto);
        }
        //Función para obtener el ID que corresponde al nuevo registro
        public int idSiguienteDeNuevoIngreso(string tabla, string campoB)
        {
            int id = sn.idSiguienteDeNuevoIngreso(tabla, campoB);
            return id;
        }
        //Función para bloquear botones
        public void bloqueabotones(string tipousuario, Button btnIngresar, Button btnEditar, Button btnGuardar, Button btnCancelar, Button btnEliminar, Button btnImprimir, Button btnActualizar, Button btnAyuda)
        {
            sn.bloqueabotones(tipousuario, btnIngresar, btnEditar, btnGuardar, btnCancelar, btnEliminar, btnImprimir, btnActualizar, btnAyuda);
        }
        //Función para llenar los combobox de categoría con condición de categoria superior
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
        //Función para llenar combobox de categorias sin categoria superior
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
        //Función para obtener el ID del dato seleccionado en un combobox
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
        //Función para obtener el nombre correspondiente a un ID dentro de un combobox
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
        //Función para insertar en la base de datos
        public void metodoInsertar(string query)
        {
            sn.metodoInsertar(query);
        }
        //Función para modificar registros en la base de datos
        public void metodoModificar(string query)
        {
            sn.metodoModificar(query);
        }
        //Función para dar de baja dentro de la base de datos
        public void metodoDarBaja(string query)
        {
            sn.metodoDarBaja(query);
        }
        //Función para eliminar registros de la base de datos
        public void metodoEliminar(string query)
        {
            sn.metodoEliminar(query);
        }
        //Función para mostrar/actualizar los datos dentro de un DataGridView
        public DataTable ActualizarDGV(string tablaDB, string campoid)
        {
            return sn.ActualizarDGV(tablaDB, campoid);
        }
        //Función para llenar un combobox con condición simple
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
        //Función para llenar combobox de categoría con categoria superior
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
        //función para llenar combobox de ubicación dentro de bodega
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
        //función para llenar la tabla de proveedores
        public DataTable LlenarProveedores(string tablaDB)
        {
            return sn.LlenarProveedores(tablaDB);
        }
        //Función para obtener el ID de categoría con categoría superior
        public void IDCAT(TextBox textbox, string tabla, string campobuscado, string nombre, string tipo, string catsup)
        {
            sn.IDCAT(textbox, tabla, campobuscado, nombre, tipo, catsup);
        }
        //función para obtener el id de categoria sin categoría superior
        public void IDCATE(TextBox textbox, string tabla, string campobuscado, string nombre, string tipo)
        {
            sn.IDCATE(textbox, tabla, campobuscado, nombre, tipo);
        }
        //función para obtener el proveedor del producto
        public Boolean encuentraProveedor(string fkproveedore, string fkproveedor, string nombre)
        {
            Boolean chequeado = false;
            chequeado = sn.encuentraProveedor(fkproveedore, fkproveedor, nombre);
            return chequeado;
        }
        //función para encontrar coincidencia en un ID de encabezado
        public Boolean idcoincidente(string tabla, string pkid, string campoid)
        {
            Boolean chequeado = false;
            chequeado = sn.idcoincidente(tabla, pkid, campoid);
            return chequeado;
        }
        //función para encontrar un registro existente
        public Boolean registroexiste(string tabla, string fkproveedores, string fkproveedore)
        {
            Boolean chequeado = false;
            chequeado = sn.registroexiste(tabla, fkproveedores, fkproveedore);
            return chequeado;
        }
        //Función para llenar el combobox de producto
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
        //función para obtener el ID del producto seleccionado en el combobox
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
        //función para obtener el nombre correspondiente al ID en el combobox
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
        //función para convertir la fecha del DateTimePicker a MySQL
        public void convertirFechaDTP(DateTimePicker dtp, TextBox txt)
        {
            sn.convertirFechaDTP(dtp, txt);
        }
        //función para convertir la fecha de MySQL a DateTimePicker
        public void convertirFechaMySQL(DateTimePicker dtp, TextBox txt)
        {
            sn.convertirFechaMySQL(dtp, txt);
        }
        //función para buscar un dato
        public string BuscaDato(string tabla, string campo, string campobuscado, string datoreferencia)
        {
            string dato = "";
            dato = sn.BuscaDato(tabla, campo, campobuscado, datoreferencia);
            return dato;
        }
        //Función para actualizar los detalles de cotización
        public DataTable ActualizaDetalles(string tablaDB, string cotizacion)
        {
            return sn.ActualizaDetalles(tablaDB, cotizacion);
        }
        //función para obtener los detalles de cotización
        public DataTable ObtenerDetalles(string cotizacion, string total)
        {
            return sn.ObtenerDetalles(cotizacion, total);
        }
        // función para cargar los recordatorios de productos en inventario mínimo
        public DataTable CargarRecordatorio(string sql)
        {
            return sn.CargarRecordatorio(sql);
        }
        //función para obtener los proveedores en lista
        public DataTable ObtenerProveedores(string encabezado)
        {
            return sn.ObtenerProveedores(encabezado);
        }
        //función para autocompletar una consulta en textbox
        public void autocompletar(TextBox txt, string texto)
        {
            sn.autocompletar(txt, texto);
        }
        //función para llenar la tabla de productos
        public DataTable LlenarProductos()
        {
            return sn.LlenarProductos();
        }
    }
}
