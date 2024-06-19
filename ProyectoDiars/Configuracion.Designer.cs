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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 15);
            label1.TabIndex = 0;
            label1.Text = "Ubicacion donde se guarda los comprobantes:";
            // 
            // txtUbiComprobantes
            // 
            txtUbiComprobantes.Location = new Point(89, 81);
            txtUbiComprobantes.Margin = new Padding(4, 3, 4, 3);
            txtUbiComprobantes.Name = "txtUbiComprobantes";
            txtUbiComprobantes.Size = new Size(480, 23);
            txtUbiComprobantes.TabIndex = 1;
            // 
            // btnUbiComprobante
            // 
            btnUbiComprobante.Location = new Point(594, 78);
            btnUbiComprobante.Margin = new Padding(4, 3, 4, 3);
            btnUbiComprobante.Name = "btnUbiComprobante";
            btnUbiComprobante.Size = new Size(120, 27);
            btnUbiComprobante.TabIndex = 2;
            btnUbiComprobante.Text = "CONFIRMAR";
            btnUbiComprobante.UseVisualStyleBackColor = true;
            btnUbiComprobante.Click += btnUbiComprobante_Click;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(749, 421);
            Controls.Add(btnUbiComprobante);
            Controls.Add(txtUbiComprobantes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Configuracion";
            Text = "Configuracion";
            Load += Configuracion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUbiComprobantes;
        private System.Windows.Forms.Button btnUbiComprobante;
    }
}