namespace pry.IEFI.LopezValentin
{
    partial class frmUsuario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblContactoDetalle = new System.Windows.Forms.Label();
            this.lblnombre2 = new System.Windows.Forms.Label();
            this.lblContacto3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(4, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(4, 45);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(87, 20);
            this.lblContacto.TabIndex = 1;
            this.lblContacto.Text = "Contacto:";
            // 
            // lblContactoDetalle
            // 
            this.lblContactoDetalle.AutoSize = true;
            this.lblContactoDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactoDetalle.Location = new System.Drawing.Point(97, 45);
            this.lblContactoDetalle.Name = "lblContactoDetalle";
            this.lblContactoDetalle.Size = new System.Drawing.Size(221, 20);
            this.lblContactoDetalle.TabIndex = 2;
            this.lblContactoDetalle.Text = "lopezvalen141@gmail.com";
            // 
            // lblnombre2
            // 
            this.lblnombre2.AutoSize = true;
            this.lblnombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre2.Location = new System.Drawing.Point(97, 9);
            this.lblnombre2.Name = "lblnombre2";
            this.lblnombre2.Size = new System.Drawing.Size(192, 20);
            this.lblnombre2.TabIndex = 3;
            this.lblnombre2.Text = "Lopez, Valentin Ruben";
            // 
            // lblContacto3
            // 
            this.lblContacto3.AutoSize = true;
            this.lblContacto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto3.Location = new System.Drawing.Point(97, 77);
            this.lblContacto3.Name = "lblContacto3";
            this.lblContacto3.Size = new System.Drawing.Size(189, 20);
            this.lblContacto3.TabIndex = 4;
            this.lblContacto3.Text = "Telefono: 3472500274";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(351, 110);
            this.Controls.Add(this.lblContacto3);
            this.Controls.Add(this.lblnombre2);
            this.Controls.Add(this.lblContactoDetalle);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblContactoDetalle;
        private System.Windows.Forms.Label lblnombre2;
        private System.Windows.Forms.Label lblContacto3;
    }
}