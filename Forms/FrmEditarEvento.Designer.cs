namespace ClubConnect.Forms
{
    partial class FrmEditarEvento
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
            txtLugarDelEvento = new TextBox();
            txtFechaYHoraDelEvento = new TextBox();
            txtDescripcion = new TextBox();
            txtNombreDelEvento = new TextBox();
            lblLugarDelEvento = new Label();
            lblFechaYHoraDelEvento = new Label();
            lblDescripcion = new Label();
            lblNombreDelEvento = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtLugarDelEvento
            // 
            txtLugarDelEvento.Location = new Point(331, 234);
            txtLugarDelEvento.Name = "txtLugarDelEvento";
            txtLugarDelEvento.Size = new Size(284, 27);
            txtLugarDelEvento.TabIndex = 19;
            // 
            // txtFechaYHoraDelEvento
            // 
            txtFechaYHoraDelEvento.Location = new Point(375, 173);
            txtFechaYHoraDelEvento.Name = "txtFechaYHoraDelEvento";
            txtFechaYHoraDelEvento.Size = new Size(240, 27);
            txtFechaYHoraDelEvento.TabIndex = 18;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(296, 113);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(319, 27);
            txtDescripcion.TabIndex = 17;
            // 
            // txtNombreDelEvento
            // 
            txtNombreDelEvento.Location = new Point(345, 54);
            txtNombreDelEvento.Name = "txtNombreDelEvento";
            txtNombreDelEvento.Size = new Size(270, 27);
            txtNombreDelEvento.TabIndex = 16;
            // 
            // lblLugarDelEvento
            // 
            lblLugarDelEvento.AutoSize = true;
            lblLugarDelEvento.Location = new Point(188, 237);
            lblLugarDelEvento.Name = "lblLugarDelEvento";
            lblLugarDelEvento.Size = new Size(123, 20);
            lblLugarDelEvento.TabIndex = 15;
            lblLugarDelEvento.Text = "Lugar del evento:";
            // 
            // lblFechaYHoraDelEvento
            // 
            lblFechaYHoraDelEvento.AutoSize = true;
            lblFechaYHoraDelEvento.Location = new Point(188, 176);
            lblFechaYHoraDelEvento.Name = "lblFechaYHoraDelEvento";
            lblFechaYHoraDelEvento.Size = new Size(169, 20);
            lblFechaYHoraDelEvento.TabIndex = 14;
            lblFechaYHoraDelEvento.Text = "Fecha y hora del evento:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(188, 116);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblNombreDelEvento
            // 
            lblNombreDelEvento.AutoSize = true;
            lblNombreDelEvento.Location = new Point(188, 57);
            lblNombreDelEvento.Name = "lblNombreDelEvento";
            lblNombreDelEvento.Size = new Size(141, 20);
            lblNombreDelEvento.TabIndex = 12;
            lblNombreDelEvento.Text = "Nombre del evento:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(521, 367);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(188, 367);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmEditarEvento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLugarDelEvento);
            Controls.Add(txtFechaYHoraDelEvento);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreDelEvento);
            Controls.Add(lblLugarDelEvento);
            Controls.Add(lblFechaYHoraDelEvento);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombreDelEvento);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "FrmEditarEvento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Evento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLugarDelEvento;
        private TextBox txtFechaYHoraDelEvento;
        private TextBox txtDescripcion;
        private TextBox txtNombreDelEvento;
        private Label lblLugarDelEvento;
        private Label lblFechaYHoraDelEvento;
        private Label lblDescripcion;
        private Label lblNombreDelEvento;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
    }
}