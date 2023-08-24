namespace CapaDePresentacion.PantallaLlamador
{
    partial class PantallaLlamadorPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrarPresencia = new System.Windows.Forms.Button();
            this.btnTurnosEnCurso = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegistrarPresencia);
            this.panel1.Controls.Add(this.btnTurnosEnCurso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnRegistrarPresencia
            // 
            this.btnRegistrarPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPresencia.Location = new System.Drawing.Point(433, 148);
            this.btnRegistrarPresencia.Name = "btnRegistrarPresencia";
            this.btnRegistrarPresencia.Size = new System.Drawing.Size(336, 111);
            this.btnRegistrarPresencia.TabIndex = 4;
            this.btnRegistrarPresencia.Text = "Registrar presencia";
            this.btnRegistrarPresencia.UseVisualStyleBackColor = true;
            this.btnRegistrarPresencia.Click += new System.EventHandler(this.btnRegistrarPresencia_Click);
            // 
            // btnTurnosEnCurso
            // 
            this.btnTurnosEnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnosEnCurso.Location = new System.Drawing.Point(42, 148);
            this.btnTurnosEnCurso.Name = "btnTurnosEnCurso";
            this.btnTurnosEnCurso.Size = new System.Drawing.Size(310, 111);
            this.btnTurnosEnCurso.TabIndex = 3;
            this.btnTurnosEnCurso.Text = "Turnos en curso";
            this.btnTurnosEnCurso.UseVisualStyleBackColor = true;
            this.btnTurnosEnCurso.Click += new System.EventHandler(this.btnTurnosEnCurso_Click);
            // 
            // PantallaLlamadorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaLlamadorPrincipal";
            this.Text = "PantallaLlamadorPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTurnosEnCurso;
        private System.Windows.Forms.Button btnRegistrarPresencia;
    }
}