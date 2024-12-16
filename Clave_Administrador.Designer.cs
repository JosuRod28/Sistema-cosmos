namespace COSMOSCOM
{
    partial class Clave_Administrador
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
            label1 = new Label();
            txt_claveAdmin = new TextBox();
            btn_aceptar = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txt_claveAdmin, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_aceptar, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(255, 114);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(249, 25);
            label1.TabIndex = 0;
            label1.Text = "Contraeña administrador";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_claveAdmin
            // 
            txt_claveAdmin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_claveAdmin.Location = new Point(3, 40);
            txt_claveAdmin.Name = "txt_claveAdmin";
            txt_claveAdmin.Size = new Size(249, 31);
            txt_claveAdmin.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_aceptar.Location = new Point(3, 77);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(249, 34);
            btn_aceptar.TabIndex = 2;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // Clave_Administrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 114);
            Controls.Add(tableLayoutPanel1);
            Name = "Clave_Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contraseña Administrador";
            Load += Clave_Administrador_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txt_claveAdmin;
        private Button btn_aceptar;
    }
}