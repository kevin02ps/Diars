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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.groupBoxPedidoPedido = new System.Windows.Forms.GroupBox();
            this.txtPrecioAgregar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.btnAceptarAgregar = new System.Windows.Forms.Button();
            this.txtCantidadAgregar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarProductoAgregar = new System.Windows.Forms.Button();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarComprobante = new System.Windows.Forms.Button();
            this.comboBoxTipoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxPedidoPedido.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(554, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 252);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.PrecioTotal});
            this.dataGridView.Location = new System.Drawing.Point(36, 328);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(698, 138);
            this.dataGridView.TabIndex = 7;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "id_producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.Width = 80;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 250;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "PrecioTotal";
            this.PrecioTotal.Name = "PrecioTotal";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(200, 46);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 11;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // groupBoxPedidoPedido
            // 
            this.groupBoxPedidoPedido.Controls.Add(this.txtPrecioAgregar);
            this.groupBoxPedidoPedido.Controls.Add(this.label5);
            this.groupBoxPedidoPedido.Controls.Add(this.lblDescripcionProducto);
            this.groupBoxPedidoPedido.Controls.Add(this.btnAceptarAgregar);
            this.groupBoxPedidoPedido.Controls.Add(this.txtCantidadAgregar);
            this.groupBoxPedidoPedido.Controls.Add(this.label3);
            this.groupBoxPedidoPedido.Enabled = false;
            this.groupBoxPedidoPedido.Location = new System.Drawing.Point(57, 163);
            this.groupBoxPedidoPedido.Name = "groupBoxPedidoPedido";
            this.groupBoxPedidoPedido.Size = new System.Drawing.Size(436, 138);
            this.groupBoxPedidoPedido.TabIndex = 12;
            this.groupBoxPedidoPedido.TabStop = false;
            this.groupBoxPedidoPedido.Text = "Pedido";
            // 
            // txtPrecioAgregar
            // 
            this.txtPrecioAgregar.Enabled = false;
            this.txtPrecioAgregar.Location = new System.Drawing.Point(96, 94);
            this.txtPrecioAgregar.Name = "txtPrecioAgregar";
            this.txtPrecioAgregar.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioAgregar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio";
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Location = new System.Drawing.Point(52, 26);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(16, 13);
            this.lblDescripcionProducto.TabIndex = 8;
            this.lblDescripcionProducto.Text = "->";
            // 
            // btnAceptarAgregar
            // 
            this.btnAceptarAgregar.Location = new System.Drawing.Point(289, 60);
            this.btnAceptarAgregar.Name = "btnAceptarAgregar";
            this.btnAceptarAgregar.Size = new System.Drawing.Size(95, 41);
            this.btnAceptarAgregar.TabIndex = 7;
            this.btnAceptarAgregar.Text = "Agregar";
            this.btnAceptarAgregar.UseVisualStyleBackColor = true;
            this.btnAceptarAgregar.Click += new System.EventHandler(this.btnAceptarAgregar_Click_1);
            // 
            // txtCantidadAgregar
            // 
            this.txtCantidadAgregar.Location = new System.Drawing.Point(96, 53);
            this.txtCantidadAgregar.Name = "txtCantidadAgregar";
            this.txtCantidadAgregar.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAgregar.TabIndex = 6;
            this.txtCantidadAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadAgregar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad";
            // 
            // btnBuscarProductoAgregar
            // 
            this.btnBuscarProductoAgregar.Location = new System.Drawing.Point(200, 129);
            this.btnBuscarProductoAgregar.Name = "btnBuscarProductoAgregar";
            this.btnBuscarProductoAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProductoAgregar.TabIndex = 13;
            this.btnBuscarProductoAgregar.Text = "Buscar";
            this.btnBuscarProductoAgregar.UseVisualStyleBackColor = true;
            this.btnBuscarProductoAgregar.Click += new System.EventHandler(this.btnBuscarProductoAgregar_Click_1);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(101, 131);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(60, 20);
            this.txtIdProducto.TabIndex = 4;
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);
            this.txtIdProducto.MouseEnter += new System.EventHandler(this.txtIdProducto_MouseEnter_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Producto";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(93, 46);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(64, 20);
            this.txtIdCliente.TabIndex = 10;
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCliente_KeyPress);
            this.txtIdCliente.MouseEnter += new System.EventHandler(this.txtIdCliente_MouseEnter_1);
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.lblNombreCliente);
            this.groupBoxCliente.Location = new System.Drawing.Point(57, 75);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(436, 46);
            this.groupBoxCliente.TabIndex = 8;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(35, 16);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(16, 13);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id Cliente:";
            // 
            // btnGenerarComprobante
            // 
            this.btnGenerarComprobante.Location = new System.Drawing.Point(753, 405);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(135, 42);
            this.btnGenerarComprobante.TabIndex = 14;
            this.btnGenerarComprobante.Text = "Generar Comprobante";
            this.btnGenerarComprobante.UseVisualStyleBackColor = true;
            this.btnGenerarComprobante.Click += new System.EventHandler(this.btnGenerarComprobante_Click);
            // 
            // comboBoxTipoPago
            // 
            this.comboBoxTipoPago.FormattingEnabled = true;
            this.comboBoxTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Crédito",
            "Transferencia Bancaria",
            "Cheque",
            "Billetera Electrónica"});
            this.comboBoxTipoPago.Location = new System.Drawing.Point(753, 364);
            this.comboBoxTipoPago.Name = "comboBoxTipoPago";
            this.comboBoxTipoPago.Size = new System.Drawing.Size(135, 21);
            this.comboBoxTipoPago.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo de pago";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTipoPago);
            this.Controls.Add(this.btnBuscarProductoAgregar);
            this.Controls.Add(this.btnGenerarComprobante);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.groupBoxPedidoPedido);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxPedidoPedido.ResumeLayout(false);
            this.groupBoxPedidoPedido.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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