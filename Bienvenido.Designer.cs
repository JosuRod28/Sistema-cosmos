namespace COSMOSCOM
{
    partial class Bienvenido
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txt_usuario = new TextBox();
            label5 = new Label();
            txt_clave = new TextBox();
            txt_email = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            btn_Crear = new Button();
            btn_cancelar = new Button();
            btn_iniciar_sesion = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Moccasin;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.8656712F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.Size = new Size(800, 603);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Moccasin;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.72796F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.27204F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 544);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.BlanchedAlmond;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel3.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Location = new Point(112, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 24.5689659F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0371752F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 65.4275055F));
            tableLayoutPanel3.Size = new Size(586, 538);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.37931F));
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Location = new Point(3, 188);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25.5924168F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 277F));
            tableLayoutPanel5.Size = new Size(580, 320);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(3, 5);
            label4.Name = "label4";
            label4.Size = new Size(574, 32);
            label4.TabIndex = 0;
            label4.Text = "Crea un nuevo usuario o Inicia Sesión";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.18118F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.8188171F));
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Controls.Add(label2, 0, 1);
            tableLayoutPanel6.Controls.Add(txt_usuario, 1, 0);
            tableLayoutPanel6.Controls.Add(label5, 0, 2);
            tableLayoutPanel6.Controls.Add(txt_clave, 1, 2);
            tableLayoutPanel6.Controls.Add(txt_email, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 46);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Size = new Size(574, 271);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(3, 30);
            label1.Name = "label1";
            label1.Size = new Size(304, 30);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(3, 120);
            label2.Name = "label2";
            label2.Size = new Size(304, 30);
            label2.TabIndex = 0;
            label2.Text = "Correo";
            // 
            // txt_usuario
            // 
            txt_usuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_usuario.Location = new Point(313, 29);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(258, 31);
            txt_usuario.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(3, 210);
            label5.Name = "label5";
            label5.Size = new Size(304, 30);
            label5.TabIndex = 0;
            label5.Text = "Contraseña";
            // 
            // txt_clave
            // 
            txt_clave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_clave.Location = new Point(313, 210);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(258, 31);
            txt_clave.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_email.Location = new Point(313, 119);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(258, 31);
            txt_email.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(580, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(3, 136);
            label3.Name = "label3";
            label3.Size = new Size(580, 45);
            label3.TabIndex = 2;
            label3.Text = "Bienvenido(a)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.7682571F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.8984051F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(btn_Crear, 0, 0);
            tableLayoutPanel4.Controls.Add(btn_cancelar, 2, 0);
            tableLayoutPanel4.Controls.Add(btn_iniciar_sesion, 1, 0);
            tableLayoutPanel4.Location = new Point(273, 553);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(524, 47);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btn_Crear
            // 
            btn_Crear.BackColor = Color.White;
            btn_Crear.Dock = DockStyle.Fill;
            btn_Crear.FlatStyle = FlatStyle.Flat;
            btn_Crear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Crear.ForeColor = Color.MediumBlue;
            btn_Crear.Location = new Point(3, 3);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(181, 41);
            btn_Crear.TabIndex = 0;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = false;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.White;
            btn_cancelar.Dock = DockStyle.Fill;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_cancelar.ForeColor = Color.MediumBlue;
            btn_cancelar.Location = new Point(351, 3);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(170, 41);
            btn_cancelar.TabIndex = 0;
            btn_cancelar.Text = "Salir";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_iniciar_sesion
            // 
            btn_iniciar_sesion.BackColor = Color.White;
            btn_iniciar_sesion.Dock = DockStyle.Fill;
            btn_iniciar_sesion.FlatStyle = FlatStyle.Flat;
            btn_iniciar_sesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_iniciar_sesion.ForeColor = Color.MediumBlue;
            btn_iniciar_sesion.Location = new Point(190, 3);
            btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            btn_iniciar_sesion.Size = new Size(155, 41);
            btn_iniciar_sesion.TabIndex = 1;
            btn_iniciar_sesion.Text = "Iniciar Sesion";
            btn_iniciar_sesion.UseVisualStyleBackColor = false;
            btn_iniciar_sesion.Click += btn_iniciar_sesion_Click;
            // 
            // Bienvenido
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(800, 603);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(822, 659);
            MinimumSize = new Size(822, 659);
            Name = "Bienvenido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido";
            Load += Bienvenido_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btn_Crear;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label1;
        private Label label2;
        private TextBox txt_usuario;
        private TextBox txt_clave;
        private Button btn_cancelar;
        private Button btn_iniciar_sesion;
        private Label label5;
        private TextBox txt_email;
    }
}