namespace PressWatcher
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DutyBtn = new System.Windows.Forms.Button();
            this.IsStartLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DutyBtn
            // 
            this.DutyBtn.Location = new System.Drawing.Point(157, 128);
            this.DutyBtn.Name = "DutyBtn";
            this.DutyBtn.Size = new System.Drawing.Size(75, 23);
            this.DutyBtn.TabIndex = 0;
            this.DutyBtn.Text = "开始监听";
            this.DutyBtn.UseVisualStyleBackColor = true;
            this.DutyBtn.Click += new System.EventHandler(this.DutyBtn_Click);
            // 
            // IsStartLabel
            // 
            this.IsStartLabel.AutoSize = true;
            this.IsStartLabel.Location = new System.Drawing.Point(239, 138);
            this.IsStartLabel.Name = "IsStartLabel";
            this.IsStartLabel.Size = new System.Drawing.Size(41, 12);
            this.IsStartLabel.TabIndex = 1;
            this.IsStartLabel.Text = "unable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "You can click the btn and try to press ctrl+a";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsStartLabel);
            this.Controls.Add(this.DutyBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "主要窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DutyBtn;
        private System.Windows.Forms.Label IsStartLabel;
        private System.Windows.Forms.Label label1;
    }
}

