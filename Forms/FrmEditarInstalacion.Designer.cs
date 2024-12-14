namespace ClubConnect.Forms
{
    partial class FrmEditarInstalacion
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
            txtCostoDeLaReserva = new TextBox();
            txtDisponibilidad = new TextBox();
            txtDescripcion = new TextBox();
            txtNombreDeLaInstalacion = new TextBox();
            lblCostoDeReserva = new Label();
            lblDisponibilidad = new Label();
            lblDescripcion = new Label();
            lblNombreDeLaInstalacion = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(519, 344);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(159, 344);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCostoDeLaReserva
            // 
            txtCostoDeLaReserva.Location = new Point(312, 240);
            txtCostoDeLaReserva.Name = "txtCostoDeLaReserva";
            txtCostoDeLaReserva.Size = new Size(301, 27);
            txtCostoDeLaReserva.TabIndex = 17;
            // 
            // txtDisponibilidad
            // 
            txtDisponibilidad.Location = new Point(288, 177);
            txtDisponibilidad.Name = "txtDisponibilidad";
            txtDisponibilidad.Size = new Size(325, 27);
            txtDisponibilidad.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(265, 115);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(348, 27);
            txtDescripcion.TabIndex = 15;
            // 
            // txtNombreDeLaInstalacion
            // 
            txtNombreDeLaInstalacion.Location = new Point(351, 60);
            txtNombreDeLaInstalacion.Name = "txtNombreDeLaInstalacion";
            txtNombreDeLaInstalacion.Size = new Size(262, 27);
            txtNombreDeLaInstalacion.TabIndex = 14;
            // 
            // lblCostoDeReserva
            // 
            lblCostoDeReserva.AutoSize = true;
            lblCostoDeReserva.Location = new Point(159, 243);
            lblCostoDeReserva.Name = "lblCostoDeReserva";
            lblCostoDeReserva.Size = new Size(138, 20);
            lblCostoDeReserva.TabIndex = 13;
            lblCostoDeReserva.Text = "Costo de la reserva:";
            // 
            // lblDisponibilidad
            // 
            lblDisponibilidad.AutoSize = true;
            lblDisponibilidad.Location = new Point(159, 180);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(110, 20);
            lblDisponibilidad.TabIndex = 12;
            lblDisponibilidad.Text = "Disponibilidad:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(159, 122);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 11;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblNombreDeLaInstalacion
            // 
            lblNombreDeLaInstalacion.AutoSize = true;
            lblNombreDeLaInstalacion.Location = new Point(159, 63);
            lblNombreDeLaInstalacion.Name = "lblNombreDeLaInstalacion";
            lblNombreDeLaInstalacion.Size = new Size(179, 20);
            lblNombreDeLaInstalacion.TabIndex = 10;
            lblNombreDeLaInstalacion.Text = "Nombre de la instalación:";
            // 
            // FrmEditarInstalacion
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
            Name = "FrmEditarInstalacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Instalacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtCostoDeLaReserva;
        private TextBox txtDisponibilidad;
        private TextBox txtDescripcion;
        private TextBox txtNombreDeLaInstalacion;
        private Label lblCostoDeReserva;
        private Label lblDisponibilidad;
        private Label lblDescripcion;
        private Label lblNombreDeLaInstalacion;
    }
}