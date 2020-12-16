namespace Tarea5MATRIZ
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstImporte = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstCantidad = new System.Windows.Forms.ListBox();
            this.lstPrecio = new System.Windows.Forms.ListBox();
            this.lstNombre = new System.Windows.Forms.ListBox();
            this.l = new System.Windows.Forms.Label();
            this.lstDia = new System.Windows.Forms.ListBox();
            this.lstSucursal = new System.Windows.Forms.ListBox();
            this.btnSucursal = new System.Windows.Forms.Button();
            this.btnDia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(68, 156);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(57, 23);
            this.btnCargar.TabIndex = 29;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(258, 130);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(57, 20);
            this.txtImporte.TabIndex = 28;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(136, 129);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 20);
            this.txtCantidad.TabIndex = 27;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(68, 130);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(57, 20);
            this.txtPrecio.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(5, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(57, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Importe";
            // 
            // lstImporte
            // 
            this.lstImporte.FormattingEnabled = true;
            this.lstImporte.Location = new System.Drawing.Point(258, 28);
            this.lstImporte.Name = "lstImporte";
            this.lstImporte.Size = new System.Drawing.Size(60, 95);
            this.lstImporte.TabIndex = 21;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(200, 59);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(52, 23);
            this.btnCalcular.TabIndex = 20;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // lstCantidad
            // 
            this.lstCantidad.FormattingEnabled = true;
            this.lstCantidad.Location = new System.Drawing.Point(133, 28);
            this.lstCantidad.Name = "lstCantidad";
            this.lstCantidad.Size = new System.Drawing.Size(60, 95);
            this.lstCantidad.TabIndex = 19;
            // 
            // lstPrecio
            // 
            this.lstPrecio.FormattingEnabled = true;
            this.lstPrecio.Location = new System.Drawing.Point(68, 28);
            this.lstPrecio.Name = "lstPrecio";
            this.lstPrecio.Size = new System.Drawing.Size(60, 95);
            this.lstPrecio.TabIndex = 18;
            // 
            // lstNombre
            // 
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.Location = new System.Drawing.Point(2, 28);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(60, 95);
            this.lstNombre.TabIndex = 17;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(2, 12);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(44, 13);
            this.l.TabIndex = 16;
            this.l.Text = "Nombre";
            // 
            // lstDia
            // 
            this.lstDia.FormattingEnabled = true;
            this.lstDia.Location = new System.Drawing.Point(399, 28);
            this.lstDia.Name = "lstDia";
            this.lstDia.Size = new System.Drawing.Size(60, 95);
            this.lstDia.TabIndex = 31;
            // 
            // lstSucursal
            // 
            this.lstSucursal.FormattingEnabled = true;
            this.lstSucursal.Location = new System.Drawing.Point(324, 28);
            this.lstSucursal.Name = "lstSucursal";
            this.lstSucursal.Size = new System.Drawing.Size(60, 95);
            this.lstSucursal.TabIndex = 32;
            // 
            // btnSucursal
            // 
            this.btnSucursal.Location = new System.Drawing.Point(327, 127);
            this.btnSucursal.Name = "btnSucursal";
            this.btnSucursal.Size = new System.Drawing.Size(57, 23);
            this.btnSucursal.TabIndex = 33;
            this.btnSucursal.Text = " Sucursal";
            this.btnSucursal.UseVisualStyleBackColor = true;
            this.btnSucursal.Click += new System.EventHandler(this.btnSucursal_Click);
            // 
            // btnDia
            // 
            this.btnDia.Location = new System.Drawing.Point(402, 129);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(57, 23);
            this.btnDia.TabIndex = 34;
            this.btnDia.Text = "Dia";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Total x dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total x Sucursal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 193);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDia);
            this.Controls.Add(this.btnSucursal);
            this.Controls.Add(this.lstSucursal);
            this.Controls.Add(this.lstDia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstImporte);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lstCantidad);
            this.Controls.Add(this.lstPrecio);
            this.Controls.Add(this.lstNombre);
            this.Controls.Add(this.l);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstImporte;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstCantidad;
        private System.Windows.Forms.ListBox lstPrecio;
        private System.Windows.Forms.ListBox lstNombre;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.ListBox lstDia;
        private System.Windows.Forms.ListBox lstSucursal;
        private System.Windows.Forms.Button btnSucursal;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

