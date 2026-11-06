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
            this.lblTitNombre = new System.Windows.Forms.Label();
            this.lblTitDeuda = new System.Windows.Forms.Label();
            this.lblTitLimite = new System.Windows.Forms.Label();
            this.grbDtosCli = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbDtosCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(60, 50);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(166, 20);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código del cliente:";
            this.lblCod.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(379, 103);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 37);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitNombre
            // 
            this.lblTitNombre.AutoSize = true;
            this.lblTitNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitNombre.Location = new System.Drawing.Point(63, 39);
            this.lblTitNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitNombre.Name = "lblTitNombre";
            this.lblTitNombre.Size = new System.Drawing.Size(74, 20);
            this.lblTitNombre.TabIndex = 3;
            this.lblTitNombre.Text = "Nombre";
            // 
            // lblTitDeuda
            // 
            this.lblTitDeuda.AutoSize = true;
            this.lblTitDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitDeuda.Location = new System.Drawing.Point(57, 96);
            this.lblTitDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitDeuda.Name = "lblTitDeuda";
            this.lblTitDeuda.Size = new System.Drawing.Size(63, 20);
            this.lblTitDeuda.TabIndex = 5;
            this.lblTitDeuda.Text = "Deuda";
            // 
            // lblTitLimite
            // 
            this.lblTitLimite.AutoSize = true;
            this.lblTitLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitLimite.Location = new System.Drawing.Point(57, 154);
            this.lblTitLimite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitLimite.Name = "lblTitLimite";
            this.lblTitLimite.Size = new System.Drawing.Size(151, 20);
            this.lblTitLimite.TabIndex = 7;
            this.lblTitLimite.Text = "Limite de credito";
            // 
            // grbDtosCli
            // 
            this.grbDtosCli.BackColor = System.Drawing.Color.LavenderBlush;
            this.grbDtosCli.Controls.Add(this.lblNombre);
            this.grbDtosCli.Controls.Add(this.txtLimite);
            this.grbDtosCli.Controls.Add(this.lblDeuda);
            this.grbDtosCli.Controls.Add(this.lblTitLimite);
            this.grbDtosCli.Controls.Add(this.lblTitDeuda);
            this.grbDtosCli.Controls.Add(this.lblTitNombre);
            this.grbDtosCli.Location = new System.Drawing.Point(33, 161);
            this.grbDtosCli.Margin = new System.Windows.Forms.Padding(4);
            this.grbDtosCli.Name = "grbDtosCli";
            this.grbDtosCli.Padding = new System.Windows.Forms.Padding(4);
            this.grbDtosCli.Size = new System.Drawing.Size(543, 239);
            this.grbDtosCli.TabIndex = 9;
            this.grbDtosCli.TabStop = false;
            this.grbDtosCli.Text = "Datos del cliente:";
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(247, 39);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(220, 32);
            this.lblNombre.TabIndex = 13;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(247, 154);
            this.txtLimite.Margin = new System.Windows.Forms.Padding(4);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(212, 22);
            this.txtLimite.TabIndex = 12;
            this.txtLimite.TextChanged += new System.EventHandler(this.txtLimite_TextChanged);
            // 
            // lblDeuda
            // 
            this.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeuda.Location = new System.Drawing.Point(247, 96);
            this.lblDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(220, 32);
            this.lblDeuda.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(267, 48);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(233, 22);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(40, 428);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 33);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(231, 428);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 33);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(425, 428);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 33);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(628, 500);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.grbDtosCli);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCod);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.grbDtosCli.ResumeLayout(false);
            this.grbDtosCli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitNombre;
        private System.Windows.Forms.Label lblTitDeuda;
        private System.Windows.Forms.Label lblTitLimite;
        private System.Windows.Forms.GroupBox grbDtosCli;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label lblDeuda;
    }
}