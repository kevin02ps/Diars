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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUbiComprobantes = new System.Windows.Forms.TextBox();
            this.btnUbiComprobante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ubicacion donde se guarda los comprobantes:";
            // 
            // txtUbiComprobantes
            // 
            this.txtUbiComprobantes.Location = new System.Drawing.Point(91, 71);
            this.txtUbiComprobantes.Name = "txtUbiComprobantes";
            this.txtUbiComprobantes.Size = new System.Drawing.Size(412, 20);
            this.txtUbiComprobantes.TabIndex = 1;
            // 
            // btnUbiComprobante
            // 
            this.btnUbiComprobante.Location = new System.Drawing.Point(509, 68);
            this.btnUbiComprobante.Name = "btnUbiComprobante";
            this.btnUbiComprobante.Size = new System.Drawing.Size(103, 23);
            this.btnUbiComprobante.TabIndex = 2;
            this.btnUbiComprobante.Text = "CONFIRMAR";
            this.btnUbiComprobante.UseVisualStyleBackColor = true;
            this.btnUbiComprobante.Click += new System.EventHandler(this.btnUbiComprobante_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnUbiComprobante);
            this.Controls.Add(this.txtUbiComprobantes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUbiComprobantes;
        private System.Windows.Forms.Button btnUbiComprobante;
    }
}