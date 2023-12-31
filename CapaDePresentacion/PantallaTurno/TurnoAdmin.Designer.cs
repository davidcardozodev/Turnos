﻿namespace CapaDePresentacion.PantallaTurno
{
    partial class TurnoAdmin
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
            this.panelModificar = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.lblCambiarProveedor = new System.Windows.Forms.Label();
            this.comboProveedores = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblProveedorCategoria = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioCategoria = new System.Windows.Forms.Label();
            this.lblFechaCategoria = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEstadoCategoria = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblHoraCategoria = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelModificar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelModificar
            // 
            this.panelModificar.Controls.Add(this.dtpFecha);
            this.panelModificar.Controls.Add(this.lblFechaModificacion);
            this.panelModificar.Controls.Add(this.lblCambiarProveedor);
            this.panelModificar.Controls.Add(this.comboProveedores);
            this.panelModificar.Location = new System.Drawing.Point(25, 422);
            this.panelModificar.Name = "panelModificar";
            this.panelModificar.Size = new System.Drawing.Size(637, 149);
            this.panelModificar.TabIndex = 36;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(174, 104);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(456, 35);
            this.dtpFecha.TabIndex = 28;
            this.dtpFecha.Visible = false;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaModificacion.Location = new System.Drawing.Point(46, 104);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(93, 32);
            this.lblFechaModificacion.TabIndex = 29;
            this.lblFechaModificacion.Text = "Fecha";
            this.lblFechaModificacion.Visible = false;
            // 
            // lblCambiarProveedor
            // 
            this.lblCambiarProveedor.AutoSize = true;
            this.lblCambiarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarProveedor.Location = new System.Drawing.Point(9, 37);
            this.lblCambiarProveedor.Name = "lblCambiarProveedor";
            this.lblCambiarProveedor.Size = new System.Drawing.Size(145, 32);
            this.lblCambiarProveedor.TabIndex = 19;
            this.lblCambiarProveedor.Text = "Proveedor";
            this.lblCambiarProveedor.Visible = false;
            // 
            // comboProveedores
            // 
            this.comboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProveedores.FormattingEnabled = true;
            this.comboProveedores.Location = new System.Drawing.Point(174, 37);
            this.comboProveedores.Name = "comboProveedores";
            this.comboProveedores.Size = new System.Drawing.Size(235, 37);
            this.comboProveedores.TabIndex = 26;
            this.comboProveedores.Visible = false;
            this.comboProveedores.SelectedIndexChanged += new System.EventHandler(this.comboProveedores_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(681, 497);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(204, 58);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.BackColor = System.Drawing.Color.Firebrick;
            this.btnDarDeBaja.Enabled = false;
            this.btnDarDeBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarDeBaja.ForeColor = System.Drawing.Color.White;
            this.btnDarDeBaja.Location = new System.Drawing.Point(681, 422);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(204, 58);
            this.btnDarDeBaja.TabIndex = 34;
            this.btnDarDeBaja.Text = "Dar de baja";
            this.btnDarDeBaja.UseVisualStyleBackColor = false;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 37);
            this.label5.TabIndex = 33;
            this.label5.Text = "Detalle del turno";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblProveedor);
            this.panel1.Controls.Add(this.lblProveedorCategoria);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblUsuarioCategoria);
            this.panel1.Controls.Add(this.lblFechaCategoria);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblEstadoCategoria);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblHoraCategoria);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Location = new System.Drawing.Point(25, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 329);
            this.panel1.TabIndex = 32;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.DimGray;
            this.lblProveedor.Location = new System.Drawing.Point(206, 206);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(145, 32);
            this.lblProveedor.TabIndex = 18;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblProveedorCategoria
            // 
            this.lblProveedorCategoria.AutoSize = true;
            this.lblProveedorCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorCategoria.Location = new System.Drawing.Point(32, 206);
            this.lblProveedorCategoria.Name = "lblProveedorCategoria";
            this.lblProveedorCategoria.Size = new System.Drawing.Size(145, 32);
            this.lblProveedorCategoria.TabIndex = 17;
            this.lblProveedorCategoria.Text = "Proveedor";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsuario.Location = new System.Drawing.Point(203, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(112, 32);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblUsuarioCategoria
            // 
            this.lblUsuarioCategoria.AutoSize = true;
            this.lblUsuarioCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioCategoria.Location = new System.Drawing.Point(72, 27);
            this.lblUsuarioCategoria.Name = "lblUsuarioCategoria";
            this.lblUsuarioCategoria.Size = new System.Drawing.Size(112, 32);
            this.lblUsuarioCategoria.TabIndex = 15;
            this.lblUsuarioCategoria.Text = "Usuario";
            // 
            // lblFechaCategoria
            // 
            this.lblFechaCategoria.AutoSize = true;
            this.lblFechaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCategoria.Location = new System.Drawing.Point(75, 91);
            this.lblFechaCategoria.Name = "lblFechaCategoria";
            this.lblFechaCategoria.Size = new System.Drawing.Size(93, 32);
            this.lblFechaCategoria.TabIndex = 5;
            this.lblFechaCategoria.Text = "Fecha";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.DimGray;
            this.lblEstado.Location = new System.Drawing.Point(206, 258);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 32);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // lblEstadoCategoria
            // 
            this.lblEstadoCategoria.AutoSize = true;
            this.lblEstadoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCategoria.Location = new System.Drawing.Point(68, 258);
            this.lblEstadoCategoria.Name = "lblEstadoCategoria";
            this.lblEstadoCategoria.Size = new System.Drawing.Size(103, 32);
            this.lblEstadoCategoria.TabIndex = 9;
            this.lblEstadoCategoria.Text = "Estado";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DimGray;
            this.lblHora.Location = new System.Drawing.Point(206, 154);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(75, 32);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora";
            // 
            // lblHoraCategoria
            // 
            this.lblHoraCategoria.AutoSize = true;
            this.lblHoraCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraCategoria.Location = new System.Drawing.Point(93, 154);
            this.lblHoraCategoria.Name = "lblHoraCategoria";
            this.lblHoraCategoria.Size = new System.Drawing.Size(75, 32);
            this.lblHoraCategoria.TabIndex = 7;
            this.lblHoraCategoria.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DimGray;
            this.lblFecha.Location = new System.Drawing.Point(206, 91);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 32);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
            // 
            // TurnoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 600);
            this.Controls.Add(this.panelModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnDarDeBaja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "TurnoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurnoAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TurnoAdmin_FormClosed);
            this.Load += new System.EventHandler(this.TurnoAdmin_Load);
            this.panelModificar.ResumeLayout(false);
            this.panelModificar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelModificar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.Label lblCambiarProveedor;
        private System.Windows.Forms.ComboBox comboProveedores;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblProveedorCategoria;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblUsuarioCategoria;
        private System.Windows.Forms.Label lblFechaCategoria;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoCategoria;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblHoraCategoria;
        private System.Windows.Forms.Label lblFecha;
    }
}