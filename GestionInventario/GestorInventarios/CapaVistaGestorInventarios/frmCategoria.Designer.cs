
namespace CapaVistaGestorInventarios
{
	partial class frmCategoria
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtCategoria = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnActivo = new System.Windows.Forms.RadioButton();
			this.rbnInactivo = new System.Windows.Forms.RadioButton();
			this.lblEstatus = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.cbxCategoria1 = new System.Windows.Forms.ComboBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtTipo = new System.Windows.Forms.TextBox();
			this.chbxlistTipo = new System.Windows.Forms.CheckedListBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnAyuda = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.cbxCategoria2 = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(755, 126);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(33, 20);
			this.txtEstado.TabIndex = 190;
			this.txtEstado.Tag = "Estado";
			this.txtEstado.Visible = false;
			this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
			// 
			// txtCategoria
			// 
			this.txtCategoria.Location = new System.Drawing.Point(755, 68);
			this.txtCategoria.Name = "txtCategoria";
			this.txtCategoria.Size = new System.Drawing.Size(33, 20);
			this.txtCategoria.TabIndex = 195;
			this.txtCategoria.Tag = "Fk_Categoria_Superior";
			this.txtCategoria.Visible = false;
			this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
			// 
			// txtID
			// 
			this.txtID.Enabled = false;
			this.txtID.Location = new System.Drawing.Point(144, 71);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(214, 20);
			this.txtID.TabIndex = 1;
			this.txtID.Tag = "ID_Categoria";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(376, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 17);
			this.label4.TabIndex = 196;
			this.label4.Text = "Nombre:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(376, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 17);
			this.label3.TabIndex = 194;
			this.label3.Text = "Categoría Superior:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbnActivo);
			this.panel1.Controls.Add(this.rbnInactivo);
			this.panel1.Location = new System.Drawing.Point(508, 123);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 30);
			this.panel1.TabIndex = 191;
			// 
			// rbnActivo
			// 
			this.rbnActivo.AutoSize = true;
			this.rbnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnActivo.Location = new System.Drawing.Point(16, 7);
			this.rbnActivo.Name = "rbnActivo";
			this.rbnActivo.Size = new System.Drawing.Size(64, 21);
			this.rbnActivo.TabIndex = 6;
			this.rbnActivo.TabStop = true;
			this.rbnActivo.Text = "Activo";
			this.rbnActivo.UseVisualStyleBackColor = true;
			this.rbnActivo.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
			// 
			// rbnInactivo
			// 
			this.rbnInactivo.AutoSize = true;
			this.rbnInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnInactivo.Location = new System.Drawing.Point(113, 7);
			this.rbnInactivo.Name = "rbnInactivo";
			this.rbnInactivo.Size = new System.Drawing.Size(74, 21);
			this.rbnInactivo.TabIndex = 7;
			this.rbnInactivo.TabStop = true;
			this.rbnInactivo.Text = "Inactivo";
			this.rbnInactivo.UseVisualStyleBackColor = true;
			this.rbnInactivo.CheckedChanged += new System.EventHandler(this.rbnInactivo_CheckedChanged);
			// 
			// lblEstatus
			// 
			this.lblEstatus.AutoSize = true;
			this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblEstatus.Location = new System.Drawing.Point(376, 127);
			this.lblEstatus.Name = "lblEstatus";
			this.lblEstatus.Size = new System.Drawing.Size(56, 17);
			this.lblEstatus.TabIndex = 189;
			this.lblEstatus.Text = "Estado:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(12, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 17);
			this.label2.TabIndex = 184;
			this.label2.Text = "Tipo Categoría:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(12, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 17);
			this.label1.TabIndex = 185;
			this.label1.Text = "ID:";
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
			this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnImprimir.FlatAppearance.BorderSize = 0;
			this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImprimir.Location = new System.Drawing.Point(252, 1);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(50, 50);
			this.btnImprimir.TabIndex = 193;
			this.btnImprimir.UseVisualStyleBackColor = false;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVistaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(12, 179);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.Size = new System.Drawing.Size(769, 231);
			this.dgvVistaPrevia.TabIndex = 192;
			this.dgvVistaPrevia.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVistaPrevia_RowHeaderMouseClick);
			this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
			// 
			// cbxCategoria1
			// 
			this.cbxCategoria1.FormattingEnabled = true;
			this.cbxCategoria1.Location = new System.Drawing.Point(144, 152);
			this.cbxCategoria1.Name = "cbxCategoria1";
			this.cbxCategoria1.Size = new System.Drawing.Size(214, 21);
			this.cbxCategoria1.TabIndex = 3;
			this.cbxCategoria1.Visible = false;
			this.cbxCategoria1.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(508, 97);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(214, 20);
			this.txtNombre.TabIndex = 5;
			this.txtNombre.Tag = "Nombre";
			this.txtNombre.EnabledChanged += new System.EventHandler(this.txtNombre_EnabledChanged);
			// 
			// txtTipo
			// 
			this.txtTipo.Location = new System.Drawing.Point(325, 99);
			this.txtTipo.Name = "txtTipo";
			this.txtTipo.Size = new System.Drawing.Size(33, 20);
			this.txtTipo.TabIndex = 188;
			this.txtTipo.Tag = "Fk_Tipo_Categoria";
			this.txtTipo.Visible = false;
			this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
			// 
			// chbxlistTipo
			// 
			this.chbxlistTipo.CheckOnClick = true;
			this.chbxlistTipo.FormattingEnabled = true;
			this.chbxlistTipo.Items.AddRange(new object[] {
            "Nivel 1",
            "Nivel 2",
            "Nivel 3"});
			this.chbxlistTipo.Location = new System.Drawing.Point(144, 97);
			this.chbxlistTipo.Name = "chbxlistTipo";
			this.chbxlistTipo.Size = new System.Drawing.Size(59, 49);
			this.chbxlistTipo.TabIndex = 2;
			this.chbxlistTipo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chbxlistTipo_ItemCheck);
			this.chbxlistTipo.SelectedIndexChanged += new System.EventHandler(this.chbxlistTipo_SelectedIndexChanged);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Transparent;
			this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
			this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Location = new System.Drawing.Point(402, 1);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(50, 50);
			this.btnSalir.TabIndex = 206;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnAyuda
			// 
			this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
			this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
			this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAyuda.FlatAppearance.BorderSize = 0;
			this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAyuda.Location = new System.Drawing.Point(352, 1);
			this.btnAyuda.Margin = new System.Windows.Forms.Padding(0);
			this.btnAyuda.Name = "btnAyuda";
			this.btnAyuda.Size = new System.Drawing.Size(50, 50);
			this.btnAyuda.TabIndex = 207;
			this.btnAyuda.UseVisualStyleBackColor = false;
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
			this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
			this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnActualizar.FlatAppearance.BorderSize = 0;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizar.Location = new System.Drawing.Point(302, 1);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(0);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(50, 50);
			this.btnActualizar.TabIndex = 212;
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
			this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(202, 1);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(50, 50);
			this.btnEliminar.TabIndex = 213;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
			this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Location = new System.Drawing.Point(152, 1);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(50, 50);
			this.btnCancelar.TabIndex = 214;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
			this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
			this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Location = new System.Drawing.Point(102, 1);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(50, 50);
			this.btnGuardar.TabIndex = 215;
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.Transparent;
			this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
			this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Location = new System.Drawing.Point(52, 1);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(50, 50);
			this.btnEditar.TabIndex = 216;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
			this.btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
			this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnIngresar.FlatAppearance.BorderSize = 0;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.Location = new System.Drawing.Point(2, 1);
			this.btnIngresar.Margin = new System.Windows.Forms.Padding(0);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(50, 50);
			this.btnIngresar.TabIndex = 217;
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// cbxCategoria2
			// 
			this.cbxCategoria2.FormattingEnabled = true;
			this.cbxCategoria2.Location = new System.Drawing.Point(508, 70);
			this.cbxCategoria2.Name = "cbxCategoria2";
			this.cbxCategoria2.Size = new System.Drawing.Size(214, 21);
			this.cbxCategoria2.TabIndex = 4;
			this.cbxCategoria2.Visible = false;
			this.cbxCategoria2.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria2_SelectedIndexChanged);
			// 
			// frmCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(793, 422);
			this.Controls.Add(this.cbxCategoria2);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAyuda);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.chbxlistTipo);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCategoria);
			this.Controls.Add(this.txtTipo);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.cbxCategoria1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblEstatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmCategoria";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Categoría";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtCategoria;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnActivo;
		private System.Windows.Forms.RadioButton rbnInactivo;
		private System.Windows.Forms.Label lblEstatus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.ComboBox cbxCategoria1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtTipo;
		private System.Windows.Forms.CheckedListBox chbxlistTipo;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnAyuda;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.ComboBox cbxCategoria2;
	}
}