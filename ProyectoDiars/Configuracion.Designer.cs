namespace InversionesHermanos
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            label1 = new Label();
            txtUbiComprobantes = new TextBox();
            btnUbiComprobante = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(89, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 16);
            label1.TabIndex = 0;
            label1.Text = "Ubicacion donde se guarda los comprobantes:";
            // 
            // txtUbiComprobantes
            // 
            txtUbiComprobantes.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            txtUbiComprobantes.Location = new Point(89, 81);
            txtUbiComprobantes.Margin = new Padding(4, 3, 4, 3);
            txtUbiComprobantes.Name = "txtUbiComprobantes";
            txtUbiComprobantes.Size = new Size(480, 22);
            txtUbiComprobantes.TabIndex = 1;
            // 
            // btnUbiComprobante
            // 
            btnUbiComprobante.BackColor = Color.Black;
            btnUbiComprobante.FlatAppearance.BorderSize = 0;
            btnUbiComprobante.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnUbiComprobante.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnUbiComprobante.FlatStyle = FlatStyle.Flat;
            btnUbiComprobante.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnUbiComprobante.ForeColor = Color.LightGray;
            btnUbiComprobante.Image = (Image)resources.GetObject("btnUbiComprobante.Image");
            btnUbiComprobante.ImageAlign = ContentAlignment.MiddleRight;
            btnUbiComprobante.Location = new Point(594, 71);
            btnUbiComprobante.Margin = new Padding(4, 3, 4, 3);
            btnUbiComprobante.Name = "btnUbiComprobante";
            btnUbiComprobante.Size = new Size(142, 42);
            btnUbiComprobante.TabIndex = 2;
            btnUbiComprobante.Text = "CONFIRMAR";
            btnUbiComprobante.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUbiComprobante.UseVisualStyleBackColor = false;
            btnUbiComprobante.Click += btnUbiComprobante_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(153, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 41, 68);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(787, 415);
            Controls.Add(pictureBox1);
            Controls.Add(btnUbiComprobante);
            Controls.Add(txtUbiComprobantes);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Configuracion";
            Opacity = 0.9D;
            Text = "Configuracion";
            Load += Configuracion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUbiComprobantes;
        private System.Windows.Forms.Button btnUbiComprobante;
        private PictureBox pictureBox1;
    }
}