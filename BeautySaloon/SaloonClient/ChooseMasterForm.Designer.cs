namespace SaloonClient
{
    partial class ChooseMasterForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Label();
            this.workDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.time17 = new System.Windows.Forms.RadioButton();
            this.time16 = new System.Windows.Forms.RadioButton();
            this.time13 = new System.Windows.Forms.RadioButton();
            this.time14 = new System.Windows.Forms.RadioButton();
            this.time15 = new System.Windows.Forms.RadioButton();
            this.time11 = new System.Windows.Forms.RadioButton();
            this.time10 = new System.Windows.Forms.RadioButton();
            this.time9 = new System.Windows.Forms.RadioButton();
            this.time8 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time7 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(10, 58);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(670, 94);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Sum);
            this.groupBox1.Controls.Add(this.workDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид услуги";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(593, 155);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(62, 13);
            this.Sum.TabIndex = 4;
            this.Sum.Text = "Сумма: 0 р";
            // 
            // workDescription
            // 
            this.workDescription.AutoEllipsis = true;
            this.workDescription.Location = new System.Drawing.Point(6, 155);
            this.workDescription.Name = "workDescription";
            this.workDescription.Size = new System.Drawing.Size(581, 39);
            this.workDescription.TabIndex = 3;
            this.workDescription.Text = "Выберите работу";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите один или несколько вариантов желаемых работ (два клика для выбора, один " +
    "клик посмотреть подсказку).\r\nЕсли вы выберете две несочитаемые работы, то на мес" +
    "те придется выбрать одну из них.\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мастер";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 160);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.time17);
            this.groupBox3.Controls.Add(this.time16);
            this.groupBox3.Controls.Add(this.time13);
            this.groupBox3.Controls.Add(this.time14);
            this.groupBox3.Controls.Add(this.time15);
            this.groupBox3.Controls.Add(this.time11);
            this.groupBox3.Controls.Add(this.time10);
            this.groupBox3.Controls.Add(this.time9);
            this.groupBox3.Controls.Add(this.time8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.time7);
            this.groupBox3.Location = new System.Drawing.Point(453, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 189);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Время";
            // 
            // time17
            // 
            this.time17.AutoSize = true;
            this.time17.Location = new System.Drawing.Point(168, 136);
            this.time17.Name = "time17";
            this.time17.Size = new System.Drawing.Size(52, 17);
            this.time17.TabIndex = 11;
            this.time17.TabStop = true;
            this.time17.Text = "17:00";
            this.time17.UseVisualStyleBackColor = true;
            // 
            // time16
            // 
            this.time16.AutoSize = true;
            this.time16.Location = new System.Drawing.Point(168, 113);
            this.time16.Name = "time16";
            this.time16.Size = new System.Drawing.Size(52, 17);
            this.time16.TabIndex = 10;
            this.time16.TabStop = true;
            this.time16.Text = "16:00";
            this.time16.UseVisualStyleBackColor = true;
            // 
            // time13
            // 
            this.time13.AutoSize = true;
            this.time13.Location = new System.Drawing.Point(168, 44);
            this.time13.Name = "time13";
            this.time13.Size = new System.Drawing.Size(52, 17);
            this.time13.TabIndex = 9;
            this.time13.TabStop = true;
            this.time13.Text = "13:00";
            this.time13.UseVisualStyleBackColor = true;
            // 
            // time14
            // 
            this.time14.AutoSize = true;
            this.time14.Location = new System.Drawing.Point(168, 67);
            this.time14.Name = "time14";
            this.time14.Size = new System.Drawing.Size(52, 17);
            this.time14.TabIndex = 8;
            this.time14.TabStop = true;
            this.time14.Text = "14:00";
            this.time14.UseVisualStyleBackColor = true;
            // 
            // time15
            // 
            this.time15.AutoSize = true;
            this.time15.Location = new System.Drawing.Point(168, 90);
            this.time15.Name = "time15";
            this.time15.Size = new System.Drawing.Size(52, 17);
            this.time15.TabIndex = 7;
            this.time15.TabStop = true;
            this.time15.Text = "15:00";
            this.time15.UseVisualStyleBackColor = true;
            // 
            // time11
            // 
            this.time11.AutoSize = true;
            this.time11.Location = new System.Drawing.Point(21, 136);
            this.time11.Name = "time11";
            this.time11.Size = new System.Drawing.Size(52, 17);
            this.time11.TabIndex = 6;
            this.time11.TabStop = true;
            this.time11.Text = "11:00";
            this.time11.UseVisualStyleBackColor = true;
            // 
            // time10
            // 
            this.time10.AutoSize = true;
            this.time10.Location = new System.Drawing.Point(21, 113);
            this.time10.Name = "time10";
            this.time10.Size = new System.Drawing.Size(52, 17);
            this.time10.TabIndex = 5;
            this.time10.TabStop = true;
            this.time10.Text = "10:00";
            this.time10.UseVisualStyleBackColor = true;
            // 
            // time9
            // 
            this.time9.AutoSize = true;
            this.time9.Location = new System.Drawing.Point(21, 90);
            this.time9.Name = "time9";
            this.time9.Size = new System.Drawing.Size(46, 17);
            this.time9.TabIndex = 4;
            this.time9.TabStop = true;
            this.time9.Text = "9:00";
            this.time9.UseVisualStyleBackColor = true;
            // 
            // time8
            // 
            this.time8.AutoSize = true;
            this.time8.Location = new System.Drawing.Point(21, 67);
            this.time8.Name = "time8";
            this.time8.Size = new System.Drawing.Size(46, 17);
            this.time8.TabIndex = 3;
            this.time8.TabStop = true;
            this.time8.Text = "8:00";
            this.time8.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "После обеда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "До обеда";
            // 
            // time7
            // 
            this.time7.AutoSize = true;
            this.time7.Enabled = false;
            this.time7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.time7.Location = new System.Drawing.Point(21, 44);
            this.time7.Name = "time7";
            this.time7.Size = new System.Drawing.Size(46, 17);
            this.time7.TabIndex = 0;
            this.time7.TabStop = true;
            this.time7.Text = "7:00";
            this.time7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Записаться";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(41, 19);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.monthCalendar1);
            this.groupBox4.Location = new System.Drawing.Point(211, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 189);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Дата";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(94, 414);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 8;
            // 
            // ChooseMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 477);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChooseMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор параметров заказа";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label workDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton time13;
        private System.Windows.Forms.RadioButton time14;
        private System.Windows.Forms.RadioButton time15;
        private System.Windows.Forms.RadioButton time11;
        private System.Windows.Forms.RadioButton time10;
        private System.Windows.Forms.RadioButton time9;
        private System.Windows.Forms.RadioButton time8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton time7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RadioButton time17;
        private System.Windows.Forms.RadioButton time16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label errorLabel;
    }
}