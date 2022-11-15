namespace pry.IEFI.LopezValentin
{
    partial class frmBuscarCliente
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
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtNombreyApell = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.mrcClientes = new System.Windows.Forms.GroupBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lstSucursal = new System.Windows.Forms.ComboBox();
            this.mrcClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(133, 104);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 17;
            // 
            // txtNombreyApell
            // 
            this.txtNombreyApell.Location = new System.Drawing.Point(133, 34);
            this.txtNombreyApell.Name = "txtNombreyApell";
            this.txtNombreyApell.ReadOnly = true;
            this.txtNombreyApell.Size = new System.Drawing.Size(176, 20);
            this.txtNombreyApell.TabIndex = 15;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(130, 12);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 14;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(11, 103);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Saldo";
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(11, 70);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(48, 13);
            this.lblSucursal.TabIndex = 12;
            this.lblSucursal.Text = "Sucursal";
            this.lblSucursal.Click += new System.EventHandler(this.lblSucursal_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(17, 12);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 11;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre y Apellido";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(243, 254);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 9;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // mrcClientes
            // 
            this.mrcClientes.Controls.Add(this.lstActividad);
            this.mrcClientes.Controls.Add(this.lblActividad);
            this.mrcClientes.Controls.Add(this.txtDocumento);
            this.mrcClientes.Controls.Add(this.lblDocumento);
            this.mrcClientes.Controls.Add(this.lstSucursal);
            this.mrcClientes.Controls.Add(this.txtNombreyApell);
            this.mrcClientes.Controls.Add(this.txtSaldo);
            this.mrcClientes.Controls.Add(this.lblNombre);
            this.mrcClientes.Controls.Add(this.lblSucursal);
            this.mrcClientes.Controls.Add(this.lblSaldo);
            this.mrcClientes.Location = new System.Drawing.Point(12, 38);
            this.mrcClientes.Name = "mrcClientes";
            this.mrcClientes.Size = new System.Drawing.Size(315, 204);
            this.mrcClientes.TabIndex = 18;
            this.mrcClientes.TabStop = false;
            this.mrcClientes.Text = "Datos";
            // 
            // lstActividad
            // 
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(133, 171);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(100, 21);
            this.lstActividad.TabIndex = 22;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(11, 171);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 21;
            this.lblActividad.Text = "Actividad";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(133, 137);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 20;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(11, 137);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 19;
            this.lblDocumento.Text = "Documento";
            // 
            // lstSucursal
            // 
            this.lstSucursal.FormattingEnabled = true;
            this.lstSucursal.Location = new System.Drawing.Point(133, 70);
            this.lstSucursal.Name = "lstSucursal";
            this.lstSucursal.Size = new System.Drawing.Size(100, 21);
            this.lstSucursal.TabIndex = 18;
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 289);
            this.Controls.Add(this.mrcClientes);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.cmdBuscar);
            this.Name = "frmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarCliente";
            this.Load += new System.EventHandler(this.frmBuscarCliente_Load);
            this.mrcClientes.ResumeLayout(false);
            this.mrcClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtNombreyApell;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.GroupBox mrcClientes;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.ComboBox lstSucursal;
    }
}