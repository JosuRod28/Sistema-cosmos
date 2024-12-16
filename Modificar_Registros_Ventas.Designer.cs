namespace COSMOSCOM
{
    partial class Modificar_Registros_Ventas
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
            Label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_Modificar = new Button();
            btn_Cerrar = new Button();
            txt_Folio = new TextBox();
            txt_id_Cliente = new TextBox();
            txt_fecha_de_atencion = new TextBox();
            txt_Total = new TextBox();
            dtp_Fecha_entrega = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(btn_Modificar, 0, 5);
            tableLayoutPanel1.Controls.Add(btn_Cerrar, 1, 5);
            tableLayoutPanel1.Controls.Add(txt_Folio, 1, 0);
            tableLayoutPanel1.Controls.Add(txt_id_Cliente, 1, 1);
            tableLayoutPanel1.Controls.Add(txt_fecha_de_atencion, 1, 2);
            tableLayoutPanel1.Controls.Add(txt_Total, 1, 4);
            tableLayoutPanel1.Controls.Add(dtp_Fecha_entrega, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.1244812F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4854774F));
            tableLayoutPanel1.Size = new Size(469, 482);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            Label1.ForeColor = Color.DarkOrange;
            Label1.Location = new Point(3, 25);
            Label1.Name = "Label1";
            Label1.Size = new Size(228, 30);
            Label1.TabIndex = 0;
            Label1.Text = "Folio";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(3, 105);
            label2.Name = "label2";
            label2.Size = new Size(228, 30);
            label2.TabIndex = 0;
            label2.Text = "id_Cliente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(3, 185);
            label3.Name = "label3";
            label3.Size = new Size(228, 30);
            label3.TabIndex = 0;
            label3.Text = "Fecha de atención";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(3, 265);
            label4.Name = "label4";
            label4.Size = new Size(228, 30);
            label4.TabIndex = 0;
            label4.Text = "Fecha de entrega";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(3, 353);
            label5.Name = "label5";
            label5.Size = new Size(228, 30);
            label5.TabIndex = 0;
            label5.Text = "Total";
            // 
            // btn_Modificar
            // 
            btn_Modificar.BackColor = Color.White;
            btn_Modificar.Dock = DockStyle.Fill;
            btn_Modificar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Modificar.ForeColor = Color.DarkOrange;
            btn_Modificar.Location = new Point(3, 419);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(228, 60);
            btn_Modificar.TabIndex = 1;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = false;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackColor = Color.White;
            btn_Cerrar.Dock = DockStyle.Fill;
            btn_Cerrar.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cerrar.ForeColor = Color.DarkOrange;
            btn_Cerrar.Location = new Point(237, 419);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(229, 60);
            btn_Cerrar.TabIndex = 1;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.UseVisualStyleBackColor = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // txt_Folio
            // 
            txt_Folio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_Folio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_Folio.Location = new Point(237, 21);
            txt_Folio.Name = "txt_Folio";
            txt_Folio.Size = new Size(229, 37);
            txt_Folio.TabIndex = 2;
            // 
            // txt_id_Cliente
            // 
            txt_id_Cliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_id_Cliente.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_id_Cliente.Location = new Point(237, 101);
            txt_id_Cliente.Name = "txt_id_Cliente";
            txt_id_Cliente.Size = new Size(229, 37);
            txt_id_Cliente.TabIndex = 2;
            // 
            // txt_fecha_de_atencion
            // 
            txt_fecha_de_atencion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_fecha_de_atencion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_fecha_de_atencion.Location = new Point(237, 181);
            txt_fecha_de_atencion.Name = "txt_fecha_de_atencion";
            txt_fecha_de_atencion.Size = new Size(229, 37);
            txt_fecha_de_atencion.TabIndex = 2;
            // 
            // txt_Total
            // 
            txt_Total.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_Total.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt_Total.Location = new Point(237, 349);
            txt_Total.Name = "txt_Total";
            txt_Total.Size = new Size(229, 37);
            txt_Total.TabIndex = 2;
            // 
            // dtp_Fecha_entrega
            // 
            dtp_Fecha_entrega.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtp_Fecha_entrega.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dtp_Fecha_entrega.Format = DateTimePickerFormat.Short;
            dtp_Fecha_entrega.Location = new Point(237, 261);
            dtp_Fecha_entrega.Name = "dtp_Fecha_entrega";
            dtp_Fecha_entrega.Size = new Size(229, 37);
            dtp_Fecha_entrega.TabIndex = 3;
            // 
            // Modificar_Registros_Ventas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(469, 482);
            Controls.Add(tableLayoutPanel1);
            Name = "Modificar_Registros_Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar_Registros_Ventas";
            Load += Modificar_Registros_Ventas_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Modificar;
        private Button btn_Cerrar;
        private TextBox txt_Folio;
        private TextBox txt_id_Cliente;
        private TextBox txt_fecha_de_atencion;
        private TextBox txt_Total;
        private DateTimePicker dtp_Fecha_entrega;
    }
}