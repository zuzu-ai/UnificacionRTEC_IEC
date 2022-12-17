using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorProyecto
{
	public class Global
	{
		private DataTable table = new DataTable();
		private string fechat;
		private string usuario;
		private string id;
		private string idtusuario;
		private string nombretusuario;
		private string cotizacion;

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

		//Obtiene Usuario
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
