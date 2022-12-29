using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloNavegador;

namespace CapaControladorNavegador
{
    public class Controlador
    {
        string errores = "";
        TextBox[] texts;
        Control control;
        Sentencias Modelo = new Sentencias();
        public TextBox[] ordenandoTextos(Control parent)
        {
            texts = Modelo.AsignaAlias(parent);
            control = parent;
            TextBox[] alias = new TextBox[texts.Length];
            int j = 0;
            for (int i = (texts.Length - 1); i >= 0; i--)
            {
                alias[j] = texts[i];
                j++;
            }
            return alias;
        }
        public void comparaTagscampoBD(TextBox[] alias, string tabla, string BD)
        {
            try
            {
                errores = Modelo.comparaTagscampoBD(alias, tabla, BD);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion comparaTagscampoBD");
            }
        }
        public void funAsignarSalidadControl(Form menu)
        {
            try
            {
                if (String.IsNullOrEmpty(errores))
                {
                    Modelo.metodoSalir(menu);
                    Modelo.metodoDeshabilitarTexts(control);
                }
                else
                {
                    MessageBox.Show(errores);
                    menu.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion funAsignarSalidadControl");
            }
        }
        public int idSiguienteDeNuevoIngreso(string tabla)
        {
            int longitud = texts.Length;
            int entero = Modelo.idSiguienteDeNuevoIngreso(tabla, texts[longitud - 1].Tag.ToString());
            return entero;
        }
        public void metodoLlenarCombo(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            try
            {
                Modelo.metodoLlenarCombo(cbx, tabla, value, display, estatus);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");
            }
        }
        public void SeleccionDeFilaDGV(DataGridView data)
        {
            try
            {
                Modelo.SeleccionDeFilaDGV(data);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion SeleccionDeFilaDGV");
            }
        }
        public void activaRadiobtn(RadioButton activo, RadioButton inactivo, TextBox estatus)
        {
            try
            {
                Modelo.metodoActivaRadiobtn(activo, inactivo, estatus);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion activaRadiobtn");
            }
        }
        public void CambioEstadoTextBox(TextBox estado, RadioButton AI, string cadenaEstado)
        {
            try
            {
                Modelo.CambioEstadoTextBox(estado, AI, cadenaEstado);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion CambioEstadoTextBox");
            }
        }
        public void enviarDatoCbxaTextbox(ComboBox combo, TextBox combotexto)
        {
            try
            {
                Modelo.metodoEnviarDatoCbxaTextbox(combo, combotexto);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion enviarDatoCbxaTextbox");
            }
        }
        public void SeleccionarElementoEnComboBox(ComboBox combo, TextBox combotexto)
        {
            try
            {
                Modelo.SeleccionarElementoEnComboBox(combo, combotexto);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion SeleccionarElementoEnComboBox");
            }
        }
        public void CambiarFormatoFecha(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                Modelo.metodoCambiarFormatoFecha(date, textoDate);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion CambiarFormatoFecha");
            }
        }
        public void SeleccionarFechaDTP(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                Modelo.SeleccionarFechaDTP(date, textoDate);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion SeleccionarFechaDTP");
            }
        }
        public string obtieneRutaReporte(string idAplicacion, string campoRuta, string campoB, string tablaR)
        {
            string ruta = Modelo.obtieneRutaReporte(idAplicacion, campoRuta, campoB, tablaR);
            return ruta;
        }
        public DataTable ActualizarDGV(string tablaDB)
        {
            return Modelo.ActualizarDGV(tablaDB);
        }
        public bool modificar(TextBox[] campos, string tablas)//Modificar de Wilber Enrique Segura Ramirez 0901-18-13952
        {
            return Modelo.Modificar(campos, tablas);
        }
        public bool insertarDatostabla(TextBox[] campos, string tablas)
        {
            return Modelo.metodoInsertarDatosTabla(campos, tablas);
        }
        public void InhabilitarRegistro(TextBox[] arreglo, string tabla, string campoEstado)
        {
            try
            {
                Modelo.metodoInhabilitarRegistro(arreglo, tabla, campoEstado);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion InhabilitarRegistro");
            }
        }
        public void LlamadaAyudas(string idAplicacion, string nombreCampo, string tablaA)
        {
            try
            {
                Modelo.LlamadaAyudas(idAplicacion, nombreCampo, tablaA, control);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion LlamadaAyudas");
            }
        }
        public void metodoRecibeHora(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                Modelo.metodoRecibeHora(date, textoDate);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion SeleccionarFechaDTP");
            }
        }
        public void metodoColocaHora(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                Modelo.metodoColocaHora(date, textoDate);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion CambiarFormatoFecha");
            }
        }

        public void bloquearBtn(Button Agregar, Button Modificar, Button Guardar, Button Cancelar, Button Eliminar, Button Reporte, Button Actualizar, Button Inicio, Button Anterior, Button Siguiente, Button Final, Button Ayuda, Button Salir, string tipousuario)
        {

            try
            {
                Modelo.bloquearBtn(Agregar, Modificar, Guardar, Cancelar, Eliminar, Reporte, Actualizar, Inicio, Anterior, Siguiente, Final, Ayuda, Salir, tipousuario);
            }
            catch
            {
                MessageBox.Show("Error en la capa controlador, revisar la funcion bloquearBtn");
            }


        }
    }
}