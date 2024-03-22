namespace Test121231
{
    partial class Form1
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dgvCustomers = new DataGridView();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            salebutt = new Button();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            price = new DataGridViewTextBoxColumn();
            weight = new DataGridViewTextBoxColumn();
            mush = new DataGridViewTextBoxColumn();
            phoneno = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("MN Mantou", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(641, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "เลือกลูกค้า";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(652, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(652, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(652, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("MN Mantou", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(667, 406);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 4;
            button1.Text = "บันทึก";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(488, 215);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { name, address, phoneno, mush, weight, price });
            dgvCustomers.Location = new Point(12, 27);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowTemplate.Height = 25;
            dgvCustomers.Size = new Size(551, 182);
            dgvCustomers.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(641, 216);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(652, 259);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // salebutt
            // 
            salebutt.Font = new Font("MN Mantou", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            salebutt.Location = new Point(667, 299);
            salebutt.Name = "salebutt";
            salebutt.Size = new Size(75, 32);
            salebutt.TabIndex = 10;
            salebutt.Text = "คำนวณราคา";
            salebutt.UseVisualStyleBackColor = true;
            salebutt.Click += salebutt_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("MN Mantou", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(652, 348);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 40);
            textBox5.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.Font = new Font("MN Mantou", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(613, 365);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 12;
            label1.Text = "ราคา";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.Font = new Font("MN Mantou", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(602, 262);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 13;
            label2.Text = "น้ำหนัก";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.None;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(45, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = SystemColors.WindowFrame;
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem1, fileToolStripMenuItem });
            openToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(37, 20);
            openToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(103, 22);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(103, 22);
            fileToolStripMenuItem.Text = "Open";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.Font = new Font("MN Mantou", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(622, 95);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 15;
            label3.Text = "ชื่อ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.Font = new Font("MN Mantou", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(616, 124);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 16;
            label4.Text = "ที่อยู่";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.WindowFrame;
            label5.Font = new Font("MN Mantou", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(597, 153);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 17;
            label5.Text = "เบอร์โทร";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
            // 
            // weight
            // 
            weight.HeaderText = "Weight";
            weight.Name = "weight";
            // 
            // mush
            // 
            mush.HeaderText = "Mushroom";
            mush.Name = "mush";
            // 
            // phoneno
            // 
            phoneno.HeaderText = "PhoneNumber";
            phoneno.Name = "phoneno";
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.Name = "address";
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_02;
            ClientSize = new Size(824, 461);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(salebutt);
            Controls.Add(textBox4);
            Controls.Add(comboBox2);
            Controls.Add(dgvCustomers);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private DataGridView dgvCustomers;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private Button salebutt;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phoneno;
        private DataGridViewTextBoxColumn mush;
        private DataGridViewTextBoxColumn weight;
        private DataGridViewTextBoxColumn price;
    }
}