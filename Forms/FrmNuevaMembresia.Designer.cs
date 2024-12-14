namespace ClubConnect.Forms
{
    partial class FrmNuevaMembresia
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
            lblTipoDeMembresia = new Label();
            lblFechaDeInicio = new Label();
            lblFechaDeExpiracion = new Label();
            lblEstado = new Label();
            lblSocio = new Label();
            txtTipoDeMembresia = new TextBox();
            txtFechaDeInicio = new TextBox();
            txtFechaDeExpiración = new TextBox();
            txtEstado = new TextBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            cboSocio = new ComboBox();
            SuspendLayout();
            // 
            // lblTipoDeMembresia
            // 
            lblTipoDeMembresia.AutoSize = true;
            lblTipoDeMembresia.Location = new Point(214, 44);
            lblTipoDeMembresia.Name = "lblTipoDeMembresia";
            lblTipoDeMembresia.Size = new Size(141, 20);
            lblTipoDeMembresia.TabIndex = 0;
            lblTipoDeMembresia.Text = "Tipo de membresía:";
            // 
            // lblFechaDeInicio
            // 
            lblFechaDeInicio.AutoSize = true;
            lblFechaDeInicio.Location = new Point(214, 102);
            lblFechaDeInicio.Name = "lblFechaDeInicio";
            lblFechaDeInicio.Size = new Size(111, 20);
            lblFechaDeInicio.TabIndex = 1;
            lblFechaDeInicio.Text = "Fecha de Inicio:";
            // 
            // lblFechaDeExpiracion
            // 
            lblFechaDeExpiracion.AutoSize = true;
            lblFechaDeExpiracion.Location = new Point(214, 157);
            lblFechaDeExpiracion.Name = "lblFechaDeExpiracion";
            lblFechaDeExpiracion.Size = new Size(144, 20);
            lblFechaDeExpiracion.TabIndex = 2;
            lblFechaDeExpiracion.Text = "Fecha de expiración:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(214, 208);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado:";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(214, 259);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(49, 20);
            lblSocio.TabIndex = 4;
            lblSocio.Text = "Socio:";
            // 
            // txtTipoDeMembresia
            // 
            txtTipoDeMembresia.Location = new Point(375, 41);
            txtTipoDeMembresia.Name = "txtTipoDeMembresia";
            txtTipoDeMembresia.Size = new Size(181, 27);
            txtTipoDeMembresia.TabIndex = 5;
            // 
            // txtFechaDeInicio
            // 
            txtFechaDeInicio.Location = new Point(342, 102);
            txtFechaDeInicio.Name = "txtFechaDeInicio";
            txtFechaDeInicio.Size = new Size(214, 27);
            txtFechaDeInicio.TabIndex = 6;
            // 
            // txtFechaDeExpiración
            // 
            txtFechaDeExpiración.Location = new Point(375, 157);
            txtFechaDeExpiración.Name = "txtFechaDeExpiración";
            txtFechaDeExpiración.Size = new Size(181, 27);
            txtFechaDeExpiración.TabIndex = 7;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(302, 205);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(254, 27);
            txtEstado.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(214, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(462, 358);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(283, 256);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(273, 28);
            cboSocio.TabIndex = 12;
            // 
            // FrmNuevaMembresia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboSocio);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEstado);
            Controls.Add(txtFechaDeExpiración);
            Controls.Add(txtFechaDeInicio);
            Controls.Add(txtTipoDeMembresia);
            Controls.Add(lblSocio);
            Controls.Add(lblEstado);
            Controls.Add(lblFechaDeExpiracion);
            Controls.Add(lblFechaDeInicio);
            Controls.Add(lblTipoDeMembresia);
            Name = "FrmNuevaMembresia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva Membresia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoDeMembresia;
        private Label lblFechaDeInicio;
        private Label lblFechaDeExpiracion;
        private Label lblEstado;
        private Label lblSocio;
        private TextBox txtTipoDeMembresia;
        private TextBox txtFechaDeInicio;
        private TextBox txtFechaDeExpiración;
        private TextBox txtEstado;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private ComboBox cboSocio;
    }
}