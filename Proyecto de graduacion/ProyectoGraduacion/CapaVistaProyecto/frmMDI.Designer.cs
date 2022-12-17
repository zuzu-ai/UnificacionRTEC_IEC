
namespace CapaVistaProyecto
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jornadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamañoDeMotorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCombustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónDeEsquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizaciónProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtnombretusuario = new System.Windows.Forms.TextBox();
            this.txtidtusuario = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.asiganacionDeProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosAsignadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesDeProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.ayudasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem,
            this.empresaClienteToolStripMenuItem,
            this.jornadaToolStripMenuItem,
            this.lineaToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.puestoToolStripMenuItem,
            this.tamañoDeMotorToolStripMenuItem,
            this.tipoDeCombustibleToolStripMenuItem,
            this.sucursalToolStripMenuItem,
            this.vehiculoToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // jornadaToolStripMenuItem
            // 
            this.jornadaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jornadaToolStripMenuItem.Image")));
            this.jornadaToolStripMenuItem.Name = "jornadaToolStripMenuItem";
            this.jornadaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.jornadaToolStripMenuItem.Text = "Jornada";
            this.jornadaToolStripMenuItem.Click += new System.EventHandler(this.jornadaToolStripMenuItem_Click);
            // 
            // lineaToolStripMenuItem
            // 
            this.lineaToolStripMenuItem.Name = "lineaToolStripMenuItem";
            this.lineaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.lineaToolStripMenuItem.Text = "Linea";
            this.lineaToolStripMenuItem.Click += new System.EventHandler(this.lineaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // puestoToolStripMenuItem
            // 
            this.puestoToolStripMenuItem.Name = "puestoToolStripMenuItem";
            this.puestoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.puestoToolStripMenuItem.Text = "Puesto";
            this.puestoToolStripMenuItem.Click += new System.EventHandler(this.puestoToolStripMenuItem_Click);
            // 
            // tamañoDeMotorToolStripMenuItem
            // 
            this.tamañoDeMotorToolStripMenuItem.Name = "tamañoDeMotorToolStripMenuItem";
            this.tamañoDeMotorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tamañoDeMotorToolStripMenuItem.Text = "Tamaño de motor";
            this.tamañoDeMotorToolStripMenuItem.Click += new System.EventHandler(this.tamañoDeMotorToolStripMenuItem_Click);
            // 
            // tipoDeCombustibleToolStripMenuItem
            // 
            this.tipoDeCombustibleToolStripMenuItem.Name = "tipoDeCombustibleToolStripMenuItem";
            this.tipoDeCombustibleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tipoDeCombustibleToolStripMenuItem.Text = "Tipo de combustible";
            this.tipoDeCombustibleToolStripMenuItem.Click += new System.EventHandler(this.tipoDeCombustibleToolStripMenuItem_Click);
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.vehiculoToolStripMenuItem.Text = "Vehiculo";
            this.vehiculoToolStripMenuItem.Click += new System.EventHandler(this.vehiculoToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignaciónDeEsquiposToolStripMenuItem,
            this.asiganacionDeProyectoToolStripMenuItem,
            this.cotizaciónProyectoToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // asignaciónDeEsquiposToolStripMenuItem
            // 
            this.asignaciónDeEsquiposToolStripMenuItem.Name = "asignaciónDeEsquiposToolStripMenuItem";
            this.asignaciónDeEsquiposToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.asignaciónDeEsquiposToolStripMenuItem.Text = "Asignación de equipos";
            this.asignaciónDeEsquiposToolStripMenuItem.Click += new System.EventHandler(this.asignaciónDeEsquiposToolStripMenuItem_Click);
            // 
            // cotizaciónProyectoToolStripMenuItem
            // 
            this.cotizaciónProyectoToolStripMenuItem.Name = "cotizaciónProyectoToolStripMenuItem";
            this.cotizaciónProyectoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cotizaciónProyectoToolStripMenuItem.Text = "Cotización Proyecto";
            this.cotizaciónProyectoToolStripMenuItem.Click += new System.EventHandler(this.cotizaciónProyectoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionesDeProyectosToolStripMenuItem,
            this.proyectosAsignadosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.tipoUsuarioToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioToolStripMenuItem.Image")));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // tipoUsuarioToolStripMenuItem
            // 
            this.tipoUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoUsuarioToolStripMenuItem.Image")));
            this.tipoUsuarioToolStripMenuItem.Name = "tipoUsuarioToolStripMenuItem";
            this.tipoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.tipoUsuarioToolStripMenuItem.Text = "Tipo Usuario";
            this.tipoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tipoUsuarioToolStripMenuItem_Click);
            // 
            // ayudasToolStripMenuItem
            // 
            this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
            this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ayudasToolStripMenuItem.Text = "Ayudas";
            // 
            // txtnombretusuario
            // 
            this.txtnombretusuario.Location = new System.Drawing.Point(670, 629);
            this.txtnombretusuario.Name = "txtnombretusuario";
            this.txtnombretusuario.Size = new System.Drawing.Size(100, 20);
            this.txtnombretusuario.TabIndex = 11;
            this.txtnombretusuario.Visible = false;
            // 
            // txtidtusuario
            // 
            this.txtidtusuario.Location = new System.Drawing.Point(540, 629);
            this.txtidtusuario.Name = "txtidtusuario";
            this.txtidtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtidtusuario.TabIndex = 10;
            this.txtidtusuario.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(423, 629);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            this.txtId.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(293, 629);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Visible = false;
            // 
            // asiganacionDeProyectoToolStripMenuItem
            // 
            this.asiganacionDeProyectoToolStripMenuItem.Name = "asiganacionDeProyectoToolStripMenuItem";
            this.asiganacionDeProyectoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.asiganacionDeProyectoToolStripMenuItem.Text = "Asiganacion de Proyecto";
            this.asiganacionDeProyectoToolStripMenuItem.Click += new System.EventHandler(this.asiganacionDeProyectoToolStripMenuItem_Click);
            // 
            // sucursalToolStripMenuItem
            // 
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sucursalToolStripMenuItem.Text = "Sucursal";
            this.sucursalToolStripMenuItem.Click += new System.EventHandler(this.sucursalToolStripMenuItem_Click);
            // 
            // empresaClienteToolStripMenuItem
            // 
            this.empresaClienteToolStripMenuItem.Name = "empresaClienteToolStripMenuItem";
            this.empresaClienteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.empresaClienteToolStripMenuItem.Text = "Empresa Cliente";
            this.empresaClienteToolStripMenuItem.Click += new System.EventHandler(this.empresaClienteToolStripMenuItem_Click);
            // 
            // proyectosAsignadosToolStripMenuItem
            // 
            this.proyectosAsignadosToolStripMenuItem.Name = "proyectosAsignadosToolStripMenuItem";
            this.proyectosAsignadosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.proyectosAsignadosToolStripMenuItem.Text = "Proyectos asignados";
            this.proyectosAsignadosToolStripMenuItem.Click += new System.EventHandler(this.proyectosAsignadosToolStripMenuItem_Click);
            // 
            // cotizacionesDeProyectosToolStripMenuItem
            // 
            this.cotizacionesDeProyectosToolStripMenuItem.Name = "cotizacionesDeProyectosToolStripMenuItem";
            this.cotizacionesDeProyectosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cotizacionesDeProyectosToolStripMenuItem.Text = "Cotizaciones de Proyectos";
            this.cotizacionesDeProyectosToolStripMenuItem.Click += new System.EventHandler(this.cotizacionesDeProyectosToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.txtnombretusuario);
            this.Controls.Add(this.txtidtusuario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1116, 700);
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSTELECOM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMDI_FormClosing);
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jornadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamañoDeMotorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCombustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaciónDeEsquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizaciónProyectoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtnombretusuario;
        private System.Windows.Forms.TextBox txtidtusuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem asiganacionDeProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesDeProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosAsignadosToolStripMenuItem;
    }
}