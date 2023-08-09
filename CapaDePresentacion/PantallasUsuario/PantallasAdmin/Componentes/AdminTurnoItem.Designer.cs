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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEstado = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDiaNombre = new System.Windows.Forms.Label();
            this.lblDiaNumero = new System.Windows.Forms.Label();
            this.picOpciones = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panelEstado.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.picOpciones);
            this.panel2.Controls.Add(this.panelEstado);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Location = new System.Drawing.Point(234, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 140);
            this.panel2.TabIndex = 8;
            // 
            // panelEstado
            // 
            this.panelEstado.BackColor = System.Drawing.Color.White;
            this.panelEstado.Controls.Add(this.lblEstado);
            this.panelEstado.Location = new System.Drawing.Point(29, 67);
            this.panelEstado.Name = "panelEstado";
            this.panelEstado.Size = new System.Drawing.Size(295, 51);
            this.panelEstado.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(18, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 32);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(23, 16);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(75, 32);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblDiaNombre);
            this.panel1.Controls.Add(this.lblDiaNumero);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 140);
            this.panel1.TabIndex = 7;
            // 
            // lblDiaNombre
            // 
            this.lblDiaNombre.AutoSize = true;
            this.lblDiaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaNombre.Location = new System.Drawing.Point(20, 17);
            this.lblDiaNombre.Name = "lblDiaNombre";
            this.lblDiaNombre.Size = new System.Drawing.Size(157, 32);
            this.lblDiaNombre.TabIndex = 0;
            this.lblDiaNombre.Text = "DiaNombre";
            // 
            // lblDiaNumero
            // 
            this.lblDiaNumero.AutoSize = true;
            this.lblDiaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaNumero.Location = new System.Drawing.Point(20, 86);
            this.lblDiaNumero.Name = "lblDiaNumero";
            this.lblDiaNumero.Size = new System.Drawing.Size(157, 32);
            this.lblDiaNumero.TabIndex = 1;
            this.lblDiaNumero.Text = "DiaNumero";
            // 
            // picOpciones
            // 
            this.picOpciones.Image = global::CapaDePresentacion.Properties.Resources.tresPuntos;
            this.picOpciones.Location = new System.Drawing.Point(361, 29);
            this.picOpciones.Name = "picOpciones";
            this.picOpciones.Size = new System.Drawing.Size(67, 70);
            this.picOpciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOpciones.TabIndex = 6;
            this.picOpciones.TabStop = false;
            this.picOpciones.Click += new System.EventHandler(this.picOpciones_Click);
            // 
            // AdminTurnoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminTurnoItem";
            this.Size = new System.Drawing.Size(710, 182);
            this.Load += new System.EventHandler(this.AdminTurnoItem_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelEstado.ResumeLayout(false);
            this.panelEstado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picOpciones;
        private System.Windows.Forms.Panel panelEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDiaNombre;
        private System.Windows.Forms.Label lblDiaNumero;
    }
}
