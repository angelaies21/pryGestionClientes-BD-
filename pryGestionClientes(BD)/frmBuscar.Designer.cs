namespace GestionClientes_archivoCSV_
{
    partial class frmBuscar
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
            this.lblCod = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblListaCredito = new System.Windows.Forms.Label();
            this.grbDtosCli = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeudas = new System.Windows.Forms.Label();
            this.lblListasCred = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grbDtosCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(45, 41);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(137, 16);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código del cliente:";
            this.lblCod.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(285, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(47, 32);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(62, 16);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nombre";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.Location = new System.Drawing.Point(43, 78);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(53, 16);
            this.lblDeuda.TabIndex = 5;
            this.lblDeuda.Text = "Deuda";
            // 
            // lblListaCredito
            // 
            this.lblListaCredito.AutoSize = true;
            this.lblListaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCredito.Location = new System.Drawing.Point(43, 125);
            this.lblListaCredito.Name = "lblListaCredito";
            this.lblListaCredito.Size = new System.Drawing.Size(114, 16);
            this.lblListaCredito.TabIndex = 7;
            this.lblListaCredito.Text = "Lista de credito";
            // 
            // grbDtosCli
            // 
            this.grbDtosCli.Controls.Add(this.lblListasCred);
            this.grbDtosCli.Controls.Add(this.lblDeudas);
            this.grbDtosCli.Controls.Add(this.lblNombre);
            this.grbDtosCli.Controls.Add(this.lblListaCredito);
            this.grbDtosCli.Controls.Add(this.lblDeuda);
            this.grbDtosCli.Controls.Add(this.lblNom);
            this.grbDtosCli.Location = new System.Drawing.Point(25, 131);
            this.grbDtosCli.Name = "grbDtosCli";
            this.grbDtosCli.Size = new System.Drawing.Size(407, 194);
            this.grbDtosCli.TabIndex = 9;
            this.grbDtosCli.TabStop = false;
            this.grbDtosCli.Text = "Datos del cliente:";
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(198, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(165, 26);
            this.lblNombre.TabIndex = 8;
            // 
            // lblDeudas
            // 
            this.lblDeudas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudas.Location = new System.Drawing.Point(198, 69);
            this.lblDeudas.Name = "lblDeudas";
            this.lblDeudas.Size = new System.Drawing.Size(165, 26);
            this.lblDeudas.TabIndex = 9;
            // 
            // lblListasCred
            // 
            this.lblListasCred.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListasCred.Location = new System.Drawing.Point(198, 115);
            this.lblListasCred.Name = "lblListasCred";
            this.lblListasCred.Size = new System.Drawing.Size(165, 26);
            this.lblListasCred.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(216, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(159, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 363);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.grbDtosCli);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCod);
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            this.grbDtosCli.ResumeLayout(false);
            this.grbDtosCli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblListaCredito;
        private System.Windows.Forms.GroupBox grbDtosCli;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblListasCred;
        private System.Windows.Forms.Label lblDeudas;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}