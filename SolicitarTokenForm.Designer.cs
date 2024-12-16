namespace COSMOSCOM
{
    partial class SolicitarTokenForm
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
            tableLayoutPanel3 = new TableLayoutPanel();
            btn_solicitarToken = new Button();
            label1 = new Label();
            txt_email = new TextBox();
            label2 = new Label();
            txt_ClaveReset = new TextBox();
            btn_verClave = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.11688F));
            tableLayoutPanel1.Size = new Size(571, 353);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.4074059F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.5925941F));
            tableLayoutPanel3.Controls.Add(btn_solicitarToken, 1, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(txt_email, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 2);
            tableLayoutPanel3.Controls.Add(txt_ClaveReset, 1, 2);
            tableLayoutPanel3.Controls.Add(btn_verClave, 1, 3);
            tableLayoutPanel3.Controls.Add(button1, 1, 4);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 21.31783F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.3798447F));
            tableLayoutPanel3.Size = new Size(565, 347);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btn_solicitarToken
            // 
            btn_solicitarToken.BackColor = Color.White;
            btn_solicitarToken.Dock = DockStyle.Fill;
            btn_solicitarToken.FlatStyle = FlatStyle.Flat;
            btn_solicitarToken.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_solicitarToken.ForeColor = Color.DarkOrange;
            btn_solicitarToken.Location = new Point(242, 71);
            btn_solicitarToken.Name = "btn_solicitarToken";
            btn_solicitarToken.Size = new Size(320, 62);
            btn_solicitarToken.TabIndex = 0;
            btn_solicitarToken.Text = "Enviar Correo";
            btn_solicitarToken.UseVisualStyleBackColor = false;
            btn_solicitarToken.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(40, 20);
            label1.Margin = new Padding(40, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su email";
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_email.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_email.Location = new Point(242, 17);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(320, 34);
            txt_email.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(40, 156);
            label2.Margin = new Padding(40, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(196, 28);
            label2.TabIndex = 2;
            label2.Text = "Verificar Clave";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_ClaveReset
            // 
            txt_ClaveReset.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_ClaveReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_ClaveReset.Location = new Point(242, 153);
            txt_ClaveReset.Name = "txt_ClaveReset";
            txt_ClaveReset.Size = new Size(320, 34);
            txt_ClaveReset.TabIndex = 1;
            // 
            // btn_verClave
            // 
            btn_verClave.BackColor = Color.White;
            btn_verClave.Dock = DockStyle.Fill;
            btn_verClave.FlatStyle = FlatStyle.Flat;
            btn_verClave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_verClave.ForeColor = Color.DarkOrange;
            btn_verClave.Location = new Point(242, 207);
            btn_verClave.Name = "btn_verClave";
            btn_verClave.Size = new Size(320, 67);
            btn_verClave.TabIndex = 3;
            btn_verClave.Text = "Verificar Clave";
            btn_verClave.UseVisualStyleBackColor = false;
            btn_verClave.Click += btn_verClave_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(242, 280);
            button1.Name = "button1";
            button1.Size = new Size(320, 64);
            button1.TabIndex = 4;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // SolicitarTokenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 353);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(593, 409);
            MinimumSize = new Size(593, 409);
            Name = "SolicitarTokenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enviar clave de verificación";
            Load += SolicitarTokenForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_solicitarToken;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_ClaveReset;
        private Button btn_verClave;
        private Button button1;
    }
}