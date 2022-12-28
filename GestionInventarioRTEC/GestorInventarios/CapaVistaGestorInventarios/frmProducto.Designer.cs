
namespace CapaVistaGestorInventarios
{
	partial class frmProducto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtSerie = new System.Windows.Forms.TextBox();
			this.txtIdInventario = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnInactivo = new System.Windows.Forms.RadioButton();
			this.rbnActivo = new System.Windows.Forms.RadioButton();
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.cbxInventario = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.cbxMarca = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxAlmacenamiento = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cbxCat1 = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cbxCat2 = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cbxCat3 = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtIdMarca = new System.Windows.Forms.TextBox();
			this.txtIdAlmacenamiento = new System.Windows.Forms.TextBox();
			this.txtIdCat1 = new System.Windows.Forms.TextBox();
			this.txtIdCat2 = new System.Windows.Forms.TextBox();
			this.txtIdCat3 = new System.Windows.Forms.TextBox();
			this.txtIdSucursal = new System.Windows.Forms.TextBox();
			this.cbxSucursal = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtIdUbicacion = new System.Windows.Forms.TextBox();
			this.cbxUbicacion = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtMin = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtMax = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtIdProveedores = new System.Windows.Forms.TextBox();
			this.txtIdBodega = new System.Windows.Forms.TextBox();
			this.cbxBodega = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.btnAyuda = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.dgvProveedores = new System.Windows.Forms.DataGridView();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtPVenta = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(787, 361);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(39, 20);
			this.txtEstado.TabIndex = 174;
			this.txtEstado.Tag = "estado";
			this.txtEstado.Visible = false;
			this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(126, 126);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(267, 20);
			this.txtNombre.TabIndex = 3;
			this.txtNombre.Tag = "Nombre";
			// 
			// txtSerie
			// 
			this.txtSerie.Location = new System.Drawing.Point(126, 99);
			this.txtSerie.Name = "txtSerie";
			this.txtSerie.Size = new System.Drawing.Size(268, 20);
			this.txtSerie.TabIndex = 2;
			this.txtSerie.Tag = "Serie";
			// 
			// txtIdInventario
			// 
			this.txtIdInventario.Location = new System.Drawing.Point(855, 67);
			this.txtIdInventario.Name = "txtIdInventario";
			this.txtIdInventario.Size = new System.Drawing.Size(39, 20);
			this.txtIdInventario.TabIndex = 173;
			this.txtIdInventario.TabStop = false;
			this.txtIdInventario.Tag = "fkinventarioE";
			this.txtIdInventario.TextChanged += new System.EventHandler(this.txtIdInventario_TextChanged);
			// 
			// txtID
			// 
			this.txtID.Enabled = false;
			this.txtID.Location = new System.Drawing.Point(127, 74);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(268, 20);
			this.txtID.TabIndex = 1;
			this.txtID.Tag = "Pk_Detalle";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.rbnInactivo);
			this.panel1.Controls.Add(this.rbnActivo);
			this.panel1.Location = new System.Drawing.Point(581, 359);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 28);
			this.panel1.TabIndex = 183;
			// 
			// rbnInactivo
			// 
			this.rbnInactivo.AutoSize = true;
			this.rbnInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnInactivo.Location = new System.Drawing.Point(104, 1);
			this.rbnInactivo.Name = "rbnInactivo";
			this.rbnInactivo.Size = new System.Drawing.Size(74, 21);
			this.rbnInactivo.TabIndex = 20;
			this.rbnInactivo.TabStop = true;
			this.rbnInactivo.Text = "Inactivo";
			this.rbnInactivo.UseVisualStyleBackColor = true;
			this.rbnInactivo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
			// 
			// rbnActivo
			// 
			this.rbnActivo.AutoSize = true;
			this.rbnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rbnActivo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rbnActivo.Location = new System.Drawing.Point(31, 1);
			this.rbnActivo.Name = "rbnActivo";
			this.rbnActivo.Size = new System.Drawing.Size(64, 21);
			this.rbnActivo.TabIndex = 19;
			this.rbnActivo.TabStop = true;
			this.rbnActivo.Text = "Activo";
			this.rbnActivo.UseVisualStyleBackColor = true;
			this.rbnActivo.CheckedChanged += new System.EventHandler(this.rbnEstatusamodulo_CheckedChanged);
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
			this.dgvVistaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvVistaPrevia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(10, 433);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.ReadOnly = true;
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(897, 175);
			this.dgvVistaPrevia.TabIndex = 181;
			this.dgvVistaPrevia.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVistaPrevia_RowHeaderMouseClick);
			this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
			// 
			// cbxInventario
			// 
			this.cbxInventario.FormattingEnabled = true;
			this.cbxInventario.Location = new System.Drawing.Point(581, 70);
			this.cbxInventario.Name = "cbxInventario";
			this.cbxInventario.Size = new System.Drawing.Size(268, 21);
			this.cbxInventario.TabIndex = 13;
			this.cbxInventario.SelectedIndexChanged += new System.EventHandler(this.cbxInventario_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(456, 357);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 17);
			this.label8.TabIndex = 169;
			this.label8.Text = "Estado:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(10, 205);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 17);
			this.label7.TabIndex = 168;
			this.label7.Text = "Cantidad:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(10, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 17);
			this.label5.TabIndex = 166;
			this.label5.Text = "Nombre:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(453, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 17);
			this.label4.TabIndex = 164;
			this.label4.Text = "Inventario:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(10, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 17);
			this.label3.TabIndex = 163;
			this.label3.Text = "Descripción:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(11, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 17);
			this.label2.TabIndex = 161;
			this.label2.Text = "Serie:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(13, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 17);
			this.label1.TabIndex = 159;
			this.label1.Text = "ID:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(126, 156);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(267, 39);
			this.txtDescripcion.TabIndex = 4;
			this.txtDescripcion.Tag = "Descripcion";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(125, 205);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(267, 20);
			this.txtCantidad.TabIndex = 5;
			this.txtCantidad.Tag = "Cantidad";
			// 
			// cbxMarca
			// 
			this.cbxMarca.FormattingEnabled = true;
			this.cbxMarca.Location = new System.Drawing.Point(126, 284);
			this.cbxMarca.Name = "cbxMarca";
			this.cbxMarca.Size = new System.Drawing.Size(268, 21);
			this.cbxMarca.TabIndex = 8;
			this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(12, 285);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 17);
			this.label6.TabIndex = 190;
			this.label6.Text = "Marca:";
			// 
			// cbxAlmacenamiento
			// 
			this.cbxAlmacenamiento.FormattingEnabled = true;
			this.cbxAlmacenamiento.Location = new System.Drawing.Point(126, 311);
			this.cbxAlmacenamiento.Name = "cbxAlmacenamiento";
			this.cbxAlmacenamiento.Size = new System.Drawing.Size(268, 21);
			this.cbxAlmacenamiento.TabIndex = 9;
			this.cbxAlmacenamiento.SelectedIndexChanged += new System.EventHandler(this.cbxAlmacenamiento_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label10.Location = new System.Drawing.Point(12, 312);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(116, 17);
			this.label10.TabIndex = 192;
			this.label10.Text = "Almacenamiento:";
			// 
			// cbxCat1
			// 
			this.cbxCat1.FormattingEnabled = true;
			this.cbxCat1.Location = new System.Drawing.Point(128, 338);
			this.cbxCat1.Name = "cbxCat1";
			this.cbxCat1.Size = new System.Drawing.Size(268, 21);
			this.cbxCat1.TabIndex = 10;
			this.cbxCat1.SelectedIndexChanged += new System.EventHandler(this.cbxCat1_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label11.Location = new System.Drawing.Point(14, 339);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 17);
			this.label11.TabIndex = 194;
			this.label11.Text = "Categoría 1:";
			// 
			// cbxCat2
			// 
			this.cbxCat2.FormattingEnabled = true;
			this.cbxCat2.Location = new System.Drawing.Point(128, 365);
			this.cbxCat2.Name = "cbxCat2";
			this.cbxCat2.Size = new System.Drawing.Size(268, 21);
			this.cbxCat2.TabIndex = 11;
			this.cbxCat2.SelectedIndexChanged += new System.EventHandler(this.cbxCat2_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label12.Location = new System.Drawing.Point(14, 366);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(85, 17);
			this.label12.TabIndex = 196;
			this.label12.Text = "Categoría 2:";
			// 
			// cbxCat3
			// 
			this.cbxCat3.FormattingEnabled = true;
			this.cbxCat3.Location = new System.Drawing.Point(128, 392);
			this.cbxCat3.Name = "cbxCat3";
			this.cbxCat3.Size = new System.Drawing.Size(268, 21);
			this.cbxCat3.TabIndex = 12;
			this.cbxCat3.SelectedIndexChanged += new System.EventHandler(this.cbxCat3_SelectedIndexChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label13.Location = new System.Drawing.Point(14, 393);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(85, 17);
			this.label13.TabIndex = 198;
			this.label13.Text = "Categoría 3:";
			// 
			// txtIdMarca
			// 
			this.txtIdMarca.Location = new System.Drawing.Point(411, 280);
			this.txtIdMarca.Name = "txtIdMarca";
			this.txtIdMarca.Size = new System.Drawing.Size(39, 20);
			this.txtIdMarca.TabIndex = 199;
			this.txtIdMarca.TabStop = false;
			this.txtIdMarca.Tag = "fkmarca";
			this.txtIdMarca.TextChanged += new System.EventHandler(this.txtIdMarca_TextChanged);
			// 
			// txtIdAlmacenamiento
			// 
			this.txtIdAlmacenamiento.Location = new System.Drawing.Point(411, 306);
			this.txtIdAlmacenamiento.Name = "txtIdAlmacenamiento";
			this.txtIdAlmacenamiento.Size = new System.Drawing.Size(39, 20);
			this.txtIdAlmacenamiento.TabIndex = 200;
			this.txtIdAlmacenamiento.TabStop = false;
			this.txtIdAlmacenamiento.Tag = "fktipoalmacen";
			this.txtIdAlmacenamiento.TextChanged += new System.EventHandler(this.txtIdAlmacenamiento_TextChanged);
			// 
			// txtIdCat1
			// 
			this.txtIdCat1.Location = new System.Drawing.Point(411, 337);
			this.txtIdCat1.Name = "txtIdCat1";
			this.txtIdCat1.Size = new System.Drawing.Size(39, 20);
			this.txtIdCat1.TabIndex = 201;
			this.txtIdCat1.TabStop = false;
			this.txtIdCat1.Tag = "fkcategoria1";
			this.txtIdCat1.TextChanged += new System.EventHandler(this.txtIdCat1_TextChanged);
			// 
			// txtIdCat2
			// 
			this.txtIdCat2.Location = new System.Drawing.Point(411, 364);
			this.txtIdCat2.Name = "txtIdCat2";
			this.txtIdCat2.Size = new System.Drawing.Size(39, 20);
			this.txtIdCat2.TabIndex = 202;
			this.txtIdCat2.TabStop = false;
			this.txtIdCat2.Tag = "fkcategoria2";
			this.txtIdCat2.TextChanged += new System.EventHandler(this.txtIdCat2_TextChanged);
			// 
			// txtIdCat3
			// 
			this.txtIdCat3.Location = new System.Drawing.Point(411, 391);
			this.txtIdCat3.Name = "txtIdCat3";
			this.txtIdCat3.Size = new System.Drawing.Size(39, 20);
			this.txtIdCat3.TabIndex = 203;
			this.txtIdCat3.TabStop = false;
			this.txtIdCat3.Tag = "fkcategoria3";
			this.txtIdCat3.TextChanged += new System.EventHandler(this.txtIdCat3_TextChanged);
			// 
			// txtIdSucursal
			// 
			this.txtIdSucursal.Location = new System.Drawing.Point(855, 99);
			this.txtIdSucursal.Name = "txtIdSucursal";
			this.txtIdSucursal.Size = new System.Drawing.Size(39, 20);
			this.txtIdSucursal.TabIndex = 206;
			this.txtIdSucursal.TabStop = false;
			this.txtIdSucursal.Tag = "fksucursal";
			this.txtIdSucursal.TextChanged += new System.EventHandler(this.txtIdSucursal_TextChanged);
			// 
			// cbxSucursal
			// 
			this.cbxSucursal.FormattingEnabled = true;
			this.cbxSucursal.Location = new System.Drawing.Point(581, 97);
			this.cbxSucursal.Name = "cbxSucursal";
			this.cbxSucursal.Size = new System.Drawing.Size(268, 21);
			this.cbxSucursal.TabIndex = 14;
			this.cbxSucursal.SelectedIndexChanged += new System.EventHandler(this.cbxSucursal_SelectedIndexChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label14.Location = new System.Drawing.Point(453, 102);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(67, 17);
			this.label14.TabIndex = 205;
			this.label14.Text = "Sucursal:";
			// 
			// txtIdUbicacion
			// 
			this.txtIdUbicacion.Location = new System.Drawing.Point(855, 154);
			this.txtIdUbicacion.Name = "txtIdUbicacion";
			this.txtIdUbicacion.Size = new System.Drawing.Size(39, 20);
			this.txtIdUbicacion.TabIndex = 209;
			this.txtIdUbicacion.TabStop = false;
			this.txtIdUbicacion.Tag = "fkubicacion";
			this.txtIdUbicacion.TextChanged += new System.EventHandler(this.txtIdUbicacion_TextChanged);
			// 
			// cbxUbicacion
			// 
			this.cbxUbicacion.FormattingEnabled = true;
			this.cbxUbicacion.Location = new System.Drawing.Point(581, 152);
			this.cbxUbicacion.Name = "cbxUbicacion";
			this.cbxUbicacion.Size = new System.Drawing.Size(268, 21);
			this.cbxUbicacion.TabIndex = 16;
			this.cbxUbicacion.SelectedIndexChanged += new System.EventHandler(this.cbxUbicacion_SelectedIndexChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label15.Location = new System.Drawing.Point(453, 157);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(74, 17);
			this.label15.TabIndex = 208;
			this.label15.Text = "Ubicación:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(453, 189);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 17);
			this.label9.TabIndex = 210;
			this.label9.Text = "Proveedores:";
			// 
			// txtMin
			// 
			this.txtMin.Location = new System.Drawing.Point(581, 297);
			this.txtMin.Name = "txtMin";
			this.txtMin.Size = new System.Drawing.Size(238, 20);
			this.txtMin.TabIndex = 17;
			this.txtMin.Tag = "minimo";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label16.Location = new System.Drawing.Point(453, 298);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(122, 17);
			this.label16.TabIndex = 214;
			this.label16.Text = "Inventario Mínimo:";
			// 
			// txtMax
			// 
			this.txtMax.Location = new System.Drawing.Point(581, 323);
			this.txtMax.Name = "txtMax";
			this.txtMax.Size = new System.Drawing.Size(238, 20);
			this.txtMax.TabIndex = 18;
			this.txtMax.Tag = "maximo";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label17.Location = new System.Drawing.Point(453, 324);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(125, 17);
			this.label17.TabIndex = 216;
			this.label17.Text = "Inventario Máximo:";
			// 
			// txtIdProveedores
			// 
			this.txtIdProveedores.Location = new System.Drawing.Point(855, 189);
			this.txtIdProveedores.Name = "txtIdProveedores";
			this.txtIdProveedores.Size = new System.Drawing.Size(39, 20);
			this.txtIdProveedores.TabIndex = 218;
			this.txtIdProveedores.TabStop = false;
			this.txtIdProveedores.Tag = "fkproveedores";
			this.txtIdProveedores.TextChanged += new System.EventHandler(this.txtIdProveedores_TextChanged);
			// 
			// txtIdBodega
			// 
			this.txtIdBodega.Location = new System.Drawing.Point(855, 126);
			this.txtIdBodega.Name = "txtIdBodega";
			this.txtIdBodega.Size = new System.Drawing.Size(39, 20);
			this.txtIdBodega.TabIndex = 222;
			this.txtIdBodega.TabStop = false;
			this.txtIdBodega.Tag = "fksucursal";
			this.txtIdBodega.TextChanged += new System.EventHandler(this.txtIdBodega_TextChanged);
			// 
			// cbxBodega
			// 
			this.cbxBodega.FormattingEnabled = true;
			this.cbxBodega.Location = new System.Drawing.Point(581, 124);
			this.cbxBodega.Name = "cbxBodega";
			this.cbxBodega.Size = new System.Drawing.Size(268, 21);
			this.cbxBodega.TabIndex = 15;
			this.cbxBodega.SelectedIndexChanged += new System.EventHandler(this.cbxBodega_SelectedIndexChanged);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label18.Location = new System.Drawing.Point(453, 129);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(61, 17);
			this.label18.TabIndex = 221;
			this.label18.Text = "Bodega:";
			// 
			// btnAyuda
			// 
			this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
			this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
			this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAyuda.FlatAppearance.BorderSize = 0;
			this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAyuda.Location = new System.Drawing.Point(349, -2);
			this.btnAyuda.Margin = new System.Windows.Forms.Padding(0);
			this.btnAyuda.Name = "btnAyuda";
			this.btnAyuda.Size = new System.Drawing.Size(50, 50);
			this.btnAyuda.TabIndex = 225;
			this.btnAyuda.UseVisualStyleBackColor = false;
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
			this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
			this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnActualizar.FlatAppearance.BorderSize = 0;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizar.Location = new System.Drawing.Point(299, -2);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(0);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(50, 50);
			this.btnActualizar.TabIndex = 226;
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
			this.btnEliminar.Location = new System.Drawing.Point(199, -2);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(50, 50);
			this.btnEliminar.TabIndex = 227;
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
			this.btnCancelar.Location = new System.Drawing.Point(149, -2);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(50, 50);
			this.btnCancelar.TabIndex = 228;
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
			this.btnGuardar.Location = new System.Drawing.Point(99, -2);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(50, 50);
			this.btnGuardar.TabIndex = 229;
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
			this.btnEditar.Location = new System.Drawing.Point(49, -2);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(50, 50);
			this.btnEditar.TabIndex = 230;
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
			this.btnIngresar.Location = new System.Drawing.Point(-1, -2);
			this.btnIngresar.Margin = new System.Windows.Forms.Padding(0);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(50, 50);
			this.btnIngresar.TabIndex = 231;
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
			this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnImprimir.FlatAppearance.BorderSize = 0;
			this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImprimir.Location = new System.Drawing.Point(249, -2);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(50, 50);
			this.btnImprimir.TabIndex = 223;
			this.btnImprimir.UseVisualStyleBackColor = false;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// dgvProveedores
			// 
			this.dgvProveedores.AllowUserToAddRows = false;
			this.dgvProveedores.AllowUserToDeleteRows = false;
			this.dgvProveedores.AllowUserToResizeRows = false;
			this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProveedores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProveedores.Enabled = false;
			this.dgvProveedores.Location = new System.Drawing.Point(581, 183);
			this.dgvProveedores.Name = "dgvProveedores";
			this.dgvProveedores.RowHeadersWidth = 51;
			this.dgvProveedores.Size = new System.Drawing.Size(268, 108);
			this.dgvProveedores.TabIndex = 232;
			this.dgvProveedores.TabStop = false;
			this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(125, 231);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(267, 20);
			this.txtPrecio.TabIndex = 6;
			this.txtPrecio.Tag = "Precio_Compra";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label19.Location = new System.Drawing.Point(10, 231);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(105, 17);
			this.label19.TabIndex = 233;
			this.label19.Text = "Precio Compra:";
			// 
			// txtPVenta
			// 
			this.txtPVenta.Location = new System.Drawing.Point(125, 257);
			this.txtPVenta.Name = "txtPVenta";
			this.txtPVenta.Size = new System.Drawing.Size(267, 20);
			this.txtPVenta.TabIndex = 7;
			this.txtPVenta.Tag = "Precio_Venta";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label20.Location = new System.Drawing.Point(11, 258);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(93, 17);
			this.label20.TabIndex = 235;
			this.label20.Text = "Precio Venta:";
			// 
			// frmProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(917, 622);
			this.Controls.Add(this.txtPVenta);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.dgvProveedores);
			this.Controls.Add(this.btnAyuda);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtMax);
			this.Controls.Add(this.txtMin);
			this.Controls.Add(this.txtIdProveedores);
			this.Controls.Add(this.txtIdUbicacion);
			this.Controls.Add(this.txtIdBodega);
			this.Controls.Add(this.txtIdSucursal);
			this.Controls.Add(this.txtIdCat3);
			this.Controls.Add(this.txtIdCat2);
			this.Controls.Add(this.txtIdCat1);
			this.Controls.Add(this.txtIdAlmacenamiento);
			this.Controls.Add(this.txtIdMarca);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtSerie);
			this.Controls.Add(this.txtIdInventario);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.cbxBodega);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cbxUbicacion);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.cbxSucursal);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.cbxCat3);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.cbxCat2);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.cbxCat1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cbxAlmacenamiento);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cbxMarca);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.cbxInventario);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmProducto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Producto";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtSerie;
		private System.Windows.Forms.TextBox txtIdInventario;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnInactivo;
		private System.Windows.Forms.RadioButton rbnActivo;
		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.ComboBox cbxInventario;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.ComboBox cbxMarca;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxAlmacenamiento;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbxCat1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbxCat2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cbxCat3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtIdMarca;
		private System.Windows.Forms.TextBox txtIdAlmacenamiento;
		private System.Windows.Forms.TextBox txtIdCat1;
		private System.Windows.Forms.TextBox txtIdCat2;
		private System.Windows.Forms.TextBox txtIdCat3;
		private System.Windows.Forms.TextBox txtIdSucursal;
		private System.Windows.Forms.ComboBox cbxSucursal;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtIdUbicacion;
		private System.Windows.Forms.ComboBox cbxUbicacion;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtMin;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtMax;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtIdProveedores;
		private System.Windows.Forms.TextBox txtIdBodega;
		private System.Windows.Forms.ComboBox cbxBodega;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button btnAyuda;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.DataGridView dgvProveedores;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtPVenta;
		private System.Windows.Forms.Label label20;
	}
}