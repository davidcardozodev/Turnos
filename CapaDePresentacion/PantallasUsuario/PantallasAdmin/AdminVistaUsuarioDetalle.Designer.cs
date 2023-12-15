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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.comboPlan = new System.Windows.Forms.ComboBox();
            this.lblTipoPlan = new System.Windows.Forms.Label();
            this.comboFin = new System.Windows.Forms.ComboBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.comboInicio = new System.Windows.Forms.ComboBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFechaCategoria = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRolCategoria = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 37);
            this.label5.TabIndex = 22;
            this.label5.Text = "Detalle del usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.comboPlan);
            this.panel1.Controls.Add(this.lblTipoPlan);
            this.panel1.Controls.Add(this.comboFin);
            this.panel1.Controls.Add(this.lblFin);
            this.panel1.Controls.Add(this.comboInicio);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.lblClave);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblFechaCategoria);
            this.panel1.Controls.Add(this.comboRol);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblRolCategoria);
            this.panel1.Location = new System.Drawing.Point(7, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 404);
            this.panel1.TabIndex = 21;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(667, 310);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(294, 61);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // comboPlan
            // 
            this.comboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPlan.FormattingEnabled = true;
            this.comboPlan.Location = new System.Drawing.Point(667, 25);
            this.comboPlan.Name = "comboPlan";
            this.comboPlan.Size = new System.Drawing.Size(294, 40);
            this.comboPlan.TabIndex = 31;
            // 
            // lblTipoPlan
            // 
            this.lblTipoPlan.AutoSize = true;
            this.lblTipoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlan.Location = new System.Drawing.Point(581, 25);
            this.lblTipoPlan.Name = "lblTipoPlan";
            this.lblTipoPlan.Size = new System.Drawing.Size(72, 32);
            this.lblTipoPlan.TabIndex = 30;
            this.lblTipoPlan.Text = "Plan";
            // 
            // comboFin
            // 
            this.comboFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFin.FormattingEnabled = true;
            this.comboFin.Location = new System.Drawing.Point(667, 218);
            this.comboFin.Name = "comboFin";
            this.comboFin.Size = new System.Drawing.Size(294, 40);
            this.comboFin.TabIndex = 29;
            this.comboFin.Visible = false;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(587, 218);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(54, 32);
            this.lblFin.TabIndex = 28;
            this.lblFin.Text = "Fin";
            this.lblFin.Visible = false;
            // 
            // comboInicio
            // 
            this.comboInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboInicio.FormattingEnabled = true;
            this.comboInicio.Location = new System.Drawing.Point(667, 155);
            this.comboInicio.Name = "comboInicio";
            this.comboInicio.Size = new System.Drawing.Size(294, 40);
            this.comboInicio.TabIndex = 27;
            this.comboInicio.Visible = false;
            this.comboInicio.SelectedValueChanged += new System.EventHandler(this.comboInicio_SelectedValueChanged);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(560, 162);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(81, 32);
            this.lblInicio.TabIndex = 25;
            this.lblInicio.Text = "Inicio";
            this.lblInicio.Visible = false;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(242, 146);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(294, 39);
            this.txtClave.TabIndex = 24;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(135, 145);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(87, 32);
            this.lblClave.TabIndex = 23;
            this.lblClave.Text = "Clave";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(242, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 39);
            this.txtEmail.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(242, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(294, 39);
            this.txtNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(108, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 32);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(242, 24);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(294, 39);
            this.txtUsuario.TabIndex = 17;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(119, 25);
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
            // comboRol
            // 
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(667, 88);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(294, 40);
            this.comboRol.TabIndex = 17;
            this.comboRol.SelectedValueChanged += new System.EventHandler(this.comboRol_SelectedValueChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(135, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 32);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblRolCategoria
            // 
            this.lblRolCategoria.AutoSize = true;
            this.lblRolCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolCategoria.Location = new System.Drawing.Point(596, 91);
            this.lblRolCategoria.Name = "lblRolCategoria";
            this.lblRolCategoria.Size = new System.Drawing.Size(57, 32);
            this.lblRolCategoria.TabIndex = 7;
            this.lblRolCategoria.Text = "Rol";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(347, 310);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(294, 61);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // AdminVistaUsuarioDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "AdminVistaUsuarioDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminVistaUsuarioDetalle";
            this.Load += new System.EventHandler(this.AdminVistaUsuarioDetalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboFin;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.ComboBox comboInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.ComboBox comboPlan;
        private System.Windows.Forms.Label lblTipoPlan;
        private System.Windows.Forms.Button btnEliminar;
    }
}