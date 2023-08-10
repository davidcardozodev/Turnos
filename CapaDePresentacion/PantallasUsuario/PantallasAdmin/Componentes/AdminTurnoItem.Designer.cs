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
            this.lblDiaNombre = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkVerMas
            // 
            this.linkVerMas.AutoSize = true;
            this.linkVerMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkVerMas.Location = new System.Drawing.Point(30, 69);
            this.linkVerMas.Name = "linkVerMas";
            this.linkVerMas.Size = new System.Drawing.Size(118, 32);
            this.linkVerMas.TabIndex = 9;
            this.linkVerMas.TabStop = true;
            this.linkVerMas.Text = "Ver mas";
            this.linkVerMas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVerMas_LinkClicked);
            // 
            // lblDiaNombre
            // 
            this.lblDiaNombre.AutoSize = true;
            this.lblDiaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaNombre.Location = new System.Drawing.Point(187, 40);
            this.lblDiaNombre.Name = "lblDiaNombre";
            this.lblDiaNombre.Size = new System.Drawing.Size(157, 32);
            this.lblDiaNombre.TabIndex = 10;
            this.lblDiaNombre.Text = "DiaNombre";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(481, 40);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 32);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(187, 94);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(75, 32);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "Hora";
            // 
            // AdminTurnoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDiaNombre);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.linkVerMas);
            this.Name = "AdminTurnoItem";
            this.Size = new System.Drawing.Size(675, 182);
            this.Load += new System.EventHandler(this.AdminTurnoItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkVerMas;
        private System.Windows.Forms.Label lblDiaNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblHora;
    }
}
