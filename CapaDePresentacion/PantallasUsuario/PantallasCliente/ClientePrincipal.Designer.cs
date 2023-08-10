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
            this.btnCrearTurno = new System.Windows.Forms.Button();
            this.btnMisTurnos = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalendario);
            this.panel1.Controls.Add(this.btnCrearTurno);
            this.panel1.Controls.Add(this.btnMisTurnos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 154);
            this.panel1.TabIndex = 0;
            // 
            // btnCrearTurno
            // 
            this.btnCrearTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTurno.Location = new System.Drawing.Point(312, 34);
            this.btnCrearTurno.Name = "btnCrearTurno";
            this.btnCrearTurno.Size = new System.Drawing.Size(209, 89);
            this.btnCrearTurno.TabIndex = 1;
            this.btnCrearTurno.Text = "Crear turno";
            this.btnCrearTurno.UseVisualStyleBackColor = true;
            this.btnCrearTurno.Click += new System.EventHandler(this.btnCrearTurno_Click);
            // 
            // btnMisTurnos
            // 
            this.btnMisTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisTurnos.Location = new System.Drawing.Point(32, 34);
            this.btnMisTurnos.Name = "btnMisTurnos";
            this.btnMisTurnos.Size = new System.Drawing.Size(209, 89);
            this.btnMisTurnos.TabIndex = 0;
            this.btnMisTurnos.Text = "Mis turnos";
            this.btnMisTurnos.UseVisualStyleBackColor = true;
            this.btnMisTurnos.Click += new System.EventHandler(this.btnMisTurnos_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.Location = new System.Drawing.Point(613, 34);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(209, 89);
            this.btnCalendario.TabIndex = 2;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // ClientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 154);
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
        private System.Windows.Forms.Button btnCalendario;
    }
}