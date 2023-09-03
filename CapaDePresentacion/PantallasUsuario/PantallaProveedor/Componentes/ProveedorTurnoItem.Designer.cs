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
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblPresencia = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(359, 22);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(162, 32);
            this.lblInformacion.TabIndex = 19;
            this.lblInformacion.Text = "Informacion";
            this.lblInformacion.MouseEnter += new System.EventHandler(this.ProveedorTurnoItem_MouseEnter);
            this.lblInformacion.MouseLeave += new System.EventHandler(this.ProveedorTurnoItem_MouseLeave);
            // 
            // lblPresencia
            // 
            this.lblPresencia.AutoSize = true;
            this.lblPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresencia.Location = new System.Drawing.Point(228, 22);
            this.lblPresencia.Name = "lblPresencia";
            this.lblPresencia.Size = new System.Drawing.Size(141, 32);
            this.lblPresencia.TabIndex = 20;
            this.lblPresencia.Text = "Presencia";
            this.lblPresencia.MouseEnter += new System.EventHandler(this.ProveedorTurnoItem_MouseEnter);
            this.lblPresencia.MouseLeave += new System.EventHandler(this.ProveedorTurnoItem_MouseLeave);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Enabled = false;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(35, 5);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(142, 57);
            this.btnAsignar.TabIndex = 21;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            this.btnAsignar.MouseEnter += new System.EventHandler(this.ProveedorTurnoItem_MouseEnter);
            this.btnAsignar.MouseLeave += new System.EventHandler(this.ProveedorTurnoItem_MouseLeave);
            // 
            // ProveedorTurnoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lblPresencia);
            this.Controls.Add(this.lblInformacion);
            this.Name = "ProveedorTurnoItem";
            this.Size = new System.Drawing.Size(857, 69);
            this.Load += new System.EventHandler(this.ProveedorTurnoItem_Load);
            this.MouseEnter += new System.EventHandler(this.ProveedorTurnoItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ProveedorTurnoItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblPresencia;
        private System.Windows.Forms.Button btnAsignar;
    }
}
