
namespace CapaVistaGestorInventarios
{
	partial class frmEmpleado
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtIdFoto = new System.Windows.Forms.TextBox();
			this.txtDespido = new System.Windows.Forms.TextBox();
			this.txtContratacion = new System.Windows.Forms.TextBox();
			this.txtJornada = new System.Windows.Forms.TextBox();
			this.txtDPI = new System.Windows.Forms.TextBox();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.txtIdPuesto = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.chbxNoDespido = new System.Windows.Forms.CheckBox();
			this.chbxNoContratacion = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
			this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
			this.navegadorMantenimientos1 = new CapaVistaNavegador.NavegadorMantenimientos();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.btnAyuda = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.pbFoto = new System.Windows.Forms.PictureBox();
			this.dtpDespido = new System.Windows.Forms.DateTimePicker();
			this.dtpContratacion = new System.Windows.Forms.DateTimePicker();
			this.cbxJornada = new System.Windows.Forms.ComboBox();
			this.cbxPuesto = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(619, 255);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(39, 20);
			this.txtEstado.TabIndex = 144;
			this.txtEstado.Tag = "estado";
			this.txtEstado.Visible = false;
			this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
			// 
			// txtIdFoto
			// 
			this.txtIdFoto.Location = new System.Drawing.Point(195, 263);
			this.txtIdFoto.Name = "txtIdFoto";
			this.txtIdFoto.Size = new System.Drawing.Size(32, 20);
			this.txtIdFoto.TabIndex = 147;
			this.txtIdFoto.Tag = "foto";
			this.txtIdFoto.Visible = false;
			this.txtIdFoto.EnabledChanged += new System.EventHandler(this.txtIdFoto_EnabledChanged);
			this.txtIdFoto.TextChanged += new System.EventHandler(this.txtIdFoto_TextChanged);
			// 
			// txtDespido
			// 
			this.txtDespido.Location = new System.Drawing.Point(619, 231);
			this.txtDespido.Name = "txtDespido";
			this.txtDespido.Size = new System.Drawing.Size(39, 20);
			this.txtDespido.TabIndex = 146;
			this.txtDespido.Tag = "despido";
			this.txtDespido.Visible = false;
			this.txtDespido.TextChanged += new System.EventHandler(this.txtDespido_TextChanged);
			// 
			// txtContratacion
			// 
			this.txtContratacion.Location = new System.Drawing.Point(619, 205);
			this.txtContratacion.Name = "txtContratacion";
			this.txtContratacion.Size = new System.Drawing.Size(39, 20);
			this.txtContratacion.TabIndex = 145;
			this.txtContratacion.Tag = "contratacion";
			this.txtContratacion.Visible = false;
			this.txtContratacion.TextChanged += new System.EventHandler(this.txtContratacion_TextChanged);
			// 
			// txtJornada
			// 
			this.txtJornada.Location = new System.Drawing.Point(619, 179);
			this.txtJornada.Name = "txtJornada";
			this.txtJornada.Size = new System.Drawing.Size(39, 20);
			this.txtJornada.TabIndex = 132;
			this.txtJornada.Tag = "fkjornada";
			this.txtJornada.Visible = false;
			this.txtJornada.TextChanged += new System.EventHandler(this.txtJornada_TextChanged);
			// 
			// txtDPI
			// 
			this.txtDPI.Location = new System.Drawing.Point(336, 153);
			this.txtDPI.Name = "txtDPI";
			this.txtDPI.Size = new System.Drawing.Size(267, 20);
			this.txtDPI.TabIndex = 135;
			this.txtDPI.Tag = "DPI";
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(336, 126);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(268, 20);
			this.txtNombres.TabIndex = 130;
			this.txtNombres.Tag = "nombre";
			this.txtNombres.EnabledChanged += new System.EventHandler(this.txtNombres_EnabledChanged);
			// 
			// txtIdPuesto
			// 
			this.txtIdPuesto.Location = new System.Drawing.Point(619, 102);
			this.txtIdPuesto.Name = "txtIdPuesto";
			this.txtIdPuesto.Size = new System.Drawing.Size(39, 20);
			this.txtIdPuesto.TabIndex = 143;
			this.txtIdPuesto.TabStop = false;
			this.txtIdPuesto.Tag = "fkpuesto";
			this.txtIdPuesto.Visible = false;
			this.txtIdPuesto.TextChanged += new System.EventHandler(this.txtIdPuesto_TextChanged);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(335, 75);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(268, 20);
			this.txtID.TabIndex = 127;
			this.txtID.Tag = "pkid";
			// 
			// chbxNoDespido
			// 
			this.chbxNoDespido.AutoSize = true;
			this.chbxNoDespido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.chbxNoDespido.Location = new System.Drawing.Point(610, 231);
			this.chbxNoDespido.Name = "chbxNoDespido";
			this.chbxNoDespido.Size = new System.Drawing.Size(86, 21);
			this.chbxNoDespido.TabIndex = 155;
			this.chbxNoDespido.Text = "No incluir";
			this.chbxNoDespido.UseVisualStyleBackColor = true;
			this.chbxNoDespido.CheckedChanged += new System.EventHandler(this.chbxNoDespido_CheckedChanged);
			// 
			// chbxNoContratacion
			// 
			this.chbxNoContratacion.AutoSize = true;
			this.chbxNoContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.chbxNoContratacion.Location = new System.Drawing.Point(610, 206);
			this.chbxNoContratacion.Name = "chbxNoContratacion";
			this.chbxNoContratacion.Size = new System.Drawing.Size(86, 21);
			this.chbxNoContratacion.TabIndex = 154;
			this.chbxNoContratacion.Text = "No incluir";
			this.chbxNoContratacion.UseVisualStyleBackColor = true;
			this.chbxNoContratacion.CheckedChanged += new System.EventHandler(this.chbxNoContratacion_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.rbnEstatusimodulo);
			this.panel1.Controls.Add(this.rbnEstatusamodulo);
			this.panel1.Location = new System.Drawing.Point(336, 255);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 28);
			this.panel1.TabIndex = 153;
			// 
			// rbnEstatusimodulo
			// 
			this.rbnEstatusimodulo.AutoSize = true;
			this.rbnEstatusimodulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnEstatusimodulo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnEstatusimodulo.Location = new System.Drawing.Point(104, 1);
			this.rbnEstatusimodulo.Name = "rbnEstatusimodulo";
			this.rbnEstatusimodulo.Size = new System.Drawing.Size(74, 21);
			this.rbnEstatusimodulo.TabIndex = 3;
			this.rbnEstatusimodulo.TabStop = true;
			this.rbnEstatusimodulo.Text = "Inactivo";
			this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
			// 
			// rbnEstatusamodulo
			// 
			this.rbnEstatusamodulo.AutoSize = true;
			this.rbnEstatusamodulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnEstatusamodulo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnEstatusamodulo.Location = new System.Drawing.Point(31, 1);
			this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
			this.rbnEstatusamodulo.Size = new System.Drawing.Size(64, 21);
			this.rbnEstatusamodulo.TabIndex = 2;
			this.rbnEstatusamodulo.TabStop = true;
			this.rbnEstatusamodulo.Text = "Activo";
			this.rbnEstatusamodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusamodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusamodulo_CheckedChanged);
			// 
			// navegadorMantenimientos1
			// 
			this.navegadorMantenimientos1.BackColor = System.Drawing.Color.Transparent;
			this.navegadorMantenimientos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.navegadorMantenimientos1.Location = new System.Drawing.Point(0, 0);
			this.navegadorMantenimientos1.Name = "navegadorMantenimientos1";
			this.navegadorMantenimientos1.Size = new System.Drawing.Size(658, 49);
			this.navegadorMantenimientos1.TabIndex = 152;
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
			this.dgvVistaPrevia.Location = new System.Drawing.Point(8, 295);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.ReadOnly = true;
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(897, 311);
			this.dgvVistaPrevia.TabIndex = 151;
			this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
			// 
			// btnAyuda
			// 
			this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
			this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
			this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAyuda.FlatAppearance.BorderSize = 0;
			this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAyuda.Location = new System.Drawing.Point(663, -4);
			this.btnAyuda.Margin = new System.Windows.Forms.Padding(0);
			this.btnAyuda.Name = "btnAyuda";
			this.btnAyuda.Size = new System.Drawing.Size(50, 50);
			this.btnAyuda.TabIndex = 150;
			this.btnAyuda.UseVisualStyleBackColor = false;
			this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(77, 60);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 17);
			this.label9.TabIndex = 149;
			this.label9.Text = "Fotografía";
			// 
			// pbFoto
			// 
			this.pbFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.BackgroundImage")));
			this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbFoto.Cursor = System.Windows.Forms.Cursors.Default;
			this.pbFoto.Location = new System.Drawing.Point(25, 79);
			this.pbFoto.Name = "pbFoto";
			this.pbFoto.Size = new System.Drawing.Size(164, 210);
			this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbFoto.TabIndex = 148;
			this.pbFoto.TabStop = false;
			this.pbFoto.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbFoto_LoadCompleted);
			// 
			// dtpDespido
			// 
			this.dtpDespido.Location = new System.Drawing.Point(336, 230);
			this.dtpDespido.Name = "dtpDespido";
			this.dtpDespido.Size = new System.Drawing.Size(268, 20);
			this.dtpDespido.TabIndex = 142;
			this.dtpDespido.ValueChanged += new System.EventHandler(this.dtpDespido_ValueChanged);
			// 
			// dtpContratacion
			// 
			this.dtpContratacion.Location = new System.Drawing.Point(336, 205);
			this.dtpContratacion.Name = "dtpContratacion";
			this.dtpContratacion.Size = new System.Drawing.Size(268, 20);
			this.dtpContratacion.TabIndex = 141;
			this.dtpContratacion.ValueChanged += new System.EventHandler(this.dtpContratacion_ValueChanged);
			// 
			// cbxJornada
			// 
			this.cbxJornada.FormattingEnabled = true;
			this.cbxJornada.Location = new System.Drawing.Point(336, 178);
			this.cbxJornada.Name = "cbxJornada";
			this.cbxJornada.Size = new System.Drawing.Size(268, 21);
			this.cbxJornada.TabIndex = 140;
			this.cbxJornada.SelectedIndexChanged += new System.EventHandler(this.cbxJornada_SelectedIndexChanged);
			// 
			// cbxPuesto
			// 
			this.cbxPuesto.FormattingEnabled = true;
			this.cbxPuesto.Location = new System.Drawing.Point(336, 101);
			this.cbxPuesto.Name = "cbxPuesto";
			this.cbxPuesto.Size = new System.Drawing.Size(268, 21);
			this.cbxPuesto.TabIndex = 128;
			this.cbxPuesto.SelectedIndexChanged += new System.EventHandler(this.cbxPuesto_SelectedIndexChanged_1);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(238, 258);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 17);
			this.label8.TabIndex = 139;
			this.label8.Text = "Estado";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(238, 232);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 17);
			this.label7.TabIndex = 138;
			this.label7.Text = "Despido:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(238, 205);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 17);
			this.label6.TabIndex = 137;
			this.label6.Text = "Contratación:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(238, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 17);
			this.label5.TabIndex = 136;
			this.label5.Text = "DPI:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(238, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 17);
			this.label4.TabIndex = 134;
			this.label4.Text = "Puesto:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(238, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 17);
			this.label3.TabIndex = 133;
			this.label3.Text = "Jornada:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(239, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 131;
			this.label2.Text = "Nombres:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(239, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 17);
			this.label1.TabIndex = 129;
			this.label1.Text = "ID:";
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
			this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnImprimir.FlatAppearance.BorderSize = 0;
			this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImprimir.Location = new System.Drawing.Point(247, -1);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(50, 50);
			this.btnImprimir.TabIndex = 156;
			this.btnImprimir.UseVisualStyleBackColor = false;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// frmEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(917, 622);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtIdFoto);
			this.Controls.Add(this.txtDespido);
			this.Controls.Add(this.txtContratacion);
			this.Controls.Add(this.txtJornada);
			this.Controls.Add(this.txtDPI);
			this.Controls.Add(this.txtNombres);
			this.Controls.Add(this.txtIdPuesto);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.chbxNoDespido);
			this.Controls.Add(this.chbxNoContratacion);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.navegadorMantenimientos1);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.btnAyuda);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pbFoto);
			this.Controls.Add(this.dtpDespido);
			this.Controls.Add(this.dtpContratacion);
			this.Controls.Add(this.cbxJornada);
			this.Controls.Add(this.cbxPuesto);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEmpleado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Empleado";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtIdFoto;
		private System.Windows.Forms.TextBox txtDespido;
		private System.Windows.Forms.TextBox txtContratacion;
		private System.Windows.Forms.TextBox txtJornada;
		private System.Windows.Forms.TextBox txtDPI;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.TextBox txtIdPuesto;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.CheckBox chbxNoDespido;
		private System.Windows.Forms.CheckBox chbxNoContratacion;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnEstatusimodulo;
		private System.Windows.Forms.RadioButton rbnEstatusamodulo;
		private CapaVistaNavegador.NavegadorMantenimientos navegadorMantenimientos1;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.Button btnAyuda;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pbFoto;
		private System.Windows.Forms.DateTimePicker dtpDespido;
		private System.Windows.Forms.DateTimePicker dtpContratacion;
		private System.Windows.Forms.ComboBox cbxJornada;
		private System.Windows.Forms.ComboBox cbxPuesto;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnImprimir;
	}
}