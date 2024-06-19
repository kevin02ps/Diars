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
            chartControl1 = new DevExpress.XtraCharts.ChartControl();
            chartControl2 = new DevExpress.XtraCharts.ChartControl();
            comboBoxGrafico1 = new ComboBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartControl2).BeginInit();
            SuspendLayout();
            // 
            // chartControl1
            // 
            chartControl1.Location = new Point(12, 56);
            chartControl1.Name = "chartControl1";
            chartControl1.Size = new Size(678, 336);
            chartControl1.TabIndex = 0;
            // 
            // chartControl2
            // 
            chartControl2.Location = new Point(719, 116);
            chartControl2.Name = "chartControl2";
            chartControl2.Size = new Size(300, 276);
            chartControl2.TabIndex = 1;
            // 
            // comboBoxGrafico1
            // 
            comboBoxGrafico1.BackColor = Color.White;
            comboBoxGrafico1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            comboBoxGrafico1.ForeColor = Color.White;
            comboBoxGrafico1.FormattingEnabled = true;
            comboBoxGrafico1.Items.AddRange(new object[] { "Cantidad por producto", "Ventas totales" });
            comboBoxGrafico1.Location = new Point(12, 12);
            comboBoxGrafico1.Name = "comboBoxGrafico1";
            comboBoxGrafico1.Size = new Size(245, 24);
            comboBoxGrafico1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            button1.ForeColor = Color.LightGray;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(737, 5);
            button1.Name = "button1";
            button1.Size = new Size(132, 39);
            button1.TabIndex = 3;
            button1.Text = "Confirmar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(456, 14);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 22);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(611, 12);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(84, 22);
            dateTimePicker2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(406, 16);
            label1.Name = "label1";
            label1.Size = new Size(44, 16);
            label1.TabIndex = 6;
            label1.Text = "DESDE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(557, 17);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 7;
            label2.Text = "HASTA:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Diario", "Mensual", "Anual" });
            comboBox1.Location = new Point(279, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 24);
            comboBox1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(5, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 380);
            panel1.TabIndex = 9;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 41, 68);
            ClientSize = new Size(1039, 471);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(comboBoxGrafico1);
            Controls.Add(chartControl2);
            Controls.Add(chartControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Consulta";
            Opacity = 0.9D;
            Text = "Agregar_Pedido";
            ((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private ComboBox comboBoxGrafico1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Panel panel1;
    }
}