using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaProyecto
{
    
    public partial class frmPantallaCarga : Form
    {
                     
        public frmPantallaCarga()
        {
            InitializeComponent();
                               
        }
              
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            progressBar1.Increment(5);
            label1.Text = progressBar1.Value.ToString() + "%";
            for (int i =5; i< progressBar1.Maximum; i+=5)
            {
                string puntos = "...";
                string barra = "";
                barra = barra + puntos;
                label3.Text = barra;
                
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                frmMDI b = new frmMDI();
                b.ShowDialog();
            }
        }
    }
}
