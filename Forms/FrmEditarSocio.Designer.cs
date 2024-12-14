namespace ClubConnect.Forms
{
    partial class FrmEditarSocio
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
            txtFechaDeIngreso = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtFechaNacimiento = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblFechaDeIngreso = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblFechaDeNacimiento = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(519, 372);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(180, 372);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtFechaDeIngreso
            // 
            txtFechaDeIngreso.Location = new Point(358, 297);
            txtFechaDeIngreso.Name = "txtFechaDeIngreso";
            txtFechaDeIngreso.Size = new Size(255, 27);
            txtFechaDeIngreso.TabIndex = 29;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(269, 248);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(342, 27);
            txtEmail.TabIndex = 28;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(269, 202);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(342, 27);
            txtTelefono.TabIndex = 27;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(269, 158);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(344, 27);
            txtDireccion.TabIndex = 26;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(347, 119);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(264, 27);
            txtFechaNacimiento.TabIndex = 25;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(269, 79);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(342, 27);
            txtApellido.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(269, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(344, 27);
            txtNombre.TabIndex = 23;
            // 
            // lblFechaDeIngreso
            // 
            lblFechaDeIngreso.AutoSize = true;
            lblFechaDeIngreso.Location = new Point(180, 297);
            lblFechaDeIngreso.Name = "lblFechaDeIngreso";
            lblFechaDeIngreso.Size = new Size(172, 20);
            lblFechaDeIngreso.TabIndex = 22;
            lblFechaDeIngreso.Text = "Fecha de ingreso al club:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(180, 248);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Email:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(180, 205);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 20;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(180, 161);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 19;
            lblDireccion.Text = "Dirección:";
            // 
            // lblFechaDeNacimiento
            // 
            lblFechaDeNacimiento.AutoSize = true;
            lblFechaDeNacimiento.Location = new Point(180, 119);
            lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            lblFechaDeNacimiento.Size = new Size(149, 20);
            lblFechaDeNacimiento.TabIndex = 18;
            lblFechaDeNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(180, 82);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 17;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(180, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 16;
            lblNombre.Text = "Nombre:";
            // 
            // FrmEditarSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtFechaDeIngreso);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblFechaDeIngreso);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblFechaDeNacimiento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "FrmEditarSocio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtFechaDeIngreso;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtFechaNacimiento;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblFechaDeIngreso;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblFechaDeNacimiento;
        private Label lblApellido;
        private Label lblNombre;
    }
}