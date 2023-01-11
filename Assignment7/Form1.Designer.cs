namespace Assignment7
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
            this.Check = new System.Windows.Forms.Button();
            this.Correct = new System.Windows.Forms.Label();
            this.Incorrect = new System.Windows.Forms.Label();
            this.IncorrectList = new System.Windows.Forms.Label();
            this.CorrectCount = new System.Windows.Forms.TextBox();
            this.IncorrectCount = new System.Windows.Forms.TextBox();
            this.listBoxIncorrect = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(78, 12);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(170, 71);
            this.Check.TabIndex = 0;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Correct
            // 
            this.Correct.AutoSize = true;
            this.Correct.Location = new System.Drawing.Point(4, 105);
            this.Correct.Name = "Correct";
            this.Correct.Size = new System.Drawing.Size(72, 13);
            this.Correct.TabIndex = 1;
            this.Correct.Text = "Correct Count";
            // 
            // Incorrect
            // 
            this.Incorrect.AutoSize = true;
            this.Incorrect.Location = new System.Drawing.Point(4, 132);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(80, 13);
            this.Incorrect.TabIndex = 2;
            this.Incorrect.Text = "Incorrect Count";
            // 
            // IncorrectList
            // 
            this.IncorrectList.AutoSize = true;
            this.IncorrectList.Location = new System.Drawing.Point(4, 162);
            this.IncorrectList.Name = "IncorrectList";
            this.IncorrectList.Size = new System.Drawing.Size(68, 13);
            this.IncorrectList.TabIndex = 3;
            this.IncorrectList.Text = "Incorrect List";
            // 
            // CorrectCount
            // 
            this.CorrectCount.Location = new System.Drawing.Point(89, 98);
            this.CorrectCount.Name = "CorrectCount";
            this.CorrectCount.Size = new System.Drawing.Size(170, 20);
            this.CorrectCount.TabIndex = 4;
            // 
            // IncorrectCount
            // 
            this.IncorrectCount.Location = new System.Drawing.Point(89, 125);
            this.IncorrectCount.Name = "IncorrectCount";
            this.IncorrectCount.Size = new System.Drawing.Size(170, 20);
            this.IncorrectCount.TabIndex = 5;
            // 
            // listBoxIncorrect
            // 
            this.listBoxIncorrect.FormattingEnabled = true;
            this.listBoxIncorrect.Location = new System.Drawing.Point(89, 161);
            this.listBoxIncorrect.Name = "listBoxIncorrect";
            this.listBoxIncorrect.Size = new System.Drawing.Size(170, 43);
            this.listBoxIncorrect.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 216);
            this.Controls.Add(this.listBoxIncorrect);
            this.Controls.Add(this.IncorrectCount);
            this.Controls.Add(this.CorrectCount);
            this.Controls.Add(this.IncorrectList);
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.Correct);
            this.Controls.Add(this.Check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label Correct;
        private System.Windows.Forms.Label Incorrect;
        private System.Windows.Forms.Label IncorrectList;
        private System.Windows.Forms.TextBox CorrectCount;
        private System.Windows.Forms.TextBox IncorrectCount;
        private System.Windows.Forms.ListBox listBoxIncorrect;
    }
}

