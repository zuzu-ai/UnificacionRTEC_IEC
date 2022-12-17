
namespace CapaVistaGestorInventarios
{
	partial class frmCotizacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotizacion));
			this.txtEstadoE = new System.Windows.Forms.TextBox();
			this.txtProyecto = new System.Windows.Forms.TextBox();
			this.txtIDE = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnInactivoE = new System.Windows.Forms.RadioButton();
			this.rbnActivoE = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.lbl = new System.Windows.Forms.Label();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAyuda = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvDetalles = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtIDD = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtInventario = new System.Windows.Forms.TextBox();
			this.cbxInventario = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.cbxProducto = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtDisponibilidad = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtEstadoD = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbnInactivoD = new System.Windows.Forms.RadioButton();
			this.rbnActivoD = new System.Windows.Forms.RadioButton();
			this.label15 = new System.Windows.Forms.Label();
			this.btnEliminarD = new System.Windows.Forms.Button();
			this.btnCancelarD = new System.Windows.Forms.Button();
			this.btnGuardarD = new System.Windows.Forms.Button();
			this.btnEditarD = new System.Windows.Forms.Button();
			this.btnIngresarD = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.dgvCotizaciones = new System.Windows.Forms.DataGridView();
			this.txtCantidad = new System.Windows.Forms.NumericUpDown();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.lblDescuento = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEstadoE
			// 
			this.txtEstadoE.Location = new System.Drawing.Point(335, 185);
			this.txtEstadoE.Name = "txtEstadoE";
			this.txtEstadoE.Size = new System.Drawing.Size(39, 20);
			this.txtEstadoE.TabIndex = 191;
			this.txtEstadoE.Tag = "estado";
			this.txtEstadoE.Visible = false;
			this.txtEstadoE.TextChanged += new System.EventHandler(this.txtEstadoE_TextChanged);
			// 
			// txtProyecto
			// 
			this.txtProyecto.Location = new System.Drawing.Point(117, 102);
			this.txtProyecto.Name = "txtProyecto";
			this.txtProyecto.Size = new System.Drawing.Size(268, 20);
			this.txtProyecto.TabIndex = 2;
			this.txtProyecto.Tag = "serie";
			// 
			// txtIDE
			// 
			this.txtIDE.Enabled = false;
			this.txtIDE.Location = new System.Drawing.Point(118, 77);
			this.txtIDE.Name = "txtIDE";
			this.txtIDE.Size = new System.Drawing.Size(268, 20);
			this.txtIDE.TabIndex = 1;
			this.txtIDE.Tag = "pkid";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.rbnInactivoE);
			this.panel1.Controls.Add(this.rbnActivoE);
			this.panel1.Location = new System.Drawing.Point(129, 183);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 28);
			this.panel1.TabIndex = 192;
			// 
			// rbnInactivoE
			// 
			this.rbnInactivoE.AutoSize = true;
			this.rbnInactivoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnInactivoE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnInactivoE.Location = new System.Drawing.Point(104, 1);
			this.rbnInactivoE.Name = "rbnInactivoE";
			this.rbnInactivoE.Size = new System.Drawing.Size(74, 21);
			this.rbnInactivoE.TabIndex = 6;
			this.rbnInactivoE.TabStop = true;
			this.rbnInactivoE.Text = "Inactivo";
			this.rbnInactivoE.UseVisualStyleBackColor = true;
			this.rbnInactivoE.CheckedChanged += new System.EventHandler(this.rbnInactivoE_CheckedChanged);
			// 
			// rbnActivoE
			// 
			this.rbnActivoE.AutoSize = true;
			this.rbnActivoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnActivoE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnActivoE.Location = new System.Drawing.Point(31, 1);
			this.rbnActivoE.Name = "rbnActivoE";
			this.rbnActivoE.Size = new System.Drawing.Size(64, 21);
			this.rbnActivoE.TabIndex = 5;
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
			this.label8.Location = new System.Drawing.Point(4, 181);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 17);
			this.label8.TabIndex = 190;
			this.label8.Text = "Estado:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(2, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 187;
			this.label2.Text = "Proyecto:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(4, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 17);
			this.label1.TabIndex = 185;
			this.label1.Text = "ID:";
			// 
			// txtTotal
			// 
			this.txtTotal.Enabled = false;
			this.txtTotal.Location = new System.Drawing.Point(117, 155);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(267, 20);
			this.txtTotal.TabIndex = 4;
			this.txtTotal.Tag = "nombre";
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lbl.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl.Location = new System.Drawing.Point(1, 159);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(44, 17);
			this.lbl.TabIndex = 194;
			this.lbl.Text = "Total:";
			// 
			// txtFecha
			// 
			this.txtFecha.Location = new System.Drawing.Point(398, 128);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(39, 20);
			this.txtFecha.TabIndex = 268;
			this.txtFecha.TabStop = false;
			this.txtFecha.Tag = "fkinventarioE";
			this.txtFecha.Visible = false;
			this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(118, 128);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(268, 20);
			this.dtpFecha.TabIndex = 3;
			this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(4, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 17);
			this.label5.TabIndex = 266;
			this.label5.Text = "Fecha:";
			// 
			// btnAyuda
			// 
			this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
			this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
			this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAyuda.FlatAppearance.BorderSize = 0;
			this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAyuda.Location = new System.Drawing.Point(422, -2);
			this.btnAyuda.Margin = new System.Windows.Forms.Padding(0);
			this.btnAyuda.Name = "btnAyuda";
			this.btnAyuda.Size = new System.Drawing.Size(50, 50);
			this.btnAyuda.TabIndex = 271;
			this.btnAyuda.TabStop = false;
			this.btnAyuda.UseVisualStyleBackColor = false;
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
			this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
			this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnActualizar.FlatAppearance.BorderSize = 0;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizar.Location = new System.Drawing.Point(372, -2);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(0);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(50, 50);
			this.btnActualizar.TabIndex = 272;
			this.btnActualizar.TabStop = false;
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
			this.btnEliminar.Location = new System.Drawing.Point(207, -2);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(50, 50);
			this.btnEliminar.TabIndex = 273;
			this.btnEliminar.TabStop = false;
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
			this.btnCancelar.Location = new System.Drawing.Point(157, -2);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(50, 50);
			this.btnCancelar.TabIndex = 274;
			this.btnCancelar.TabStop = false;
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
			this.btnGuardar.Location = new System.Drawing.Point(107, -2);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(50, 50);
			this.btnGuardar.TabIndex = 275;
			this.btnGuardar.TabStop = false;
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
			this.btnEditar.Location = new System.Drawing.Point(57, -2);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(50, 50);
			this.btnEditar.TabIndex = 276;
			this.btnEditar.TabStop = false;
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
			this.btnIngresar.Location = new System.Drawing.Point(7, -2);
			this.btnIngresar.Margin = new System.Windows.Forms.Padding(0);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(50, 50);
			this.btnIngresar.TabIndex = 277;
			this.btnIngresar.TabStop = false;
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(536, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 17);
			this.label3.TabIndex = 279;
			this.label3.Text = "Cotizaciones Registradas";
			// 
			// dgvDetalles
			// 
			this.dgvDetalles.AllowUserToAddRows = false;
			this.dgvDetalles.AllowUserToDeleteRows = false;
			this.dgvDetalles.AllowUserToResizeRows = false;
			this.dgvDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDetalles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalles.Location = new System.Drawing.Point(463, 223);
			this.dgvDetalles.Name = "dgvDetalles";
			this.dgvDetalles.RowHeadersWidth = 51;
			this.dgvDetalles.Size = new System.Drawing.Size(325, 306);
			this.dgvDetalles.TabIndex = 280;
			this.dgvDetalles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDetalles_RowHeaderMouseClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(551, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 17);
			this.label4.TabIndex = 281;
			this.label4.Text = "Detalles Relacionados";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(126, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(176, 17);
			this.label6.TabIndex = 282;
			this.label6.Text = "Encabezado de Cotizacion";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(157, 274);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(141, 17);
			this.label7.TabIndex = 283;
			this.label7.Text = "Detalle de Cotizacion";
			// 
			// txtIDD
			// 
			this.txtIDD.Enabled = false;
			this.txtIDD.Location = new System.Drawing.Point(118, 296);
			this.txtIDD.Name = "txtIDD";
			this.txtIDD.Size = new System.Drawing.Size(268, 20);
			this.txtIDD.TabIndex = 7;
			this.txtIDD.Tag = "pkid";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(4, 296);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 17);
			this.label9.TabIndex = 285;
			this.label9.Text = "ID:";
			// 
			// txtInventario
			// 
			this.txtInventario.Location = new System.Drawing.Point(398, 325);
			this.txtInventario.Name = "txtInventario";
			this.txtInventario.Size = new System.Drawing.Size(39, 20);
			this.txtInventario.TabIndex = 288;
			this.txtInventario.TabStop = false;
			this.txtInventario.Tag = "fkinventarioE";
			this.txtInventario.Visible = false;
			this.txtInventario.TextChanged += new System.EventHandler(this.txtInventario_TextChanged);
			// 
			// cbxInventario
			// 
			this.cbxInventario.FormattingEnabled = true;
			this.cbxInventario.Location = new System.Drawing.Point(118, 322);
			this.cbxInventario.Name = "cbxInventario";
			this.cbxInventario.Size = new System.Drawing.Size(268, 21);
			this.cbxInventario.TabIndex = 8;
			this.cbxInventario.SelectedIndexChanged += new System.EventHandler(this.cbxInventario_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label10.Location = new System.Drawing.Point(2, 326);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 17);
			this.label10.TabIndex = 287;
			this.label10.Text = "Inventario:";
			// 
			// txtProducto
			// 
			this.txtProducto.Location = new System.Drawing.Point(398, 352);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(39, 20);
			this.txtProducto.TabIndex = 291;
			this.txtProducto.TabStop = false;
			this.txtProducto.Tag = "fkinventarioE";
			this.txtProducto.Visible = false;
			this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
			// 
			// cbxProducto
			// 
			this.cbxProducto.FormattingEnabled = true;
			this.cbxProducto.Location = new System.Drawing.Point(118, 349);
			this.cbxProducto.Name = "cbxProducto";
			this.cbxProducto.Size = new System.Drawing.Size(268, 21);
			this.cbxProducto.TabIndex = 9;
			this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label11.Location = new System.Drawing.Point(2, 353);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(69, 17);
			this.label11.TabIndex = 290;
			this.label11.Text = "Producto:";
			// 
			// txtDisponibilidad
			// 
			this.txtDisponibilidad.Enabled = false;
			this.txtDisponibilidad.Location = new System.Drawing.Point(118, 376);
			this.txtDisponibilidad.Name = "txtDisponibilidad";
			this.txtDisponibilidad.Size = new System.Drawing.Size(268, 20);
			this.txtDisponibilidad.TabIndex = 10;
			this.txtDisponibilidad.Tag = "serie";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label12.Location = new System.Drawing.Point(3, 379);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 17);
			this.label12.TabIndex = 293;
			this.label12.Text = "Disponibilidad:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Enabled = false;
			this.txtPrecio.Location = new System.Drawing.Point(118, 402);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(268, 20);
			this.txtPrecio.TabIndex = 11;
			this.txtPrecio.Tag = "serie";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label13.Location = new System.Drawing.Point(3, 405);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(105, 17);
			this.label13.TabIndex = 295;
			this.label13.Text = "Precio Unitario:";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Enabled = false;
			this.txtSubtotal.Location = new System.Drawing.Point(118, 479);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(268, 20);
			this.txtSubtotal.TabIndex = 14;
			this.txtSubtotal.Tag = "serie";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label14.Location = new System.Drawing.Point(3, 482);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 17);
			this.label14.TabIndex = 297;
			this.label14.Text = "Subtotal:";
			// 
			// txtEstadoD
			// 
			this.txtEstadoD.Location = new System.Drawing.Point(337, 510);
			this.txtEstadoD.Name = "txtEstadoD";
			this.txtEstadoD.Size = new System.Drawing.Size(39, 20);
			this.txtEstadoD.TabIndex = 299;
			this.txtEstadoD.Tag = "estado";
			this.txtEstadoD.Visible = false;
			this.txtEstadoD.TextChanged += new System.EventHandler(this.txtEstadoD_TextChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.rbnInactivoD);
			this.panel2.Controls.Add(this.rbnActivoD);
			this.panel2.Location = new System.Drawing.Point(131, 508);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 28);
			this.panel2.TabIndex = 300;
			// 
			// rbnInactivoD
			// 
			this.rbnInactivoD.AutoSize = true;
			this.rbnInactivoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnInactivoD.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnInactivoD.Location = new System.Drawing.Point(104, 1);
			this.rbnInactivoD.Name = "rbnInactivoD";
			this.rbnInactivoD.Size = new System.Drawing.Size(74, 21);
			this.rbnInactivoD.TabIndex = 16;
			this.rbnInactivoD.TabStop = true;
			this.rbnInactivoD.Text = "Inactivo";
			this.rbnInactivoD.UseVisualStyleBackColor = true;
			this.rbnInactivoD.CheckedChanged += new System.EventHandler(this.rbnInactivoD_CheckedChanged);
			// 
			// rbnActivoD
			// 
			this.rbnActivoD.AutoSize = true;
			this.rbnActivoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnActivoD.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnActivoD.Location = new System.Drawing.Point(31, 1);
			this.rbnActivoD.Name = "rbnActivoD";
			this.rbnActivoD.Size = new System.Drawing.Size(64, 21);
			this.rbnActivoD.TabIndex = 15;
			this.rbnActivoD.TabStop = true;
			this.rbnActivoD.Text = "Activo";
			this.rbnActivoD.UseVisualStyleBackColor = true;
			this.rbnActivoD.CheckedChanged += new System.EventHandler(this.rbnActivoD_CheckedChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label15.Location = new System.Drawing.Point(6, 506);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 17);
			this.label15.TabIndex = 298;
			this.label15.Text = "Estado:";
			// 
			// btnEliminarD
			// 
			this.btnEliminarD.BackColor = System.Drawing.Color.Transparent;
			this.btnEliminarD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarD.BackgroundImage")));
			this.btnEliminarD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEliminarD.FlatAppearance.BorderSize = 0;
			this.btnEliminarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminarD.Location = new System.Drawing.Point(206, 216);
			this.btnEliminarD.Margin = new System.Windows.Forms.Padding(0);
			this.btnEliminarD.Name = "btnEliminarD";
			this.btnEliminarD.Size = new System.Drawing.Size(50, 50);
			this.btnEliminarD.TabIndex = 305;
			this.btnEliminarD.TabStop = false;
			this.btnEliminarD.UseVisualStyleBackColor = false;
			this.btnEliminarD.Click += new System.EventHandler(this.btnEliminarD_Click);
			// 
			// btnCancelarD
			// 
			this.btnCancelarD.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelarD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarD.BackgroundImage")));
			this.btnCancelarD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCancelarD.FlatAppearance.BorderSize = 0;
			this.btnCancelarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelarD.Location = new System.Drawing.Point(156, 216);
			this.btnCancelarD.Margin = new System.Windows.Forms.Padding(0);
			this.btnCancelarD.Name = "btnCancelarD";
			this.btnCancelarD.Size = new System.Drawing.Size(50, 50);
			this.btnCancelarD.TabIndex = 306;
			this.btnCancelarD.TabStop = false;
			this.btnCancelarD.UseVisualStyleBackColor = false;
			this.btnCancelarD.Click += new System.EventHandler(this.btnCancelarD_Click);
			// 
			// btnGuardarD
			// 
			this.btnGuardarD.BackColor = System.Drawing.Color.Transparent;
			this.btnGuardarD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarD.BackgroundImage")));
			this.btnGuardarD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGuardarD.FlatAppearance.BorderSize = 0;
			this.btnGuardarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardarD.Location = new System.Drawing.Point(106, 216);
			this.btnGuardarD.Margin = new System.Windows.Forms.Padding(0);
			this.btnGuardarD.Name = "btnGuardarD";
			this.btnGuardarD.Size = new System.Drawing.Size(50, 50);
			this.btnGuardarD.TabIndex = 307;
			this.btnGuardarD.TabStop = false;
			this.btnGuardarD.UseVisualStyleBackColor = false;
			this.btnGuardarD.Click += new System.EventHandler(this.btnGuardarD_Click);
			// 
			// btnEditarD
			// 
			this.btnEditarD.BackColor = System.Drawing.Color.Transparent;
			this.btnEditarD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarD.BackgroundImage")));
			this.btnEditarD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEditarD.FlatAppearance.BorderSize = 0;
			this.btnEditarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditarD.Location = new System.Drawing.Point(56, 216);
			this.btnEditarD.Margin = new System.Windows.Forms.Padding(0);
			this.btnEditarD.Name = "btnEditarD";
			this.btnEditarD.Size = new System.Drawing.Size(50, 50);
			this.btnEditarD.TabIndex = 308;
			this.btnEditarD.TabStop = false;
			this.btnEditarD.UseVisualStyleBackColor = false;
			this.btnEditarD.Click += new System.EventHandler(this.btnEditarD_Click);
			// 
			// btnIngresarD
			// 
			this.btnIngresarD.BackColor = System.Drawing.Color.Transparent;
			this.btnIngresarD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresarD.BackgroundImage")));
			this.btnIngresarD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnIngresarD.FlatAppearance.BorderSize = 0;
			this.btnIngresarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresarD.Location = new System.Drawing.Point(6, 216);
			this.btnIngresarD.Margin = new System.Windows.Forms.Padding(0);
			this.btnIngresarD.Name = "btnIngresarD";
			this.btnIngresarD.Size = new System.Drawing.Size(50, 50);
			this.btnIngresarD.TabIndex = 309;
			this.btnIngresarD.TabStop = false;
			this.btnIngresarD.UseVisualStyleBackColor = false;
			this.btnIngresarD.Click += new System.EventHandler(this.btnIngresarD_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label16.Location = new System.Drawing.Point(3, 431);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(68, 17);
			this.label16.TabIndex = 311;
			this.label16.Text = "Cantidad:";
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
			this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnImprimir.FlatAppearance.BorderSize = 0;
			this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImprimir.Location = new System.Drawing.Point(324, -2);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(50, 50);
			this.btnImprimir.TabIndex = 312;
			this.btnImprimir.TabStop = false;
			this.btnImprimir.UseVisualStyleBackColor = false;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// dgvCotizaciones
			// 
			this.dgvCotizaciones.AllowUserToAddRows = false;
			this.dgvCotizaciones.AllowUserToDeleteRows = false;
			this.dgvCotizaciones.AllowUserToResizeRows = false;
			this.dgvCotizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCotizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCotizaciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.dgvCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCotizaciones.Location = new System.Drawing.Point(463, 66);
			this.dgvCotizaciones.Name = "dgvCotizaciones";
			this.dgvCotizaciones.ReadOnly = true;
			this.dgvCotizaciones.RowHeadersWidth = 51;
			this.dgvCotizaciones.Size = new System.Drawing.Size(325, 132);
			this.dgvCotizaciones.TabIndex = 313;
			this.dgvCotizaciones.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCotizaciones_RowHeaderMouseClick);
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(117, 430);
			this.txtCantidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(269, 20);
			this.txtCantidad.TabIndex = 12;
			this.txtCantidad.ValueChanged += new System.EventHandler(this.txtCantidad_ValueChanged);
			this.txtCantidad.Scroll += new System.Windows.Forms.ScrollEventHandler(this.txtCantidad_Scroll);
			this.txtCantidad.Click += new System.EventHandler(this.txtCantidad_Click);
			this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress_1);
			this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
			this.txtCantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCantidad_MouseClick);
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(118, 455);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(268, 20);
			this.txtDescuento.TabIndex = 13;
			this.txtDescuento.Tag = "serie";
			this.txtDescuento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lblDescuento
			// 
			this.lblDescuento.AutoSize = true;
			this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDescuento.Location = new System.Drawing.Point(3, 458);
			this.lblDescuento.Name = "lblDescuento";
			this.lblDescuento.Size = new System.Drawing.Size(80, 17);
			this.lblDescuento.TabIndex = 316;
			this.lblDescuento.Text = "Descuento:";
			// 
			// frmCotizacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 541);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.lblDescuento);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.dgvCotizaciones);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.btnEliminarD);
			this.Controls.Add(this.btnCancelarD);
			this.Controls.Add(this.btnGuardarD);
			this.Controls.Add(this.btnEditarD);
			this.Controls.Add(this.btnIngresarD);
			this.Controls.Add(this.txtEstadoD);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtDisponibilidad);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtProducto);
			this.Controls.Add(this.cbxProducto);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtInventario);
			this.Controls.Add(this.cbxInventario);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtIDD);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgvDetalles);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnAyuda);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnIngresar);
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
			this.Name = "frmCotizacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cotizacion";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEstadoE;
		private System.Windows.Forms.TextBox txtProyecto;
		private System.Windows.Forms.TextBox txtIDE;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnInactivoE;
		private System.Windows.Forms.RadioButton rbnActivoE;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAyuda;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvDetalles;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtIDD;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtInventario;
		private System.Windows.Forms.ComboBox cbxInventario;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtProducto;
		private System.Windows.Forms.ComboBox cbxProducto;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtDisponibilidad;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtEstadoD;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbnInactivoD;
		private System.Windows.Forms.RadioButton rbnActivoD;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button btnEliminarD;
		private System.Windows.Forms.Button btnCancelarD;
		private System.Windows.Forms.Button btnGuardarD;
		private System.Windows.Forms.Button btnEditarD;
		private System.Windows.Forms.Button btnIngresarD;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.DataGridView dgvCotizaciones;
		private System.Windows.Forms.NumericUpDown txtCantidad;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.Label lblDescuento;
	}
}