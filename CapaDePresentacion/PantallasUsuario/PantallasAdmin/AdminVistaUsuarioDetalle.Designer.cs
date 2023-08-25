namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    partial class AdminVistaUsuarioDetalle
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFechaCategoria = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRolCategoria = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboFin = new System.Windows.Forms.ComboBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.comboInicio = new System.Windows.Forms.ComboBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 37);
            this.label5.TabIndex = 22;
            this.label5.Text = "Detalle del usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.lblClave);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtSegundoNombre);
            this.panel1.Controls.Add(this.txtPrimerNombre);
            this.panel1.Controls.Add(this.lblSegundoNombre);
            this.panel1.Controls.Add(this.lblPrimerNombre);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblFechaCategoria);
            this.panel1.Controls.Add(this.comboRol);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblRolCategoria);
            this.panel1.Location = new System.Drawing.Point(35, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 381);
            this.panel1.TabIndex = 21;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(139, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(112, 32);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblFechaCategoria
            // 
            this.lblFechaCategoria.AutoSize = true;
            this.lblFechaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCategoria.Location = new System.Drawing.Point(94, 24);
            this.lblFechaCategoria.Name = "lblFechaCategoria";
            this.lblFechaCategoria.Size = new System.Drawing.Size(0, 32);
            this.lblFechaCategoria.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(155, 253);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 32);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblRolCategoria
            // 
            this.lblRolCategoria.AutoSize = true;
            this.lblRolCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolCategoria.Location = new System.Drawing.Point(173, 317);
            this.lblRolCategoria.Name = "lblRolCategoria";
            this.lblRolCategoria.Size = new System.Drawing.Size(57, 32);
            this.lblRolCategoria.TabIndex = 7;
            this.lblRolCategoria.Text = "Rol";
            // 
            // comboRol
            // 
            this.comboRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(262, 314);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(294, 40);
            this.comboRol.TabIndex = 17;
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.comboRol_SelectedIndexChanged);
            this.comboRol.SelectedValueChanged += new System.EventHandler(this.comboRol_SelectedValueChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(612, 598);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 78);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibilidad.Location = new System.Drawing.Point(37, 479);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(195, 32);
            this.lblDisponibilidad.TabIndex = 28;
            this.lblDisponibilidad.Text = "Disponibilidad";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboFin);
            this.panel2.Controls.Add(this.lblFin);
            this.panel2.Controls.Add(this.comboInicio);
            this.panel2.Controls.Add(this.lblInicio);
            this.panel2.Location = new System.Drawing.Point(34, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 68);
            this.panel2.TabIndex = 27;
            // 
            // comboFin
            // 
            this.comboFin.Enabled = false;
            this.comboFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFin.FormattingEnabled = true;
            this.comboFin.Location = new System.Drawing.Point(538, 13);
            this.comboFin.Name = "comboFin";
            this.comboFin.Size = new System.Drawing.Size(162, 40);
            this.comboFin.TabIndex = 29;
            this.comboFin.SelectedIndexChanged += new System.EventHandler(this.comboFin_SelectedIndexChanged);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(427, 13);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(54, 32);
            this.lblFin.TabIndex = 28;
            this.lblFin.Text = "Fin";
            // 
            // comboInicio
            // 
            this.comboInicio.Enabled = false;
            this.comboInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboInicio.FormattingEnabled = true;
            this.comboInicio.Location = new System.Drawing.Point(131, 13);
            this.comboInicio.Name = "comboInicio";
            this.comboInicio.Size = new System.Drawing.Size(162, 40);
            this.comboInicio.TabIndex = 27;
            this.comboInicio.SelectedValueChanged += new System.EventHandler(this.comboInicio_SelectedValueChanged);
            this.comboInicio.Click += new System.EventHandler(this.comboInicio_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(20, 13);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(81, 32);
            this.lblInicio.TabIndex = 25;
            this.lblInicio.Text = "Inicio";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(262, 17);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(294, 39);
            this.txtUsuario.TabIndex = 17;
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(51, 133);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(200, 32);
            this.lblPrimerNombre.TabIndex = 18;
            this.lblPrimerNombre.Text = "Primer nombre";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(19, 193);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(232, 32);
            this.lblSegundoNombre.TabIndex = 19;
            this.lblSegundoNombre.Text = "Segundo nombre";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(262, 133);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(294, 39);
            this.txtPrimerNombre.TabIndex = 20;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.Location = new System.Drawing.Point(262, 193);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(294, 39);
            this.txtSegundoNombre.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(262, 250);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 39);
            this.txtEmail.TabIndex = 22;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(262, 74);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(294, 39);
            this.txtClave.TabIndex = 24;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(155, 74);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(87, 32);
            this.lblClave.TabIndex = 23;
            this.lblClave.Text = "Clave";
            // 
            // AdminVistaUsuarioDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 683);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "AdminVistaUsuarioDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminVistaUsuarioDetalle";
            this.Load += new System.EventHandler(this.AdminVistaUsuarioDetalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFechaCategoria;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRolCategoria;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboFin;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.ComboBox comboInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
    }
}