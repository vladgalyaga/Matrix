namespace matrix
{
    partial class MainFinalForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мфToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додаванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відніманняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.множенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транспонуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.множенняНаСкалярToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownNumberOfDecimal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMaxValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownMinValue = new System.Windows.Forms.NumericUpDown();
            this.визначникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гаусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крамераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оберненаМатрицяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValue)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.мфToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.файлToolStripMenuItem.Text = "Файл...";
            // 
            // мфToolStripMenuItem
            // 
            this.мфToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додаванняToolStripMenuItem,
            this.відніманняToolStripMenuItem,
            this.множенняToolStripMenuItem,
            this.транспонуванняToolStripMenuItem,
            this.множенняНаСкалярToolStripMenuItem,
            this.визначникToolStripMenuItem,
            this.гаусаToolStripMenuItem,
            this.крамераToolStripMenuItem,
            this.оберненаМатрицяToolStripMenuItem});
            this.мфToolStripMenuItem.Name = "мфToolStripMenuItem";
            this.мфToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.мфToolStripMenuItem.Text = "Дії над Матрицями";
            // 
            // додаванняToolStripMenuItem
            // 
            this.додаванняToolStripMenuItem.Name = "додаванняToolStripMenuItem";
            this.додаванняToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.додаванняToolStripMenuItem.Text = "Додавання";
            this.додаванняToolStripMenuItem.Click += new System.EventHandler(this.додаванняToolStripMenuItem_Click);
            // 
            // відніманняToolStripMenuItem
            // 
            this.відніманняToolStripMenuItem.Name = "відніманняToolStripMenuItem";
            this.відніманняToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.відніманняToolStripMenuItem.Text = "Віднімання";
            this.відніманняToolStripMenuItem.Click += new System.EventHandler(this.відніманняToolStripMenuItem_Click);
            // 
            // множенняToolStripMenuItem
            // 
            this.множенняToolStripMenuItem.Name = "множенняToolStripMenuItem";
            this.множенняToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.множенняToolStripMenuItem.Text = "Множення";
            this.множенняToolStripMenuItem.Click += new System.EventHandler(this.множенняToolStripMenuItem_Click);
            // 
            // транспонуванняToolStripMenuItem
            // 
            this.транспонуванняToolStripMenuItem.Name = "транспонуванняToolStripMenuItem";
            this.транспонуванняToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.транспонуванняToolStripMenuItem.Text = "Транспонування";
            this.транспонуванняToolStripMenuItem.Click += new System.EventHandler(this.транспонуванняToolStripMenuItem_Click);
            // 
            // множенняНаСкалярToolStripMenuItem
            // 
            this.множенняНаСкалярToolStripMenuItem.Name = "множенняНаСкалярToolStripMenuItem";
            this.множенняНаСкалярToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.множенняНаСкалярToolStripMenuItem.Text = "Множення на скаляр";
            this.множенняНаСкалярToolStripMenuItem.Click += new System.EventHandler(this.множенняНаСкалярToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownNumberOfDecimal, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownMaxValue, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownMinValue, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 215);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // numericUpDownNumberOfDecimal
            // 
            this.numericUpDownNumberOfDecimal.Location = new System.Drawing.Point(445, 5);
            this.numericUpDownNumberOfDecimal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.numericUpDownNumberOfDecimal.Name = "numericUpDownNumberOfDecimal";
            this.numericUpDownNumberOfDecimal.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownNumberOfDecimal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Знаків після коми";
            // 
            // numericUpDownMaxValue
            // 
            this.numericUpDownMaxValue.Location = new System.Drawing.Point(250, 5);
            this.numericUpDownMaxValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.numericUpDownMaxValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxValue.Name = "numericUpDownMaxValue";
            this.numericUpDownMaxValue.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownMaxValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "До";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Застосувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Від";
            // 
            // numericUpDownMinValue
            // 
            this.numericUpDownMinValue.Location = new System.Drawing.Point(132, 5);
            this.numericUpDownMinValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.numericUpDownMinValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMinValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownMinValue.Name = "numericUpDownMinValue";
            this.numericUpDownMinValue.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownMinValue.TabIndex = 2;
            // 
            // визначникToolStripMenuItem
            // 
            this.визначникToolStripMenuItem.Name = "визначникToolStripMenuItem";
            this.визначникToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.визначникToolStripMenuItem.Text = "Визначник";
            this.визначникToolStripMenuItem.Click += new System.EventHandler(this.визначникToolStripMenuItem_Click);
            // 
            // гаусаToolStripMenuItem
            // 
            this.гаусаToolStripMenuItem.Name = "гаусаToolStripMenuItem";
            this.гаусаToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.гаусаToolStripMenuItem.Text = "Гауса";
            this.гаусаToolStripMenuItem.Click += new System.EventHandler(this.гаусаToolStripMenuItem_Click);
            // 
            // крамераToolStripMenuItem
            // 
            this.крамераToolStripMenuItem.Name = "крамераToolStripMenuItem";
            this.крамераToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.крамераToolStripMenuItem.Text = "Крамера";
            this.крамераToolStripMenuItem.Click += new System.EventHandler(this.крамераToolStripMenuItem_Click);
            // 
            // оберненаМатрицяToolStripMenuItem
            // 
            this.оберненаМатрицяToolStripMenuItem.Name = "оберненаМатрицяToolStripMenuItem";
            this.оберненаМатрицяToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.оберненаМатрицяToolStripMenuItem.Text = "Обернена матриця";
            this.оберненаМатрицяToolStripMenuItem.Click += new System.EventHandler(this.оберненаМатрицяToolStripMenuItem_Click);
            // 
            // MainFinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 239);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFinalForm";
            this.Text = "TeachMatrix";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мфToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додаванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відніманняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem множенняToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfDecimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMinValue;
        private System.Windows.Forms.ToolStripMenuItem транспонуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem множенняНаСкалярToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem визначникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гаусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem крамераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оберненаМатрицяToolStripMenuItem;
    }
}