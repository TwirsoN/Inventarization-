namespace Inventarization
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tBVal2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmBDef2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFilter2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tBVal1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmBDef1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmBNum = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmBMaterial = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmBColor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmBName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmBType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tBNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBMaterial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBType = new System.Windows.Forms.TextBox();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1MinSize = 345;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainDGV);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(1084, 441);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tBVal2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cmBDef2);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnFilter2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tBVal1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmBDef1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmBNum);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmBMaterial);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmBColor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmBName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmBType);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 298);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтры";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(7, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 20);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "Вес";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(234, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Введите значение";
            // 
            // tBVal2
            // 
            this.tBVal2.Location = new System.Drawing.Point(235, 153);
            this.tBVal2.Name = "tBVal2";
            this.tBVal2.Size = new System.Drawing.Size(98, 20);
            this.tBVal2.TabIndex = 28;
            this.tBVal2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBWeight_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(116, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 27;
            this.label17.Tag = "";
            this.label17.Text = "Выбор условия";
            // 
            // cmBDef2
            // 
            this.cmBDef2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBDef2.FormattingEnabled = true;
            this.cmBDef2.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            ">",
            ">=",
            "<",
            "<="});
            this.cmBDef2.Location = new System.Drawing.Point(119, 152);
            this.cmBDef2.Name = "cmBDef2";
            this.cmBDef2.Size = new System.Drawing.Size(100, 21);
            this.cmBDef2.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 25;
            this.label18.Tag = "";
            this.label18.Text = "Метрика";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(7, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Кол-во";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(7, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 33);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Сбросить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFilter2
            // 
            this.btnFilter2.Location = new System.Drawing.Point(119, 179);
            this.btnFilter2.Name = "btnFilter2";
            this.btnFilter2.Size = new System.Drawing.Size(214, 33);
            this.btnFilter2.TabIndex = 22;
            this.btnFilter2.Text = "Применить фильтры";
            this.btnFilter2.UseVisualStyleBackColor = true;
            this.btnFilter2.Click += new System.EventHandler(this.btnFilter2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Введите значение";
            // 
            // tBVal1
            // 
            this.tBVal1.Location = new System.Drawing.Point(235, 113);
            this.tBVal1.Name = "tBVal1";
            this.tBVal1.Size = new System.Drawing.Size(98, 20);
            this.tBVal1.TabIndex = 20;
            this.tBVal1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCount_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 19;
            this.label13.Tag = "";
            this.label13.Text = "Выбор условия";
            // 
            // cmBDef1
            // 
            this.cmBDef1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBDef1.FormattingEnabled = true;
            this.cmBDef1.Items.AddRange(new object[] {
            "",
            "=",
            "!=",
            ">",
            ">=",
            "<",
            "<="});
            this.cmBDef1.Location = new System.Drawing.Point(119, 112);
            this.cmBDef1.Name = "cmBDef1";
            this.cmBDef1.Size = new System.Drawing.Size(100, 21);
            this.cmBDef1.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 17;
            this.label15.Tag = "";
            this.label15.Text = "Метрика";
            // 
            // cmBNum
            // 
            this.cmBNum.FormattingEnabled = true;
            this.cmBNum.Location = new System.Drawing.Point(119, 72);
            this.cmBNum.Name = "cmBNum";
            this.cmBNum.Size = new System.Drawing.Size(98, 21);
            this.cmBNum.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(116, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Номер аудитории";
            // 
            // cmBMaterial
            // 
            this.cmBMaterial.FormattingEnabled = true;
            this.cmBMaterial.Location = new System.Drawing.Point(7, 72);
            this.cmBMaterial.Name = "cmBMaterial";
            this.cmBMaterial.Size = new System.Drawing.Size(98, 21);
            this.cmBMaterial.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Материал";
            // 
            // cmBColor
            // 
            this.cmBColor.FormattingEnabled = true;
            this.cmBColor.Location = new System.Drawing.Point(235, 32);
            this.cmBColor.Name = "cmBColor";
            this.cmBColor.Size = new System.Drawing.Size(98, 21);
            this.cmBColor.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Цвет";
            // 
            // cmBName
            // 
            this.cmBName.FormattingEnabled = true;
            this.cmBName.Location = new System.Drawing.Point(119, 32);
            this.cmBName.Name = "cmBName";
            this.cmBName.Size = new System.Drawing.Size(98, 21);
            this.cmBName.TabIndex = 3;
            this.cmBName.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 2;
            this.label9.Tag = "";
            this.label9.Text = "Название";
            // 
            // cmBType
            // 
            this.cmBType.FormattingEnabled = true;
            this.cmBType.Location = new System.Drawing.Point(7, 32);
            this.cmBType.Name = "cmBType";
            this.cmBType.Size = new System.Drawing.Size(98, 21);
            this.cmBType.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Тип";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddData);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tBNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tBMaterial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tBWeight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записей";
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(115, 97);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(204, 33);
            this.btnAddData.TabIndex = 14;
            this.btnAddData.Text = "Ввести данные в БД";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Номер аудитории";
            // 
            // tBNum
            // 
            this.tBNum.BackColor = System.Drawing.SystemColors.Window;
            this.tBNum.Location = new System.Drawing.Point(7, 110);
            this.tBNum.Name = "tBNum";
            this.tBNum.Size = new System.Drawing.Size(100, 20);
            this.tBNum.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Материал";
            // 
            // tBMaterial
            // 
            this.tBMaterial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBMaterial.Location = new System.Drawing.Point(219, 71);
            this.tBMaterial.Name = "tBMaterial";
            this.tBMaterial.Size = new System.Drawing.Size(100, 20);
            this.tBMaterial.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Вес";
            // 
            // tBWeight
            // 
            this.tBWeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBWeight.Location = new System.Drawing.Point(113, 71);
            this.tBWeight.Name = "tBWeight";
            this.tBWeight.Size = new System.Drawing.Size(100, 20);
            this.tBWeight.TabIndex = 8;
            this.tBWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBWeight_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цвет";
            // 
            // tBColor
            // 
            this.tBColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBColor.Location = new System.Drawing.Point(7, 71);
            this.tBColor.Name = "tBColor";
            this.tBColor.Size = new System.Drawing.Size(100, 20);
            this.tBColor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название";
            // 
            // tBName
            // 
            this.tBName.BackColor = System.Drawing.SystemColors.Window;
            this.tBName.Location = new System.Drawing.Point(219, 32);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(100, 20);
            this.tBName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во";
            // 
            // tBCount
            // 
            this.tBCount.BackColor = System.Drawing.SystemColors.Window;
            this.tBCount.Location = new System.Drawing.Point(113, 32);
            this.tBCount.Name = "tBCount";
            this.tBCount.Size = new System.Drawing.Size(100, 20);
            this.tBCount.TabIndex = 2;
            this.tBCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип";
            // 
            // tBType
            // 
            this.tBType.BackColor = System.Drawing.SystemColors.Window;
            this.tBType.Location = new System.Drawing.Point(7, 32);
            this.tBType.Name = "tBType";
            this.tBType.Size = new System.Drawing.Size(100, 20);
            this.tBType.TabIndex = 0;
            // 
            // mainDGV
            // 
            this.mainDGV.AllowUserToAddRows = false;
            this.mainDGV.AllowUserToDeleteRows = false;
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDGV.Location = new System.Drawing.Point(0, 0);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.Size = new System.Drawing.Size(735, 441);
            this.mainDGV.TabIndex = 0;
            this.mainDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDGV_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 441);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Инвентаризация СГУГиТ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmBNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmBMaterial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmBColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmBName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmBType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmBDef1;
        private System.Windows.Forms.Button btnFilter2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBVal1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tBVal2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmBDef2;
        private System.Windows.Forms.Label label18;
    }
}

