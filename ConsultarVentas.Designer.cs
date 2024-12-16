namespace COSMOSCOM
{
    partial class ConsultarVentas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVentas));
            button1 = new Button();
            groupBox1 = new GroupBox();
            button5 = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            DataGrid_Ventas = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            button3 = new Button();
            txt_buscar = new TextBox();
            cb_filtro = new ComboBox();
            btn_Regresar = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel6 = new TableLayoutPanel();
            button4 = new Button();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Ventas).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.MediumBlue;
            button1.Location = new Point(745, 450);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(144, 65);
            button1.TabIndex = 8;
            button1.Text = "Modificar ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.BlanchedAlmond;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Controls.Add(btn_Regresar);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MediumBlue;
            groupBox1.Location = new Point(4, 4);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(940, 661);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultar Venta";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HighlightText;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.MediumBlue;
            button5.Location = new Point(155, 450);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(191, 65);
            button5.TabIndex = 18;
            button5.Text = "Detalle de Venta";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(DataGrid_Ventas, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel5.Location = new Point(42, 52);
            tableLayoutPanel5.Margin = new Padding(4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 314F));
            tableLayoutPanel5.Size = new Size(846, 376);
            tableLayoutPanel5.TabIndex = 17;
            // 
            // DataGrid_Ventas
            // 
            DataGrid_Ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.MediumBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataGrid_Ventas.DefaultCellStyle = dataGridViewCellStyle1;
            DataGrid_Ventas.Dock = DockStyle.Fill;
            DataGrid_Ventas.Location = new Point(4, 66);
            DataGrid_Ventas.Margin = new Padding(4);
            DataGrid_Ventas.Name = "DataGrid_Ventas";
            DataGrid_Ventas.RowHeadersWidth = 51;
            DataGrid_Ventas.Size = new Size(838, 306);
            DataGrid_Ventas.TabIndex = 7;
            DataGrid_Ventas.CellContentClick += DataGrid_Ventas_CellContentClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3698635F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4589043F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1712322F));
            tableLayoutPanel3.Controls.Add(button3, 2, 0);
            tableLayoutPanel3.Controls.Add(txt_buscar, 1, 0);
            tableLayoutPanel3.Controls.Add(cb_filtro, 0, 0);
            tableLayoutPanel3.Location = new Point(4, 4);
            tableLayoutPanel3.Margin = new Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(838, 54);
            tableLayoutPanel3.TabIndex = 14;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.MediumBlue;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.HighlightText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(630, 4);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(204, 46);
            button3.TabIndex = 10;
            button3.Text = "Buscar";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // txt_buscar
            // 
            txt_buscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_buscar.Location = new Point(224, 9);
            txt_buscar.Margin = new Padding(4);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(398, 35);
            txt_buscar.TabIndex = 12;
            // 
            // cb_filtro
            // 
            cb_filtro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_filtro.FormattingEnabled = true;
            cb_filtro.Items.AddRange(new object[] { "Todos", "Folio", "id_Cliente", "Fecha de atención", "Fecha de entrega" });
            cb_filtro.Location = new Point(4, 10);
            cb_filtro.Margin = new Padding(4);
            cb_filtro.Name = "cb_filtro";
            cb_filtro.Size = new Size(212, 36);
            cb_filtro.TabIndex = 13;
            cb_filtro.Text = "Filtrar Por";
            cb_filtro.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_Regresar
            // 
            btn_Regresar.BackColor = SystemColors.HighlightText;
            btn_Regresar.FlatStyle = FlatStyle.Popup;
            btn_Regresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Regresar.ForeColor = Color.MediumBlue;
            btn_Regresar.Location = new Point(749, 574);
            btn_Regresar.Margin = new Padding(4);
            btn_Regresar.Name = "btn_Regresar";
            btn_Regresar.Size = new Size(139, 65);
            btn_Regresar.TabIndex = 14;
            btn_Regresar.Text = "Regresar";
            btn_Regresar.UseVisualStyleBackColor = false;
            btn_Regresar.Click += btn_Regresar_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.MediumBlue;
            button2.Location = new Point(591, 450);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(135, 65);
            button2.TabIndex = 9;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.BlanchedAlmond;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 626F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(948, 136);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(180, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(613, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 136);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(948, 669);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(194, 74);
            dataGridView1.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.13127F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8687267F));
            tableLayoutPanel6.Controls.Add(button4, 1, 0);
            tableLayoutPanel6.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(194, 45);
            tableLayoutPanel6.TabIndex = 14;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.MediumBlue;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.HighlightText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(146, 3);
            button4.Name = "button4";
            button4.Size = new Size(45, 39);
            button4.TabIndex = 10;
            button4.Text = "Buscar";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 31);
            textBox2.TabIndex = 12;
            // 
            // ConsultarVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(948, 805);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            MaximumSize = new Size(970, 861);
            MinimumSize = new Size(970, 861);
            Name = "ConsultarVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarVentas";
            Load += ConsultarVentas_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGrid_Ventas).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Button btn_Regresar;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button4;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView DataGrid_Ventas;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button3;
        private TextBox txt_buscar;
        private ComboBox cb_filtro;
        private Button button5;
    }
}