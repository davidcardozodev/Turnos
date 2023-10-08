namespace CapaDePresentacion.PantallaTurno
{
    partial class TurnoCliente
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
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblProveedorCategoria = new System.Windows.Forms.Label();
            this.rtxtDecripcion = new System.Windows.Forms.RichTextBox();
            this.lblFechaCategoria = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEstadoCategoria = new System.Windows.Forms.Label();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblHoraCategoria = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.Enabled = false;
            this.btnDarDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarDeBaja.Location = new System.Drawing.Point(683, 469);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(204, 58);
            this.btnDarDeBaja.TabIndex = 24;
            this.btnDarDeBaja.Text = "Dar de baja";
            this.btnDarDeBaja.UseVisualStyleBackColor = true;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 37);
            this.label5.TabIndex = 23;
            this.label5.Text = "Detalle del turno";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblProveedor);
            this.panel1.Controls.Add(this.lblProveedorCategoria);
            this.panel1.Controls.Add(this.rtxtDecripcion);
            this.panel1.Controls.Add(this.lblFechaCategoria);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblEstadoCategoria);
            this.panel1.Controls.Add(this.lblDescripcionCategoria);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblHoraCategoria);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Location = new System.Drawing.Point(27, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 387);
            this.panel1.TabIndex = 22;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.DimGray;
            this.lblProveedor.Location = new System.Drawing.Point(209, 281);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(145, 32);
            this.lblProveedor.TabIndex = 18;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblProveedorCategoria
            // 
            this.lblProveedorCategoria.AutoSize = true;
            this.lblProveedorCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorCategoria.Location = new System.Drawing.Point(29, 281);
            this.lblProveedorCategoria.Name = "lblProveedorCategoria";
            this.lblProveedorCategoria.Size = new System.Drawing.Size(145, 32);
            this.lblProveedorCategoria.TabIndex = 17;
            this.lblProveedorCategoria.Text = "Proveedor";
            // 
            // rtxtDecripcion
            // 
            this.rtxtDecripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDecripcion.Location = new System.Drawing.Point(212, 154);
            this.rtxtDecripcion.Name = "rtxtDecripcion";
            this.rtxtDecripcion.ReadOnly = true;
            this.rtxtDecripcion.Size = new System.Drawing.Size(492, 91);
            this.rtxtDecripcion.TabIndex = 14;
            this.rtxtDecripcion.Text = "";
            // 
            // lblFechaCategoria
            // 
            this.lblFechaCategoria.AutoSize = true;
            this.lblFechaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCategoria.Location = new System.Drawing.Point(78, 15);
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
            this.lblEstado.Location = new System.Drawing.Point(209, 330);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 32);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // lblEstadoCategoria
            // 
            this.lblEstadoCategoria.AutoSize = true;
            this.lblEstadoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCategoria.Location = new System.Drawing.Point(71, 330);
            this.lblEstadoCategoria.Name = "lblEstadoCategoria";
            this.lblEstadoCategoria.Size = new System.Drawing.Size(103, 32);
            this.lblEstadoCategoria.TabIndex = 9;
            this.lblEstadoCategoria.Text = "Estado";
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(8, 166);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(163, 32);
            this.lblDescripcionCategoria.TabIndex = 8;
            this.lblDescripcionCategoria.Text = "Descripcion";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DimGray;
            this.lblHora.Location = new System.Drawing.Point(209, 96);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(75, 32);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora";
            // 
            // lblHoraCategoria
            // 
            this.lblHoraCategoria.AutoSize = true;
            this.lblHoraCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraCategoria.Location = new System.Drawing.Point(96, 96);
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
            this.lblFecha.Location = new System.Drawing.Point(209, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 32);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
            // 
            // TurnoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 547);
            this.Controls.Add(this.btnDarDeBaja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "TurnoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurnoDetalle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TurnoDetalle_FormClosed);
            this.Load += new System.EventHandler(this.TurnoDetalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblProveedorCategoria;
        private System.Windows.Forms.RichTextBox rtxtDecripcion;
        private System.Windows.Forms.Label lblFechaCategoria;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoCategoria;
        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblHoraCategoria;
        private System.Windows.Forms.Label lblFecha;
    }
}