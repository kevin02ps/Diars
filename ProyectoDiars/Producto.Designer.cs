namespace InversionesHermanos
{
    partial class Producto
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            dataGridView1 = new DataGridView();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnAgregarProducto = new Button();
            groupBoxModificar = new GroupBox();
            btnBuscarM = new Button();
            groupBoxdatosM = new GroupBox();
            txtPrecioM = new TextBox();
            txtNombreM = new TextBox();
            label9 = new Label();
            txtCantStockM = new TextBox();
            label6 = new Label();
            label8 = new Label();
            txtDescripcionM = new TextBox();
            label7 = new Label();
            txtIDM = new TextBox();
            label11 = new Label();
            btnModificar = new Button();
            groupBoxAgregarProducto = new GroupBox();
            txtIdProveedorA = new TextBox();
            label2 = new Label();
            btnAceptarA = new Button();
            txtCantStockA = new TextBox();
            label5 = new Label();
            txtPrecioA = new TextBox();
            label4 = new Label();
            txtDescripcionA = new TextBox();
            label3 = new Label();
            txtNombreA = new TextBox();
            label1 = new Label();
            groupBoxEliminar = new GroupBox();
            txtIDE = new TextBox();
            label17 = new Label();
            btnEliminarE = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxModificar.SuspendLayout();
            groupBoxdatosM.SuspendLayout();
            groupBoxAgregarProducto.SuspendLayout();
            groupBoxEliminar.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.SteelBlue;
            dataGridView1.Location = new Point(451, 29);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(584, 519);
            dataGridView1.TabIndex = 0;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarProducto.Image = (Image)resources.GetObject("btnEliminarProducto.Image");
            btnEliminarProducto.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminarProducto.Location = new Point(294, 12);
            btnEliminarProducto.Margin = new Padding(4, 3, 4, 3);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(129, 53);
            btnEliminarProducto.TabIndex = 18;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarProducto.Image = (Image)resources.GetObject("btnModificarProducto.Image");
            btnModificarProducto.ImageAlign = ContentAlignment.MiddleRight;
            btnModificarProducto.Location = new Point(166, 12);
            btnModificarProducto.Margin = new Padding(4, 3, 4, 3);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(120, 53);
            btnModificarProducto.TabIndex = 17;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarProducto.Image = (Image)resources.GetObject("btnAgregarProducto.Image");
            btnAgregarProducto.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregarProducto.Location = new Point(24, 12);
            btnAgregarProducto.Margin = new Padding(4, 3, 4, 3);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(125, 53);
            btnAgregarProducto.TabIndex = 16;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // groupBoxModificar
            // 
            groupBoxModificar.Controls.Add(btnBuscarM);
            groupBoxModificar.Controls.Add(groupBoxdatosM);
            groupBoxModificar.Controls.Add(txtIDM);
            groupBoxModificar.Controls.Add(label11);
            groupBoxModificar.Controls.Add(btnModificar);
            groupBoxModificar.Location = new Point(24, 83);
            groupBoxModificar.Margin = new Padding(4, 3, 4, 3);
            groupBoxModificar.Name = "groupBoxModificar";
            groupBoxModificar.Padding = new Padding(4, 3, 4, 3);
            groupBoxModificar.Size = new Size(420, 460);
            groupBoxModificar.TabIndex = 19;
            groupBoxModificar.TabStop = false;
            // 
            // btnBuscarM
            // 
            btnBuscarM.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarM.Image = (Image)resources.GetObject("btnBuscarM.Image");
            btnBuscarM.ImageAlign = ContentAlignment.BottomRight;
            btnBuscarM.Location = new Point(267, 22);
            btnBuscarM.Margin = new Padding(4, 3, 4, 3);
            btnBuscarM.Name = "btnBuscarM";
            btnBuscarM.Size = new Size(131, 49);
            btnBuscarM.TabIndex = 13;
            btnBuscarM.Text = "Buscar";
            btnBuscarM.UseVisualStyleBackColor = true;
            btnBuscarM.Click += btnBuscarM_Click_1;
            // 
            // groupBoxdatosM
            // 
            groupBoxdatosM.Controls.Add(txtPrecioM);
            groupBoxdatosM.Controls.Add(txtNombreM);
            groupBoxdatosM.Controls.Add(label9);
            groupBoxdatosM.Controls.Add(txtCantStockM);
            groupBoxdatosM.Controls.Add(label6);
            groupBoxdatosM.Controls.Add(label8);
            groupBoxdatosM.Controls.Add(txtDescripcionM);
            groupBoxdatosM.Controls.Add(label7);
            groupBoxdatosM.Enabled = false;
            groupBoxdatosM.Location = new Point(7, 87);
            groupBoxdatosM.Margin = new Padding(4, 3, 4, 3);
            groupBoxdatosM.Name = "groupBoxdatosM";
            groupBoxdatosM.Padding = new Padding(4, 3, 4, 3);
            groupBoxdatosM.Size = new Size(406, 245);
            groupBoxdatosM.TabIndex = 5;
            groupBoxdatosM.TabStop = false;
            // 
            // txtPrecioM
            // 
            txtPrecioM.Location = new Point(166, 138);
            txtPrecioM.Margin = new Padding(4, 3, 4, 3);
            txtPrecioM.Name = "txtPrecioM";
            txtPrecioM.Size = new Size(212, 23);
            txtPrecioM.TabIndex = 7;
            // 
            // txtNombreM
            // 
            txtNombreM.Location = new Point(166, 37);
            txtNombreM.Margin = new Padding(4, 3, 4, 3);
            txtNombreM.Name = "txtNombreM";
            txtNombreM.Size = new Size(212, 23);
            txtNombreM.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(37, 45);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 2;
            label9.Text = "Nombre";
            // 
            // txtCantStockM
            // 
            txtCantStockM.Location = new Point(166, 187);
            txtCantStockM.Margin = new Padding(4, 3, 4, 3);
            txtCantStockM.Name = "txtCantStockM";
            txtCantStockM.Size = new Size(212, 23);
            txtCantStockM.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(40, 194);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 8;
            label6.Text = "CantStock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(40, 95);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 4;
            label8.Text = "Descripcion";
            // 
            // txtDescripcionM
            // 
            txtDescripcionM.Location = new Point(166, 88);
            txtDescripcionM.Margin = new Padding(4, 3, 4, 3);
            txtDescripcionM.Name = "txtDescripcionM";
            txtDescripcionM.Size = new Size(212, 23);
            txtDescripcionM.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(40, 145);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 6;
            label7.Text = "Precio";
            // 
            // txtIDM
            // 
            txtIDM.Location = new Point(119, 40);
            txtIDM.Margin = new Padding(4, 3, 4, 3);
            txtIDM.Name = "txtIDM";
            txtIDM.Size = new Size(106, 23);
            txtIDM.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(40, 44);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 11;
            label11.Text = "Id Producto";
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleRight;
            btnModificar.Location = new Point(142, 367);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 66);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // groupBoxAgregarProducto
            // 
            groupBoxAgregarProducto.Controls.Add(txtIdProveedorA);
            groupBoxAgregarProducto.Controls.Add(label2);
            groupBoxAgregarProducto.Controls.Add(btnAceptarA);
            groupBoxAgregarProducto.Controls.Add(txtCantStockA);
            groupBoxAgregarProducto.Controls.Add(label5);
            groupBoxAgregarProducto.Controls.Add(txtPrecioA);
            groupBoxAgregarProducto.Controls.Add(label4);
            groupBoxAgregarProducto.Controls.Add(txtDescripcionA);
            groupBoxAgregarProducto.Controls.Add(label3);
            groupBoxAgregarProducto.Controls.Add(txtNombreA);
            groupBoxAgregarProducto.Controls.Add(label1);
            groupBoxAgregarProducto.Location = new Point(24, 83);
            groupBoxAgregarProducto.Margin = new Padding(4, 3, 4, 3);
            groupBoxAgregarProducto.Name = "groupBoxAgregarProducto";
            groupBoxAgregarProducto.Padding = new Padding(4, 3, 4, 3);
            groupBoxAgregarProducto.Size = new Size(420, 460);
            groupBoxAgregarProducto.TabIndex = 15;
            groupBoxAgregarProducto.TabStop = false;
            // 
            // txtIdProveedorA
            // 
            txtIdProveedorA.Location = new Point(186, 255);
            txtIdProveedorA.Margin = new Padding(4, 3, 4, 3);
            txtIdProveedorA.Name = "txtIdProveedorA";
            txtIdProveedorA.Size = new Size(212, 23);
            txtIdProveedorA.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 258);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 11;
            label2.Text = "Id Proveedor";
            // 
            // btnAceptarA
            // 
            btnAceptarA.Location = new Point(142, 338);
            btnAceptarA.Margin = new Padding(4, 3, 4, 3);
            btnAceptarA.Name = "btnAceptarA";
            btnAceptarA.Size = new Size(127, 45);
            btnAceptarA.TabIndex = 10;
            btnAceptarA.Text = "ACEPTAR";
            btnAceptarA.UseVisualStyleBackColor = true;
            btnAceptarA.Click += btnAceptarA_Click_1;
            // 
            // txtCantStockA
            // 
            txtCantStockA.Location = new Point(186, 204);
            txtCantStockA.Margin = new Padding(4, 3, 4, 3);
            txtCantStockA.Name = "txtCantStockA";
            txtCantStockA.Size = new Size(212, 23);
            txtCantStockA.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 208);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 8;
            label5.Text = "CantStock";
            // 
            // txtPrecioA
            // 
            txtPrecioA.Location = new Point(186, 156);
            txtPrecioA.Margin = new Padding(4, 3, 4, 3);
            txtPrecioA.Name = "txtPrecioA";
            txtPrecioA.Size = new Size(212, 23);
            txtPrecioA.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 159);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // txtDescripcionA
            // 
            txtDescripcionA.Location = new Point(186, 105);
            txtDescripcionA.Margin = new Padding(4, 3, 4, 3);
            txtDescripcionA.Name = "txtDescripcionA";
            txtDescripcionA.Size = new Size(212, 23);
            txtDescripcionA.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 108);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // txtNombreA
            // 
            txtNombreA.Location = new Point(186, 47);
            txtNombreA.Margin = new Padding(4, 3, 4, 3);
            txtNombreA.Name = "txtNombreA";
            txtNombreA.Size = new Size(212, 23);
            txtNombreA.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBoxEliminar
            // 
            groupBoxEliminar.Controls.Add(txtIDE);
            groupBoxEliminar.Controls.Add(label17);
            groupBoxEliminar.Controls.Add(btnEliminarE);
            groupBoxEliminar.Location = new Point(24, 83);
            groupBoxEliminar.Margin = new Padding(4, 3, 4, 3);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Padding = new Padding(4, 3, 4, 3);
            groupBoxEliminar.Size = new Size(420, 460);
            groupBoxEliminar.TabIndex = 20;
            groupBoxEliminar.TabStop = false;
            // 
            // txtIDE
            // 
            txtIDE.Location = new Point(203, 102);
            txtIDE.Margin = new Padding(4, 3, 4, 3);
            txtIDE.Name = "txtIDE";
            txtIDE.Size = new Size(106, 23);
            txtIDE.TabIndex = 12;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(92, 105);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(69, 15);
            label17.TabIndex = 11;
            label17.Text = "Id Producto";
            // 
            // btnEliminarE
            // 
            btnEliminarE.Location = new Point(126, 195);
            btnEliminarE.Margin = new Padding(4, 3, 4, 3);
            btnEliminarE.Name = "btnEliminarE";
            btnEliminarE.Size = new Size(127, 45);
            btnEliminarE.TabIndex = 10;
            btnEliminarE.Text = "EKIMINAR";
            btnEliminarE.UseVisualStyleBackColor = true;
            btnEliminarE.Click += btnEliminarE_Click_1;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1050, 577);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxModificar);
            Controls.Add(groupBoxAgregarProducto);
            Controls.Add(groupBoxEliminar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Producto";
            Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxModificar.ResumeLayout(false);
            groupBoxModificar.PerformLayout();
            groupBoxdatosM.ResumeLayout(false);
            groupBoxdatosM.PerformLayout();
            groupBoxAgregarProducto.ResumeLayout(false);
            groupBoxAgregarProducto.PerformLayout();
            groupBoxEliminar.ResumeLayout(false);
            groupBoxEliminar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.GroupBox groupBoxModificar;
        private System.Windows.Forms.Button btnBuscarM;
        private System.Windows.Forms.GroupBox groupBoxdatosM;
        private System.Windows.Forms.TextBox txtPrecioM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantStockM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcionM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBoxAgregarProducto;
        private System.Windows.Forms.Button btnAceptarA;
        private System.Windows.Forms.TextBox txtCantStockA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxEliminar;
        private System.Windows.Forms.TextBox txtIDE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnEliminarE;
        private System.Windows.Forms.TextBox txtIdProveedorA;
        private System.Windows.Forms.Label label2;
    }
}