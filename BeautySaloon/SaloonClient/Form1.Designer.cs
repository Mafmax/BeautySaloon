namespace SaloonClient
{
    partial class MainPageForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.manicureButton = new System.Windows.Forms.Button();
            this.visagistButton = new System.Windows.Forms.Button();
            this.hairdresserButton = new System.Windows.Forms.Button();
            this.massageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manicureButton
            // 
            this.manicureButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manicureButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("manicureButton.BackgroundImage")));
            this.manicureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manicureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manicureButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.manicureButton.Location = new System.Drawing.Point(419, 216);
            this.manicureButton.Name = "manicureButton";
            this.manicureButton.Size = new System.Drawing.Size(400, 200);
            this.manicureButton.TabIndex = 3;
            this.manicureButton.Text = "Мастер \r\nманикюра";
            this.manicureButton.UseVisualStyleBackColor = false;
            this.manicureButton.Click += new System.EventHandler(this.manicureButton_Click);
            // 
            // visagistButton
            // 
            this.visagistButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.visagistButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("visagistButton.BackgroundImage")));
            this.visagistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visagistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visagistButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.visagistButton.Location = new System.Drawing.Point(12, 217);
            this.visagistButton.Name = "visagistButton";
            this.visagistButton.Size = new System.Drawing.Size(400, 200);
            this.visagistButton.TabIndex = 2;
            this.visagistButton.Text = "Визажист";
            this.visagistButton.UseVisualStyleBackColor = false;
            this.visagistButton.Click += new System.EventHandler(this.visagistButton_Click);
            // 
            // hairdresserButton
            // 
            this.hairdresserButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hairdresserButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hairdresserButton.BackgroundImage")));
            this.hairdresserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hairdresserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hairdresserButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.hairdresserButton.Location = new System.Drawing.Point(419, 10);
            this.hairdresserButton.Name = "hairdresserButton";
            this.hairdresserButton.Size = new System.Drawing.Size(400, 200);
            this.hairdresserButton.TabIndex = 1;
            this.hairdresserButton.Text = "Парикмахер";
            this.hairdresserButton.UseVisualStyleBackColor = false;
            this.hairdresserButton.Click += new System.EventHandler(this.hairdresserButton_Click);
            // 
            // massageButton
            // 
            this.massageButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.massageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("massageButton.BackgroundImage")));
            this.massageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.massageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.massageButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.massageButton.Location = new System.Drawing.Point(12, 10);
            this.massageButton.Name = "massageButton";
            this.massageButton.Size = new System.Drawing.Size(400, 200);
            this.massageButton.TabIndex = 0;
            this.massageButton.Text = "Массажист";
            this.massageButton.UseVisualStyleBackColor = false;
            this.massageButton.Click += new System.EventHandler(this.massageButton_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 429);
            this.Controls.Add(this.manicureButton);
            this.Controls.Add(this.visagistButton);
            this.Controls.Add(this.hairdresserButton);
            this.Controls.Add(this.massageButton);
            this.Name = "MainPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button massageButton;
        private System.Windows.Forms.Button hairdresserButton;
        private System.Windows.Forms.Button visagistButton;
        private System.Windows.Forms.Button manicureButton;
    }
}

