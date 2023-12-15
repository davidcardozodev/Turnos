namespace CapaDePresentacion.PantallasUsuario.PantallasCliente
{
    partial class ClienteTurnosVista
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.btnCrearTurno = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(836, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turnos agendados";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(176, 361);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1546, 550);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificaciones.Location = new System.Drawing.Point(1635, 102);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(204, 53);
            this.btnNotificaciones.TabIndex = 4;
            this.btnNotificaciones.Text = "Notificaciones";
            this.btnNotificaciones.UseVisualStyleBackColor = true;
            this.btnNotificaciones.Click += new System.EventHandler(this.btnNotificaciones_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblTurno);
            this.panel1.Controls.Add(this.btnCrearTurno);
            this.panel1.Controls.Add(this.btnCalendario);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.comboEstado);
            this.panel1.Controls.Add(this.lblMostrar);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btnNotificaciones);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1876, 950);
            this.panel1.TabIndex = 5;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1512, 308);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(87, 37);
            this.lblHora.TabIndex = 16;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1044, 308);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(106, 37);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(499, 308);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(117, 37);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(209, 308);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(102, 37);
            this.lblTurno.TabIndex = 13;
            this.lblTurno.Text = "Turno";
            // 
            // btnCrearTurno
            // 
            this.btnCrearTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTurno.Location = new System.Drawing.Point(1203, 102);
            this.btnCrearTurno.Name = "btnCrearTurno";
            this.btnCrearTurno.Size = new System.Drawing.Size(204, 53);
            this.btnCrearTurno.TabIndex = 11;
            this.btnCrearTurno.Text = "Crear turno";
            this.btnCrearTurno.UseVisualStyleBackColor = true;
            this.btnCrearTurno.Click += new System.EventHandler(this.btnCrearTurno_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.Location = new System.Drawing.Point(1419, 102);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(204, 53);
            this.btnCalendario.TabIndex = 10;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1061, 197);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 53);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(673, 201);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(344, 44);
            this.txtBuscar.TabIndex = 8;
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(310, 204);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(280, 40);
            this.comboEstado.TabIndex = 6;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.Location = new System.Drawing.Point(190, 204);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(100, 37);
            this.lblMostrar.TabIndex = 5;
            this.lblMostrar.Text = "Filtrar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(1296, 197);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(195, 58);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ClienteTurnosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1876, 950);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClienteTurnosVista";
            this.Text = "ClienteTurnosVista";
            this.Load += new System.EventHandler(this.ClienteTurnosVista_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrearTurno;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Button btnActualizar;
    }
}