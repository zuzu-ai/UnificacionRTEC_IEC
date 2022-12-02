
namespace CapaVistaGestorInventarios
{
	partial class frmJornada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJornada));
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnActivo = new System.Windows.Forms.RadioButton();
            this.rbnInactivo = new System.Windows.Forms.RadioButton();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.navegadorMantenimientos1 = new CapaVistaNavegador.NavegadorMantenimientos();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 229);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.Size = new System.Drawing.Size(637, 209);
            this.dgvVistaPrevia.TabIndex = 11;
            this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(302, 187);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(39, 20);
            this.txtEstado.TabIndex = 10;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnActivo);
            this.panel1.Controls.Add(this.rbnInactivo);
            this.panel1.Location = new System.Drawing.Point(94, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 127;
            // 
            // rbnActivo
            // 
            this.rbnActivo.AutoSize = true;
            this.rbnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbnActivo.Location = new System.Drawing.Point(16, 7);
            this.rbnActivo.Name = "rbnActivo";
            this.rbnActivo.Size = new System.Drawing.Size(64, 21);
            this.rbnActivo.TabIndex = 5;
            this.rbnActivo.TabStop = true;
            this.rbnActivo.Text = "Activo";
            this.rbnActivo.UseVisualStyleBackColor = true;
            this.rbnActivo.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            // 
            // rbnInactivo
            // 
            this.rbnInactivo.AutoSize = true;
            this.rbnInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbnInactivo.Location = new System.Drawing.Point(123, 7);
            this.rbnInactivo.Name = "rbnInactivo";
            this.rbnInactivo.Size = new System.Drawing.Size(74, 21);
            this.rbnInactivo.TabIndex = 6;
            this.rbnInactivo.TabStop = true;
            this.rbnInactivo.Text = "Inactivo";
            this.rbnInactivo.UseVisualStyleBackColor = true;
            this.rbnInactivo.CheckedChanged += new System.EventHandler(this.rbnInactivo_CheckedChanged);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstatus.Location = new System.Drawing.Point(12, 186);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(56, 17);
            this.lblEstatus.TabIndex = 125;
            this.lblEstatus.Text = "Estado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "nombre";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(94, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Tag = "pkid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 120;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 121;
            this.label1.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 129;
            this.label3.Text = "Hora Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 131;
            this.label4.Text = "Hora Fin:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInicio.Location = new System.Drawing.Point(94, 128);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowUpDown = true;
            this.dtpInicio.Size = new System.Drawing.Size(71, 20);
            this.dtpInicio.TabIndex = 3;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFin.Location = new System.Drawing.Point(94, 157);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowUpDown = true;
            this.dtpFin.Size = new System.Drawing.Size(71, 20);
            this.dtpFin.TabIndex = 4;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // txtFin
            // 
            this.txtFin.Enabled = false;
            this.txtFin.Location = new System.Drawing.Point(171, 154);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(143, 20);
            this.txtFin.TabIndex = 8;
            this.txtFin.TabStop = false;
            this.txtFin.Tag = "horafin";
            this.txtFin.Visible = false;
            this.txtFin.TextChanged += new System.EventHandler(this.txtFin_TextChanged);
            // 
            // txtInicio
            // 
            this.txtInicio.Enabled = false;
            this.txtInicio.Location = new System.Drawing.Point(171, 127);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(143, 20);
            this.txtInicio.TabIndex = 7;
            this.txtInicio.TabStop = false;
            this.txtInicio.Tag = "horainicio";
            this.txtInicio.Visible = false;
            this.txtInicio.TextChanged += new System.EventHandler(this.txtInicio_TextChanged);
            // 
            // navegadorMantenimientos1
            // 
            this.navegadorMantenimientos1.BackColor = System.Drawing.Color.Transparent;
            this.navegadorMantenimientos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navegadorMantenimientos1.Location = new System.Drawing.Point(0, -1);
            this.navegadorMantenimientos1.Name = "navegadorMantenimientos1";
            this.navegadorMantenimientos1.Size = new System.Drawing.Size(658, 49);
            this.navegadorMantenimientos1.TabIndex = 122;
            this.navegadorMantenimientos1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(246, -1);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 157;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.navegadorMantenimientos1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJornada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jornada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnActivo;
		private System.Windows.Forms.RadioButton rbnInactivo;
		private System.Windows.Forms.Label lblEstatus;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private CapaVistaNavegador.NavegadorMantenimientos navegadorMantenimientos1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.TextBox txtFin;
		private System.Windows.Forms.TextBox txtInicio;
		private System.Windows.Forms.Button btnImprimir;
	}
}