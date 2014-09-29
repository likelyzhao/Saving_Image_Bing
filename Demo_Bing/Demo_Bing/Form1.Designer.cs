namespace Demo_Bing
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_page = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Text_end = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_imgnow = new System.Windows.Forms.Label();
            this.checkBox_xunlei = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "key words";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Bing";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Searching";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Page";
            // 
            // text_page
            // 
            this.text_page.AutoSize = true;
            this.text_page.Location = new System.Drawing.Point(329, 34);
            this.text_page.Name = "text_page";
            this.text_page.Size = new System.Drawing.Size(11, 12);
            this.text_page.TabIndex = 6;
            this.text_page.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Idx_end";
            // 
            // Text_end
            // 
            this.Text_end.AutoSize = true;
            this.Text_end.Location = new System.Drawing.Point(551, 33);
            this.Text_end.Name = "Text_end";
            this.Text_end.Size = new System.Drawing.Size(11, 12);
            this.Text_end.TabIndex = 8;
            this.Text_end.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Idx_now";
            // 
            // text_imgnow
            // 
            this.text_imgnow.AutoSize = true;
            this.text_imgnow.Location = new System.Drawing.Point(423, 34);
            this.text_imgnow.Name = "text_imgnow";
            this.text_imgnow.Size = new System.Drawing.Size(11, 12);
            this.text_imgnow.TabIndex = 10;
            this.text_imgnow.Text = "0";
            // 
            // checkBox_xunlei
            // 
            this.checkBox_xunlei.AutoSize = true;
            this.checkBox_xunlei.Location = new System.Drawing.Point(24, 116);
            this.checkBox_xunlei.Name = "checkBox_xunlei";
            this.checkBox_xunlei.Size = new System.Drawing.Size(72, 16);
            this.checkBox_xunlei.TabIndex = 11;
            this.checkBox_xunlei.Text = "迅雷加速";
            this.checkBox_xunlei.UseVisualStyleBackColor = true;
            this.checkBox_xunlei.CheckedChanged += new System.EventHandler(this.checkBox_xunlei_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(91, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "soso";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 262);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox_xunlei);
            this.Controls.Add(this.text_imgnow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Text_end);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_page);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text_page;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Text_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label text_imgnow;
        private System.Windows.Forms.CheckBox checkBox_xunlei;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

