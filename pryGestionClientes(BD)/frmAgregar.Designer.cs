namespace GestionClientes_archivoCSV_
{
    partial class frmAgregar
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblLim = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtLim = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCargarSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(47, 62);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(91, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre y apellido";
            // 
            // lblLim
            // 
            this.lblLim.AutoSize = true;
            this.lblLim.Location = new System.Drawing.Point(36, 133);
            this.lblLim.Name = "lblLim";
            this.lblLim.Size = new System.Drawing.Size(77, 13);
            this.lblLim.TabIndex = 2;
            this.lblLim.Text = "Limite y credito";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(61, 215);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 3;
            this.lblCiudad.Text = "Ciudad";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(145, 215);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(202, 21);
            this.cmbCiudad.TabIndex = 4;
            // 
            // txtLim
            // 
            this.txtLim.Location = new System.Drawing.Point(145, 133);
            this.txtLim.Name = "txtLim";
            this.txtLim.Size = new System.Drawing.Size(152, 20);
            this.txtLim.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(145, 62);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(202, 20);
            this.txtNom.TabIndex = 6;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(242, 273);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(82, 28);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCargarSQL
            // 
            this.btnCargarSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarSQL.Location = new System.Drawing.Point(80, 273);
            this.btnCargarSQL.Name = "btnCargarSQL";
            this.btnCargarSQL.Size = new System.Drawing.Size(102, 28);
            this.btnCargarSQL.TabIndex = 8;
            this.btnCargarSQL.Text = "Cargar SQL";
            this.btnCargarSQL.UseVisualStyleBackColor = true;
            this.btnCargarSQL.Click += new System.EventHandler(this.btnCargarSQL_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 333);
            this.Controls.Add(this.btnCargarSQL);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtLim);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblLim);
            this.Controls.Add(this.lblNom);
            this.Name = "frmAgregar";
            this.Text = "frmAgregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblLim;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.TextBox txtLim;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCargarSQL;
    }
}