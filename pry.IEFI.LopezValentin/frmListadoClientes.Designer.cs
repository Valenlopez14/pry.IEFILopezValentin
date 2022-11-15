namespace pry.IEFI.LopezValentin
{
    partial class frmListadoClientes
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
            this.DgvGrilla = new System.Windows.Forms.DataGridView();
            this.cmdListarClientes = new System.Windows.Forms.Button();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotalDinero = new System.Windows.Forms.Label();
            this.lblCantidadResultado = new System.Windows.Forms.Label();
            this.lblTotalResultado = new System.Windows.Forms.Label();
            this.lblPromedioResultado = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvGrilla
            // 
            this.DgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvGrilla.Location = new System.Drawing.Point(3, 1);
            this.DgvGrilla.Name = "DgvGrilla";
            this.DgvGrilla.Size = new System.Drawing.Size(344, 302);
            this.DgvGrilla.TabIndex = 0;
            this.DgvGrilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrilla_CellContentClick);
            // 
            // cmdListarClientes
            // 
            this.cmdListarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListarClientes.Location = new System.Drawing.Point(260, 371);
            this.cmdListarClientes.Name = "cmdListarClientes";
            this.cmdListarClientes.Size = new System.Drawing.Size(75, 28);
            this.cmdListarClientes.TabIndex = 1;
            this.cmdListarClientes.Text = "Listar Clientes";
            this.cmdListarClientes.UseVisualStyleBackColor = true;
            this.cmdListarClientes.Click += new System.EventHandler(this.cmdListarClientes_Click);
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadClientes.Location = new System.Drawing.Point(13, 320);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(155, 16);
            this.lblCantidadClientes.TabIndex = 2;
            this.lblCantidadClientes.Text = "Cantidad de Clientes:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(13, 379);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(78, 16);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblTotalDinero
            // 
            this.lblTotalDinero.AutoSize = true;
            this.lblTotalDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDinero.Location = new System.Drawing.Point(13, 349);
            this.lblTotalDinero.Name = "lblTotalDinero";
            this.lblTotalDinero.Size = new System.Drawing.Size(97, 16);
            this.lblTotalDinero.TabIndex = 4;
            this.lblTotalDinero.Text = "Total Dinero:";
            // 
            // lblCantidadResultado
            // 
            this.lblCantidadResultado.AutoSize = true;
            this.lblCantidadResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadResultado.Location = new System.Drawing.Point(174, 320);
            this.lblCantidadResultado.Name = "lblCantidadResultado";
            this.lblCantidadResultado.Size = new System.Drawing.Size(15, 20);
            this.lblCantidadResultado.TabIndex = 6;
            this.lblCantidadResultado.Text = "-";
            // 
            // lblTotalResultado
            // 
            this.lblTotalResultado.AutoSize = true;
            this.lblTotalResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResultado.Location = new System.Drawing.Point(174, 351);
            this.lblTotalResultado.Name = "lblTotalResultado";
            this.lblTotalResultado.Size = new System.Drawing.Size(15, 20);
            this.lblTotalResultado.TabIndex = 7;
            this.lblTotalResultado.Text = "-";
            // 
            // lblPromedioResultado
            // 
            this.lblPromedioResultado.AutoSize = true;
            this.lblPromedioResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioResultado.Location = new System.Drawing.Point(174, 379);
            this.lblPromedioResultado.Name = "lblPromedioResultado";
            this.lblPromedioResultado.Size = new System.Drawing.Size(15, 20);
            this.lblPromedioResultado.TabIndex = 8;
            this.lblPromedioResultado.Text = "-";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Documento";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Saldo";
            this.Column3.Name = "Column3";
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 411);
            this.Controls.Add(this.lblPromedioResultado);
            this.Controls.Add(this.lblTotalResultado);
            this.Controls.Add(this.lblCantidadResultado);
            this.Controls.Add(this.lblTotalDinero);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblCantidadClientes);
            this.Controls.Add(this.cmdListarClientes);
            this.Controls.Add(this.DgvGrilla);
            this.Name = "frmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListadoClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvGrilla;
        private System.Windows.Forms.Button cmdListarClientes;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotalDinero;
        private System.Windows.Forms.Label lblCantidadResultado;
        private System.Windows.Forms.Label lblTotalResultado;
        private System.Windows.Forms.Label lblPromedioResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}