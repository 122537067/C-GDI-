namespace bit_mouse
{
    partial class Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_got = new System.Windows.Forms.TextBox();
            this.textBox_lose = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_win = new System.Windows.Forms.TextBox();
            this.textBox_defeat = new System.Windows.Forms.TextBox();
            this.textBox_prop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "打一个地鼠得";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "漏一个地鼠失";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "分";
            // 
            // textBox_got
            // 
            this.textBox_got.Location = new System.Drawing.Point(116, 60);
            this.textBox_got.Name = "textBox_got";
            this.textBox_got.Size = new System.Drawing.Size(69, 21);
            this.textBox_got.TabIndex = 4;
            this.textBox_got.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_got_KeyPress);
            // 
            // textBox_lose
            // 
            this.textBox_lose.Location = new System.Drawing.Point(116, 93);
            this.textBox_lose.Name = "textBox_lose";
            this.textBox_lose.Size = new System.Drawing.Size(69, 21);
            this.textBox_lose.TabIndex = 5;
            this.textBox_lose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_lose_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "分时游戏胜利";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "分时游戏失败";
            // 
            // textBox_win
            // 
            this.textBox_win.Location = new System.Drawing.Point(35, 134);
            this.textBox_win.Name = "textBox_win";
            this.textBox_win.Size = new System.Drawing.Size(75, 21);
            this.textBox_win.TabIndex = 11;
            this.textBox_win.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_win_KeyPress);
            // 
            // textBox_defeat
            // 
            this.textBox_defeat.Location = new System.Drawing.Point(35, 165);
            this.textBox_defeat.Name = "textBox_defeat";
            this.textBox_defeat.Size = new System.Drawing.Size(73, 21);
            this.textBox_defeat.TabIndex = 12;
            this.textBox_defeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_defeat_KeyPress);
            // 
            // textBox_prop
            // 
            this.textBox_prop.Location = new System.Drawing.Point(112, 195);
            this.textBox_prop.Name = "textBox_prop";
            this.textBox_prop.Size = new System.Drawing.Size(73, 21);
            this.textBox_prop.TabIndex = 13;
            this.textBox_prop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_prop_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "道具分值";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "分";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 269);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_prop);
            this.Controls.Add(this.textBox_defeat);
            this.Controls.Add(this.textBox_win);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_lose);
            this.Controls.Add(this.textBox_got);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_got;
        private System.Windows.Forms.TextBox textBox_lose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_win;
        private System.Windows.Forms.TextBox textBox_defeat;
        private System.Windows.Forms.TextBox textBox_prop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}