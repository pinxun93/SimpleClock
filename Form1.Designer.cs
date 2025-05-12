
namespace SimpleClock
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "時鐘";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "碼表";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "倒數";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(756, 151);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

