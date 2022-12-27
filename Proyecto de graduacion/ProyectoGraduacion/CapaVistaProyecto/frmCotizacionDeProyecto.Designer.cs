
namespace CapaVistaProyecto
{
    partial class frmCotizacionDeProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotizacionDeProyecto));
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvCotizaciones = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnEliminarD = new System.Windows.Forms.Button();
            this.btnCancelarD = new System.Windows.Forms.Button();
            this.btnGuardarD = new System.Windows.Forms.Button();
            this.btnEditarD = new System.Windows.Forms.Button();
            this.btnIngresarD = new System.Windows.Forms.Button();
            this.txtEstadoD = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbnInactivoD = new System.Windows.Forms.RadioButton();
            this.rbnActivoD = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtHospedaje = new System.Windows.Forms.TextBox();
            this.txtPeaje = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCombustible = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtManodeobra = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDisponibilidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.cbxInventario = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
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
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.cbxIdEmpresa = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(124, 616);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(268, 20);
            this.txtDescuento.TabIndex = 378;
            this.txtDescuento.Tag = "serie";
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(124, 457);
            this.txtCantidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(268, 20);
            this.txtCantidad.TabIndex = 377;
            this.txtCantidad.ValueChanged += new System.EventHandler(this.txtCantidad_ValueChanged);
            this.txtCantidad.Scroll += new System.Windows.Forms.ScrollEventHandler(this.txtCantidad_Scroll);
            this.txtCantidad.Click += new System.EventHandler(this.txtCantidad_Click);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress_1);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            this.txtCantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCantidad_MouseClick);
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
            this.dgvCotizaciones.Location = new System.Drawing.Point(428, 71);
            this.dgvCotizaciones.Name = "dgvCotizaciones";
            this.dgvCotizaciones.ReadOnly = true;
            this.dgvCotizaciones.RowHeadersWidth = 51;
            this.dgvCotizaciones.Size = new System.Drawing.Size(462, 188);
            this.dgvCotizaciones.TabIndex = 376;
            this.dgvCotizaciones.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCotizaciones_RowHeaderMouseClick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(10, 615);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 17);
            this.label22.TabIndex = 374;
            this.label22.Text = "Descuento:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(330, 3);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 375;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(10, 458);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 373;
            this.label16.Text = "Cantidad:";
            // 
            // btnEliminarD
            // 
            this.btnEliminarD.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarD.BackgroundImage")));
            this.btnEliminarD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarD.FlatAppearance.BorderSize = 0;
            this.btnEliminarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarD.Location = new System.Drawing.Point(212, 237);
            this.btnEliminarD.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarD.Name = "btnEliminarD";
            this.btnEliminarD.Size = new System.Drawing.Size(50, 50);
            this.btnEliminarD.TabIndex = 368;
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
            this.btnCancelarD.Location = new System.Drawing.Point(162, 237);
            this.btnCancelarD.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelarD.Name = "btnCancelarD";
            this.btnCancelarD.Size = new System.Drawing.Size(50, 50);
            this.btnCancelarD.TabIndex = 369;
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
            this.btnGuardarD.Location = new System.Drawing.Point(112, 237);
            this.btnGuardarD.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardarD.Name = "btnGuardarD";
            this.btnGuardarD.Size = new System.Drawing.Size(50, 50);
            this.btnGuardarD.TabIndex = 370;
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
            this.btnEditarD.Location = new System.Drawing.Point(62, 237);
            this.btnEditarD.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarD.Name = "btnEditarD";
            this.btnEditarD.Size = new System.Drawing.Size(50, 50);
            this.btnEditarD.TabIndex = 371;
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
            this.btnIngresarD.Location = new System.Drawing.Point(12, 237);
            this.btnIngresarD.Margin = new System.Windows.Forms.Padding(0);
            this.btnIngresarD.Name = "btnIngresarD";
            this.btnIngresarD.Size = new System.Drawing.Size(50, 50);
            this.btnIngresarD.TabIndex = 372;
            this.btnIngresarD.UseVisualStyleBackColor = false;
            this.btnIngresarD.Click += new System.EventHandler(this.btnIngresarD_Click);
            // 
            // txtEstadoD
            // 
            this.txtEstadoD.Location = new System.Drawing.Point(343, 673);
            this.txtEstadoD.Name = "txtEstadoD";
            this.txtEstadoD.Size = new System.Drawing.Size(39, 20);
            this.txtEstadoD.TabIndex = 366;
            this.txtEstadoD.Tag = "estado";
            this.txtEstadoD.Visible = false;
            this.txtEstadoD.TextChanged += new System.EventHandler(this.txtEstadoD_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.rbnInactivoD);
            this.panel2.Controls.Add(this.rbnActivoD);
            this.panel2.Location = new System.Drawing.Point(137, 671);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 28);
            this.panel2.TabIndex = 367;
            // 
            // rbnInactivoD
            // 
            this.rbnInactivoD.AutoSize = true;
            this.rbnInactivoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbnInactivoD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbnInactivoD.Location = new System.Drawing.Point(104, 1);
            this.rbnInactivoD.Name = "rbnInactivoD";
            this.rbnInactivoD.Size = new System.Drawing.Size(74, 21);
            this.rbnInactivoD.TabIndex = 3;
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
            this.rbnActivoD.TabIndex = 2;
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
            this.label15.Location = new System.Drawing.Point(12, 669);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 365;
            this.label15.Text = "Estado:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(123, 642);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(268, 20);
            this.txtSubtotal.TabIndex = 363;
            this.txtSubtotal.Tag = "serie";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(8, 645);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 364;
            this.label14.Text = "Subtotal:";
            // 
            // txtOtros
            // 
            this.txtOtros.Enabled = false;
            this.txtOtros.Location = new System.Drawing.Point(124, 588);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(268, 20);
            this.txtOtros.TabIndex = 351;
            this.txtOtros.Tag = "";
            this.txtOtros.Text = "0";
            this.txtOtros.TextChanged += new System.EventHandler(this.txtOtros_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(8, 589);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 17);
            this.label21.TabIndex = 360;
            this.label21.Text = "Otros:";
            // 
            // txtHospedaje
            // 
            this.txtHospedaje.Enabled = false;
            this.txtHospedaje.Location = new System.Drawing.Point(124, 536);
            this.txtHospedaje.Name = "txtHospedaje";
            this.txtHospedaje.Size = new System.Drawing.Size(268, 20);
            this.txtHospedaje.TabIndex = 352;
            this.txtHospedaje.Tag = "serie";
            this.txtHospedaje.Text = "0";
            this.txtHospedaje.TextChanged += new System.EventHandler(this.txtHospedaje_TextChanged);
            // 
            // txtPeaje
            // 
            this.txtPeaje.Enabled = false;
            this.txtPeaje.Location = new System.Drawing.Point(124, 562);
            this.txtPeaje.Name = "txtPeaje";
            this.txtPeaje.Size = new System.Drawing.Size(268, 20);
            this.txtPeaje.TabIndex = 353;
            this.txtPeaje.Tag = "serie";
            this.txtPeaje.Text = "0";
            this.txtPeaje.TextChanged += new System.EventHandler(this.txtPeaje_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(8, 537);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 17);
            this.label19.TabIndex = 358;
            this.label19.Text = "Hospedaje:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(7, 563);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 17);
            this.label20.TabIndex = 357;
            this.label20.Text = "Peaje:";
            // 
            // txtCombustible
            // 
            this.txtCombustible.Enabled = false;
            this.txtCombustible.Location = new System.Drawing.Point(124, 510);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.Size = new System.Drawing.Size(268, 20);
            this.txtCombustible.TabIndex = 354;
            this.txtCombustible.Tag = "serie";
            this.txtCombustible.Text = "0";
            this.txtCombustible.TextChanged += new System.EventHandler(this.txtCombustible_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(7, 511);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 17);
            this.label18.TabIndex = 362;
            this.label18.Text = "Combustible:";
            // 
            // txtManodeobra
            // 
            this.txtManodeobra.Enabled = false;
            this.txtManodeobra.Location = new System.Drawing.Point(124, 483);
            this.txtManodeobra.Name = "txtManodeobra";
            this.txtManodeobra.Size = new System.Drawing.Size(268, 20);
            this.txtManodeobra.TabIndex = 355;
            this.txtManodeobra.Tag = "serie";
            this.txtManodeobra.Text = "0";
            this.txtManodeobra.TextChanged += new System.EventHandler(this.txtManodeobra_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(7, 486);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 17);
            this.label17.TabIndex = 359;
            this.label17.Text = "Mano de obra:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(124, 431);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(268, 20);
            this.txtPrecio.TabIndex = 356;
            this.txtPrecio.Tag = "serie";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(9, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 17);
            this.label13.TabIndex = 361;
            this.label13.Text = "Precio Unitario:";
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.Enabled = false;
            this.txtDisponibilidad.Location = new System.Drawing.Point(124, 405);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(268, 20);
            this.txtDisponibilidad.TabIndex = 349;
            this.txtDisponibilidad.Tag = "serie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(9, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 350;
            this.label12.Text = "Disponibilidad:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(124, 377);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(39, 20);
            this.txtProducto.TabIndex = 348;
            this.txtProducto.TabStop = false;
            this.txtProducto.Tag = "fkinventarioE";
            this.txtProducto.Visible = false;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(124, 378);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(268, 21);
            this.cbxProducto.TabIndex = 346;
            this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(8, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 347;
            this.label11.Text = "Producto:";
            // 
            // txtInventario
            // 
            this.txtInventario.Location = new System.Drawing.Point(123, 351);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(39, 20);
            this.txtInventario.TabIndex = 345;
            this.txtInventario.TabStop = false;
            this.txtInventario.Tag = "fkinventarioE";
            this.txtInventario.Visible = false;
            this.txtInventario.TextChanged += new System.EventHandler(this.txtInventario_TextChanged);
            // 
            // cbxInventario
            // 
            this.cbxInventario.FormattingEnabled = true;
            this.cbxInventario.Location = new System.Drawing.Point(124, 351);
            this.cbxInventario.Name = "cbxInventario";
            this.cbxInventario.Size = new System.Drawing.Size(268, 21);
            this.cbxInventario.TabIndex = 343;
            this.cbxInventario.SelectedIndexChanged += new System.EventHandler(this.cbxInventario_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(8, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 344;
            this.label10.Text = "Inventario:";
            // 
            // txtIDD
            // 
            this.txtIDD.Enabled = false;
            this.txtIDD.Location = new System.Drawing.Point(124, 325);
            this.txtIDD.Name = "txtIDD";
            this.txtIDD.Size = new System.Drawing.Size(268, 20);
            this.txtIDD.TabIndex = 341;
            this.txtIDD.Tag = "pkid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(10, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 342;
            this.label9.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(163, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 340;
            this.label7.Text = "Detalle de Cotizacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(132, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 17);
            this.label6.TabIndex = 339;
            this.label6.Text = "Encabezado de Cotizacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(635, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 338;
            this.label4.Text = "Detalles Relacionados";
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
            this.dgvDetalles.Location = new System.Drawing.Point(428, 262);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(462, 434);
            this.dgvDetalles.TabIndex = 337;
            this.dgvDetalles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDetalles_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(625, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 336;
            this.label3.Text = "Cotizaciones Registradas";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(478, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.TabIndex = 328;
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
            this.btnAyuda.Location = new System.Drawing.Point(428, 3);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(50, 50);
            this.btnAyuda.TabIndex = 329;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(378, 3);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(50, 50);
            this.btnActualizar.TabIndex = 330;
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
            this.btnEliminar.Location = new System.Drawing.Point(213, 3);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 331;
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
            this.btnCancelar.Location = new System.Drawing.Point(163, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 332;
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
            this.btnGuardar.Location = new System.Drawing.Point(113, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 333;
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
            this.btnEditar.Location = new System.Drawing.Point(63, 3);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 334;
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
            this.btnIngresar.Location = new System.Drawing.Point(13, 3);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(50, 50);
            this.btnIngresar.TabIndex = 335;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(124, 133);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(39, 20);
            this.txtFecha.TabIndex = 327;
            this.txtFecha.TabStop = false;
            this.txtFecha.Tag = "fkinventarioE";
            this.txtFecha.Visible = false;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(124, 133);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(268, 20);
            this.dtpFecha.TabIndex = 326;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(10, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 325;
            this.label5.Text = "Fecha:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(125, 159);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(267, 20);
            this.txtTotal.TabIndex = 323;
            this.txtTotal.Tag = "nombre";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl.Location = new System.Drawing.Point(7, 164);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 17);
            this.lbl.TabIndex = 324;
            this.lbl.Text = "Total:";
            // 
            // txtEstadoE
            // 
            this.txtEstadoE.Location = new System.Drawing.Point(341, 214);
            this.txtEstadoE.Name = "txtEstadoE";
            this.txtEstadoE.Size = new System.Drawing.Size(39, 20);
            this.txtEstadoE.TabIndex = 321;
            this.txtEstadoE.Tag = "estado";
            this.txtEstadoE.Visible = false;
            this.txtEstadoE.TextChanged += new System.EventHandler(this.txtEstadoE_TextChanged);
            // 
            // txtProyecto
            // 
            this.txtProyecto.Location = new System.Drawing.Point(124, 107);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(268, 20);
            this.txtProyecto.TabIndex = 318;
            this.txtProyecto.Tag = "serie";
            // 
            // txtIDE
            // 
            this.txtIDE.Enabled = false;
            this.txtIDE.Location = new System.Drawing.Point(124, 82);
            this.txtIDE.Name = "txtIDE";
            this.txtIDE.Size = new System.Drawing.Size(268, 20);
            this.txtIDE.TabIndex = 316;
            this.txtIDE.Tag = "pkid";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbnInactivoE);
            this.panel1.Controls.Add(this.rbnActivoE);
            this.panel1.Location = new System.Drawing.Point(135, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 28);
            this.panel1.TabIndex = 322;
            // 
            // rbnInactivoE
            // 
            this.rbnInactivoE.AutoSize = true;
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
            this.label8.Location = new System.Drawing.Point(10, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 320;
            this.label8.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 319;
            this.label2.Text = "Proyecto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 317;
            this.label1.Text = "ID:";
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Location = new System.Drawing.Point(124, 183);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(39, 20);
            this.txtIdEmpresa.TabIndex = 379;
            this.txtIdEmpresa.TabStop = false;
            this.txtIdEmpresa.Tag = "Fk_Empresa";
            this.txtIdEmpresa.Visible = false;
            // 
            // cbxIdEmpresa
            // 
            this.cbxIdEmpresa.FormattingEnabled = true;
            this.cbxIdEmpresa.Location = new System.Drawing.Point(123, 183);
            this.cbxIdEmpresa.Name = "cbxIdEmpresa";
            this.cbxIdEmpresa.Size = new System.Drawing.Size(269, 21);
            this.cbxIdEmpresa.TabIndex = 381;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(8, 184);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 16);
            this.label23.TabIndex = 380;
            this.label23.Text = "Empresa:";
            // 
            // frmCotizacionDeProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 702);
            this.Controls.Add(this.txtIdEmpresa);
            this.Controls.Add(this.cbxIdEmpresa);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvCotizaciones);
            this.Controls.Add(this.label22);
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
            this.Controls.Add(this.txtOtros);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtHospedaje);
            this.Controls.Add(this.txtPeaje);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCombustible);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtManodeobra);
            this.Controls.Add(this.label17);
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
            this.Controls.Add(this.btnSalir);
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
            this.Name = "frmCotizacionDeProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotización de Proyecto";
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizaciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.DataGridView dgvCotizaciones;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnEliminarD;
        private System.Windows.Forms.Button btnCancelarD;
        private System.Windows.Forms.Button btnGuardarD;
        private System.Windows.Forms.Button btnEditarD;
        private System.Windows.Forms.Button btnIngresarD;
        private System.Windows.Forms.TextBox txtEstadoD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbnInactivoD;
        private System.Windows.Forms.RadioButton rbnActivoD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtHospedaje;
        private System.Windows.Forms.TextBox txtPeaje;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCombustible;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtManodeobra;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDisponibilidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.ComboBox cbxInventario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnIngresar;
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
        private System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.ComboBox cbxIdEmpresa;
        private System.Windows.Forms.Label label23;
    }
}