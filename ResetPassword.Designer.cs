namespace COSMOSCOM
{
    partial class ResetPassword
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txt_NuevaClave = new TextBox();
            label2 = new Label();
            txt_ConfirmarClave = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_restablecer = new Button();
            btn_Cerrar = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DarkOrange;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 407);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Restablecer Contraseña";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txt_NuevaClave, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(txt_ConfirmarClave, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 4);
            tableLayoutPanel1.Location = new Point(26, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4727793F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.0515766F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.1315794F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7894735F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.86842F));
            tableLayoutPanel1.Size = new Size(419, 352);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(413, 28);
            label1.TabIndex = 0;
            label1.Text = "Nueva Contraseña";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_NuevaClave
            // 
            txt_NuevaClave.Anchor = AnchorStyles.None;
            txt_NuevaClave.Location = new Point(134, 68);
            txt_NuevaClave.Name = "txt_NuevaClave";
            txt_NuevaClave.Size = new Size(150, 34);
            txt_NuevaClave.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 129);
            label2.Name = "label2";
            label2.Size = new Size(413, 28);
            label2.TabIndex = 2;
            label2.Text = "Confirmar contraseña";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_ConfirmarClave
            // 
            txt_ConfirmarClave.Anchor = AnchorStyles.None;
            txt_ConfirmarClave.Location = new Point(134, 180);
            txt_ConfirmarClave.Name = "txt_ConfirmarClave";
            txt_ConfirmarClave.Size = new Size(150, 34);
            txt_ConfirmarClave.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(btn_restablecer, 1, 0);
            tableLayoutPanel2.Controls.Add(btn_Cerrar, 1, 1);
            tableLayoutPanel2.Location = new Point(3, 228);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.5454559F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4545441F));
            tableLayoutPanel2.Size = new Size(413, 110);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btn_restablecer
            // 
            btn_restablecer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_restablecer.BackColor = Color.White;
            btn_restablecer.FlatStyle = FlatStyle.Flat;
            btn_restablecer.Location = new Point(140, 8);
            btn_restablecer.Name = "btn_restablecer";
            btn_restablecer.Size = new Size(131, 43);
            btn_restablecer.TabIndex = 0;
            btn_restablecer.Text = "Aceptar";
            btn_restablecer.UseVisualStyleBackColor = false;
            btn_restablecer.Click += btn_restablecer_Click;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_Cerrar.BackColor = Color.White;
            btn_Cerrar.FlatStyle = FlatStyle.Flat;
            btn_Cerrar.Location = new Point(140, 64);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(131, 41);
            btn_Cerrar.TabIndex = 1;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.UseVisualStyleBackColor = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 431);
            Controls.Add(groupBox1);
            MinimumSize = new Size(514, 430);
            Name = "ResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restablecer Contraseña";
            Load += ResetPassword_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txt_NuevaClave;
        private Label label2;
        private TextBox txt_ConfirmarClave;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_restablecer;
        private Button btn_Cerrar;
    }
}