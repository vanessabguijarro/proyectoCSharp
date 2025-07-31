namespace Proyecto_Facturacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEmitirFactura = new System.Windows.Forms.Button();
            this.lbxMeses = new System.Windows.Forms.ListBox();
            this.lbxClientes = new System.Windows.Forms.ListBox();
            this.rtbPlantilla = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbxClientes2 = new System.Windows.Forms.ListBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblAvisos = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAltaEmpresa = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTfEmpresa = new System.Windows.Forms.Label();
            this.lblCPostalEmpresa = new System.Windows.Forms.Label();
            this.lblCiudadEmpresa = new System.Windows.Forms.Label();
            this.lblDireccionEmpresa = new System.Windows.Forms.Label();
            this.lblNifEmpresa = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1108, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEmitirFactura);
            this.tabPage1.Controls.Add(this.lbxMeses);
            this.tabPage1.Controls.Add(this.lbxClientes);
            this.tabPage1.Controls.Add(this.rtbPlantilla);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emitir Facturas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEmitirFactura
            // 
            this.btnEmitirFactura.Location = new System.Drawing.Point(798, 6);
            this.btnEmitirFactura.Name = "btnEmitirFactura";
            this.btnEmitirFactura.Size = new System.Drawing.Size(136, 69);
            this.btnEmitirFactura.TabIndex = 4;
            this.btnEmitirFactura.Text = "Emitir factura";
            this.btnEmitirFactura.UseVisualStyleBackColor = true;
            this.btnEmitirFactura.Click += new System.EventHandler(this.btnEmitirFactura_Click);
            // 
            // lbxMeses
            // 
            this.lbxMeses.FormattingEnabled = true;
            this.lbxMeses.ItemHeight = 20;
            this.lbxMeses.Location = new System.Drawing.Point(798, 305);
            this.lbxMeses.Name = "lbxMeses";
            this.lbxMeses.Size = new System.Drawing.Size(136, 204);
            this.lbxMeses.TabIndex = 3;
            this.lbxMeses.SelectedIndexChanged += new System.EventHandler(this.lbxMeses_SelectedIndexChanged);
            // 
            // lbxClientes
            // 
            this.lbxClientes.FormattingEnabled = true;
            this.lbxClientes.ItemHeight = 20;
            this.lbxClientes.Location = new System.Drawing.Point(798, 104);
            this.lbxClientes.Name = "lbxClientes";
            this.lbxClientes.Size = new System.Drawing.Size(136, 184);
            this.lbxClientes.TabIndex = 2;
            this.lbxClientes.SelectedIndexChanged += new System.EventHandler(this.lbxClientes_SelectedIndexChanged);
            // 
            // rtbPlantilla
            // 
            this.rtbPlantilla.Location = new System.Drawing.Point(6, 6);
            this.rtbPlantilla.Name = "rtbPlantilla";
            this.rtbPlantilla.Size = new System.Drawing.Size(753, 601);
            this.rtbPlantilla.TabIndex = 0;
            this.rtbPlantilla.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbxClientes2);
            this.tabPage2.Controls.Add(this.txtProvincia);
            this.tabPage2.Controls.Add(this.lblProvincia);
            this.tabPage2.Controls.Add(this.lblAvisos);
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.btnAltaEmpresa);
            this.tabPage2.Controls.Add(this.lblEmail);
            this.tabPage2.Controls.Add(this.lblTfEmpresa);
            this.tabPage2.Controls.Add(this.lblCPostalEmpresa);
            this.tabPage2.Controls.Add(this.lblCiudadEmpresa);
            this.tabPage2.Controls.Add(this.lblDireccionEmpresa);
            this.tabPage2.Controls.Add(this.lblNifEmpresa);
            this.tabPage2.Controls.Add(this.lblNombreEmpresa);
            this.tabPage2.Controls.Add(this.txtCorreoElectronico);
            this.tabPage2.Controls.Add(this.txtTelefono);
            this.tabPage2.Controls.Add(this.txtCodigoPostal);
            this.tabPage2.Controls.Add(this.txtCiudad);
            this.tabPage2.Controls.Add(this.txtDireccion);
            this.tabPage2.Controls.Add(this.txtNif);
            this.tabPage2.Controls.Add(this.txtNombreEmpresa);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alta Empresa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbxClientes2
            // 
            this.lbxClientes2.FormattingEnabled = true;
            this.lbxClientes2.ItemHeight = 20;
            this.lbxClientes2.Location = new System.Drawing.Point(611, 127);
            this.lbxClientes2.Name = "lbxClientes2";
            this.lbxClientes2.Size = new System.Drawing.Size(145, 164);
            this.lbxClientes2.TabIndex = 20;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(33, 247);
            this.txtProvincia.MaxLength = 30;
            this.txtProvincia.Multiline = true;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(280, 25);
            this.txtProvincia.TabIndex = 5;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(29, 224);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(76, 20);
            this.lblProvincia.TabIndex = 19;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblAvisos
            // 
            this.lblAvisos.AutoSize = true;
            this.lblAvisos.BackColor = System.Drawing.Color.White;
            this.lblAvisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisos.ForeColor = System.Drawing.Color.Red;
            this.lblAvisos.Location = new System.Drawing.Point(29, 389);
            this.lblAvisos.Name = "lblAvisos";
            this.lblAvisos.Size = new System.Drawing.Size(368, 20);
            this.lblAvisos.TabIndex = 18;
            this.lblAvisos.Text = "AVISO: Debe cubrir todos los datos, gracias.";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Snow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Location = new System.Drawing.Point(611, 335);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 74);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnAltaEmpresa
            // 
            this.btnAltaEmpresa.BackColor = System.Drawing.Color.Snow;
            this.btnAltaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAltaEmpresa.Location = new System.Drawing.Point(611, 35);
            this.btnAltaEmpresa.Name = "btnAltaEmpresa";
            this.btnAltaEmpresa.Size = new System.Drawing.Size(145, 74);
            this.btnAltaEmpresa.TabIndex = 8;
            this.btnAltaEmpresa.Text = "ALTA EMPRESA";
            this.btnAltaEmpresa.UseVisualStyleBackColor = false;
            this.btnAltaEmpresa.Click += new System.EventHandler(this.btnAltaEmpresa_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(29, 302);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(144, 20);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Correo Electrónico:";
            // 
            // lblTfEmpresa
            // 
            this.lblTfEmpresa.AutoSize = true;
            this.lblTfEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTfEmpresa.Location = new System.Drawing.Point(346, 74);
            this.lblTfEmpresa.Name = "lblTfEmpresa";
            this.lblTfEmpresa.Size = new System.Drawing.Size(75, 20);
            this.lblTfEmpresa.TabIndex = 14;
            this.lblTfEmpresa.Text = "Teléfono:";
            // 
            // lblCPostalEmpresa
            // 
            this.lblCPostalEmpresa.AutoSize = true;
            this.lblCPostalEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPostalEmpresa.Location = new System.Drawing.Point(345, 224);
            this.lblCPostalEmpresa.Name = "lblCPostalEmpresa";
            this.lblCPostalEmpresa.Size = new System.Drawing.Size(111, 20);
            this.lblCPostalEmpresa.TabIndex = 13;
            this.lblCPostalEmpresa.Text = "Código Postal:";
            // 
            // lblCiudadEmpresa
            // 
            this.lblCiudadEmpresa.AutoSize = true;
            this.lblCiudadEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadEmpresa.Location = new System.Drawing.Point(346, 146);
            this.lblCiudadEmpresa.Name = "lblCiudadEmpresa";
            this.lblCiudadEmpresa.Size = new System.Drawing.Size(63, 20);
            this.lblCiudadEmpresa.TabIndex = 12;
            this.lblCiudadEmpresa.Text = "Ciudad:";
            // 
            // lblDireccionEmpresa
            // 
            this.lblDireccionEmpresa.AutoSize = true;
            this.lblDireccionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionEmpresa.Location = new System.Drawing.Point(29, 146);
            this.lblDireccionEmpresa.Name = "lblDireccionEmpresa";
            this.lblDireccionEmpresa.Size = new System.Drawing.Size(79, 20);
            this.lblDireccionEmpresa.TabIndex = 11;
            this.lblDireccionEmpresa.Text = "Dirección:";
            // 
            // lblNifEmpresa
            // 
            this.lblNifEmpresa.AutoSize = true;
            this.lblNifEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNifEmpresa.Location = new System.Drawing.Point(29, 74);
            this.lblNifEmpresa.Name = "lblNifEmpresa";
            this.lblNifEmpresa.Size = new System.Drawing.Size(32, 20);
            this.lblNifEmpresa.TabIndex = 10;
            this.lblNifEmpresa.Text = "Nif:";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(29, 12);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(69, 20);
            this.lblNombreEmpresa.TabIndex = 9;
            this.lblNombreEmpresa.Text = "Nombre:";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(33, 325);
            this.txtCorreoElectronico.MaxLength = 50;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(462, 26);
            this.txtCorreoElectronico.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(350, 97);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(145, 26);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(349, 247);
            this.txtCodigoPostal.MaxLength = 5;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(146, 26);
            this.txtCodigoPostal.TabIndex = 6;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(350, 169);
            this.txtCiudad.MaxLength = 50;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(145, 26);
            this.txtCiudad.TabIndex = 4;
            this.txtCiudad.TextChanged += new System.EventHandler(this.txtCiudad_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(33, 169);
            this.txtDireccion.MaxLength = 80;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(280, 26);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtNif
            // 
            this.txtNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Location = new System.Drawing.Point(33, 97);
            this.txtNif.MaxLength = 9;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(123, 26);
            this.txtNif.TabIndex = 1;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.Location = new System.Drawing.Point(33, 35);
            this.txtNombreEmpresa.MaxLength = 50;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(462, 26);
            this.txtNombreEmpresa.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1100, 641);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Buscar Facturas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 667);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAltaEmpresa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTfEmpresa;
        private System.Windows.Forms.Label lblCPostalEmpresa;
        private System.Windows.Forms.Label lblCiudadEmpresa;
        private System.Windows.Forms.Label lblDireccionEmpresa;
        private System.Windows.Forms.Label lblNifEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblAvisos;
        private System.Windows.Forms.ListBox lbxClientes2;
        private System.Windows.Forms.RichTextBox rtbPlantilla;
        private System.Windows.Forms.ListBox lbxClientes;
        private System.Windows.Forms.ListBox lbxMeses;
        private System.Windows.Forms.Button btnEmitirFactura;
    }
}

