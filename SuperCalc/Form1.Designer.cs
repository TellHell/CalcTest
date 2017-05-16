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
            this.panTwoArgs.SuspendLayout();
            this.panMoreArgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBX
            // 
            this.TBX.Location = new System.Drawing.Point(3, 12);
            this.TBX.Name = "TBX";
            this.TBX.Size = new System.Drawing.Size(73, 20);
            this.TBX.TabIndex = 1;
            // 
            // TBY
            // 
            this.TBY.Location = new System.Drawing.Point(89, 12);
            this.TBY.Name = "TBY";
            this.TBY.Size = new System.Drawing.Size(77, 20);
            this.TBY.TabIndex = 2;
            // 
            // LResult
            // 
            this.LResult.AutoSize = true;
            this.LResult.Location = new System.Drawing.Point(12, 243);
            this.LResult.Name = "LResult";
            this.LResult.Size = new System.Drawing.Size(25, 13);
            this.LResult.TabIndex = 4;
            this.LResult.Text = "123";
            this.LResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbOper
            // 
            this.cbOper.FormattingEnabled = true;
            this.cbOper.Location = new System.Drawing.Point(101, 8);
            this.cbOper.Name = "cbOper";
            this.cbOper.Size = new System.Drawing.Size(121, 21);
            this.cbOper.TabIndex = 5;
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
            this.panTwoArgs.Controls.Add(this.TBX);
            this.panTwoArgs.Controls.Add(this.TBY);
            this.panTwoArgs.Location = new System.Drawing.Point(12, 61);
            this.panTwoArgs.Name = "panTwoArgs";
            this.panTwoArgs.Size = new System.Drawing.Size(200, 100);
            this.panTwoArgs.TabIndex = 7;
            this.panTwoArgs.Visible = false;
            // 
            // panMoreArgs
            // 
            this.panMoreArgs.Controls.Add(this.tbMore);
            this.panMoreArgs.Location = new System.Drawing.Point(287, 61);
            this.panMoreArgs.Name = "panMoreArgs";
            this.panMoreArgs.Size = new System.Drawing.Size(200, 100);
            this.panMoreArgs.TabIndex = 8;
            this.panMoreArgs.Visible = false;
            // 
            // tbMore
            // 
            this.tbMore.Location = new System.Drawing.Point(19, 12);
            this.tbMore.Name = "tbMore";
            this.tbMore.Size = new System.Drawing.Size(157, 66);
            this.tbMore.TabIndex = 0;
            this.tbMore.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 306);
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
    }
}

