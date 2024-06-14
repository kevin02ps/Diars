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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            btnConsultarPedidos = new Button();
            groupBoxConsultaPedidos = new GroupBox();
            btnBuscarCP = new Button();
            dataGridViewDetallePedidoC = new DataGridView();
            dataGridViewPedidoC = new DataGridView();
            txtIdPedidoC = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBoxConsultaPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetallePedidoC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidoC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConsultarPedidos
            // 
            btnConsultarPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConsultarPedidos.Image = (Image)resources.GetObject("btnConsultarPedidos.Image");
            btnConsultarPedidos.ImageAlign = ContentAlignment.MiddleRight;
            btnConsultarPedidos.Location = new Point(54, 12);
            btnConsultarPedidos.Margin = new Padding(4, 3, 4, 3);
            btnConsultarPedidos.Name = "btnConsultarPedidos";
            btnConsultarPedidos.Size = new Size(175, 29);
            btnConsultarPedidos.TabIndex = 0;
            btnConsultarPedidos.Text = "Consultar Pedidos";
            btnConsultarPedidos.UseVisualStyleBackColor = true;
            btnConsultarPedidos.Click += btnConsultarPedidos_Click;
            // 
            // groupBoxConsultaPedidos
            // 
            groupBoxConsultaPedidos.Controls.Add(btnBuscarCP);
            groupBoxConsultaPedidos.Controls.Add(dataGridViewDetallePedidoC);
            groupBoxConsultaPedidos.Controls.Add(dataGridViewPedidoC);
            groupBoxConsultaPedidos.Controls.Add(txtIdPedidoC);
            groupBoxConsultaPedidos.Controls.Add(label1);
            groupBoxConsultaPedidos.Location = new Point(14, 47);
            groupBoxConsultaPedidos.Margin = new Padding(4, 3, 4, 3);
            groupBoxConsultaPedidos.Name = "groupBoxConsultaPedidos";
            groupBoxConsultaPedidos.Padding = new Padding(4, 3, 4, 3);
            groupBoxConsultaPedidos.Size = new Size(1003, 471);
            groupBoxConsultaPedidos.TabIndex = 1;
            groupBoxConsultaPedidos.TabStop = false;
            // 
            // btnBuscarCP
            // 
            btnBuscarCP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarCP.Image = (Image)resources.GetObject("btnBuscarCP.Image");
            btnBuscarCP.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarCP.Location = new Point(80, 102);
            btnBuscarCP.Margin = new Padding(4, 3, 4, 3);
            btnBuscarCP.Name = "btnBuscarCP";
            btnBuscarCP.Size = new Size(134, 40);
            btnBuscarCP.TabIndex = 4;
            btnBuscarCP.Text = "Buscar";
            btnBuscarCP.UseVisualStyleBackColor = true;
            btnBuscarCP.Click += btnBuscarCP_Click;
            // 
            // dataGridViewDetallePedidoC
            // 
            dataGridViewDetallePedidoC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetallePedidoC.Location = new Point(40, 209);
            dataGridViewDetallePedidoC.Margin = new Padding(4, 3, 4, 3);
            dataGridViewDetallePedidoC.Name = "dataGridViewDetallePedidoC";
            dataGridViewDetallePedidoC.Size = new Size(939, 231);
            dataGridViewDetallePedidoC.TabIndex = 3;
            // 
            // dataGridViewPedidoC
            // 
            dataGridViewPedidoC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidoC.Location = new Point(309, 36);
            dataGridViewPedidoC.Margin = new Padding(4, 3, 4, 3);
            dataGridViewPedidoC.Name = "dataGridViewPedidoC";
            dataGridViewPedidoC.Size = new Size(670, 148);
            dataGridViewPedidoC.TabIndex = 2;
            // 
            // txtIdPedidoC
            // 
            txtIdPedidoC.Location = new Point(125, 51);
            txtIdPedidoC.Margin = new Padding(4, 3, 4, 3);
            txtIdPedidoC.Name = "txtIdPedidoC";
            txtIdPedidoC.Size = new Size(116, 23);
            txtIdPedidoC.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(29, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Id Pedido";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(597, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1031, 532);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxConsultaPedidos);
            Controls.Add(btnConsultarPedidos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Consulta";
            Text = "Agregar_Pedido";
            groupBoxConsultaPedidos.ResumeLayout(false);
            groupBoxConsultaPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetallePedidoC).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidoC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnConsultarPedidos;
        private System.Windows.Forms.GroupBox groupBoxConsultaPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCP;
        private System.Windows.Forms.DataGridView dataGridViewDetallePedidoC;
        private System.Windows.Forms.DataGridView dataGridViewPedidoC;
        private System.Windows.Forms.TextBox txtIdPedidoC;
        private PictureBox pictureBox1;
    }
}