namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin.Componentes
{
    partial class AdminTurnoItem
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkVerMas
            // 
            this.linkVerMas.AutoSize = true;
            this.linkVerMas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkVerMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkVerMas.Location = new System.Drawing.Point(19, 27);
            this.linkVerMas.Name = "linkVerMas";
            this.linkVerMas.Size = new System.Drawing.Size(118, 32);
            this.linkVerMas.TabIndex = 9;
            this.linkVerMas.TabStop = true;
            this.linkVerMas.Text = "Ver mas";
            this.linkVerMas.Click += new System.EventHandler(this.AdminTurnoItem_Click);
            this.linkVerMas.MouseEnter += new System.EventHandler(this.AdminTurnoItem_MouseEnter);
            this.linkVerMas.MouseLeave += new System.EventHandler(this.AdminTurnoItem_MouseLeave);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(166, 27);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 32);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Click += new System.EventHandler(this.AdminTurnoItem_Click);
            this.lblEstado.MouseEnter += new System.EventHandler(this.AdminTurnoItem_MouseEnter);
            this.lblEstado.MouseLeave += new System.EventHandler(this.AdminTurnoItem_MouseLeave);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(318, 27);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(162, 32);
            this.lblInformacion.TabIndex = 14;
            this.lblInformacion.Text = "Informacion";
            this.lblInformacion.Click += new System.EventHandler(this.AdminTurnoItem_Click);
            this.lblInformacion.MouseEnter += new System.EventHandler(this.AdminTurnoItem_MouseEnter);
            this.lblInformacion.MouseLeave += new System.EventHandler(this.AdminTurnoItem_MouseLeave);
            // 
            // AdminTurnoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.linkVerMas);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "AdminTurnoItem";
            this.Size = new System.Drawing.Size(1054, 75);
            this.Load += new System.EventHandler(this.AdminTurnoItem_Load);
            this.Click += new System.EventHandler(this.AdminTurnoItem_Click);
            this.MouseEnter += new System.EventHandler(this.AdminTurnoItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.AdminTurnoItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkVerMas;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblInformacion;
    }
}
