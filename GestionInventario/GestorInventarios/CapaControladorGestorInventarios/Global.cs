using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorGestorInventarios
{
	public class Global
	{
		private DataTable table = new DataTable();
		static string fechat;
		static string usuario;
		static string id;
		static string idtusuario;
		static string nombretusuario;
		static string cotizacion;

		public DataTable obtenertabla
		{
			get { return table; }
			set { table = value; }
		}
		public string fechatrabajada
		{
			get { return fechat; }
			set { fechat = value; }
		}
		public string obtieneusuario
		{
			get { return usuario; }
			set { usuario = value; }
		}
		public string obtieneid
		{
			get { return id; }
			set { id = value; }
		}
		public string obtieneidtusuario
		{
			get { return idtusuario; }
			set { idtusuario = value; }
		}
		public string obtienenombretusuario
		{
			get { return nombretusuario; }
			set { nombretusuario = value; }
		}
		public string cotizacionseleccionada
		{
			get { return cotizacion; }
			set { cotizacion = value; }
		}
	}
}
