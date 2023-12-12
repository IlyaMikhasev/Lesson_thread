namespace Lesson_thread
{
    partial class Form2
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
            this.pgbar = new System.Windows.Forms.ProgressBar();
            this.l_procent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbar
            // 
            this.pgbar.Location = new System.Drawing.Point(13, 47);
            this.pgbar.Name = "pgbar";
            this.pgbar.Size = new System.Drawing.Size(453, 24);
            this.pgbar.Step = 1;
            this.pgbar.TabIndex = 0;
            // 
            // l_procent
            // 
            this.l_procent.AutoSize = true;
            this.l_procent.BackColor = System.Drawing.Color.Transparent;
            this.l_procent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_procent.Location = new System.Drawing.Point(196, 9);
            this.l_procent.Name = "l_procent";
            this.l_procent.Size = new System.Drawing.Size(20, 24);
            this.l_procent.TabIndex = 1;
            this.l_procent.Text = "0";
            this.l_procent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 83);
            this.Controls.Add(this.l_procent);
            this.Controls.Add(this.pgbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbar;
        private System.Windows.Forms.Label l_procent;
    }
}