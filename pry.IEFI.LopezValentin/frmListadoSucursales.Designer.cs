namespace pry.IEFI.LopezValentin
{
    partial class frmListadoSucursales
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
            this.dgvListadoSucursales = new System.Windows.Forms.DataGridView();
            this.cmdListarSucursales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoSucursales
            // 
            this.dgvListadoSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoSucursales.Location = new System.Drawing.Point(1, 1);
            this.dgvListadoSucursales.Name = "dgvListadoSucursales";
            this.dgvListadoSucursales.Size = new System.Drawing.Size(241, 280);
            this.dgvListadoSucursales.TabIndex = 0;
            // 
            // cmdListarSucursales
            // 
            this.cmdListarSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListarSucursales.Location = new System.Drawing.Point(157, 287);
            this.cmdListarSucursales.Name = "cmdListarSucursales";
            this.cmdListarSucursales.Size = new System.Drawing.Size(75, 23);
            this.cmdListarSucursales.TabIndex = 1;
            this.cmdListarSucursales.Text = "Listar";
            this.cmdListarSucursales.UseVisualStyleBackColor = true;
            this.cmdListarSucursales.Click += new System.EventHandler(this.cmdListarSucursales_Click);
            // 
            // frmListadoSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 320);
            this.Controls.Add(this.cmdListarSucursales);
            this.Controls.Add(this.dgvListadoSucursales);
            this.Name = "frmListadoSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSucursales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoSucursales;
        private System.Windows.Forms.Button cmdListarSucursales;
    }
}