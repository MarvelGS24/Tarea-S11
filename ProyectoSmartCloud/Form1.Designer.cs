
namespace ProyectoSmartCloud
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresarImpuesto = new System.Windows.Forms.Button();
            this.btnCalcularFacturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.Location = new System.Drawing.Point(50, 74);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(145, 23);
            this.btnIngresarCliente.TabIndex = 2;
            this.btnIngresarCliente.Text = "Ingresar Cliente";
            this.btnIngresarCliente.UseVisualStyleBackColor = true;
            this.btnIngresarCliente.Click += new System.EventHandler(this.btnIngresarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Smart Cloud";
            // 
            // btnIngresarImpuesto
            // 
            this.btnIngresarImpuesto.Location = new System.Drawing.Point(50, 113);
            this.btnIngresarImpuesto.Name = "btnIngresarImpuesto";
            this.btnIngresarImpuesto.Size = new System.Drawing.Size(145, 23);
            this.btnIngresarImpuesto.TabIndex = 4;
            this.btnIngresarImpuesto.Text = "Ingresar Impuesto";
            this.btnIngresarImpuesto.UseVisualStyleBackColor = true;
            // 
            // btnCalcularFacturas
            // 
            this.btnCalcularFacturas.Location = new System.Drawing.Point(50, 152);
            this.btnCalcularFacturas.Name = "btnCalcularFacturas";
            this.btnCalcularFacturas.Size = new System.Drawing.Size(145, 23);
            this.btnCalcularFacturas.TabIndex = 5;
            this.btnCalcularFacturas.Text = "Calcular Facturas";
            this.btnCalcularFacturas.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 222);
            this.Controls.Add(this.btnCalcularFacturas);
            this.Controls.Add(this.btnIngresarImpuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresarCliente);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarImpuesto;
        private System.Windows.Forms.Button btnCalcularFacturas;
    }
}

