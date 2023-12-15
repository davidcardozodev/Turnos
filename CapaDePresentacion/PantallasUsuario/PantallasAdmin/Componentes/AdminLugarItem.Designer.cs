namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes
{
    partial class AdminLugarItem
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(39, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 32);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.AdminLugarItem_Click);
            this.lblNombre.MouseEnter += new System.EventHandler(this.lblNombre_MouseEnter);
            this.lblNombre.MouseLeave += new System.EventHandler(this.lblNombre_MouseLeave);
            // 
            // AdminLugarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNombre);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "AdminLugarItem";
            this.Size = new System.Drawing.Size(388, 100);
            this.Load += new System.EventHandler(this.AdminLugarItem_Load);
            this.Click += new System.EventHandler(this.AdminLugarItem_Click);
            this.MouseEnter += new System.EventHandler(this.lblNombre_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.lblNombre_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
    }
}
