namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes
{
    partial class ProveedorTurnoItem
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkVerMas = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDiaNombre = new System.Windows.Forms.Label();
            this.lblDiaNumero = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkVerMas
            // 
            this.linkVerMas.AutoSize = true;
            this.linkVerMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkVerMas.Location = new System.Drawing.Point(14, 71);
            this.linkVerMas.Name = "linkVerMas";
            this.linkVerMas.Size = new System.Drawing.Size(118, 32);
            this.linkVerMas.TabIndex = 12;
            this.linkVerMas.TabStop = true;
            this.linkVerMas.Text = "Ver mas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Location = new System.Drawing.Point(373, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 140);
            this.panel2.TabIndex = 11;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(23, 76);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(104, 32);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(23, 16);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(75, 32);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.lblDiaNombre);
            this.panel1.Controls.Add(this.lblDiaNumero);
            this.panel1.Location = new System.Drawing.Point(155, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 140);
            this.panel1.TabIndex = 10;
            // 
            // lblDiaNombre
            // 
            this.lblDiaNombre.AutoSize = true;
            this.lblDiaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaNombre.Location = new System.Drawing.Point(20, 17);
            this.lblDiaNombre.Name = "lblDiaNombre";
            this.lblDiaNombre.Size = new System.Drawing.Size(157, 32);
            this.lblDiaNombre.TabIndex = 0;
            this.lblDiaNombre.Text = "DiaNombre";
            // 
            // lblDiaNumero
            // 
            this.lblDiaNumero.AutoSize = true;
            this.lblDiaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaNumero.Location = new System.Drawing.Point(20, 86);
            this.lblDiaNumero.Name = "lblDiaNumero";
            this.lblDiaNumero.Size = new System.Drawing.Size(157, 32);
            this.lblDiaNumero.TabIndex = 1;
            this.lblDiaNumero.Text = "DiaNumero";
            // 
            // ProveedorTurnoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkVerMas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProveedorTurnoItem";
            this.Size = new System.Drawing.Size(847, 186);
            this.Load += new System.EventHandler(this.ProveedorTurnoItem_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkVerMas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDiaNombre;
        private System.Windows.Forms.Label lblDiaNumero;
    }
}
