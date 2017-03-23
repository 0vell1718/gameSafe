namespace gameSafe
{
    partial class Form1
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
            this.infoBtn = new System.Windows.Forms.Button();
            this.infoTbx = new System.Windows.Forms.TextBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.infoLbl1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(309, 6);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(87, 43);
            this.infoBtn.TabIndex = 1;
            this.infoBtn.Text = "Начать";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // infoTbx
            // 
            this.infoTbx.Location = new System.Drawing.Point(170, 6);
            this.infoTbx.Name = "infoTbx";
            this.infoTbx.Size = new System.Drawing.Size(26, 20);
            this.infoTbx.TabIndex = 0;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(2, 9);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(152, 13);
            this.infoLbl.TabIndex = 2;
            this.infoLbl.Text = "Введите размер сейфа NxN:";
            // 
            // infoLbl1
            // 
            this.infoLbl1.AutoSize = true;
            this.infoLbl1.Location = new System.Drawing.Point(2, 36);
            this.infoLbl1.Name = "infoLbl1";
            this.infoLbl1.Size = new System.Drawing.Size(162, 13);
            this.infoLbl1.TabIndex = 3;
            this.infoLbl1.Text = "Выберите уровень сложности:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Легкий",
            "Средний",
            "Тяжелый"});
            this.comboBox1.Location = new System.Drawing.Point(170, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.infoLbl1);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.infoTbx);
            this.Controls.Add(this.infoBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сейф братьев пилотов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.TextBox infoTbx;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Label infoLbl1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

