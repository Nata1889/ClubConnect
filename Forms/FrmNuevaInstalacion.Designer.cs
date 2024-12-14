namespace ClubConnect.Forms
{
    partial class FrmNuevaInstalacion
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
            lblNombreDeLaInstalacion = new Label();
            lblDescripcion = new Label();
            lblDisponibilidad = new Label();
            lblCostoDeReserva = new Label();
            txtNombreDeLaInstalacion = new TextBox();
            txtDescripcion = new TextBox();
            txtDisponibilidad = new TextBox();
            txtCostoDeLaReserva = new TextBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblNombreDeLaInstalacion
            // 
            lblNombreDeLaInstalacion.AutoSize = true;
            lblNombreDeLaInstalacion.Location = new Point(165, 59);
            lblNombreDeLaInstalacion.Name = "lblNombreDeLaInstalacion";
            lblNombreDeLaInstalacion.Size = new Size(179, 20);
            lblNombreDeLaInstalacion.TabIndex = 0;
            lblNombreDeLaInstalacion.Text = "Nombre de la instalación:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(165, 118);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblDisponibilidad
            // 
            lblDisponibilidad.AutoSize = true;
            lblDisponibilidad.Location = new Point(165, 176);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(110, 20);
            lblDisponibilidad.TabIndex = 2;
            lblDisponibilidad.Text = "Disponibilidad:";
            // 
            // lblCostoDeReserva
            // 
            lblCostoDeReserva.AutoSize = true;
            lblCostoDeReserva.Location = new Point(165, 239);
            lblCostoDeReserva.Name = "lblCostoDeReserva";
            lblCostoDeReserva.Size = new Size(138, 20);
            lblCostoDeReserva.TabIndex = 3;
            lblCostoDeReserva.Text = "Costo de la reserva:";
            // 
            // txtNombreDeLaInstalacion
            // 
            txtNombreDeLaInstalacion.Location = new Point(357, 56);
            txtNombreDeLaInstalacion.Name = "txtNombreDeLaInstalacion";
            txtNombreDeLaInstalacion.Size = new Size(262, 27);
            txtNombreDeLaInstalacion.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(271, 111);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(348, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // txtDisponibilidad
            // 
            txtDisponibilidad.Location = new Point(294, 173);
            txtDisponibilidad.Name = "txtDisponibilidad";
            txtDisponibilidad.Size = new Size(325, 27);
            txtDisponibilidad.TabIndex = 6;
            // 
            // txtCostoDeLaReserva
            // 
            txtCostoDeLaReserva.Location = new Point(318, 236);
            txtCostoDeLaReserva.Name = "txtCostoDeLaReserva";
            txtCostoDeLaReserva.Size = new Size(301, 27);
            txtCostoDeLaReserva.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(165, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(525, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmNuevaInstalacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCostoDeLaReserva);
            Controls.Add(txtDisponibilidad);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreDeLaInstalacion);
            Controls.Add(lblCostoDeReserva);
            Controls.Add(lblDisponibilidad);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombreDeLaInstalacion);
            Name = "FrmNuevaInstalacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva Instalacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreDeLaInstalacion;
        private Label lblDescripcion;
        private Label lblDisponibilidad;
        private Label lblCostoDeReserva;
        private TextBox txtNombreDeLaInstalacion;
        private TextBox txtDescripcion;
        private TextBox txtDisponibilidad;
        private TextBox txtCostoDeLaReserva;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}