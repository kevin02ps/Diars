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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
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
            btnConsultarPedidos.BackColor = Color.Cornsilk;
            btnConsultarPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConsultarPedidos.Image = (Image)resources.GetObject("btnConsultarPedidos.Image");
            btnConsultarPedidos.ImageAlign = ContentAlignment.MiddleRight;
            btnConsultarPedidos.Location = new Point(65, 12);
            btnConsultarPedidos.Margin = new Padding(4, 3, 4, 3);
            btnConsultarPedidos.Name = "btnConsultarPedidos";
            btnConsultarPedidos.Size = new Size(201, 29);
            btnConsultarPedidos.TabIndex = 0;
            btnConsultarPedidos.Text = "Consultar Pedidos";
            btnConsultarPedidos.UseVisualStyleBackColor = false;
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
            btnBuscarCP.BackColor = SystemColors.InactiveBorder;
            btnBuscarCP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarCP.Image = (Image)resources.GetObject("btnBuscarCP.Image");
            btnBuscarCP.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarCP.Location = new Point(80, 102);
            btnBuscarCP.Margin = new Padding(4, 3, 4, 3);
            btnBuscarCP.Name = "btnBuscarCP";
            btnBuscarCP.Size = new Size(134, 40);
            btnBuscarCP.TabIndex = 4;
            btnBuscarCP.Text = "Buscar";
            btnBuscarCP.UseVisualStyleBackColor = false;
            btnBuscarCP.Click += btnBuscarCP_Click;
            // 
            // dataGridViewDetallePedidoC
            // 
            dataGridViewDetallePedidoC.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridViewDetallePedidoC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDetallePedidoC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDetallePedidoC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewDetallePedidoC.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDetallePedidoC.EnableHeadersVisualStyles = false;
            dataGridViewDetallePedidoC.GridColor = Color.SteelBlue;
            dataGridViewDetallePedidoC.Location = new Point(40, 209);
            dataGridViewDetallePedidoC.Margin = new Padding(4, 3, 4, 3);
            dataGridViewDetallePedidoC.Name = "dataGridViewDetallePedidoC";
            dataGridViewDetallePedidoC.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDetallePedidoC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewDetallePedidoC.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewDetallePedidoC.Size = new Size(939, 231);
            dataGridViewDetallePedidoC.TabIndex = 3;
            // 
            // dataGridViewPedidoC
            // 
            dataGridViewPedidoC.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridViewPedidoC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewPedidoC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewPedidoC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidoC.EnableHeadersVisualStyles = false;
            dataGridViewPedidoC.GridColor = Color.RoyalBlue;
            dataGridViewPedidoC.Location = new Point(309, 36);
            dataGridViewPedidoC.Margin = new Padding(4, 3, 4, 3);
            dataGridViewPedidoC.Name = "dataGridViewPedidoC";
            dataGridViewPedidoC.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewPedidoC.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewPedidoC.RowsDefaultCellStyle = dataGridViewCellStyle7;
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
            BackColor = SystemColors.ActiveCaption;
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