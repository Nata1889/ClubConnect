namespace ClubConnect.Forms
{
    partial class FrmEditarReserva
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
            txtFechaDeFin = new TextBox();
            txtFechaDeInicio = new TextBox();
            lblInstalacion = new Label();
            lblSocio = new Label();
            lblEstado = new Label();
            lblFechaDeFin = new Label();
            lblFechaDeInicio = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cboSocio = new ComboBox();
            cboInstalacion = new ComboBox();
            cboEstado = new ComboBox();
            SuspendLayout();
            // 
            // txtFechaDeFin
            // 
            txtFechaDeFin.Location = new Point(354, 90);
            txtFechaDeFin.Name = "txtFechaDeFin";
            txtFechaDeFin.Size = new Size(246, 27);
            txtFechaDeFin.TabIndex = 20;
            // 
            // txtFechaDeInicio
            // 
            txtFechaDeInicio.Location = new Point(371, 43);
            txtFechaDeInicio.Name = "txtFechaDeInicio";
            txtFechaDeInicio.Size = new Size(229, 27);
            txtFechaDeInicio.TabIndex = 19;
            // 
            // lblInstalacion
            // 
            lblInstalacion.AutoSize = true;
            lblInstalacion.Location = new Point(200, 255);
            lblInstalacion.Name = "lblInstalacion";
            lblInstalacion.Size = new Size(83, 20);
            lblInstalacion.TabIndex = 18;
            lblInstalacion.Text = "Instalacion:";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(200, 199);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(49, 20);
            lblSocio.TabIndex = 17;
            lblSocio.Text = "Socio:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(200, 144);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 16;
            lblEstado.Text = "Estado:";
            // 
            // lblFechaDeFin
            // 
            lblFechaDeFin.AutoSize = true;
            lblFechaDeFin.Location = new Point(200, 93);
            lblFechaDeFin.Name = "lblFechaDeFin";
            lblFechaDeFin.Size = new Size(137, 20);
            lblFechaDeFin.TabIndex = 15;
            lblFechaDeFin.Text = "Fecha y hora de fin:";
            // 
            // lblFechaDeInicio
            // 
            lblFechaDeInicio.AutoSize = true;
            lblFechaDeInicio.Location = new Point(200, 46);
            lblFechaDeInicio.Name = "lblFechaDeInicio";
            lblFechaDeInicio.Size = new Size(156, 20);
            lblFechaDeInicio.TabIndex = 14;
            lblFechaDeInicio.Text = "Fecha y hora de inicio:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(506, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(200, 378);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(268, 196);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(332, 28);
            cboSocio.TabIndex = 22;
            // 
            // cboInstalacion
            // 
            cboInstalacion.FormattingEnabled = true;
            cboInstalacion.Location = new Point(309, 252);
            cboInstalacion.Name = "cboInstalacion";
            cboInstalacion.Size = new Size(291, 28);
            cboInstalacion.TabIndex = 23;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(287, 141);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(302, 28);
            cboEstado.TabIndex = 24;
            // 
            // FrmEditarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboEstado);
            Controls.Add(cboInstalacion);
            Controls.Add(cboSocio);
            Controls.Add(txtFechaDeFin);
            Controls.Add(txtFechaDeInicio);
            Controls.Add(lblInstalacion);
            Controls.Add(lblSocio);
            Controls.Add(lblEstado);
            Controls.Add(lblFechaDeFin);
            Controls.Add(lblFechaDeInicio);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "FrmEditarReserva";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Reserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFechaDeFin;
        private TextBox txtFechaDeInicio;
        private Label lblInstalacion;
        private Label lblSocio;
        private Label lblEstado;
        private Label lblFechaDeFin;
        private Label lblFechaDeInicio;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cboSocio;
        private ComboBox cboInstalacion;
        private ComboBox cboEstado;
    }
}