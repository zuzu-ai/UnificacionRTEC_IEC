
namespace CapaVistaGestorInventarios
{
	partial class frmConsultaProducto
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProducto));
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblListaProveedor = new System.Windows.Forms.Label();
			this.lblTituloProveedor = new System.Windows.Forms.Label();
			this.lblSerie = new System.Windows.Forms.Label();
			this.lblPreciov = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.lblProducto = new System.Windows.Forms.Label();
			this.lblPrecioc = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 267);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.ReadOnly = true;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(776, 171);
			this.dgvVistaPrevia.TabIndex = 129;
			this.dgvVistaPrevia.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVistaPrevia_RowHeaderMouseClick);
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtBusqueda.Location = new System.Drawing.Point(125, 24);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(567, 20);
			this.txtBusqueda.TabIndex = 130;
			this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
			this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 131;
			this.label1.Text = "Inserte una busqueda";
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
			this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
			this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnConsultar.FlatAppearance.BorderSize = 0;
			this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultar.Location = new System.Drawing.Point(695, 9);
			this.btnConsultar.Margin = new System.Windows.Forms.Padding(0);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(50, 50);
			this.btnConsultar.TabIndex = 158;
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblListaProveedor);
			this.panel2.Controls.Add(this.lblTituloProveedor);
			this.panel2.Controls.Add(this.lblSerie);
			this.panel2.Controls.Add(this.lblPreciov);
			this.panel2.Controls.Add(this.lblMarca);
			this.panel2.Controls.Add(this.lblProducto);
			this.panel2.Controls.Add(this.lblPrecioc);
			this.panel2.Controls.Add(this.lblCantidad);
			this.panel2.Location = new System.Drawing.Point(12, 62);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 199);
			this.panel2.TabIndex = 271;
			// 
			// lblListaProveedor
			// 
			this.lblListaProveedor.AutoSize = true;
			this.lblListaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblListaProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblListaProveedor.Location = new System.Drawing.Point(404, 84);
			this.lblListaProveedor.Name = "lblListaProveedor";
			this.lblListaProveedor.Size = new System.Drawing.Size(0, 24);
			this.lblListaProveedor.TabIndex = 273;
			// 
			// lblTituloProveedor
			// 
			this.lblTituloProveedor.AutoSize = true;
			this.lblTituloProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTituloProveedor.Location = new System.Drawing.Point(404, 57);
			this.lblTituloProveedor.Name = "lblTituloProveedor";
			this.lblTituloProveedor.Size = new System.Drawing.Size(0, 24);
			this.lblTituloProveedor.TabIndex = 272;
			// 
			// lblSerie
			// 
			this.lblSerie.AutoSize = true;
			this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSerie.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblSerie.Location = new System.Drawing.Point(3, 156);
			this.lblSerie.Name = "lblSerie";
			this.lblSerie.Size = new System.Drawing.Size(0, 24);
			this.lblSerie.TabIndex = 271;
			// 
			// lblPreciov
			// 
			this.lblPreciov.AutoSize = true;
			this.lblPreciov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPreciov.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPreciov.Location = new System.Drawing.Point(3, 108);
			this.lblPreciov.Name = "lblPreciov";
			this.lblPreciov.Size = new System.Drawing.Size(0, 24);
			this.lblPreciov.TabIndex = 269;
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblMarca.Location = new System.Drawing.Point(3, 132);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(0, 24);
			this.lblMarca.TabIndex = 270;
			// 
			// lblProducto
			// 
			this.lblProducto.AutoSize = true;
			this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProducto.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProducto.Location = new System.Drawing.Point(2, 11);
			this.lblProducto.Name = "lblProducto";
			this.lblProducto.Size = new System.Drawing.Size(0, 25);
			this.lblProducto.TabIndex = 266;
			// 
			// lblPrecioc
			// 
			this.lblPrecioc.AutoSize = true;
			this.lblPrecioc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecioc.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPrecioc.Location = new System.Drawing.Point(3, 84);
			this.lblPrecioc.Name = "lblPrecioc";
			this.lblPrecioc.Size = new System.Drawing.Size(0, 24);
			this.lblPrecioc.TabIndex = 268;
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCantidad.Location = new System.Drawing.Point(3, 57);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(0, 24);
			this.lblCantidad.TabIndex = 267;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
			this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
			this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimpiar.FlatAppearance.BorderSize = 0;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Location = new System.Drawing.Point(745, 8);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(0);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(50, 50);
			this.btnLimpiar.TabIndex = 272;
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// frmConsultaProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsultaProducto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta de Producto";
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblPreciov;
		private System.Windows.Forms.Label lblProducto;
		private System.Windows.Forms.Label lblPrecioc;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.Label lblListaProveedor;
		private System.Windows.Forms.Label lblTituloProveedor;
		private System.Windows.Forms.Label lblSerie;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.Button btnLimpiar;
	}
}