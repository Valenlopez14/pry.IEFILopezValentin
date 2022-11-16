namespace pry.IEFI.LopezValentin
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPorActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusBase = new System.Windows.Forms.StatusStrip();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StatusBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoClienteToolStripMenuItem,
            this.toolStripSeparator1,
            this.buscarUnClienteToolStripMenuItem,
            this.modificaUnClienteToolStripMenuItem,
            this.toolStripSeparator2,
            this.listadoDeClientesToolStripMenuItem,
            this.listadoDeSucursalesToolStripMenuItem,
            this.listadoPorActividadToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarNuevoClienteToolStripMenuItem
            // 
            this.agregarNuevoClienteToolStripMenuItem.Name = "agregarNuevoClienteToolStripMenuItem";
            this.agregarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.agregarNuevoClienteToolStripMenuItem.Text = "Agregar nuevo cliente..";
            this.agregarNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoClienteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // buscarUnClienteToolStripMenuItem
            // 
            this.buscarUnClienteToolStripMenuItem.Name = "buscarUnClienteToolStripMenuItem";
            this.buscarUnClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.buscarUnClienteToolStripMenuItem.Text = "Buscar un cliente..";
            this.buscarUnClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarUnClienteToolStripMenuItem_Click);
            // 
            // modificaUnClienteToolStripMenuItem
            // 
            this.modificaUnClienteToolStripMenuItem.Name = "modificaUnClienteToolStripMenuItem";
            this.modificaUnClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.modificaUnClienteToolStripMenuItem.Text = "Gestiona un cliente..";
            this.modificaUnClienteToolStripMenuItem.Click += new System.EventHandler(this.modificaUnClienteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de clientes..";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // listadoDeSucursalesToolStripMenuItem
            // 
            this.listadoDeSucursalesToolStripMenuItem.Name = "listadoDeSucursalesToolStripMenuItem";
            this.listadoDeSucursalesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listadoDeSucursalesToolStripMenuItem.Text = "Listado de sucursales..";
            this.listadoDeSucursalesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSucursalesToolStripMenuItem_Click);
            // 
            // listadoPorActividadToolStripMenuItem
            // 
            this.listadoPorActividadToolStripMenuItem.Name = "listadoPorActividadToolStripMenuItem";
            this.listadoPorActividadToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listadoPorActividadToolStripMenuItem.Text = "Listado por actividad..";
            this.listadoPorActividadToolStripMenuItem.Click += new System.EventHandler(this.listadoPorActividadToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // StatusBase
            // 
            this.StatusBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFecha,
            this.lblEstado});
            this.StatusBase.Location = new System.Drawing.Point(0, 428);
            this.StatusBase.Name = "StatusBase";
            this.StatusBase.Size = new System.Drawing.Size(381, 22);
            this.StatusBase.TabIndex = 2;
            this.StatusBase.Text = "statusStrip1";
            this.StatusBase.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusBase_ItemClicked);
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(12, 17);
            this.lblFecha.Text = "-";
            this.lblFecha.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(12, 17);
            this.lblEstado.Text = "-";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.StatusBase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StatusBase.ResumeLayout(false);
            this.StatusBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem buscarUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSucursalesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusBase;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripMenuItem listadoPorActividadToolStripMenuItem;
    }
}