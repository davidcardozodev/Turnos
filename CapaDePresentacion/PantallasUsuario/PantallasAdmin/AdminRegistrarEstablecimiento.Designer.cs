namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    partial class AdminRegistrarEstablecimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAtras.Location = new System.Drawing.Point(217, 43);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(204, 58);
            this.btnVolverAtras.TabIndex = 63;
            this.btnVolverAtras.Text = "Volver atras";
            this.btnVolverAtras.UseVisualStyleBackColor = true;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(831, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 37);
            this.label5.TabIndex = 61;
            this.label5.Text = "Registrar establecimiento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(892, 380);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(294, 61);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(892, 266);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(294, 39);
            this.txtNombre.TabIndex = 60;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(758, 269);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 32);
            this.lblNombre.TabIndex = 59;
            this.lblNombre.Text = "Nombre";
            // 
            // AdminRegistrarEstablecimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1369, 745);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminRegistrarEstablecimiento";
            this.Text = "AdminRegistrarEstablecimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}