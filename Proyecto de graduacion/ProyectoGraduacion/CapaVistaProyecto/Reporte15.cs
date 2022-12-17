using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorProyecto;

namespace CapaVistaGestorInventarios
{
	public partial class Reporte15 : Form
	{
		Controlador controlador = new Controlador();
		Global g = new Global();
		public Reporte15()
		{
			InitializeComponent();
			txtIDE.Text = g.cotizacionseleccionada;
			try
			{
				ObtenerDatosE();
			}
			catch (Exception excep) { }

			try
			{
				llenarTblGuardar();
			} catch (Exception e) { }
		}

		public void ObtenerDatosE()
		{
			if (txtIDE.Text != "")
			{
				txtProyecto.Text = controlador.BuscaDato("cotizacione", "proyecto", "pkid", txtIDE.Text);
				txtFecha.Text = controlador.BuscaDato("cotizacione", "fecha", "pkid", txtIDE.Text);
				txtTotal.Text = controlador.BuscaDato("cotizacione", "total", "pkid", txtIDE.Text);
				txtEstadoE.Text = controlador.BuscaDato("cotizacione", "estado", "pkid", txtIDE.Text);
			}
			else { }
		}

		public void ObtenerDetalles()
		{
			try
			{
				DataTable dt = new DataTable();
				dt = controlador.ObtenerDetalles(txtIDE.Text, txtTotal.Text);
				dgvVistaPrevia.DataSource = dt;
			}
			catch (Exception e) { }
		}
		public void llenarTblGuardar()
		{

			DataTable table = new DataTable();
			table.Columns.Add("Cantidad");
			table.Columns.Add("Producto");
			table.Columns.Add("Precio Unitario");
			table.Columns.Add("Subtotal");
			

			foreach (DataGridViewRow rowGrid in dgvVistaPrevia.Rows)
			{
				DataRow row = table.NewRow();
				row["Cantidad"] = (rowGrid.Cells[0].Value).ToString();
				row["Producto"] = (rowGrid.Cells[1].Value).ToString();
				row["Precio Unitario"] = (rowGrid.Cells[2].Value).ToString();
				row["Subtotal"] = (rowGrid.Cells[3].Value).ToString();

				table.Rows.Add(row);
			}
				DataRow row2 = table.NewRow();
				row2["Cantidad"] = " ";
				row2["Producto"] = " ";
				row2["Precio Unitario"] = "Total";
				row2["Subtotal"] = txtTotal.Text;
				table.Rows.Add(row2);
			dgvGuardar.DataSource = table;

		}
		private void btnExportar_Click(object sender, EventArgs e)
		{
			DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
			printer.Title = "Cotización" + "\n" + txtProyecto.Text;

			printer.SubTitle = string.Format("Formato: " + txtIDE.Text + "\n" + "  Fecha de Generación: " + dtpFecha.Text);
			printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
			printer.PageNumbers = true;
			printer.PageNumberInHeader = false;
			printer.PorportionalColumns = true;
			printer.HeaderCellAlignment = StringAlignment.Near;
			printer.Footer = "RTEC";
			printer.FooterSpacing = 15;
			printer.PrintDataGridView(dgvGuardar);
		}

		private void dtpFecha_ValueChanged(object sender, EventArgs e)
		{
			controlador.convertirFechaDTP(dtpFecha, txtFecha);
		}

		private void txtFecha_TextChanged(object sender, EventArgs e)
		{
			controlador.convertirFechaMySQL(dtpFecha, txtFecha);
		}

		private void rbnActivoE_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnActivoE.Checked == true)
			{
				txtEstadoE.Text = "1";
			}
		}

		private void rbnInactivoE_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnInactivoE.Checked == true)
			{
				txtEstadoE.Text = "0";
			}
		}

		private void txtEstadoE_TextChanged(object sender, EventArgs e)
		{
			if (txtEstadoE.Text == "1")
			{
				rbnActivoE.Checked = true;
			}
			else if (txtEstadoE.Text == "0")
			{
				rbnInactivoE.Checked = true;
			}
		}

		private void txtIDE_TextChanged(object sender, EventArgs e)
		{
			if (txtIDE.Text != "")
			{
				ObtenerDetalles();
			}
			else { }
		}
	}
}
