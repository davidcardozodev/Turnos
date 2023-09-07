namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes
{
    partial class ProveedorTurnoLlamadorAsignado
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
            this.btnAgregarEnCurso = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarEnCurso
            // 
            this.btnAgregarEnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEnCurso.Location = new System.Drawing.Point(19, 17);
            this.btnAgregarEnCurso.Name = "btnAgregarEnCurso";
            this.btnAgregarEnCurso.Size = new System.Drawing.Size(64, 52);
            this.btnAgregarEnCurso.TabIndex = 8;
            this.btnAgregarEnCurso.Text = "+";
            this.btnAgregarEnCurso.UseVisualStyleBackColor = true;
            this.btnAgregarEnCurso.Click += new System.EventHandler(this.btnAgregarEnCurso_Click);
            this.btnAgregarEnCurso.MouseEnter += new System.EventHandler(this.ProveedorTurnoLlamadorAsignado_MouseEnter);
            this.btnAgregarEnCurso.MouseLeave += new System.EventHandler(this.ProveedorTurnoLlamadorAsignado_MouseLeave);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(100, 27);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(104, 32);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.MouseEnter += new System.EventHandler(this.ProveedorTurnoLlamadorAsignado_MouseEnter);
            this.lblCliente.MouseLeave += new System.EventHandler(this.ProveedorTurnoLlamadorAsignado_MouseLeave);
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(100, 81);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(129, 32);
            this.lblPrioridad.TabIndex = 19;
            this.lblPrioridad.Text = "Prioridad";
            this.lblPrioridad.MouseEnter += new System.EventHandler(this.ProveedorTurnoLlamadorAsignado_MouseEnter);
            this.lblPrioridad.MouseLeave += new System.EventHandler(this.ProveedorTurnoLlamadorAsignado_MouseLeave);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(318, 27);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(87, 32);
            this.lblLugar.TabIndex = 20;
            this.lblLugar.Text = "Lugar";
            // 
            // ProveedorTurnoLlamadorAsignado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(250)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.btnAgregarEnCurso);
            this.Controls.Add(this.lblCliente);
            this.Name = "ProveedorTurnoLlamadorAsignado";
            this.Size = new System.Drawing.Size(663, 129);
            this.Load += new System.EventHandler(this.ProveedorTurnoLlamador_Load);
            this.MouseEnter += new System.EventHandler(this.ProveedorTurnoLlamadorAsignado_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ProveedorTurnoLlamadorAsignado_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEnCurso;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblLugar;
    }
}
