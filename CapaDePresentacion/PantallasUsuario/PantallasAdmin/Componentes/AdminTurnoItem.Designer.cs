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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
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
            this.lblEstado.Location = new System.Drawing.Point(258, 27);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 32);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Click += new System.EventHandler(this.AdminTurnoItem_Click);
            this.lblEstado.MouseEnter += new System.EventHandler(this.AdminTurnoItem_MouseEnter);
            this.lblEstado.MouseLeave += new System.EventHandler(this.AdminTurnoItem_MouseLeave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(534, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(112, 32);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.AdminTurnoItem_Click);
            this.lblUsuario.MouseEnter += new System.EventHandler(this.AdminTurnoItem_MouseEnter);
            this.lblUsuario.MouseLeave += new System.EventHandler(this.AdminTurnoItem_MouseLeave);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(777, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 32);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1292, 27);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(75, 32);
            this.lblHora.TabIndex = 16;
            this.lblHora.Text = "Hora";
            // 
            // AdminTurnoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.linkVerMas);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "AdminTurnoItem";
            this.Size = new System.Drawing.Size(1462, 75);
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
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
    }
}
