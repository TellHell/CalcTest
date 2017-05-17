namespace SuperCalc
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
            this.button1 = new System.Windows.Forms.Button();
            this.TBX = new System.Windows.Forms.TextBox();
            this.TBY = new System.Windows.Forms.TextBox();
            this.LResult = new System.Windows.Forms.Label();
            this.cbOper = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panTwoArgs = new System.Windows.Forms.Panel();
            this.panMoreArgs = new System.Windows.Forms.Panel();
            this.tbMore = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panTwoArgs.SuspendLayout();
            this.panMoreArgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBX
            // 
            this.TBX.Location = new System.Drawing.Point(3, 22);
            this.TBX.Name = "TBX";
            this.TBX.Size = new System.Drawing.Size(73, 20);
            this.TBX.TabIndex = 1;
            // 
            // TBY
            // 
            this.TBY.Location = new System.Drawing.Point(89, 22);
            this.TBY.Name = "TBY";
            this.TBY.Size = new System.Drawing.Size(77, 20);
            this.TBY.TabIndex = 2;
            // 
            // LResult
            // 
            this.LResult.AutoSize = true;
            this.LResult.Location = new System.Drawing.Point(80, 132);
            this.LResult.Name = "LResult";
            this.LResult.Size = new System.Drawing.Size(0, 13);
            this.LResult.TabIndex = 4;
            this.LResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbOper
            // 
            this.cbOper.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOper.FormattingEnabled = true;
            this.cbOper.Location = new System.Drawing.Point(101, 8);
            this.cbOper.Name = "cbOper";
            this.cbOper.Size = new System.Drawing.Size(121, 21);
            this.cbOper.TabIndex = 5;
            this.cbOper.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbOper_DrawItem);
            this.cbOper.SelectedIndexChanged += new System.EventHandler(this.cbOper_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Operation";
            // 
            // panTwoArgs
            // 
            this.panTwoArgs.Controls.Add(this.label3);
            this.panTwoArgs.Controls.Add(this.label2);
            this.panTwoArgs.Controls.Add(this.TBX);
            this.panTwoArgs.Controls.Add(this.TBY);
            this.panTwoArgs.Location = new System.Drawing.Point(12, 35);
            this.panTwoArgs.Name = "panTwoArgs";
            this.panTwoArgs.Size = new System.Drawing.Size(210, 86);
            this.panTwoArgs.TabIndex = 7;
            this.panTwoArgs.Visible = false;
            // 
            // panMoreArgs
            // 
            this.panMoreArgs.Controls.Add(this.label6);
            this.panMoreArgs.Controls.Add(this.label5);
            this.panMoreArgs.Controls.Add(this.tbMore);
            this.panMoreArgs.Location = new System.Drawing.Point(12, 35);
            this.panMoreArgs.Name = "panMoreArgs";
            this.panMoreArgs.Size = new System.Drawing.Size(210, 86);
            this.panMoreArgs.TabIndex = 8;
            this.panMoreArgs.Visible = false;
            // 
            // tbMore
            // 
            this.tbMore.Location = new System.Drawing.Point(3, 34);
            this.tbMore.Name = "tbMore";
            this.tbMore.Size = new System.Drawing.Size(204, 49);
            this.tbMore.TabIndex = 0;
            this.tbMore.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Значение X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Значение Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результат:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Значения для операции";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "вводить через пробел";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 203);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panMoreArgs);
            this.Controls.Add(this.panTwoArgs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOper);
            this.Controls.Add(this.LResult);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panTwoArgs.ResumeLayout(false);
            this.panTwoArgs.PerformLayout();
            this.panMoreArgs.ResumeLayout(false);
            this.panMoreArgs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBX;
        private System.Windows.Forms.TextBox TBY;
        private System.Windows.Forms.Label LResult;
        private System.Windows.Forms.ComboBox cbOper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panTwoArgs;
        private System.Windows.Forms.Panel panMoreArgs;
        private System.Windows.Forms.RichTextBox tbMore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

