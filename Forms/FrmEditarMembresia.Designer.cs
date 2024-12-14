namespace ClubConnect.Forms
{
    partial class FrmEditarMembresia
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
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtEstado = new TextBox();
            txtFechaDeExpiracion = new TextBox();
            txtFechaDeInicio = new TextBox();
            txtTipoDeMembresia = new TextBox();
            lblSocio = new Label();
            lblEstado = new Label();
            lblFechaDeExpiracion = new Label();
            lblFechaDeInicio = new Label();
            lblTipoDeMembresia = new Label();
            cboSocio = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(467, 365);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(219, 365);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(307, 212);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(254, 27);
            txtEstado.TabIndex = 20;
            // 
            // txtFechaDeExpiracion
            // 
            txtFechaDeExpiracion.Location = new Point(380, 164);
            txtFechaDeExpiracion.Name = "txtFechaDeExpiracion";
            txtFechaDeExpiracion.Size = new Size(181, 27);
            txtFechaDeExpiracion.TabIndex = 19;
            // 
            // txtFechaDeInicio
            // 
            txtFechaDeInicio.Location = new Point(347, 109);
            txtFechaDeInicio.Name = "txtFechaDeInicio";
            txtFechaDeInicio.Size = new Size(214, 27);
            txtFechaDeInicio.TabIndex = 18;
            // 
            // txtTipoDeMembresia
            // 
            txtTipoDeMembresia.Location = new Point(380, 48);
            txtTipoDeMembresia.Name = "txtTipoDeMembresia";
            txtTipoDeMembresia.Size = new Size(181, 27);
            txtTipoDeMembresia.TabIndex = 17;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(219, 266);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(49, 20);
            lblSocio.TabIndex = 16;
            lblSocio.Text = "Socio:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(219, 215);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado:";
            // 
            // lblFechaDeExpiracion
            // 
            lblFechaDeExpiracion.AutoSize = true;
            lblFechaDeExpiracion.Location = new Point(219, 164);
            lblFechaDeExpiracion.Name = "lblFechaDeExpiracion";
            lblFechaDeExpiracion.Size = new Size(144, 20);
            lblFechaDeExpiracion.TabIndex = 14;
            lblFechaDeExpiracion.Text = "Fecha de expiración:";
            // 
            // lblFechaDeInicio
            // 
            lblFechaDeInicio.AutoSize = true;
            lblFechaDeInicio.Location = new Point(219, 109);
            lblFechaDeInicio.Name = "lblFechaDeInicio";
            lblFechaDeInicio.Size = new Size(111, 20);
            lblFechaDeInicio.TabIndex = 13;
            lblFechaDeInicio.Text = "Fecha de Inicio:";
            // 
            // lblTipoDeMembresia
            // 
            lblTipoDeMembresia.AutoSize = true;
            lblTipoDeMembresia.Location = new Point(219, 51);
            lblTipoDeMembresia.Name = "lblTipoDeMembresia";
            lblTipoDeMembresia.Size = new Size(141, 20);
            lblTipoDeMembresia.TabIndex = 12;
            lblTipoDeMembresia.Text = "Tipo de membresía:";
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(287, 263);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(274, 28);
            cboSocio.TabIndex = 24;
            // 
            // FrmEditarMembresia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboSocio);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEstado);
            Controls.Add(txtFechaDeExpiracion);
            Controls.Add(txtFechaDeInicio);
            Controls.Add(txtTipoDeMembresia);
            Controls.Add(lblSocio);
            Controls.Add(lblEstado);
            Controls.Add(lblFechaDeExpiracion);
            Controls.Add(lblFechaDeInicio);
            Controls.Add(lblTipoDeMembresia);
            Name = "FrmEditarMembresia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Membresia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtEstado;
        private TextBox txtFechaDeExpiracion;
        private TextBox txtFechaDeInicio;
        private TextBox txtTipoDeMembresia;
        private Label lblSocio;
        private Label lblEstado;
        private Label lblFechaDeExpiracion;
        private Label lblFechaDeInicio;
        private Label lblTipoDeMembresia;
        private ComboBox cboSocio;
    }
}