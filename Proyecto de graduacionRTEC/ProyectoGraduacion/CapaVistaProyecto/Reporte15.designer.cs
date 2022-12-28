
namespace CapaVistaGestorInventarios
{
	partial class Reporte15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte15));
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtEstadoE = new System.Windows.Forms.TextBox();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.txtIDE = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnInactivoE = new System.Windows.Forms.RadioButton();
            this.rbnActivoE = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvGuardar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(402, 54);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(39, 20);
            this.txtFecha.TabIndex = 280;
            this.txtFecha.TabStop = false;
            this.txtFecha.Tag = "fkinventarioE";
            this.txtFecha.Visible = false;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(122, 54);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(268, 20);
            this.dtpFecha.TabIndex = 279;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(8, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 278;
            this.label5.Text = "Fecha:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(121, 81);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(267, 20);
            this.txtTotal.TabIndex = 276;
            this.txtTotal.Tag = "nombre";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl.Location = new System.Drawing.Point(5, 85);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 17);
            this.lbl.TabIndex = 277;
            this.lbl.Text = "Total:";
            // 
            // txtEstadoE
            // 
            this.txtEstadoE.Location = new System.Drawing.Point(339, 111);
            this.txtEstadoE.Name = "txtEstadoE";
            this.txtEstadoE.Size = new System.Drawing.Size(39, 20);
            this.txtEstadoE.TabIndex = 274;
            this.txtEstadoE.Tag = "estado";
            this.txtEstadoE.Visible = false;
            this.txtEstadoE.TextChanged += new System.EventHandler(this.txtEstadoE_TextChanged);
            // 
            // txtProyecto
            // 
            this.txtProyecto.Enabled = false;
            this.txtProyecto.Location = new System.Drawing.Point(121, 28);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(268, 20);
            this.txtProyecto.TabIndex = 271;
            this.txtProyecto.Tag = "serie";
            // 
            // txtIDE
            // 
            this.txtIDE.Enabled = false;
            this.txtIDE.Location = new System.Drawing.Point(122, 3);
            this.txtIDE.Name = "txtIDE";
            this.txtIDE.Size = new System.Drawing.Size(268, 20);
            this.txtIDE.TabIndex = 269;
            this.txtIDE.Tag = "pkid";
            this.txtIDE.TextChanged += new System.EventHandler(this.txtIDE_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbnInactivoE);
            this.panel1.Controls.Add(this.rbnActivoE);
            this.panel1.Location = new System.Drawing.Point(133, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 28);
            this.panel1.TabIndex = 275;
            // 
            // rbnInactivoE
            // 
            this.rbnInactivoE.AutoSize = true;
            this.rbnInactivoE.Enabled = false;
            this.rbnInactivoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbnInactivoE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbnInactivoE.Location = new System.Drawing.Point(104, 1);
            this.rbnInactivoE.Name = "rbnInactivoE";
            this.rbnInactivoE.Size = new System.Drawing.Size(74, 21);
            this.rbnInactivoE.TabIndex = 3;
            this.rbnInactivoE.TabStop = true;
            this.rbnInactivoE.Text = "Inactivo";
            this.rbnInactivoE.UseVisualStyleBackColor = true;
            this.rbnInactivoE.CheckedChanged += new System.EventHandler(this.rbnInactivoE_CheckedChanged);
            // 
            // rbnActivoE
            // 
            this.rbnActivoE.AutoSize = true;
            this.rbnActivoE.Enabled = false;
            this.rbnActivoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbnActivoE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbnActivoE.Location = new System.Drawing.Point(31, 1);
            this.rbnActivoE.Name = "rbnActivoE";
            this.rbnActivoE.Size = new System.Drawing.Size(64, 21);
            this.rbnActivoE.TabIndex = 2;
            this.rbnActivoE.TabStop = true;
            this.rbnActivoE.Text = "Activo";
            this.rbnActivoE.UseVisualStyleBackColor = true;
            this.rbnActivoE.CheckedChanged += new System.EventHandler(this.rbnActivoE_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(8, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 273;
            this.label8.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 272;
            this.label2.Text = "Proyecto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 270;
            this.label1.Text = "ID:";
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.AllowUserToResizeRows = false;
            this.dgvVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVistaPrevia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(10, 143);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.RowHeadersWidth = 51;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(506, 295);
            this.dgvVistaPrevia.TabIndex = 281;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(463, 41);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(50, 50);
            this.btnExportar.TabIndex = 282;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvGuardar
            // 
            this.dgvGuardar.AllowUserToAddRows = false;
            this.dgvGuardar.AllowUserToDeleteRows = false;
            this.dgvGuardar.AllowUserToResizeRows = false;
            this.dgvGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGuardar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGuardar.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvGuardar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuardar.Location = new System.Drawing.Point(11, 143);
            this.dgvGuardar.Name = "dgvGuardar";
            this.dgvGuardar.ReadOnly = true;
            this.dgvGuardar.RowHeadersWidth = 51;
            this.dgvGuardar.Size = new System.Drawing.Size(506, 295);
            this.dgvGuardar.TabIndex = 283;
            // 
            // Reporte15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.dgvGuardar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtEstadoE);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.txtIDE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte15";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Cotización";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.TextBox txtEstadoE;
		private System.Windows.Forms.TextBox txtProyecto;
		private System.Windows.Forms.TextBox txtIDE;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnInactivoE;
		private System.Windows.Forms.RadioButton rbnActivoE;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.Button btnExportar;
		private System.Windows.Forms.DataGridView dgvGuardar;
	}
}