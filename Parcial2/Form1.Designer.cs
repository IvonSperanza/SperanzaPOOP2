namespace Parcial2
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
            System.Windows.Forms.TextBox cuitprovedor;
            System.Windows.Forms.TextBox Situacionfiscal;
            System.Windows.Forms.TextBox textBox1;
            System.Windows.Forms.TextBox CodigoProducto;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreProveedor = new System.Windows.Forms.TextBox();
            this.direccionproveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cuitproveedor = new System.Windows.Forms.Label();
            this.Situacion = new System.Windows.Forms.Label();
            this.Codigoproveedor = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.dtcProvedor = new System.Windows.Forms.DataGridView();
            this.dtvPorducto = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoriaProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NombreProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.Label();
            this.CargarPorducto = new System.Windows.Forms.Button();
            this.CargarProvedor = new System.Windows.Forms.Button();
            cuitprovedor = new System.Windows.Forms.TextBox();
            Situacionfiscal = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            CodigoProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtcProvedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPorducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proveedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.Location = new System.Drawing.Point(66, 40);
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.Size = new System.Drawing.Size(100, 26);
            this.NombreProveedor.TabIndex = 4;
            // 
            // direccionproveedor
            // 
            this.direccionproveedor.Location = new System.Drawing.Point(81, 140);
            this.direccionproveedor.Name = "direccionproveedor";
            this.direccionproveedor.Size = new System.Drawing.Size(100, 26);
            this.direccionproveedor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cuitprovedor
            // 
            cuitprovedor.Location = new System.Drawing.Point(66, 72);
            cuitprovedor.Name = "cuitprovedor";
            cuitprovedor.Size = new System.Drawing.Size(100, 26);
            cuitprovedor.TabIndex = 8;
            // 
            // Cuitproveedor
            // 
            this.Cuitproveedor.AutoSize = true;
            this.Cuitproveedor.Location = new System.Drawing.Point(0, 90);
            this.Cuitproveedor.Name = "Cuitproveedor";
            this.Cuitproveedor.Size = new System.Drawing.Size(46, 20);
            this.Cuitproveedor.TabIndex = 7;
            this.Cuitproveedor.Text = "CUIT";
            this.Cuitproveedor.Click += new System.EventHandler(this.label4_Click);
            // 
            // Situacionfiscal
            // 
            Situacionfiscal.Location = new System.Drawing.Point(271, 84);
            Situacionfiscal.Name = "Situacionfiscal";
            Situacionfiscal.Size = new System.Drawing.Size(100, 26);
            Situacionfiscal.TabIndex = 14;
            // 
            // Situacion
            // 
            this.Situacion.AutoSize = true;
            this.Situacion.Location = new System.Drawing.Point(205, 90);
            this.Situacion.Name = "Situacion";
            this.Situacion.Size = new System.Drawing.Size(46, 20);
            this.Situacion.TabIndex = 13;
            this.Situacion.Text = "CUIT";
            // 
            // Codigoproveedor
            // 
            this.Codigoproveedor.Location = new System.Drawing.Point(271, 40);
            this.Codigoproveedor.Name = "Codigoproveedor";
            this.Codigoproveedor.Size = new System.Drawing.Size(100, 26);
            this.Codigoproveedor.TabIndex = 10;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(205, 46);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(65, 20);
            this.Codigo.TabIndex = 9;
            this.Codigo.Text = "Nombre";
            // 
            // dtcProvedor
            // 
            this.dtcProvedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcProvedor.Location = new System.Drawing.Point(402, 16);
            this.dtcProvedor.Name = "dtcProvedor";
            this.dtcProvedor.RowHeadersWidth = 62;
            this.dtcProvedor.RowTemplate.Height = 28;
            this.dtcProvedor.Size = new System.Drawing.Size(386, 176);
            this.dtcProvedor.TabIndex = 15;
            this.dtcProvedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtcProvedor_CellContentClick);
            // 
            // dtvPorducto
            // 
            this.dtvPorducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvPorducto.Location = new System.Drawing.Point(402, 246);
            this.dtvPorducto.Name = "dtvPorducto";
            this.dtvPorducto.RowHeadersWidth = 62;
            this.dtvPorducto.RowTemplate.Height = 28;
            this.dtvPorducto.Size = new System.Drawing.Size(386, 176);
            this.dtvPorducto.TabIndex = 27;
            this.dtvPorducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(271, 314);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 26);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "CUIT";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nombre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CodigoProducto
            // 
            CodigoProducto.Location = new System.Drawing.Point(66, 314);
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.Size = new System.Drawing.Size(100, 26);
            CodigoProducto.TabIndex = 22;
            CodigoProducto.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Codigo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CategoriaProducto
            // 
            this.CategoriaProducto.Location = new System.Drawing.Point(81, 370);
            this.CategoriaProducto.Name = "CategoriaProducto";
            this.CategoriaProducto.Size = new System.Drawing.Size(100, 26);
            this.CategoriaProducto.TabIndex = 20;
            this.CategoriaProducto.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Categoria";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // NombreProducto
            // 
            this.NombreProducto.Location = new System.Drawing.Point(66, 270);
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(100, 26);
            this.NombreProducto.TabIndex = 18;
            this.NombreProducto.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nombre";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(0, 230);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(73, 20);
            this.Producto.TabIndex = 16;
            this.Producto.Text = "Producto";
            this.Producto.Click += new System.EventHandler(this.label9_Click);
            // 
            // CargarPorducto
            // 
            this.CargarPorducto.Location = new System.Drawing.Point(271, 372);
            this.CargarPorducto.Name = "CargarPorducto";
            this.CargarPorducto.Size = new System.Drawing.Size(75, 23);
            this.CargarPorducto.TabIndex = 28;
            this.CargarPorducto.Text = "Cargar";
            this.CargarPorducto.UseVisualStyleBackColor = true;
            this.CargarPorducto.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CargarProvedor
            // 
            this.CargarProvedor.Location = new System.Drawing.Point(246, 140);
            this.CargarProvedor.Name = "CargarProvedor";
            this.CargarProvedor.Size = new System.Drawing.Size(75, 23);
            this.CargarProvedor.TabIndex = 29;
            this.CargarProvedor.Text = "Cargar";
            this.CargarProvedor.UseVisualStyleBackColor = true;
            this.CargarProvedor.Click += new System.EventHandler(this.CargarProvedor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CargarProvedor);
            this.Controls.Add(this.CargarPorducto);
            this.Controls.Add(this.dtvPorducto);
            this.Controls.Add(textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(CodigoProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CategoriaProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NombreProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.dtcProvedor);
            this.Controls.Add(Situacionfiscal);
            this.Controls.Add(this.Situacion);
            this.Controls.Add(this.Codigoproveedor);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(cuitprovedor);
            this.Controls.Add(this.Cuitproveedor);
            this.Controls.Add(this.direccionproveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtcProvedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPorducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreProveedor;
        private System.Windows.Forms.TextBox direccionproveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Cuitproveedor;
        private System.Windows.Forms.Label Situacion;
        private System.Windows.Forms.TextBox Codigoproveedor;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.DataGridView dtcProvedor;
        private System.Windows.Forms.DataGridView dtvPorducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CategoriaProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombreProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.Button CargarPorducto;
        private System.Windows.Forms.Button CargarProvedor;
    }
}

