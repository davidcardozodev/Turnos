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
            this.btnTurnosClientes = new System.Windows.Forms.Button();
            this.btnListaUsuarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListaUsuarios);
            this.panel1.Controls.Add(this.btnTurnosClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
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
            // AdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}