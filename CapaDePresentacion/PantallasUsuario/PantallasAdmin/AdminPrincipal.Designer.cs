namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    partial class AdminPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAsociarEstablecimientosAreas = new System.Windows.Forms.Button();
            this.btnAdministrarLugares = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnListaUsuarios = new System.Windows.Forms.Button();
            this.btnTurnosClientes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAsociarEstablecimientosAreas);
            this.panel1.Controls.Add(this.btnAdministrarLugares);
            this.panel1.Controls.Add(this.btnAgregarUsuario);
            this.panel1.Controls.Add(this.btnListaUsuarios);
            this.panel1.Controls.Add(this.btnTurnosClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 450);
            this.panel1.TabIndex = 1;
            // 
            // btnAsociarEstablecimientosAreas
            // 
            this.btnAsociarEstablecimientosAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociarEstablecimientosAreas.Location = new System.Drawing.Point(411, 300);
            this.btnAsociarEstablecimientosAreas.Name = "btnAsociarEstablecimientosAreas";
            this.btnAsociarEstablecimientosAreas.Size = new System.Drawing.Size(507, 111);
            this.btnAsociarEstablecimientosAreas.TabIndex = 4;
            this.btnAsociarEstablecimientosAreas.Text = "Asociar establecimientos y areas";
            this.btnAsociarEstablecimientosAreas.UseVisualStyleBackColor = true;
            this.btnAsociarEstablecimientosAreas.Click += new System.EventHandler(this.btnAsociarEstablecimientosAreas_Click);
            // 
            // btnAdministrarLugares
            // 
            this.btnAdministrarLugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarLugares.Location = new System.Drawing.Point(50, 300);
            this.btnAdministrarLugares.Name = "btnAdministrarLugares";
            this.btnAdministrarLugares.Size = new System.Drawing.Size(310, 111);
            this.btnAdministrarLugares.TabIndex = 3;
            this.btnAdministrarLugares.Text = "Administrar lugares";
            this.btnAdministrarLugares.UseVisualStyleBackColor = true;
            this.btnAdministrarLugares.Click += new System.EventHandler(this.btnAdministrarLugares_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(784, 138);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(310, 111);
            this.btnAgregarUsuario.TabIndex = 2;
            this.btnAgregarUsuario.Text = "Agregar nuevo usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnListaUsuarios
            // 
            this.btnListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaUsuarios.Location = new System.Drawing.Point(411, 138);
            this.btnListaUsuarios.Name = "btnListaUsuarios";
            this.btnListaUsuarios.Size = new System.Drawing.Size(310, 111);
            this.btnListaUsuarios.TabIndex = 1;
            this.btnListaUsuarios.Text = "Lista de usuarios";
            this.btnListaUsuarios.UseVisualStyleBackColor = true;
            this.btnListaUsuarios.Click += new System.EventHandler(this.btnListaUsuarios_Click);
            // 
            // btnTurnosClientes
            // 
            this.btnTurnosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnosClientes.Location = new System.Drawing.Point(50, 138);
            this.btnTurnosClientes.Name = "btnTurnosClientes";
            this.btnTurnosClientes.Size = new System.Drawing.Size(310, 111);
            this.btnTurnosClientes.TabIndex = 0;
            this.btnTurnosClientes.Text = "Turnos de los clientes";
            this.btnTurnosClientes.UseVisualStyleBackColor = true;
            this.btnTurnosClientes.Click += new System.EventHandler(this.btnTurnosClientes_Click);
            // 
            // AdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPrincipal";
            this.Text = "AdminPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTurnosClientes;
        private System.Windows.Forms.Button btnListaUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnAdministrarLugares;
        private System.Windows.Forms.Button btnAsociarEstablecimientosAreas;
    }
}