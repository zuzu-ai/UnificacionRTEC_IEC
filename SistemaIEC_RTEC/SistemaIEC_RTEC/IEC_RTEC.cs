using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorIEC_RTEC;


namespace SistemaIEC_RTEC
{
	public partial class IEC_RTEC : Form
	{
		//variables globales
		private Controlador controlador = new Controlador();
		private Global g = new Global();
		public IEC_RTEC()
		{
			InitializeComponent();
		}
	}
}
