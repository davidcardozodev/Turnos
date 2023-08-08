namespace CapaDePresentacion.PantallasUsuario
{
    partial class ClientePrincipal
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
            this.btnMisTurnos = new System.Windows.Forms.Button();
            this.btnCrearTurno = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCrearTurno);
            this.panel1.Controls.Add(this.btnMisTurnos);
            this.panel1.Location = new System.Drawing.Point(81, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 402);
            this.panel1.TabIndex = 0;
            // 
            // btnMisTurnos
            // 
            this.btnMisTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisTurnos.Location = new System.Drawing.Point(78, 138);
            this.btnMisTurnos.Name = "btnMisTurnos";
            this.btnMisTurnos.Size = new System.Drawing.Size(209, 89);
            this.btnMisTurnos.TabIndex = 0;
            this.btnMisTurnos.Text = "Mis turnos";
            this.btnMisTurnos.UseVisualStyleBackColor = true;
            // 
            // btnCrearTurno
            // 
            this.btnCrearTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTurno.Location = new System.Drawing.Point(481, 138);
            this.btnCrearTurno.Name = "btnCrearTurno";
            this.btnCrearTurno.Size = new System.Drawing.Size(209, 89);
            this.btnCrearTurno.TabIndex = 1;
            this.btnCrearTurno.Text = "Crear turno";
            this.btnCrearTurno.UseVisualStyleBackColor = true;
            // 
            // ClientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 654);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientePrincipal";
            this.Text = "Cliente";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearTurno;
        private System.Windows.Forms.Button btnMisTurnos;
    }
}