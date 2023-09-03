namespace CapaDePresentacion.PantallasUsuario.PantallasCliente.Componentes
{
    partial class ClienteTurnoItemModificacion
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
            this.linkTurnoOriginal = new System.Windows.Forms.LinkLabel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(390, 33);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(162, 32);
            this.lblInformacion.TabIndex = 0;
            this.lblInformacion.Text = "Informacion";
            this.lblInformacion.MouseEnter += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseEnter);
            this.lblInformacion.MouseLeave += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseLeave);
            // 
            // linkTurnoOriginal
            // 
            this.linkTurnoOriginal.AutoSize = true;
            this.linkTurnoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTurnoOriginal.Location = new System.Drawing.Point(13, 28);
            this.linkTurnoOriginal.Name = "linkTurnoOriginal";
            this.linkTurnoOriginal.Size = new System.Drawing.Size(189, 32);
            this.linkTurnoOriginal.TabIndex = 1;
            this.linkTurnoOriginal.TabStop = true;
            this.linkTurnoOriginal.Text = "Turno original";
            this.linkTurnoOriginal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTurnoOriginal_LinkClicked);
            this.linkTurnoOriginal.MouseEnter += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseEnter);
            this.linkTurnoOriginal.MouseLeave += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseLeave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(1061, 22);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 47);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseEnter += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseEnter);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseLeave);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.Location = new System.Drawing.Point(1189, 22);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(138, 47);
            this.btnRechazar.TabIndex = 3;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            this.btnRechazar.MouseEnter += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseEnter);
            this.btnRechazar.MouseLeave += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseLeave);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(222, 33);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 32);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            this.lblEstado.MouseEnter += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseEnter);
            this.lblEstado.MouseLeave += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseLeave);
            // 
            // ClienteTurnoItemModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.linkTurnoOriginal);
            this.Controls.Add(this.lblInformacion);
            this.Name = "ClienteTurnoItemModificacion";
            this.Size = new System.Drawing.Size(1341, 90);
            this.Load += new System.EventHandler(this.ClienteTurnoItemModificacion_Load);
            this.MouseEnter += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ClienteTurnoItemModificacion_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.LinkLabel linkTurnoOriginal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Label lblEstado;
    }
}
