namespace Lesson_thread
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
            this.b_call_form2 = new System.Windows.Forms.Button();
            this.b_ThreadStop = new System.Windows.Forms.Button();
            this.chb_list = new System.Windows.Forms.CheckedListBox();
            this.b_resume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_call_form2
            // 
            this.b_call_form2.Location = new System.Drawing.Point(574, 146);
            this.b_call_form2.Name = "b_call_form2";
            this.b_call_form2.Size = new System.Drawing.Size(133, 41);
            this.b_call_form2.TabIndex = 0;
            this.b_call_form2.Text = "Создать поток";
            this.b_call_form2.UseVisualStyleBackColor = true;
            this.b_call_form2.Click += new System.EventHandler(this.b_call_form2_Click);
            // 
            // b_ThreadStop
            // 
            this.b_ThreadStop.Location = new System.Drawing.Point(574, 193);
            this.b_ThreadStop.Name = "b_ThreadStop";
            this.b_ThreadStop.Size = new System.Drawing.Size(133, 43);
            this.b_ThreadStop.TabIndex = 1;
            this.b_ThreadStop.Text = "Остановить поток";
            this.b_ThreadStop.UseVisualStyleBackColor = true;
            this.b_ThreadStop.Click += new System.EventHandler(this.b_ThreadStop_Click);
            // 
            // chb_list
            // 
            this.chb_list.CheckOnClick = true;
            this.chb_list.FormattingEnabled = true;
            this.chb_list.Location = new System.Drawing.Point(13, 47);
            this.chb_list.Name = "chb_list";
            this.chb_list.Size = new System.Drawing.Size(140, 409);
            this.chb_list.TabIndex = 2;
            // 
            // b_resume
            // 
            this.b_resume.Location = new System.Drawing.Point(574, 242);
            this.b_resume.Name = "b_resume";
            this.b_resume.Size = new System.Drawing.Size(133, 49);
            this.b_resume.TabIndex = 3;
            this.b_resume.Text = "Возобновить поток";
            this.b_resume.UseVisualStyleBackColor = true;
            this.b_resume.Click += new System.EventHandler(this.b_resume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 492);
            this.Controls.Add(this.b_resume);
            this.Controls.Add(this.chb_list);
            this.Controls.Add(this.b_ThreadStop);
            this.Controls.Add(this.b_call_form2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_call_form2;
        private System.Windows.Forms.Button b_ThreadStop;
        private System.Windows.Forms.CheckedListBox chb_list;
        private System.Windows.Forms.Button b_resume;
    }
}

