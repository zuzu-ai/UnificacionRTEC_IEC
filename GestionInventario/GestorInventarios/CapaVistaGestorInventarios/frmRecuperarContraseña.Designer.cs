
namespace CapaVistaGestorInventarios
{
	partial class frmRecuperarContraseña
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarContraseña));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.navegadorMantenimientos1 = new CapaVistaNavegador.NavegadorMantenimientos();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.txtIDPregunta = new System.Windows.Forms.TextBox();
            this.mtxtContraseña = new System.Windows.Forms.MaskedTextBox();
            this.mtxtConfirmarContraseña = new System.Windows.Forms.MaskedTextBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnPasswordn = new System.Windows.Forms.Button();
            this.cbxPregunta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tltNombre = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(146, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(268, 20);
            this.txtUsuario.TabIndex = 150;
            this.txtUsuario.Tag = "usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 167;
            this.label2.Text = "Nombre de usuario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(249, 175);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 157;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(169, 175);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(50, 50);
            this.btnAceptar.TabIndex = 156;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // navegadorMantenimientos1
            // 
            this.navegadorMantenimientos1.BackColor = System.Drawing.Color.Transparent;
            this.navegadorMantenimientos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navegadorMantenimientos1.Location = new System.Drawing.Point(22, -50);
            this.navegadorMantenimientos1.Name = "navegadorMantenimientos1";
            this.navegadorMantenimientos1.Size = new System.Drawing.Size(658, 49);
            this.navegadorMantenimientos1.TabIndex = 166;
            this.navegadorMantenimientos1.Visible = false;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(146, 84);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(268, 20);
            this.txtRespuesta.TabIndex = 152;
            this.txtRespuesta.Tag = "repuesta";
            // 
            // txtIDPregunta
            // 
            this.txtIDPregunta.Location = new System.Drawing.Point(145, 58);
            this.txtIDPregunta.Name = "txtIDPregunta";
            this.txtIDPregunta.Size = new System.Drawing.Size(268, 20);
            this.txtIDPregunta.TabIndex = 163;
            this.txtIDPregunta.TabStop = false;
            this.txtIDPregunta.Tag = "fkpregunta";
            this.txtIDPregunta.Visible = false;
            // 
            // mtxtContraseña
            // 
            this.mtxtContraseña.Location = new System.Drawing.Point(146, 113);
            this.mtxtContraseña.Name = "mtxtContraseña";
            this.mtxtContraseña.Size = new System.Drawing.Size(268, 20);
            this.mtxtContraseña.TabIndex = 154;
            this.mtxtContraseña.Tag = "";
            this.mtxtContraseña.UseSystemPasswordChar = true;
            // 
            // mtxtConfirmarContraseña
            // 
            this.mtxtConfirmarContraseña.Location = new System.Drawing.Point(146, 139);
            this.mtxtConfirmarContraseña.Name = "mtxtConfirmarContraseña";
            this.mtxtConfirmarContraseña.Size = new System.Drawing.Size(268, 20);
            this.mtxtConfirmarContraseña.TabIndex = 155;
            this.mtxtConfirmarContraseña.Tag = "";
            this.mtxtConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPassword.BackgroundImage")));
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Location = new System.Drawing.Point(417, 113);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(19, 19);
            this.btnPassword.TabIndex = 165;
            this.btnPassword.TabStop = false;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnPasswordn
            // 
            this.btnPasswordn.BackColor = System.Drawing.Color.Transparent;
            this.btnPasswordn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasswordn.BackgroundImage")));
            this.btnPasswordn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasswordn.FlatAppearance.BorderSize = 0;
            this.btnPasswordn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordn.Location = new System.Drawing.Point(417, 113);
            this.btnPasswordn.Name = "btnPasswordn";
            this.btnPasswordn.Size = new System.Drawing.Size(19, 19);
            this.btnPasswordn.TabIndex = 164;
            this.btnPasswordn.TabStop = false;
            this.btnPasswordn.UseVisualStyleBackColor = false;
            this.btnPasswordn.Visible = false;
            this.btnPasswordn.Click += new System.EventHandler(this.btnPasswordn_Click);
            // 
            // cbxPregunta
            // 
            this.cbxPregunta.FormattingEnabled = true;
            this.cbxPregunta.Location = new System.Drawing.Point(145, 57);
            this.cbxPregunta.Name = "cbxPregunta";
            this.cbxPregunta.Size = new System.Drawing.Size(268, 21);
            this.cbxPregunta.TabIndex = 151;
            this.cbxPregunta.SelectedIndexChanged += new System.EventHandler(this.cbxPregunta_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(9, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 162;
            this.label4.Text = "Pregunta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(10, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 158;
            this.label6.Text = "Confirmar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(10, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 159;
            this.label10.Text = "Conrtraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(10, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 160;
            this.label5.Text = "Conrtraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(9, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 161;
            this.label7.Text = "Respuesta:";
            // 
            // frmRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 245);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.navegadorMantenimientos1);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.txtIDPregunta);
            this.Controls.Add(this.mtxtContraseña);
            this.Controls.Add(this.mtxtConfirmarContraseña);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnPasswordn);
            this.Controls.Add(this.cbxPregunta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Contraseña";
            this.Leave += new System.EventHandler(this.mtxtConfirmarContraseña_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private CapaVistaNavegador.NavegadorMantenimientos navegadorMantenimientos1;
		private System.Windows.Forms.TextBox txtRespuesta;
		private System.Windows.Forms.TextBox txtIDPregunta;
		private System.Windows.Forms.MaskedTextBox mtxtContraseña;
		private System.Windows.Forms.MaskedTextBox mtxtConfirmarContraseña;
		private System.Windows.Forms.Button btnPassword;
		private System.Windows.Forms.Button btnPasswordn;
		private System.Windows.Forms.ComboBox cbxPregunta;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ToolTip tltNombre;
	}
}