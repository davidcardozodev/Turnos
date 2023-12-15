namespace CapaDePresentacion.PantallasUsuario.PantallasAdmin
{
    partial class AdminAsociarEstablecimientoArea
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEstablecimiento = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.comboEstablecimiento = new System.Windows.Forms.ComboBox();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAtras.Location = new System.Drawing.Point(222, 29);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(204, 58);
            this.btnVolverAtras.TabIndex = 62;
            this.btnVolverAtras.Text = "Volver atras";
            this.btnVolverAtras.UseVisualStyleBackColor = true;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEstablecimiento);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.comboEstablecimiento);
            this.panel1.Controls.Add(this.comboArea);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Location = new System.Drawing.Point(508, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 285);
            this.panel1.TabIndex = 70;
            // 
            // lblEstablecimiento
            // 
            this.lblEstablecimiento.AutoSize = true;
            this.lblEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstablecimiento.Location = new System.Drawing.Point(31, 44);
            this.lblEstablecimiento.Name = "lblEstablecimiento";
            this.lblEstablecimiento.Size = new System.Drawing.Size(242, 37);
            this.lblEstablecimiento.TabIndex = 66;
            this.lblEstablecimiento.Text = "Establecimiento";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(297, 209);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(495, 59);
            this.btnRegistrar.TabIndex = 63;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // comboEstablecimiento
            // 
            this.comboEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstablecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstablecimiento.FormattingEnabled = true;
            this.comboEstablecimiento.Location = new System.Drawing.Point(297, 44);
            this.comboEstablecimiento.Name = "comboEstablecimiento";
            this.comboEstablecimiento.Size = new System.Drawing.Size(495, 40);
            this.comboEstablecimiento.TabIndex = 67;
            // 
            // comboArea
            // 
            this.comboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboArea.FormattingEnabled = true;
            this.comboArea.Location = new System.Drawing.Point(297, 115);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(495, 40);
            this.comboArea.TabIndex = 65;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(184, 115);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(85, 37);
            this.lblArea.TabIndex = 64;
            this.lblArea.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(770, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 37);
            this.label1.TabIndex = 71;
            this.label1.Text = "Asociar establecimiento y area";
            // 
            // AdminAsociarEstablecimientoArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolverAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAsociarEstablecimientoArea";
            this.Text = "AdminAsociarEstablecimientoArea";
            this.Load += new System.EventHandler(this.AdminAsociarEstablecimientoArea_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEstablecimiento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox comboEstablecimiento;
        private System.Windows.Forms.ComboBox comboArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label1;
    }
}