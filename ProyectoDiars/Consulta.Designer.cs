namespace InversionesHermanos
{
    partial class Consulta
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
            this.btnConsultarPedidos = new System.Windows.Forms.Button();
            this.groupBoxConsultaPedidos = new System.Windows.Forms.GroupBox();
            this.btnBuscarCP = new System.Windows.Forms.Button();
            this.dataGridViewDetallePedidoC = new System.Windows.Forms.DataGridView();
            this.dataGridViewPedidoC = new System.Windows.Forms.DataGridView();
            this.txtIdPedidoC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxConsultaPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePedidoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarPedidos
            // 
            this.btnConsultarPedidos.Location = new System.Drawing.Point(119, 12);
            this.btnConsultarPedidos.Name = "btnConsultarPedidos";
            this.btnConsultarPedidos.Size = new System.Drawing.Size(124, 23);
            this.btnConsultarPedidos.TabIndex = 0;
            this.btnConsultarPedidos.Text = "Consultar Pedidos";
            this.btnConsultarPedidos.UseVisualStyleBackColor = true;
            this.btnConsultarPedidos.Click += new System.EventHandler(this.btnConsultarPedidos_Click);
            // 
            // groupBoxConsultaPedidos
            // 
            this.groupBoxConsultaPedidos.Controls.Add(this.btnBuscarCP);
            this.groupBoxConsultaPedidos.Controls.Add(this.dataGridViewDetallePedidoC);
            this.groupBoxConsultaPedidos.Controls.Add(this.dataGridViewPedidoC);
            this.groupBoxConsultaPedidos.Controls.Add(this.txtIdPedidoC);
            this.groupBoxConsultaPedidos.Controls.Add(this.label1);
            this.groupBoxConsultaPedidos.Location = new System.Drawing.Point(12, 41);
            this.groupBoxConsultaPedidos.Name = "groupBoxConsultaPedidos";
            this.groupBoxConsultaPedidos.Size = new System.Drawing.Size(860, 408);
            this.groupBoxConsultaPedidos.TabIndex = 1;
            this.groupBoxConsultaPedidos.TabStop = false;
            // 
            // btnBuscarCP
            // 
            this.btnBuscarCP.Location = new System.Drawing.Point(69, 88);
            this.btnBuscarCP.Name = "btnBuscarCP";
            this.btnBuscarCP.Size = new System.Drawing.Size(83, 27);
            this.btnBuscarCP.TabIndex = 4;
            this.btnBuscarCP.Text = "Buscar";
            this.btnBuscarCP.UseVisualStyleBackColor = true;
            this.btnBuscarCP.Click += new System.EventHandler(this.btnBuscarCP_Click);
            // 
            // dataGridViewDetallePedidoC
            // 
            this.dataGridViewDetallePedidoC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetallePedidoC.Location = new System.Drawing.Point(34, 181);
            this.dataGridViewDetallePedidoC.Name = "dataGridViewDetallePedidoC";
            this.dataGridViewDetallePedidoC.Size = new System.Drawing.Size(805, 200);
            this.dataGridViewDetallePedidoC.TabIndex = 3;
            // 
            // dataGridViewPedidoC
            // 
            this.dataGridViewPedidoC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidoC.Location = new System.Drawing.Point(265, 31);
            this.dataGridViewPedidoC.Name = "dataGridViewPedidoC";
            this.dataGridViewPedidoC.Size = new System.Drawing.Size(574, 128);
            this.dataGridViewPedidoC.TabIndex = 2;
            // 
            // txtIdPedidoC
            // 
            this.txtIdPedidoC.Location = new System.Drawing.Point(107, 44);
            this.txtIdPedidoC.Name = "txtIdPedidoC";
            this.txtIdPedidoC.Size = new System.Drawing.Size(100, 20);
            this.txtIdPedidoC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Pedido";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBoxConsultaPedidos);
            this.Controls.Add(this.btnConsultarPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta";
            this.Text = "Agregar_Pedido";
            this.groupBoxConsultaPedidos.ResumeLayout(false);
            this.groupBoxConsultaPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePedidoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidoC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarPedidos;
        private System.Windows.Forms.GroupBox groupBoxConsultaPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCP;
        private System.Windows.Forms.DataGridView dataGridViewDetallePedidoC;
        private System.Windows.Forms.DataGridView dataGridViewPedidoC;
        private System.Windows.Forms.TextBox txtIdPedidoC;
    }
}