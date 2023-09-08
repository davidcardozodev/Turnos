namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor
{
    partial class ProveedorPrincipal
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
            this.btnLlamador = new System.Windows.Forms.Button();
            this.btnTurnosClientes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLlamador);
            this.panel1.Controls.Add(this.btnTurnosClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 699);
            this.panel1.TabIndex = 2;
            // 
            // btnLlamador
            // 
            this.btnLlamador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamador.Location = new System.Drawing.Point(733, 278);
            this.btnLlamador.Name = "btnLlamador";
            this.btnLlamador.Size = new System.Drawing.Size(310, 111);
            this.btnLlamador.TabIndex = 3;
            this.btnLlamador.Text = "Llamador";
            this.btnLlamador.UseVisualStyleBackColor = true;
            this.btnLlamador.Click += new System.EventHandler(this.btnLlamador_Click);
            // 
            // btnTurnosClientes
            // 
            this.btnTurnosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnosClientes.Location = new System.Drawing.Point(378, 278);
            this.btnTurnosClientes.Name = "btnTurnosClientes";
            this.btnTurnosClientes.Size = new System.Drawing.Size(310, 111);
            this.btnTurnosClientes.TabIndex = 2;
            this.btnTurnosClientes.Text = "Turnos de los clientes";
            this.btnTurnosClientes.UseVisualStyleBackColor = true;
            this.btnTurnosClientes.Click += new System.EventHandler(this.btnTurnosClientes_Click);
            // 
            // ProveedorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 699);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProveedorPrincipal";
            this.Text = "ProveedorPrincipal";
            this.Load += new System.EventHandler(this.ProveedorPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTurnosClientes;
        private System.Windows.Forms.Button btnLlamador;
    }
}