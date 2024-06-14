namespace InversionesHermanos
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            dataGridView1 = new DataGridView();
            dataGridView = new DataGridView();
            id_producto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            PrecioTotal = new DataGridViewTextBoxColumn();
            btnBuscarCliente = new Button();
            groupBoxPedidoPedido = new GroupBox();
            txtPrecioAgregar = new TextBox();
            label5 = new Label();
            lblDescripcionProducto = new Label();
            btnAceptarAgregar = new Button();
            txtCantidadAgregar = new TextBox();
            label3 = new Label();
            btnBuscarProductoAgregar = new Button();
            txtIdProducto = new TextBox();
            label2 = new Label();
            txtIdCliente = new TextBox();
            groupBoxCliente = new GroupBox();
            lblNombreCliente = new Label();
            label1 = new Label();
            btnGenerarComprobante = new Button();
            comboBoxTipoPago = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBoxPedidoPedido.SuspendLayout();
            groupBoxCliente.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(646, 57);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(390, 291);
            dataGridView1.TabIndex = 13;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { id_producto, Producto, Cantidad, Precio, PrecioTotal });
            dataGridView.Location = new Point(38, 377);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(674, 159);
            dataGridView.TabIndex = 7;
            // 
            // id_producto
            // 
            id_producto.HeaderText = "id_producto";
            id_producto.Name = "id_producto";
            id_producto.Width = 80;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Width = 250;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // PrecioTotal
            // 
            PrecioTotal.HeaderText = "PrecioTotal";
            PrecioTotal.Name = "PrecioTotal";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarCliente.Image = (Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarCliente.Location = new Point(233, 41);
            btnBuscarCliente.Margin = new Padding(4, 3, 4, 3);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(112, 40);
            btnBuscarCliente.TabIndex = 11;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click_1;
            // 
            // groupBoxPedidoPedido
            // 
            groupBoxPedidoPedido.Controls.Add(txtPrecioAgregar);
            groupBoxPedidoPedido.Controls.Add(label5);
            groupBoxPedidoPedido.Controls.Add(lblDescripcionProducto);
            groupBoxPedidoPedido.Controls.Add(btnAceptarAgregar);
            groupBoxPedidoPedido.Controls.Add(txtCantidadAgregar);
            groupBoxPedidoPedido.Controls.Add(label3);
            groupBoxPedidoPedido.Enabled = false;
            groupBoxPedidoPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxPedidoPedido.Location = new Point(66, 188);
            groupBoxPedidoPedido.Margin = new Padding(4, 3, 4, 3);
            groupBoxPedidoPedido.Name = "groupBoxPedidoPedido";
            groupBoxPedidoPedido.Padding = new Padding(4, 3, 4, 3);
            groupBoxPedidoPedido.Size = new Size(509, 159);
            groupBoxPedidoPedido.TabIndex = 12;
            groupBoxPedidoPedido.TabStop = false;
            groupBoxPedidoPedido.Text = "Pedido";
            // 
            // txtPrecioAgregar
            // 
            txtPrecioAgregar.Enabled = false;
            txtPrecioAgregar.Location = new Point(112, 108);
            txtPrecioAgregar.Margin = new Padding(4, 3, 4, 3);
            txtPrecioAgregar.Name = "txtPrecioAgregar";
            txtPrecioAgregar.Size = new Size(116, 23);
            txtPrecioAgregar.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 112);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 9;
            label5.Text = "Precio";
            // 
            // lblDescripcionProducto
            // 
            lblDescripcionProducto.AutoSize = true;
            lblDescripcionProducto.Location = new Point(61, 30);
            lblDescripcionProducto.Margin = new Padding(4, 0, 4, 0);
            lblDescripcionProducto.Name = "lblDescripcionProducto";
            lblDescripcionProducto.Size = new Size(20, 15);
            lblDescripcionProducto.TabIndex = 8;
            lblDescripcionProducto.Text = "->";
            // 
            // btnAceptarAgregar
            // 
            btnAceptarAgregar.Image = (Image)resources.GetObject("btnAceptarAgregar.Image");
            btnAceptarAgregar.ImageAlign = ContentAlignment.MiddleRight;
            btnAceptarAgregar.Location = new Point(337, 69);
            btnAceptarAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAceptarAgregar.Name = "btnAceptarAgregar";
            btnAceptarAgregar.Size = new Size(119, 47);
            btnAceptarAgregar.TabIndex = 7;
            btnAceptarAgregar.Text = "Agregar";
            btnAceptarAgregar.UseVisualStyleBackColor = true;
            btnAceptarAgregar.Click += btnAceptarAgregar_Click_1;
            // 
            // txtCantidadAgregar
            // 
            txtCantidadAgregar.Location = new Point(112, 61);
            txtCantidadAgregar.Margin = new Padding(4, 3, 4, 3);
            txtCantidadAgregar.Name = "txtCantidadAgregar";
            txtCantidadAgregar.Size = new Size(116, 23);
            txtCantidadAgregar.TabIndex = 6;
            txtCantidadAgregar.KeyPress += txtCantidadAgregar_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad";
            // 
            // btnBuscarProductoAgregar
            // 
            btnBuscarProductoAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarProductoAgregar.Image = (Image)resources.GetObject("btnBuscarProductoAgregar.Image");
            btnBuscarProductoAgregar.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarProductoAgregar.Location = new Point(233, 146);
            btnBuscarProductoAgregar.Margin = new Padding(4, 3, 4, 3);
            btnBuscarProductoAgregar.Name = "btnBuscarProductoAgregar";
            btnBuscarProductoAgregar.Size = new Size(112, 37);
            btnBuscarProductoAgregar.TabIndex = 13;
            btnBuscarProductoAgregar.Text = "Buscar";
            btnBuscarProductoAgregar.UseVisualStyleBackColor = true;
            btnBuscarProductoAgregar.Click += btnBuscarProductoAgregar_Click_1;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtIdProducto.Location = new Point(118, 151);
            txtIdProducto.Margin = new Padding(4, 3, 4, 3);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(69, 23);
            txtIdProducto.TabIndex = 4;
            txtIdProducto.TextChanged += txtIdProducto_TextChanged;
            txtIdProducto.KeyPress += txtIdProducto_KeyPress;
            txtIdProducto.MouseEnter += txtIdProducto_MouseEnter_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(38, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 0;
            label2.Text = "Id Producto";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtIdCliente.Location = new Point(108, 53);
            txtIdCliente.Margin = new Padding(4, 3, 4, 3);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(74, 23);
            txtIdCliente.TabIndex = 10;
            txtIdCliente.KeyPress += txtIdCliente_KeyPress;
            txtIdCliente.MouseEnter += txtIdCliente_MouseEnter_1;
            // 
            // groupBoxCliente
            // 
            groupBoxCliente.Controls.Add(lblNombreCliente);
            groupBoxCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxCliente.Location = new Point(66, 87);
            groupBoxCliente.Margin = new Padding(4, 3, 4, 3);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Padding = new Padding(4, 3, 4, 3);
            groupBoxCliente.Size = new Size(509, 53);
            groupBoxCliente.TabIndex = 8;
            groupBoxCliente.TabStop = false;
            groupBoxCliente.Text = "Cliente";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(41, 18);
            lblNombreCliente.Margin = new Padding(4, 0, 4, 0);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(16, 15);
            lblNombreCliente.TabIndex = 0;
            lblNombreCliente.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(38, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 9;
            label1.Text = "Id Cliente:";
            // 
            // btnGenerarComprobante
            // 
            btnGenerarComprobante.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerarComprobante.Image = (Image)resources.GetObject("btnGenerarComprobante.Image");
            btnGenerarComprobante.ImageAlign = ContentAlignment.MiddleRight;
            btnGenerarComprobante.Location = new Point(781, 458);
            btnGenerarComprobante.Margin = new Padding(4, 3, 4, 3);
            btnGenerarComprobante.Name = "btnGenerarComprobante";
            btnGenerarComprobante.Size = new Size(136, 56);
            btnGenerarComprobante.TabIndex = 14;
            btnGenerarComprobante.Text = "Generar Comprobante   ";
            btnGenerarComprobante.UseVisualStyleBackColor = true;
            btnGenerarComprobante.Click += btnGenerarComprobante_Click;
            // 
            // comboBoxTipoPago
            // 
            comboBoxTipoPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            comboBoxTipoPago.FormattingEnabled = true;
            comboBoxTipoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta de Crédito", "Transferencia Bancaria", "Cheque", "Billetera Electrónica" });
            comboBoxTipoPago.Location = new Point(769, 397);
            comboBoxTipoPago.Margin = new Padding(4, 3, 4, 3);
            comboBoxTipoPago.Name = "comboBoxTipoPago";
            comboBoxTipoPago.Size = new Size(157, 23);
            comboBoxTipoPago.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(766, 379);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 16;
            label4.Text = "Tipo de pago";
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1050, 577);
            Controls.Add(label4);
            Controls.Add(comboBoxTipoPago);
            Controls.Add(btnBuscarProductoAgregar);
            Controls.Add(btnGenerarComprobante);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView);
            Controls.Add(btnBuscarCliente);
            Controls.Add(groupBoxPedidoPedido);
            Controls.Add(txtIdCliente);
            Controls.Add(groupBoxCliente);
            Controls.Add(txtIdProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Pedidos";
            Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBoxPedidoPedido.ResumeLayout(false);
            groupBoxPedidoPedido.PerformLayout();
            groupBoxCliente.ResumeLayout(false);
            groupBoxCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox groupBoxPedidoPedido;
        private System.Windows.Forms.Button btnBuscarProductoAgregar;
        private System.Windows.Forms.TextBox txtPrecioAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.Button btnAceptarAgregar;
        private System.Windows.Forms.TextBox txtCantidadAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.ComboBox comboBoxTipoPago;
        private System.Windows.Forms.Label label4;
    }
}