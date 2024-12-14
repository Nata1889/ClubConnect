namespace ClubConnect.Forms
{
    partial class FrmNuevoEvento
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
            lblNombreDelEvento = new Label();
            lblDescripcion = new Label();
            lblFechaYHoraDelEvento = new Label();
            lblLugarDelEvento = new Label();
            txtNombreDelEvento = new TextBox();
            txtDescripcion = new TextBox();
            txtFechaYHoraDelEvento = new TextBox();
            txtLugarDelEvento = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(179, 373);
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
            btnCancelar.Location = new Point(512, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombreDelEvento
            // 
            lblNombreDelEvento.AutoSize = true;
            lblNombreDelEvento.Location = new Point(179, 63);
            lblNombreDelEvento.Name = "lblNombreDelEvento";
            lblNombreDelEvento.Size = new Size(141, 20);
            lblNombreDelEvento.TabIndex = 2;
            lblNombreDelEvento.Text = "Nombre del evento:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(179, 122);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblFechaYHoraDelEvento
            // 
            lblFechaYHoraDelEvento.AutoSize = true;
            lblFechaYHoraDelEvento.Location = new Point(179, 182);
            lblFechaYHoraDelEvento.Name = "lblFechaYHoraDelEvento";
            lblFechaYHoraDelEvento.Size = new Size(169, 20);
            lblFechaYHoraDelEvento.TabIndex = 4;
            lblFechaYHoraDelEvento.Text = "Fecha y hora del evento:";
            // 
            // lblLugarDelEvento
            // 
            lblLugarDelEvento.AutoSize = true;
            lblLugarDelEvento.Location = new Point(179, 243);
            lblLugarDelEvento.Name = "lblLugarDelEvento";
            lblLugarDelEvento.Size = new Size(123, 20);
            lblLugarDelEvento.TabIndex = 5;
            lblLugarDelEvento.Text = "Lugar del evento:";
            // 
            // txtNombreDelEvento
            // 
            txtNombreDelEvento.Location = new Point(336, 60);
            txtNombreDelEvento.Name = "txtNombreDelEvento";
            txtNombreDelEvento.Size = new Size(270, 27);
            txtNombreDelEvento.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(287, 119);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(319, 27);
            txtDescripcion.TabIndex = 7;
            // 
            // txtFechaYHoraDelEvento
            // 
            txtFechaYHoraDelEvento.Location = new Point(366, 179);
            txtFechaYHoraDelEvento.Name = "txtFechaYHoraDelEvento";
            txtFechaYHoraDelEvento.Size = new Size(240, 27);
            txtFechaYHoraDelEvento.TabIndex = 8;
            // 
            // txtLugarDelEvento
            // 
            txtLugarDelEvento.Location = new Point(322, 240);
            txtLugarDelEvento.Name = "txtLugarDelEvento";
            txtLugarDelEvento.Size = new Size(284, 27);
            txtLugarDelEvento.TabIndex = 9;
            // 
            // FrmNuevoEvento
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
            Name = "FrmNuevoEvento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Evento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Label lblNombreDelEvento;
        private Label lblDescripcion;
        private Label lblFechaYHoraDelEvento;
        private Label lblLugarDelEvento;
        private TextBox txtNombreDelEvento;
        private TextBox txtDescripcion;
        private TextBox txtFechaYHoraDelEvento;
        private TextBox txtLugarDelEvento;
    }
}