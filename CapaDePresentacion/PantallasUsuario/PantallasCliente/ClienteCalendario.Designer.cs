﻿namespace CapaDePresentacion.PantallasUsuario.PantallasCliente
{
    partial class ClienteCalendario
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCrearTurno = new System.Windows.Forms.Button();
            this.panelCalendario = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFechaCategoria = new System.Windows.Forms.Label();
            this.panelCalendario.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(49, 95);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(349, 95);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(64, 52);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "+";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCrearTurno
            // 
            this.btnCrearTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTurno.Location = new System.Drawing.Point(356, 225);
            this.btnCrearTurno.Name = "btnCrearTurno";
            this.btnCrearTurno.Size = new System.Drawing.Size(204, 58);
            this.btnCrearTurno.TabIndex = 10;
            this.btnCrearTurno.Text = "Crear turno";
            this.btnCrearTurno.UseVisualStyleBackColor = true;
            this.btnCrearTurno.Click += new System.EventHandler(this.btnCrearTurno_Click);
            // 
            // panelCalendario
            // 
            this.panelCalendario.BackColor = System.Drawing.Color.White;
            this.panelCalendario.Controls.Add(this.lblFecha);
            this.panelCalendario.Controls.Add(this.btnCrearTurno);
            this.panelCalendario.Controls.Add(this.txtDescripcion);
            this.panelCalendario.Controls.Add(this.comboHora);
            this.panelCalendario.Controls.Add(this.lblDescripcion);
            this.panelCalendario.Controls.Add(this.lblHora);
            this.panelCalendario.Controls.Add(this.lblFechaCategoria);
            this.panelCalendario.Location = new System.Drawing.Point(466, 95);
            this.panelCalendario.Name = "panelCalendario";
            this.panelCalendario.Size = new System.Drawing.Size(583, 306);
            this.panelCalendario.TabIndex = 11;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DimGray;
            this.lblFecha.Location = new System.Drawing.Point(124, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(106, 37);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(202, 163);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(358, 35);
            this.txtDescripcion.TabIndex = 10;
            // 
            // comboHora
            // 
            this.comboHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHora.FormattingEnabled = true;
            this.comboHora.Location = new System.Drawing.Point(124, 97);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(436, 37);
            this.comboHora.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 160);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(184, 37);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(12, 94);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(87, 37);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora";
            // 
            // lblFechaCategoria
            // 
            this.lblFechaCategoria.AutoSize = true;
            this.lblFechaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCategoria.Location = new System.Drawing.Point(12, 27);
            this.lblFechaCategoria.Name = "lblFechaCategoria";
            this.lblFechaCategoria.Size = new System.Drawing.Size(106, 37);
            this.lblFechaCategoria.TabIndex = 5;
            this.lblFechaCategoria.Text = "Fecha";
            // 
            // ClienteCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 571);
            this.Controls.Add(this.panelCalendario);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "ClienteCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteCalendario";
            this.Load += new System.EventHandler(this.ClienteCalendario_Load);
            this.panelCalendario.ResumeLayout(false);
            this.panelCalendario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCrearTurno;
        private System.Windows.Forms.Panel panelCalendario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFechaCategoria;
    }
}