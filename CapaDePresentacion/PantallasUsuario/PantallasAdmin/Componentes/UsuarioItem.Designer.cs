namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes
{
    partial class UsuarioItem
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
            this.linkModificar = new System.Windows.Forms.LinkLabel();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkModificar
            // 
            this.linkModificar.AutoSize = true;
            this.linkModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkModificar.Location = new System.Drawing.Point(24, 29);
            this.linkModificar.Name = "linkModificar";
            this.linkModificar.Size = new System.Drawing.Size(130, 32);
            this.linkModificar.TabIndex = 6;
            this.linkModificar.TabStop = true;
            this.linkModificar.Text = "Modificar";
            this.linkModificar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkModificar_LinkClicked);
            this.linkModificar.MouseEnter += new System.EventHandler(this.UsuarioItem_MouseEnter);
            this.linkModificar.MouseLeave += new System.EventHandler(this.UsuarioItem_MouseLeave);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(187, 29);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(162, 32);
            this.lblInformacion.TabIndex = 7;
            this.lblInformacion.Text = "Informacion";
            this.lblInformacion.MouseEnter += new System.EventHandler(this.UsuarioItem_MouseEnter);
            this.lblInformacion.MouseLeave += new System.EventHandler(this.UsuarioItem_MouseLeave);
            // 
            // UsuarioItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.linkModificar);
            this.Name = "UsuarioItem";
            this.Size = new System.Drawing.Size(1055, 76);
            this.Load += new System.EventHandler(this.UsuarioItem_Load);
            this.MouseEnter += new System.EventHandler(this.UsuarioItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UsuarioItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkModificar;
        private System.Windows.Forms.Label lblInformacion;
    }
}
