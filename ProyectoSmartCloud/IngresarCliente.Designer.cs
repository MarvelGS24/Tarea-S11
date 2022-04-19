
namespace ProyectoSmartCloud
{
    partial class IngresarCliente
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.chkTipoNacional = new System.Windows.Forms.CheckBox();
            this.chkTipoExtranjero = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 154);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Cliente";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(46, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 15);
            label2.TabIndex = 1;
            label2.Text = "Identificación Tributaria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(46, 212);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo Servicio ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(46, 271);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Tipo de Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(99, 27);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(289, 32);
            label5.TabIndex = 10;
            label5.Text = "Menu Ingreso de Clientes";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(128, 309);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(199, 41);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(191, 146);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(216, 23);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(191, 90);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(216, 23);
            this.txtIdentificacion.TabIndex = 6;
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.DisplayMember = "1,2,3";
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Items.AddRange(new object[] {
            "Premium",
            "Golden",
            "Bronce"});
            this.cmbTipoServicio.Location = new System.Drawing.Point(191, 209);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(216, 23);
            this.cmbTipoServicio.TabIndex = 7;
            this.cmbTipoServicio.ValueMember = "1,2,3";
            // 
            // chkTipoNacional
            // 
            this.chkTipoNacional.AutoSize = true;
            this.chkTipoNacional.Location = new System.Drawing.Point(191, 270);
            this.chkTipoNacional.Name = "chkTipoNacional";
            this.chkTipoNacional.Size = new System.Drawing.Size(73, 19);
            this.chkTipoNacional.TabIndex = 8;
            this.chkTipoNacional.Text = "Nacional";
            this.chkTipoNacional.UseVisualStyleBackColor = true;
            this.chkTipoNacional.CheckedChanged += new System.EventHandler(this.chkTipoNacional_CheckedChanged);
            // 
            // chkTipoExtranjero
            // 
            this.chkTipoExtranjero.AutoSize = true;
            this.chkTipoExtranjero.Location = new System.Drawing.Point(328, 269);
            this.chkTipoExtranjero.Name = "chkTipoExtranjero";
            this.chkTipoExtranjero.Size = new System.Drawing.Size(79, 19);
            this.chkTipoExtranjero.TabIndex = 9;
            this.chkTipoExtranjero.Text = "Extranjero";
            this.chkTipoExtranjero.UseVisualStyleBackColor = true;
            this.chkTipoExtranjero.CheckedChanged += new System.EventHandler(this.chkTipoExtranjero_CheckedChanged);
            // 
            // IngresarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 374);
            this.Controls.Add(label5);
            this.Controls.Add(this.chkTipoExtranjero);
            this.Controls.Add(this.chkTipoNacional);
            this.Controls.Add(this.cmbTipoServicio);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "IngresarCliente";
            this.Text = "IngresarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.CheckBox chkTipoNacional;
        private System.Windows.Forms.CheckBox chkTipoExtranjero;
    }
}