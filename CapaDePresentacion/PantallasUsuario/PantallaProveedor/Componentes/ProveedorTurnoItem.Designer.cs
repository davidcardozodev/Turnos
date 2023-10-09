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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPresencia = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblTipoPlan = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(315, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 32);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.MouseEnter += new System.EventHandler(this.ProveedorTurnoItem_MouseEnter);
            this.lblNombre.MouseLeave += new System.EventHandler(this.ProveedorTurnoItem_MouseLeave);
            // 
            // lblPresencia
            // 
            this.lblPresencia.AutoSize = true;
            this.lblPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresencia.Location = new System.Drawing.Point(23, 34);
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
            this.btnAsignar.Location = new System.Drawing.Point(1345, 22);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(142, 57);
            this.btnAsignar.TabIndex = 21;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            this.btnAsignar.MouseEnter += new System.EventHandler(this.ProveedorTurnoItem_MouseEnter);
            this.btnAsignar.MouseLeave += new System.EventHandler(this.ProveedorTurnoItem_MouseLeave);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(604, 34);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(75, 32);
            this.lblHora.TabIndex = 22;
            this.lblHora.Text = "Hora";
            // 
            // lblTipoPlan
            // 
            this.lblTipoPlan.AutoSize = true;
            this.lblTipoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlan.Location = new System.Drawing.Point(868, 34);
            this.lblTipoPlan.Name = "lblTipoPlan";
            this.lblTipoPlan.Size = new System.Drawing.Size(128, 32);
            this.lblTipoPlan.TabIndex = 23;
            this.lblTipoPlan.Text = "TipoPlan";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(1132, 34);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(129, 32);
            this.lblPrioridad.TabIndex = 24;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // ProveedorTurnoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblTipoPlan);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lblPresencia);
            this.Controls.Add(this.lblNombre);
            this.Name = "ProveedorTurnoItem";
            this.Size = new System.Drawing.Size(1521, 98);
            this.Load += new System.EventHandler(this.ProveedorTurnoItem_Load);
            this.MouseEnter += new System.EventHandler(this.ProveedorTurnoItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ProveedorTurnoItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPresencia;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblTipoPlan;
        private System.Windows.Forms.Label lblPrioridad;
    }
}
