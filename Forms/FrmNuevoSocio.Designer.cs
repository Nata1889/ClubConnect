namespace ClubConnect.Forms
{
    partial class FrmNuevoSocio
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblFechaDeNacimiento = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblFechaDeIngreso = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtFechaNacimiento = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtFechaDeIngreso = new TextBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(170, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(170, 85);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblFechaDeNacimiento
            // 
            lblFechaDeNacimiento.AutoSize = true;
            lblFechaDeNacimiento.Location = new Point(170, 122);
            lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            lblFechaDeNacimiento.Size = new Size(149, 20);
            lblFechaDeNacimiento.TabIndex = 2;
            lblFechaDeNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(170, 164);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(170, 208);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(170, 251);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblFechaDeIngreso
            // 
            lblFechaDeIngreso.AutoSize = true;
            lblFechaDeIngreso.Location = new Point(170, 300);
            lblFechaDeIngreso.Name = "lblFechaDeIngreso";
            lblFechaDeIngreso.Size = new Size(172, 20);
            lblFechaDeIngreso.TabIndex = 6;
            lblFechaDeIngreso.Text = "Fecha de ingreso al club:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(259, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(344, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(259, 82);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(342, 27);
            txtApellido.TabIndex = 8;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(337, 122);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(264, 27);
            txtFechaNacimiento.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(259, 161);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(344, 27);
            txtDireccion.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(259, 205);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(342, 27);
            txtTelefono.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(259, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(342, 27);
            txtEmail.TabIndex = 12;
            // 
            // txtFechaDeIngreso
            // 
            txtFechaDeIngreso.Location = new Point(348, 300);
            txtFechaDeIngreso.Name = "txtFechaDeIngreso";
            txtFechaDeIngreso.Size = new Size(255, 27);
            txtFechaDeIngreso.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(170, 375);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(509, 375);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmNuevoSocio
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
            Name = "FrmNuevoSocio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblFechaDeNacimiento;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblFechaDeIngreso;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtFechaNacimiento;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtFechaDeIngreso;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}