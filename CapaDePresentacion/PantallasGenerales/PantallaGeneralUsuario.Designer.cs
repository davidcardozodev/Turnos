namespace CapaDePresentacion.PantallasGenerales
{
    partial class PantallaGeneralUsuario
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelcontainer = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.linkPerfil = new System.Windows.Forms.LinkLabel();
            this.linkCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.panelcontainer.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelForm.Location = new System.Drawing.Point(16, 42);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1762, 615);
            this.panelForm.TabIndex = 2;
            // 
            // panelcontainer
            // 
            this.panelcontainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelcontainer.Controls.Add(this.panelForm);
            this.panelcontainer.Controls.Add(this.panelTitulo);
            this.panelcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontainer.Location = new System.Drawing.Point(0, 0);
            this.panelcontainer.MinimumSize = new System.Drawing.Size(650, 650);
            this.panelcontainer.Name = "panelcontainer";
            this.panelcontainer.Size = new System.Drawing.Size(1829, 669);
            this.panelcontainer.TabIndex = 1;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.panelTitulo.Controls.Add(this.linkPerfil);
            this.panelTitulo.Controls.Add(this.linkCerrarSesion);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1829, 51);
            this.panelTitulo.TabIndex = 0;
            // 
            // linkPerfil
            // 
            this.linkPerfil.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkPerfil.AutoSize = true;
            this.linkPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPerfil.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkPerfil.Location = new System.Drawing.Point(426, 9);
            this.linkPerfil.Name = "linkPerfil";
            this.linkPerfil.Size = new System.Drawing.Size(80, 32);
            this.linkPerfil.TabIndex = 0;
            this.linkPerfil.TabStop = true;
            this.linkPerfil.Text = "Perfil";
            this.linkPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPerfil_LinkClicked);
            // 
            // linkCerrarSesion
            // 
            this.linkCerrarSesion.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkCerrarSesion.AutoSize = true;
            this.linkCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCerrarSesion.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkCerrarSesion.Location = new System.Drawing.Point(16, 9);
            this.linkCerrarSesion.Name = "linkCerrarSesion";
            this.linkCerrarSesion.Size = new System.Drawing.Size(183, 32);
            this.linkCerrarSesion.TabIndex = 5;
            this.linkCerrarSesion.TabStop = true;
            this.linkCerrarSesion.Text = "Cerrar sesion";
            this.linkCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCerrarSesion_LinkClicked);
            // 
            // PantallaGeneralUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1829, 669);
            this.Controls.Add(this.panelcontainer);
            this.Name = "PantallaGeneralUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.PantallaGeneralUsuario_Load);
            this.panelcontainer.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelcontainer;
        private System.Windows.Forms.LinkLabel linkCerrarSesion;
        private System.Windows.Forms.LinkLabel linkPerfil;
        private System.Windows.Forms.Panel panelTitulo;
    }
}