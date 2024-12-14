namespace ClubConnect
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            socioToolStripMenuItem = new ToolStripMenuItem();
            administrarSociosToolStripMenuItem = new ToolStripMenuItem();
            membresíaToolStripMenuItem = new ToolStripMenuItem();
            administrarMembresíasToolStripMenuItem = new ToolStripMenuItem();
            instalaciónToolStripMenuItem = new ToolStripMenuItem();
            administrarInstalacionesToolStripMenuItem = new ToolStripMenuItem();
            reservaToolStripMenuItem = new ToolStripMenuItem();
            administarReservasToolStripMenuItem = new ToolStripMenuItem();
            eventoToolStripMenuItem = new ToolStripMenuItem();
            administarEventosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            listadoDeSociosToolStripMenuItem = new ToolStripMenuItem();
            listadoDeMembresíasToolStripMenuItem = new ToolStripMenuItem();
            listadoDeInstalacionesToolStripMenuItem = new ToolStripMenuItem();
            listadoDeReservasToolStripMenuItem = new ToolStripMenuItem();
            metodosDePagoToolStripMenuItem = new ToolStripMenuItem();
            mercadoPagoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            listadoDeEventosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, metodosDePagoToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { socioToolStripMenuItem, membresíaToolStripMenuItem, instalaciónToolStripMenuItem, reservaToolStripMenuItem, eventoToolStripMenuItem, toolStripSeparator1, listadoDeSociosToolStripMenuItem, listadoDeMembresíasToolStripMenuItem, listadoDeInstalacionesToolStripMenuItem, listadoDeReservasToolStripMenuItem, listadoDeEventosToolStripMenuItem });
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(80, 24);
            principalToolStripMenuItem.Text = "Principal";
            // 
            // socioToolStripMenuItem
            // 
            socioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarSociosToolStripMenuItem });
            socioToolStripMenuItem.Name = "socioToolStripMenuItem";
            socioToolStripMenuItem.Size = new Size(250, 26);
            socioToolStripMenuItem.Text = "Socio";
            // 
            // administrarSociosToolStripMenuItem
            // 
            administrarSociosToolStripMenuItem.Name = "administrarSociosToolStripMenuItem";
            administrarSociosToolStripMenuItem.Size = new Size(214, 26);
            administrarSociosToolStripMenuItem.Text = "Administrar socios";
            administrarSociosToolStripMenuItem.Click += administrarSociosToolStripMenuItem_Click;
            // 
            // membresíaToolStripMenuItem
            // 
            membresíaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarMembresíasToolStripMenuItem });
            membresíaToolStripMenuItem.Name = "membresíaToolStripMenuItem";
            membresíaToolStripMenuItem.Size = new Size(250, 26);
            membresíaToolStripMenuItem.Text = "Membresía";
            // 
            // administrarMembresíasToolStripMenuItem
            // 
            administrarMembresíasToolStripMenuItem.Name = "administrarMembresíasToolStripMenuItem";
            administrarMembresíasToolStripMenuItem.Size = new Size(253, 26);
            administrarMembresíasToolStripMenuItem.Text = "Administrar membresías";
            administrarMembresíasToolStripMenuItem.Click += administrarMembresíasToolStripMenuItem_Click;
            // 
            // instalaciónToolStripMenuItem
            // 
            instalaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarInstalacionesToolStripMenuItem });
            instalaciónToolStripMenuItem.Name = "instalaciónToolStripMenuItem";
            instalaciónToolStripMenuItem.Size = new Size(250, 26);
            instalaciónToolStripMenuItem.Text = "Instalación";
            // 
            // administrarInstalacionesToolStripMenuItem
            // 
            administrarInstalacionesToolStripMenuItem.Name = "administrarInstalacionesToolStripMenuItem";
            administrarInstalacionesToolStripMenuItem.Size = new Size(258, 26);
            administrarInstalacionesToolStripMenuItem.Text = "Administrar Instalaciones";
            administrarInstalacionesToolStripMenuItem.Click += administrarInstalacionesToolStripMenuItem_Click;
            // 
            // reservaToolStripMenuItem
            // 
            reservaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administarReservasToolStripMenuItem });
            reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            reservaToolStripMenuItem.Size = new Size(250, 26);
            reservaToolStripMenuItem.Text = "Reserva";
            // 
            // administarReservasToolStripMenuItem
            // 
            administarReservasToolStripMenuItem.Name = "administarReservasToolStripMenuItem";
            administarReservasToolStripMenuItem.Size = new Size(221, 26);
            administarReservasToolStripMenuItem.Text = "Administar reservas";
            administarReservasToolStripMenuItem.Click += administarReservasToolStripMenuItem_Click;
            // 
            // eventoToolStripMenuItem
            // 
            eventoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administarEventosToolStripMenuItem });
            eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            eventoToolStripMenuItem.Size = new Size(250, 26);
            eventoToolStripMenuItem.Text = "Evento";
            // 
            // administarEventosToolStripMenuItem
            // 
            administarEventosToolStripMenuItem.Name = "administarEventosToolStripMenuItem";
            administarEventosToolStripMenuItem.Size = new Size(219, 26);
            administarEventosToolStripMenuItem.Text = "Administar eventos";
            administarEventosToolStripMenuItem.Click += administarEventosToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(247, 6);
            // 
            // listadoDeSociosToolStripMenuItem
            // 
            listadoDeSociosToolStripMenuItem.Name = "listadoDeSociosToolStripMenuItem";
            listadoDeSociosToolStripMenuItem.Size = new Size(250, 26);
            listadoDeSociosToolStripMenuItem.Text = "Listado de Socios";
            listadoDeSociosToolStripMenuItem.Click += listadoDeSociosToolStripMenuItem_Click;
            // 
            // listadoDeMembresíasToolStripMenuItem
            // 
            listadoDeMembresíasToolStripMenuItem.Name = "listadoDeMembresíasToolStripMenuItem";
            listadoDeMembresíasToolStripMenuItem.Size = new Size(250, 26);
            listadoDeMembresíasToolStripMenuItem.Text = "Listado de Membresías";
            listadoDeMembresíasToolStripMenuItem.Click += listadoDeMembresíasToolStripMenuItem_Click;
            // 
            // listadoDeInstalacionesToolStripMenuItem
            // 
            listadoDeInstalacionesToolStripMenuItem.Name = "listadoDeInstalacionesToolStripMenuItem";
            listadoDeInstalacionesToolStripMenuItem.Size = new Size(250, 26);
            listadoDeInstalacionesToolStripMenuItem.Text = "Listado de Instalaciones";
            listadoDeInstalacionesToolStripMenuItem.Click += listadoDeInstalacionesToolStripMenuItem_Click;
            // 
            // listadoDeReservasToolStripMenuItem
            // 
            listadoDeReservasToolStripMenuItem.Name = "listadoDeReservasToolStripMenuItem";
            listadoDeReservasToolStripMenuItem.Size = new Size(250, 26);
            listadoDeReservasToolStripMenuItem.Text = "Listado de Reservas";
            listadoDeReservasToolStripMenuItem.Click += listadoDeReservasToolStripMenuItem_Click;
            // 
            // metodosDePagoToolStripMenuItem
            // 
            metodosDePagoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mercadoPagoToolStripMenuItem });
            metodosDePagoToolStripMenuItem.Name = "metodosDePagoToolStripMenuItem";
            metodosDePagoToolStripMenuItem.Size = new Size(144, 24);
            metodosDePagoToolStripMenuItem.Text = "Metodos de Pago ";
            // 
            // mercadoPagoToolStripMenuItem
            // 
            mercadoPagoToolStripMenuItem.Name = "mercadoPagoToolStripMenuItem";
            mercadoPagoToolStripMenuItem.Size = new Size(188, 26);
            mercadoPagoToolStripMenuItem.Text = "Mercado Pago";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, salirToolStripMenuItem1 });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(200, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de ...";
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(200, 26);
            salirToolStripMenuItem1.Text = "Salir del sistema";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // listadoDeEventosToolStripMenuItem
            // 
            listadoDeEventosToolStripMenuItem.Name = "listadoDeEventosToolStripMenuItem";
            listadoDeEventosToolStripMenuItem.Size = new Size(250, 26);
            listadoDeEventosToolStripMenuItem.Text = "Listado de Eventos";
            listadoDeEventosToolStripMenuItem.Click += listadoDeEventosToolStripMenuItem_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuPrincipal";
            Text = "ClubConnect";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem socioToolStripMenuItem;
        private ToolStripMenuItem administrarSociosToolStripMenuItem;
        private ToolStripMenuItem membresíaToolStripMenuItem;
        private ToolStripMenuItem administrarMembresíasToolStripMenuItem;
        private ToolStripMenuItem instalaciónToolStripMenuItem;
        private ToolStripMenuItem administrarInstalacionesToolStripMenuItem;
        private ToolStripMenuItem reservaToolStripMenuItem;
        private ToolStripMenuItem administarReservasToolStripMenuItem;
        private ToolStripMenuItem eventoToolStripMenuItem;
        private ToolStripMenuItem administarEventosToolStripMenuItem;
        private ToolStripMenuItem metodosDePagoToolStripMenuItem;
        private ToolStripMenuItem mercadoPagoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem listadoDeSociosToolStripMenuItem;
        private ToolStripMenuItem listadoDeMembresíasToolStripMenuItem;
        private ToolStripMenuItem listadoDeInstalacionesToolStripMenuItem;
        private ToolStripMenuItem listadoDeReservasToolStripMenuItem;
        private ToolStripMenuItem listadoDeEventosToolStripMenuItem;
    }
}