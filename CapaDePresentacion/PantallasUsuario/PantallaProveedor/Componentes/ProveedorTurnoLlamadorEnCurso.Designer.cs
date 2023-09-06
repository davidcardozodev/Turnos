namespace CapaDePresentacion.PantallasUsuario.PantallaProveedor.Componentes
{
    partial class ProveedorTurnoLlamadorEnCurso
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(116, 44);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(162, 32);
            this.lblInformacion.TabIndex = 6;
            this.lblInformacion.Text = "Informacion";
            this.lblInformacion.MouseEnter += new System.EventHandler(this.ProveedorTurnoLlamadorEnCurso_MouseEnter);
            this.lblInformacion.MouseLeave += new System.EventHandler(this.ProveedorTurnoLlamadorEnCurso_MouseLeave);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(23, 34);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(64, 52);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "-";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            this.btnFinalizar.MouseEnter += new System.EventHandler(this.ProveedorTurnoLlamadorEnCurso_MouseEnter);
            this.btnFinalizar.MouseLeave += new System.EventHandler(this.ProveedorTurnoLlamadorEnCurso_MouseLeave);
            // 
            // ProveedorTurnoLlamadorEnCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblInformacion);
            this.Name = "ProveedorTurnoLlamadorEnCurso";
            this.Size = new System.Drawing.Size(647, 120);
            this.Load += new System.EventHandler(this.ProveedorTurnoLlamadorEnCurso_Load);
            this.MouseEnter += new System.EventHandler(this.ProveedorTurnoLlamadorEnCurso_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ProveedorTurnoLlamadorEnCurso_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnFinalizar;
    }
}
