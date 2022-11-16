namespace pry.IEFI.LopezValentin
{
    partial class frmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCliente));
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtNombreyApe = new System.Windows.Forms.TextBox();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.DTPFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lstSucursal = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(376, 250);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 0;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(136, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre y Apellido";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(12, 87);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(72, 16);
            this.lblActividad.TabIndex = 2;
            this.lblActividad.Text = "Actividad";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(12, 47);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 16);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(12, 128);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(132, 16);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(12, 165);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(67, 16);
            this.lblSucursal.TabIndex = 5;
            this.lblSucursal.Text = "Sucursal";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(15, 206);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(48, 16);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtNombreyApe
            // 
            this.txtNombreyApe.Location = new System.Drawing.Point(166, 9);
            this.txtNombreyApe.Name = "txtNombreyApe";
            this.txtNombreyApe.Size = new System.Drawing.Size(285, 20);
            this.txtNombreyApe.TabIndex = 7;
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(166, 47);
            this.mskDNI.Mask = "99999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(100, 20);
            this.mskDNI.TabIndex = 8;
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(166, 87);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(100, 21);
            this.lstActividad.TabIndex = 9;
            // 
            // DTPFechaNac
            // 
            this.DTPFechaNac.Location = new System.Drawing.Point(166, 128);
            this.DTPFechaNac.Name = "DTPFechaNac";
            this.DTPFechaNac.Size = new System.Drawing.Size(100, 20);
            this.DTPFechaNac.TabIndex = 10;
            // 
            // lstSucursal
            // 
            this.lstSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSucursal.FormattingEnabled = true;
            this.lstSucursal.Location = new System.Drawing.Point(166, 165);
            this.lstSucursal.Name = "lstSucursal";
            this.lstSucursal.Size = new System.Drawing.Size(100, 21);
            this.lstSucursal.TabIndex = 11;
            // 
            // txtSaldo
            // 
            this.txtSaldo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSaldo.Location = new System.Drawing.Point(166, 206);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 290);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lstSucursal);
            this.Controls.Add(this.DTPFechaNac);
            this.Controls.Add(this.lstActividad);
            this.Controls.Add(this.mskDNI);
            this.Controls.Add(this.txtNombreyApe);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmdRegistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarCliente";
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtNombreyApe;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.DateTimePicker DTPFechaNac;
        private System.Windows.Forms.ComboBox lstSucursal;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}