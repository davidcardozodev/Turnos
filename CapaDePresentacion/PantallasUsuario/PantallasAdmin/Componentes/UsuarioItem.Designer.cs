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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkModificar
            // 
            this.linkModificar.AutoSize = true;
            this.linkModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkModificar.Location = new System.Drawing.Point(24, 29);
            this.linkModificar.Name = "linkModificar";
            this.linkModificar.Size = new System.Drawing.Size(130, 32);
            this.linkModificar.TabIndex = 6;
            this.linkModificar.TabStop = true;
            this.linkModificar.Text = "Modificar";
            this.linkModificar.Click += new System.EventHandler(this.UsuarioItem_Click);
            this.linkModificar.MouseEnter += new System.EventHandler(this.UsuarioItem_MouseEnter);
            this.linkModificar.MouseLeave += new System.EventHandler(this.UsuarioItem_MouseLeave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(316, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(112, 32);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.UsuarioItem_Click);
            this.lblUsuario.MouseEnter += new System.EventHandler(this.UsuarioItem_MouseEnter);
            this.lblUsuario.MouseLeave += new System.EventHandler(this.UsuarioItem_MouseLeave);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(639, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 32);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.UsuarioItem_Click);
            this.lblNombre.MouseEnter += new System.EventHandler(this.UsuarioItem_MouseEnter);
            this.lblNombre.MouseLeave += new System.EventHandler(this.UsuarioItem_MouseLeave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(969, 29);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 32);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.UsuarioItem_Click);
            this.lblEmail.MouseEnter += new System.EventHandler(this.UsuarioItem_MouseEnter);
            this.lblEmail.MouseLeave += new System.EventHandler(this.UsuarioItem_MouseLeave);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(1351, 29);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(57, 32);
            this.lblRol.TabIndex = 10;
            this.lblRol.Text = "Rol";
            this.lblRol.Click += new System.EventHandler(this.UsuarioItem_Click);
            this.lblRol.MouseEnter += new System.EventHandler(this.UsuarioItem_MouseEnter);
            this.lblRol.MouseLeave += new System.EventHandler(this.UsuarioItem_MouseLeave);
            // 
            // UsuarioItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.linkModificar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UsuarioItem";
            this.Size = new System.Drawing.Size(1543, 76);
            this.Load += new System.EventHandler(this.UsuarioItem_Load);
            this.Click += new System.EventHandler(this.UsuarioItem_Click);
            this.MouseEnter += new System.EventHandler(this.UsuarioItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UsuarioItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkModificar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRol;
    }
}
