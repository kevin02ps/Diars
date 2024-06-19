namespace InversionesHermanos
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnEliminar = new Button();
            btnModificarCliente = new Button();
            btnAgregarCliente = new Button();
            dataGridView1 = new DataGridView();
            groupBoxModificar = new GroupBox();
            btnBuscarM = new Button();
            txtIDM = new TextBox();
            label11 = new Label();
            btnModificar = new Button();
            groupBoxdatosM = new GroupBox();
            comboBoxCargoM = new ComboBox();
            txtUsuarioM = new TextBox();
            txtDniM = new TextBox();
            label9 = new Label();
            txtContraseñaM = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBoxAgregarCliente = new GroupBox();
            comboBoxCargoA = new ComboBox();
            label2 = new Label();
            label10 = new Label();
            label12 = new Label();
            btnAceptarA = new Button();
            txtContraseñaA = new TextBox();
            txtUsuarioA = new TextBox();
            txtDniA = new TextBox();
            label1 = new Label();
            groupBoxEliminar = new GroupBox();
            txtIDE = new TextBox();
            label17 = new Label();
            btnEliminarE = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxModificar.SuspendLayout();
            groupBoxdatosM.SuspendLayout();
            groupBoxAgregarCliente.SuspendLayout();
            groupBoxEliminar.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.LightGray;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.Location = new Point(301, 32);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 43);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = Color.Black;
            btnModificarCliente.FlatAppearance.BorderSize = 0;
            btnModificarCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnModificarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnModificarCliente.FlatStyle = FlatStyle.Flat;
            btnModificarCliente.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnModificarCliente.ForeColor = Color.LightGray;
            btnModificarCliente.Image = (Image)resources.GetObject("btnModificarCliente.Image");
            btnModificarCliente.ImageAlign = ContentAlignment.MiddleRight;
            btnModificarCliente.Location = new Point(163, 32);
            btnModificarCliente.Margin = new Padding(4, 3, 4, 3);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(130, 43);
            btnModificarCliente.TabIndex = 18;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificarCliente.UseVisualStyleBackColor = false;
            btnModificarCliente.Click += btnModificarEmpleado_Click_1;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.Black;
            btnAgregarCliente.FlatAppearance.BorderSize = 0;
            btnAgregarCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAgregarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnAgregarCliente.ForeColor = Color.LightGray;
            btnAgregarCliente.Image = (Image)resources.GetObject("btnAgregarCliente.Image");
            btnAgregarCliente.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregarCliente.Location = new Point(28, 32);
            btnAgregarCliente.Margin = new Padding(4, 3, 4, 3);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(127, 43);
            btnAgregarCliente.TabIndex = 17;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarEmpleado_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.SteelBlue;
            dataGridView1.Location = new Point(455, 23);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(581, 531);
            dataGridView1.TabIndex = 15;
            // 
            // groupBoxModificar
            // 
            groupBoxModificar.BackColor = Color.Transparent;
            groupBoxModificar.Controls.Add(btnBuscarM);
            groupBoxModificar.Controls.Add(txtIDM);
            groupBoxModificar.Controls.Add(label11);
            groupBoxModificar.Controls.Add(btnModificar);
            groupBoxModificar.Controls.Add(groupBoxdatosM);
            groupBoxModificar.Location = new Point(14, 93);
            groupBoxModificar.Margin = new Padding(4, 3, 4, 3);
            groupBoxModificar.Name = "groupBoxModificar";
            groupBoxModificar.Padding = new Padding(4, 3, 4, 3);
            groupBoxModificar.Size = new Size(420, 460);
            groupBoxModificar.TabIndex = 20;
            groupBoxModificar.TabStop = false;
            // 
            // btnBuscarM
            // 
            btnBuscarM.BackColor = SystemColors.Control;
            btnBuscarM.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnBuscarM.Image = (Image)resources.GetObject("btnBuscarM.Image");
            btnBuscarM.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarM.Location = new Point(258, 31);
            btnBuscarM.Margin = new Padding(4, 3, 4, 3);
            btnBuscarM.Name = "btnBuscarM";
            btnBuscarM.Size = new Size(113, 46);
            btnBuscarM.TabIndex = 13;
            btnBuscarM.Text = "Buscar";
            btnBuscarM.UseVisualStyleBackColor = false;
            btnBuscarM.Click += btnBuscarM_Click_1;
            // 
            // txtIDM
            // 
            txtIDM.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            txtIDM.Location = new Point(126, 40);
            txtIDM.Margin = new Padding(4, 3, 4, 3);
            txtIDM.Name = "txtIDM";
            txtIDM.Size = new Size(106, 22);
            txtIDM.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label11.Location = new Point(40, 44);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 16);
            label11.TabIndex = 11;
            label11.Text = "Id Empleado";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.Control;
            btnModificar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleRight;
            btnModificar.Location = new Point(144, 354);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(147, 46);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // groupBoxdatosM
            // 
            groupBoxdatosM.Controls.Add(comboBoxCargoM);
            groupBoxdatosM.Controls.Add(txtUsuarioM);
            groupBoxdatosM.Controls.Add(txtDniM);
            groupBoxdatosM.Controls.Add(label9);
            groupBoxdatosM.Controls.Add(txtContraseñaM);
            groupBoxdatosM.Controls.Add(label6);
            groupBoxdatosM.Controls.Add(label8);
            groupBoxdatosM.Controls.Add(label7);
            groupBoxdatosM.Enabled = false;
            groupBoxdatosM.Location = new Point(7, 87);
            groupBoxdatosM.Margin = new Padding(4, 3, 4, 3);
            groupBoxdatosM.Name = "groupBoxdatosM";
            groupBoxdatosM.Padding = new Padding(4, 3, 4, 3);
            groupBoxdatosM.Size = new Size(406, 249);
            groupBoxdatosM.TabIndex = 5;
            groupBoxdatosM.TabStop = false;
            // 
            // comboBoxCargoM
            // 
            comboBoxCargoM.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            comboBoxCargoM.FormattingEnabled = true;
            comboBoxCargoM.Items.AddRange(new object[] { "GERENTE", "VENDEDOR", "ADMINISTRADOR" });
            comboBoxCargoM.Location = new Point(166, 95);
            comboBoxCargoM.Margin = new Padding(4, 3, 4, 3);
            comboBoxCargoM.Name = "comboBoxCargoM";
            comboBoxCargoM.Size = new Size(212, 24);
            comboBoxCargoM.TabIndex = 10;
            // 
            // txtUsuarioM
            // 
            txtUsuarioM.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            txtUsuarioM.Location = new Point(166, 138);
            txtUsuarioM.Margin = new Padding(4, 3, 4, 3);
            txtUsuarioM.Name = "txtUsuarioM";
            txtUsuarioM.Size = new Size(212, 22);
            txtUsuarioM.TabIndex = 7;
            // 
            // txtDniM
            // 
            txtDniM.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            txtDniM.Location = new Point(166, 37);
            txtDniM.Margin = new Padding(4, 3, 4, 3);
            txtDniM.Name = "txtDniM";
            txtDniM.Size = new Size(212, 22);
            txtDniM.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label9.Location = new Point(37, 45);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(28, 16);
            label9.TabIndex = 2;
            label9.Text = "DNI";
            // 
            // txtContraseñaM
            // 
            txtContraseñaM.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            txtContraseñaM.Location = new Point(166, 187);
            txtContraseñaM.Margin = new Padding(4, 3, 4, 3);
            txtContraseñaM.Name = "txtContraseñaM";
            txtContraseñaM.Size = new Size(212, 22);
            txtContraseñaM.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label6.Location = new Point(40, 194);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 16);
            label6.TabIndex = 8;
            label6.Text = "Contraseña";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label8.Location = new Point(40, 95);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(44, 16);
            label8.TabIndex = 4;
            label8.Text = "Cargo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label7.Location = new Point(40, 145);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(50, 16);
            label7.TabIndex = 6;
            label7.Text = "Usuario";
            // 
            // groupBoxAgregarCliente
            // 
            groupBoxAgregarCliente.BackColor = Color.Black;
            groupBoxAgregarCliente.Controls.Add(comboBoxCargoA);
            groupBoxAgregarCliente.Controls.Add(label2);
            groupBoxAgregarCliente.Controls.Add(label10);
            groupBoxAgregarCliente.Controls.Add(label12);
            groupBoxAgregarCliente.Controls.Add(btnAceptarA);
            groupBoxAgregarCliente.Controls.Add(txtContraseñaA);
            groupBoxAgregarCliente.Controls.Add(txtUsuarioA);
            groupBoxAgregarCliente.Controls.Add(txtDniA);
            groupBoxAgregarCliente.Controls.Add(label1);
            groupBoxAgregarCliente.Location = new Point(14, 93);
            groupBoxAgregarCliente.Margin = new Padding(4, 3, 4, 3);
            groupBoxAgregarCliente.Name = "groupBoxAgregarCliente";
            groupBoxAgregarCliente.Padding = new Padding(4, 3, 4, 3);
            groupBoxAgregarCliente.Size = new Size(420, 460);
            groupBoxAgregarCliente.TabIndex = 16;
            groupBoxAgregarCliente.TabStop = false;
            // 
            // comboBoxCargoA
            // 
            comboBoxCargoA.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            comboBoxCargoA.FormattingEnabled = true;
            comboBoxCargoA.Items.AddRange(new object[] { "GERENTE", "VENDEDOR", "ADMINISTRADOR" });
            comboBoxCargoA.Location = new Point(173, 99);
            comboBoxCargoA.Margin = new Padding(4, 3, 4, 3);
            comboBoxCargoA.Name = "comboBoxCargoA";
            comboBoxCargoA.Size = new Size(212, 24);
            comboBoxCargoA.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(30, 208);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 16);
            label2.TabIndex = 13;
            label2.Text = "Contraseña";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label10.ForeColor = Color.LightGray;
            label10.Location = new Point(30, 108);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(44, 16);
            label10.TabIndex = 11;
            label10.Text = "Cargo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label12.ForeColor = Color.LightGray;
            label12.Location = new Point(30, 159);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(50, 16);
            label12.TabIndex = 12;
            label12.Text = "Usuario";
            // 
            // btnAceptarA
            // 
            btnAceptarA.BackColor = Color.FromArgb(4, 41, 68);
            btnAceptarA.FlatAppearance.BorderSize = 0;
            btnAceptarA.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAceptarA.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAceptarA.FlatStyle = FlatStyle.Flat;
            btnAceptarA.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnAceptarA.ForeColor = Color.LightGray;
            btnAceptarA.Image = (Image)resources.GetObject("btnAceptarA.Image");
            btnAceptarA.ImageAlign = ContentAlignment.MiddleRight;
            btnAceptarA.Location = new Point(142, 274);
            btnAceptarA.Margin = new Padding(4, 3, 4, 3);
            btnAceptarA.Name = "btnAceptarA";
            btnAceptarA.Size = new Size(137, 48);
            btnAceptarA.TabIndex = 10;
            btnAceptarA.Text = "AGREGAR";
            btnAceptarA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptarA.UseVisualStyleBackColor = false;
            btnAceptarA.Click += btnAceptarA_Click_1;
            // 
            // txtContraseñaA
            // 
            txtContraseñaA.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            txtContraseñaA.Location = new Point(173, 200);
            txtContraseñaA.Margin = new Padding(4, 3, 4, 3);
            txtContraseñaA.Name = "txtContraseñaA";
            txtContraseñaA.Size = new Size(212, 22);
            txtContraseñaA.TabIndex = 9;
            // 
            // txtUsuarioA
            // 
            txtUsuarioA.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            txtUsuarioA.Location = new Point(173, 151);
            txtUsuarioA.Margin = new Padding(4, 3, 4, 3);
            txtUsuarioA.Name = "txtUsuarioA";
            txtUsuarioA.Size = new Size(212, 22);
            txtUsuarioA.TabIndex = 7;
            // 
            // txtDniA
            // 
            txtDniA.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            txtDniA.Location = new Point(173, 43);
            txtDniA.Margin = new Padding(4, 3, 4, 3);
            txtDniA.Name = "txtDniA";
            txtDniA.Size = new Size(212, 22);
            txtDniA.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(30, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 16);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // groupBoxEliminar
            // 
            groupBoxEliminar.BackColor = Color.Transparent;
            groupBoxEliminar.Controls.Add(txtIDE);
            groupBoxEliminar.Controls.Add(label17);
            groupBoxEliminar.Controls.Add(btnEliminarE);
            groupBoxEliminar.Location = new Point(14, 93);
            groupBoxEliminar.Margin = new Padding(4, 3, 4, 3);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Padding = new Padding(4, 3, 4, 3);
            groupBoxEliminar.Size = new Size(420, 460);
            groupBoxEliminar.TabIndex = 21;
            groupBoxEliminar.TabStop = false;
            // 
            // txtIDE
            // 
            txtIDE.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            txtIDE.Location = new Point(203, 102);
            txtIDE.Margin = new Padding(4, 3, 4, 3);
            txtIDE.Name = "txtIDE";
            txtIDE.Size = new Size(106, 22);
            txtIDE.TabIndex = 12;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label17.Location = new Point(92, 105);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(82, 16);
            label17.TabIndex = 11;
            label17.Text = "Id Empleado";
            // 
            // btnEliminarE
            // 
            btnEliminarE.BackColor = SystemColors.Control;
            btnEliminarE.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnEliminarE.Image = (Image)resources.GetObject("btnEliminarE.Image");
            btnEliminarE.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminarE.Location = new Point(126, 195);
            btnEliminarE.Margin = new Padding(4, 3, 4, 3);
            btnEliminarE.Name = "btnEliminarE";
            btnEliminarE.Size = new Size(127, 45);
            btnEliminarE.TabIndex = 10;
            btnEliminarE.Text = "ELIMINAR";
            btnEliminarE.UseVisualStyleBackColor = false;
            btnEliminarE.Click += btnEliminarE_Click_1;
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(4, 41, 68);
            ClientSize = new Size(1050, 577);
            ControlBox = false;
            Controls.Add(btnEliminar);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxAgregarCliente);
            Controls.Add(groupBoxEliminar);
            Controls.Add(groupBoxModificar);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Empleado";
            Opacity = 0.9D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrarse";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxModificar.ResumeLayout(false);
            groupBoxModificar.PerformLayout();
            groupBoxdatosM.ResumeLayout(false);
            groupBoxdatosM.PerformLayout();
            groupBoxAgregarCliente.ResumeLayout(false);
            groupBoxAgregarCliente.PerformLayout();
            groupBoxEliminar.ResumeLayout(false);
            groupBoxEliminar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxModificar;
        private System.Windows.Forms.Button btnBuscarM;
        private System.Windows.Forms.GroupBox groupBoxdatosM;
        private System.Windows.Forms.TextBox txtUsuarioM;
        private System.Windows.Forms.TextBox txtDniM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContraseñaM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBoxAgregarCliente;
        private System.Windows.Forms.Button btnAceptarA;
        private System.Windows.Forms.TextBox txtContraseñaA;
        private System.Windows.Forms.TextBox txtUsuarioA;
        private System.Windows.Forms.TextBox txtDniA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxEliminar;
        private System.Windows.Forms.TextBox txtIDE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnEliminarE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCargoM;
        private System.Windows.Forms.ComboBox comboBoxCargoA;
    }
}