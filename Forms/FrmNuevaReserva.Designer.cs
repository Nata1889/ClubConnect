namespace ClubConnect.Forms
{
    partial class FrmNuevaReserva
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
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            lblFechaDeInicio = new Label();
            lblFechaDeFin = new Label();
            lblEstado = new Label();
            lblSocio = new Label();
            lblInstalacion = new Label();
            txtFechaDeInicio = new TextBox();
            txtFechaDeFin = new TextBox();
            txtEstado = new TextBox();
            cboSocio = new ComboBox();
            cboInstalacion = new ComboBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(197, 382);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(503, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblFechaDeInicio
            // 
            lblFechaDeInicio.AutoSize = true;
            lblFechaDeInicio.Location = new Point(197, 50);
            lblFechaDeInicio.Name = "lblFechaDeInicio";
            lblFechaDeInicio.Size = new Size(156, 20);
            lblFechaDeInicio.TabIndex = 2;
            lblFechaDeInicio.Text = "Fecha y hora de inicio:";
            // 
            // lblFechaDeFin
            // 
            lblFechaDeFin.AutoSize = true;
            lblFechaDeFin.Location = new Point(197, 97);
            lblFechaDeFin.Name = "lblFechaDeFin";
            lblFechaDeFin.Size = new Size(137, 20);
            lblFechaDeFin.TabIndex = 3;
            lblFechaDeFin.Text = "Fecha y hora de fin:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(197, 148);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado:";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(197, 203);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(49, 20);
            lblSocio.TabIndex = 5;
            lblSocio.Text = "Socio:";
            // 
            // lblInstalacion
            // 
            lblInstalacion.AutoSize = true;
            lblInstalacion.Location = new Point(197, 259);
            lblInstalacion.Name = "lblInstalacion";
            lblInstalacion.Size = new Size(83, 20);
            lblInstalacion.TabIndex = 6;
            lblInstalacion.Text = "Instalacion:";
            // 
            // txtFechaDeInicio
            // 
            txtFechaDeInicio.Location = new Point(368, 47);
            txtFechaDeInicio.Name = "txtFechaDeInicio";
            txtFechaDeInicio.Size = new Size(229, 27);
            txtFechaDeInicio.TabIndex = 7;
            // 
            // txtFechaDeFin
            // 
            txtFechaDeFin.Location = new Point(351, 94);
            txtFechaDeFin.Name = "txtFechaDeFin";
            txtFechaDeFin.Size = new Size(246, 27);
            txtFechaDeFin.TabIndex = 8;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(276, 145);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(321, 27);
            txtEstado.TabIndex = 9;
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(276, 203);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(321, 28);
            cboSocio.TabIndex = 10;
            // 
            // cboInstalacion
            // 
            cboInstalacion.FormattingEnabled = true;
            cboInstalacion.Location = new Point(299, 256);
            cboInstalacion.Name = "cboInstalacion";
            cboInstalacion.Size = new Size(298, 28);
            cboInstalacion.TabIndex = 11;
            // 
            // FrmNuevaReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboInstalacion);
            Controls.Add(cboSocio);
            Controls.Add(txtEstado);
            Controls.Add(txtFechaDeFin);
            Controls.Add(txtFechaDeInicio);
            Controls.Add(lblInstalacion);
            Controls.Add(lblSocio);
            Controls.Add(lblEstado);
            Controls.Add(lblFechaDeFin);
            Controls.Add(lblFechaDeInicio);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "FrmNuevaReserva";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva Reserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Label lblFechaDeInicio;
        private Label lblFechaDeFin;
        private Label lblEstado;
        private Label lblSocio;
        private Label lblInstalacion;
        private TextBox txtFechaDeInicio;
        private TextBox txtFechaDeFin;
        private TextBox txtEstado;
        private ComboBox cboSocio;
        private ComboBox cboInstalacion;
    }
}