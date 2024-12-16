namespace COSMOSCOM
{
    partial class Autenticacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txtClave = new TextBox();
            cbUsuarios = new ComboBox();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            btnSalir = new Button();
            linkLabel2 = new LinkLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.usuario1;
            pictureBox1.Location = new Point(325, 21);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.BlanchedAlmond;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.62708F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3858089F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.0266075F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 3);
            tableLayoutPanel1.Controls.Add(txtClave, 1, 4);
            tableLayoutPanel1.Controls.Add(cbUsuarios, 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnLogin, 1, 5);
            tableLayoutPanel1.Controls.Add(linkLabel1, 1, 6);
            tableLayoutPanel1.Controls.Add(btnSalir, 2, 7);
            tableLayoutPanel1.Controls.Add(linkLabel2, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 142);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.70968F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.68356371F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.29493F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.912442F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.06605244F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1351767F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.831029F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9032259F));
            tableLayoutPanel1.Size = new Size(902, 647);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(325, 246);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 30);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(325, 334);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 30);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.Location = new Point(325, 382);
            txtClave.Margin = new Padding(4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(229, 31);
            txtClave.TabIndex = 4;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // cbUsuarios
            // 
            cbUsuarios.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbUsuarios.ForeColor = SystemColors.Desktop;
            cbUsuarios.FormattingEnabled = true;
            cbUsuarios.Location = new Point(325, 291);
            cbUsuarios.Margin = new Padding(4);
            cbUsuarios.Name = "cbUsuarios";
            cbUsuarios.Size = new Size(229, 33);
            cbUsuarios.TabIndex = 7;
            cbUsuarios.Text = "Elige un usuario";
            cbUsuarios.SelectedIndexChanged += txtUsuario_SelectedIndexChanged;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.GhostWhite;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Orange;
            btnLogin.Location = new Point(325, 437);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(229, 48);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.DarkOrange;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(324, 503);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(231, 56);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Crear un nuevo usuario";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.GhostWhite;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Orange;
            btnSalir.Location = new Point(671, 580);
            btnSalir.Margin = new Padding(4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 48);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button2_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(324, 574);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(231, 60);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Olvide mi contraseña";
            linkLabel2.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Moccasin;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(902, 134);
            tableLayoutPanel2.TabIndex = 2;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.BlanchedAlmond;
            pictureBox2.Image = Properties.Resources.Logo;
            pictureBox2.Location = new Point(4, 4);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(894, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Autenticacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(902, 789);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            MaximumSize = new Size(924, 845);
            MinimumSize = new Size(924, 845);
            Name = "Autenticacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += Autenticacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox txtClave;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox2;
        private Button btnLogin;
        private Button btnSalir;
        private ComboBox cbUsuarios;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}
