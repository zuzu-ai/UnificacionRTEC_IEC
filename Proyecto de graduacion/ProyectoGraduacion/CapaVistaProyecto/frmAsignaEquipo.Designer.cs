
namespace CapaVistaProyecto
{
    partial class frmAsignaEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignaEquipo));
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
            this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dvgEmpleadosAsignados = new System.Windows.Forms.DataGridView();
            this.dvgTodosEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAsignarTodosEmp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAsignarUnEmpleado = new System.Windows.Forms.Button();
            this.quitarunemp = new System.Windows.Forms.Button();
            this.quietatodosemp = new System.Windows.Forms.Button();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.navegadorMantenimientos1 = new CapaVistaNavegador.NavegadorMantenimientos();
            this.txtCeldas = new System.Windows.Forms.Label();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.cbxIdEmpresa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleadosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTodosEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(158, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 20);
            this.txtID.TabIndex = 144;
            this.txtID.Tag = "ID_Encabezado";
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 145;
            this.label1.Text = "ID de equipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 145;
            this.label2.Text = "Nombre del equipo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(158, 101);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(204, 20);
            this.txtDescripcion.TabIndex = 144;
            this.txtDescripcion.Tag = "nombre";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(697, 102);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(39, 20);
            this.txtEstado.TabIndex = 151;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbnEstatusimodulo);
            this.panel1.Controls.Add(this.rbnEstatusamodulo);
            this.panel1.Location = new System.Drawing.Point(493, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 28);
            this.panel1.TabIndex = 150;
            // 
            // rbnEstatusimodulo
            // 
            this.rbnEstatusimodulo.AutoSize = true;
            this.rbnEstatusimodulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEstatusimodulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbnEstatusimodulo.Location = new System.Drawing.Point(97, 5);
            this.rbnEstatusimodulo.Name = "rbnEstatusimodulo";
            this.rbnEstatusimodulo.Size = new System.Drawing.Size(72, 20);
            this.rbnEstatusimodulo.TabIndex = 6;
            this.rbnEstatusimodulo.TabStop = true;
            this.rbnEstatusimodulo.Text = "Inactivo";
            this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
            this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
            // 
            // rbnEstatusamodulo
            // 
            this.rbnEstatusamodulo.AutoSize = true;
            this.rbnEstatusamodulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEstatusamodulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbnEstatusamodulo.Location = new System.Drawing.Point(24, 5);
            this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
            this.rbnEstatusamodulo.Size = new System.Drawing.Size(63, 20);
            this.rbnEstatusamodulo.TabIndex = 5;
            this.rbnEstatusamodulo.TabStop = true;
            this.rbnEstatusamodulo.Text = "Activo";
            this.rbnEstatusamodulo.UseVisualStyleBackColor = true;
            this.rbnEstatusamodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusamodulo_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(398, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 149;
            this.label8.Text = "Estado:";
            // 
            // dvgEmpleadosAsignados
            // 
            this.dvgEmpleadosAsignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgEmpleadosAsignados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgEmpleadosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEmpleadosAsignados.Location = new System.Drawing.Point(461, 354);
            this.dvgEmpleadosAsignados.Name = "dvgEmpleadosAsignados";
            this.dvgEmpleadosAsignados.Size = new System.Drawing.Size(334, 322);
            this.dvgEmpleadosAsignados.TabIndex = 161;
            // 
            // dvgTodosEmpleados
            // 
            this.dvgTodosEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgTodosEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgTodosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTodosEmpleados.Location = new System.Drawing.Point(19, 354);
            this.dvgTodosEmpleados.Name = "dvgTodosEmpleados";
            this.dvgTodosEmpleados.Size = new System.Drawing.Size(334, 322);
            this.dvgTodosEmpleados.TabIndex = 160;
            // 
            // btnAsignarTodosEmp
            // 
            this.btnAsignarTodosEmp.Location = new System.Drawing.Point(381, 426);
            this.btnAsignarTodosEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarTodosEmp.Name = "btnAsignarTodosEmp";
            this.btnAsignarTodosEmp.Size = new System.Drawing.Size(58, 27);
            this.btnAsignarTodosEmp.TabIndex = 159;
            this.btnAsignarTodosEmp.Text = ">>";
            this.btnAsignarTodosEmp.UseVisualStyleBackColor = true;
            this.btnAsignarTodosEmp.Click += new System.EventHandler(this.btnAsignarTodosEmp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(19, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 158;
            this.label5.Text = "Todos los empleados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(467, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 157;
            this.label4.Text = "Empleados asignados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(363, 470);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 156;
            this.label3.Text = "Quitar Empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(364, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 155;
            this.label6.Text = "Asignar Empleado";
            // 
            // btnAsignarUnEmpleado
            // 
            this.btnAsignarUnEmpleado.Location = new System.Drawing.Point(381, 395);
            this.btnAsignarUnEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarUnEmpleado.Name = "btnAsignarUnEmpleado";
            this.btnAsignarUnEmpleado.Size = new System.Drawing.Size(58, 27);
            this.btnAsignarUnEmpleado.TabIndex = 153;
            this.btnAsignarUnEmpleado.Text = ">";
            this.btnAsignarUnEmpleado.UseVisualStyleBackColor = true;
            this.btnAsignarUnEmpleado.Click += new System.EventHandler(this.btnAsignarUnEmpleado_Click);
            // 
            // quitarunemp
            // 
            this.quitarunemp.Location = new System.Drawing.Point(380, 495);
            this.quitarunemp.Margin = new System.Windows.Forms.Padding(2);
            this.quitarunemp.Name = "quitarunemp";
            this.quitarunemp.Size = new System.Drawing.Size(58, 27);
            this.quitarunemp.TabIndex = 152;
            this.quitarunemp.Text = "<";
            this.quitarunemp.UseVisualStyleBackColor = true;
            this.quitarunemp.Click += new System.EventHandler(this.quitarunemp_Click);
            // 
            // quietatodosemp
            // 
            this.quietatodosemp.Location = new System.Drawing.Point(380, 527);
            this.quietatodosemp.Margin = new System.Windows.Forms.Padding(2);
            this.quietatodosemp.Name = "quietatodosemp";
            this.quietatodosemp.Size = new System.Drawing.Size(58, 27);
            this.quietatodosemp.TabIndex = 154;
            this.quietatodosemp.Text = "<<";
            this.quietatodosemp.UseVisualStyleBackColor = true;
            this.quietatodosemp.Click += new System.EventHandler(this.quietatodosemp_Click);
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVistaPrevia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVistaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVistaPrevia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(19, 171);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.RowHeadersWidth = 51;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(776, 140);
            this.dgvVistaPrevia.TabIndex = 162;
            this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(19, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 158;
            this.label7.Text = "Todos los equipos";
            // 
            // navegadorMantenimientos1
            // 
            this.navegadorMantenimientos1.BackColor = System.Drawing.Color.Transparent;
            this.navegadorMantenimientos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navegadorMantenimientos1.Location = new System.Drawing.Point(83, 12);
            this.navegadorMantenimientos1.Name = "navegadorMantenimientos1";
            this.navegadorMantenimientos1.Size = new System.Drawing.Size(658, 49);
            this.navegadorMantenimientos1.TabIndex = 163;
            // 
            // txtCeldas
            // 
            this.txtCeldas.AutoSize = true;
            this.txtCeldas.BackColor = System.Drawing.Color.Transparent;
            this.txtCeldas.Location = new System.Drawing.Point(180, 327);
            this.txtCeldas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCeldas.Name = "txtCeldas";
            this.txtCeldas.Size = new System.Drawing.Size(0, 13);
            this.txtCeldas.TabIndex = 158;
            this.txtCeldas.Visible = false;
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Location = new System.Drawing.Point(471, 74);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(37, 20);
            this.txtIdEmpresa.TabIndex = 164;
            this.txtIdEmpresa.TabStop = false;
            this.txtIdEmpresa.Tag = "Fk_Empresa";
            this.txtIdEmpresa.Visible = false;
            this.txtIdEmpresa.TextChanged += new System.EventHandler(this.txtIdEmpresa_TextChanged);
            // 
            // cbxIdEmpresa
            // 
            this.cbxIdEmpresa.FormattingEnabled = true;
            this.cbxIdEmpresa.Location = new System.Drawing.Point(470, 74);
            this.cbxIdEmpresa.Name = "cbxIdEmpresa";
            this.cbxIdEmpresa.Size = new System.Drawing.Size(251, 21);
            this.cbxIdEmpresa.TabIndex = 166;
            this.cbxIdEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbxIdEmpresa_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(398, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 165;
            this.label9.Text = "Empresa:";
            // 
            // frmAsignaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 691);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtIdEmpresa);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxIdEmpresa);
            this.Controls.Add(this.navegadorMantenimientos1);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.dvgEmpleadosAsignados);
            this.Controls.Add(this.dvgTodosEmpleados);
            this.Controls.Add(this.btnAsignarTodosEmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCeldas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAsignarUnEmpleado);
            this.Controls.Add(this.quitarunemp);
            this.Controls.Add(this.quietatodosemp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAsignaEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Equipo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleadosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTodosEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dvgEmpleadosAsignados;
        private System.Windows.Forms.DataGridView dvgTodosEmpleados;
        private System.Windows.Forms.Button btnAsignarTodosEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAsignarUnEmpleado;
        private System.Windows.Forms.Button quitarunemp;
        private System.Windows.Forms.Button quietatodosemp;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.Label label7;
        private CapaVistaNavegador.NavegadorMantenimientos navegadorMantenimientos1;
        private System.Windows.Forms.Label txtCeldas;
        private System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.ComboBox cbxIdEmpresa;
        private System.Windows.Forms.Label label9;
    }
}