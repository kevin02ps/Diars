namespace InversionesHermanos
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            btnIniciarSesion = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Black;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 10.8F);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(78, 67);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(228, 18);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Usuario";
            // 
            // txtPassword
            // 
            txtPassword.AccessibleDescription = "";
            txtPassword.AccessibleName = "";
            txtPassword.BackColor = Color.Black;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 10.8F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(79, 105);
            txtPassword.MaxLength = 30;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(228, 18);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(40, 40, 40);
            btnIniciarSesion.FlatAppearance.BorderColor = Color.DarkGray;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Microsoft Sans Serif", 7.8F);
            btnIniciarSesion.ForeColor = Color.LightGray;
            btnIniciarSesion.Image = (Image)resources.GetObject("btnIniciarSesion.Image");
            btnIniciarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btnIniciarSesion.Location = new Point(79, 146);
            btnIniciarSesion.Margin = new Padding(4, 3, 4, 3);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(239, 63);
            btnIniciarSesion.TabIndex = 3;
            btnIniciarSesion.Text = "ACCEDER";
            btnIniciarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnIniciarSesion);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 240);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(75, 16);
            label3.Name = "label3";
            label3.Size = new Size(243, 25);
            label3.TabIndex = 9;
            label3.Text = "Inversiones Hermanos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(75, 73);
            label1.Name = "label1";
            label1.Size = new Size(217, 13);
            label1.TabIndex = 10;
            label1.Text = "______________________________\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(75, 111);
            label2.Name = "label2";
            label2.Size = new Size(217, 13);
            label2.TabIndex = 11;
            label2.Text = "______________________________\r\n";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 41);
            panel2.TabIndex = 6;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(338, 3);
            button2.Name = "button2";
            button2.Size = new Size(53, 35);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(279, 3);
            button1.Name = "button1";
            button1.Size = new Size(53, 35);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(393, 431);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inversiones Hermanos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private PictureBox pictureBox1;
        private Button btnIniciarSesion;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}

