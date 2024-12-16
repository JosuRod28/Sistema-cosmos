namespace COSMOSCOM
{
    partial class Modificar_Usuarios
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
            label2 = new Label();
            label1 = new Label();
            txt_Usuario = new TextBox();
            label4 = new Label();
            txt_id_usuario = new TextBox();
            button2 = new Button();
            label3 = new Label();
            txt_Rol = new TextBox();
            button1 = new Button();
            label5 = new Label();
            txt_passwd = new TextBox();
            txt_correo = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.607708F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.392292F));
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(txt_Usuario, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(txt_id_usuario, 1, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(txt_Rol, 1, 4);
            tableLayoutPanel1.Controls.Add(button1, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(txt_passwd, 1, 2);
            tableLayoutPanel1.Controls.Add(txt_correo, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.4444447F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.333334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.666667F));
            tableLayoutPanel1.Size = new Size(441, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(3, 171);
            label2.Name = "label2";
            label2.Size = new Size(226, 30);
            label2.TabIndex = 0;
            label2.Text = "Constraseña";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(3, 86);
            label1.Name = "label1";
            label1.Size = new Size(226, 30);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            txt_Usuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_Usuario.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            txt_Usuario.Location = new Point(235, 83);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(203, 37);
            txt_Usuario.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(3, 15);
            label4.Name = "label4";
            label4.Size = new Size(226, 30);
            label4.TabIndex = 0;
            label4.Text = "id_Usuario";
            // 
            // txt_id_usuario
            // 
            txt_id_usuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_id_usuario.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            txt_id_usuario.Location = new Point(235, 11);
            txt_id_usuario.Name = "txt_id_usuario";
            txt_id_usuario.Size = new Size(203, 37);
            txt_id_usuario.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button2.ForeColor = Color.DarkOrange;
            button2.Location = new Point(235, 386);
            button2.Name = "button2";
            button2.Size = new Size(203, 52);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(3, 327);
            label3.Name = "label3";
            label3.Size = new Size(226, 30);
            label3.TabIndex = 0;
            label3.Text = "Rol";
            // 
            // txt_Rol
            // 
            txt_Rol.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_Rol.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            txt_Rol.Location = new Point(235, 324);
            txt_Rol.Name = "txt_Rol";
            txt_Rol.Size = new Size(203, 37);
            txt_Rol.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(3, 386);
            button1.Name = "button1";
            button1.Size = new Size(214, 52);
            button1.TabIndex = 2;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(3, 251);
            label5.Name = "label5";
            label5.Size = new Size(226, 30);
            label5.TabIndex = 0;
            label5.Text = "Correo";
            label5.Click += label2_Click;
            // 
            // txt_passwd
            // 
            txt_passwd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_passwd.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            txt_passwd.Location = new Point(235, 168);
            txt_passwd.Name = "txt_passwd";
            txt_passwd.Size = new Size(203, 37);
            txt_passwd.TabIndex = 1;
            txt_passwd.TextChanged += txt_passwd_TextChanged;
            // 
            // txt_correo
            // 
            txt_correo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_correo.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            txt_correo.Location = new Point(235, 247);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(203, 37);
            txt_correo.TabIndex = 1;
            txt_correo.TextChanged += txt_passwd_TextChanged;
            // 
            // Modificar_Usuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Modificar_Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar_Usuarios";
            Load += Modificar_Usuarios_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Usuario;
        private TextBox txt_passwd;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox txt_id_usuario;
        private TextBox txt_Rol;
        private Label label5;
        private TextBox txt_correo;
    }
}