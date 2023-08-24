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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDiaNombre = new System.Windows.Forms.Label();
            this.lblDiaNumero = new System.Windows.Forms.Label();
            this.lblPresencia = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
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
            this.linkVerMas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVerMas_LinkClicked);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(369, 29);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(104, 32);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "Cliente";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(369, 71);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(75, 32);
            this.lblHora.TabIndex = 15;
            this.lblHora.Text = "Hora";
            // 
            // lblDiaNombre
            // 
            this.lblDiaNombre.AutoSize = true;
            this.lblDiaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaNombre.Location = new System.Drawing.Point(182, 29);
            this.lblDiaNombre.Name = "lblDiaNombre";
            this.lblDiaNombre.Size = new System.Drawing.Size(157, 32);
            this.lblDiaNombre.TabIndex = 13;
            this.lblDiaNombre.Text = "DiaNombre";
            // 
            // lblDiaNumero
            // 
            this.lblDiaNumero.AutoSize = true;
            this.lblDiaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaNumero.Location = new System.Drawing.Point(182, 71);
            this.lblDiaNumero.Name = "lblDiaNumero";
            this.lblDiaNumero.Size = new System.Drawing.Size(157, 32);
            this.lblDiaNumero.TabIndex = 14;
            this.lblDiaNumero.Text = "DiaNumero";
            // 
            // lblPresencia
            // 
            this.lblPresencia.AutoSize = true;
            this.lblPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresencia.Location = new System.Drawing.Point(182, 121);
            this.lblPresencia.Name = "lblPresencia";
            this.lblPresencia.Size = new System.Drawing.Size(141, 32);
            this.lblPresencia.TabIndex = 17;
            this.lblPresencia.Text = "Presencia";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.Location = new System.Drawing.Point(182, 166);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(72, 32);
            this.lblPlan.TabIndex = 18;
            this.lblPlan.Text = "Plan";
            // 
            // ProveedorTurnoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.lblPresencia);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblDiaNombre);
            this.Controls.Add(this.lblDiaNumero);
            this.Controls.Add(this.linkVerMas);
            this.Name = "ProveedorTurnoItem";
            this.Size = new System.Drawing.Size(691, 224);
            this.Load += new System.EventHandler(this.ProveedorTurnoItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkVerMas;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDiaNombre;
        private System.Windows.Forms.Label lblDiaNumero;
        private System.Windows.Forms.Label lblPresencia;
        private System.Windows.Forms.Label lblPlan;
    }
}
