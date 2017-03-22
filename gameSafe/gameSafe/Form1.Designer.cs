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
            this.SuspendLayout();
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(196, 157);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(111, 35);
            this.infoBtn.TabIndex = 0;
            this.infoBtn.Text = "button1";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // infoTbx
            // 
            this.infoTbx.Location = new System.Drawing.Point(226, 131);
            this.infoTbx.Name = "infoTbx";
            this.infoTbx.Size = new System.Drawing.Size(53, 20);
            this.infoTbx.TabIndex = 1;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(175, 106);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(152, 13);
            this.infoLbl.TabIndex = 2;
            this.infoLbl.Text = "Введите размер сейфа NxN:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 363);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.infoTbx);
            this.Controls.Add(this.infoBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.TextBox infoTbx;
        private System.Windows.Forms.Label infoLbl;
    }
}

