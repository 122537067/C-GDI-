namespace bit_mouse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.难度选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分值设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地鼠图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锤子选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_mouse = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_disappear = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.timer_cursor = new System.Windows.Forms.Timer(this.components);
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mouse)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项OToolStripMenuItem,
            this.图像IToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选项OToolStripMenuItem
            // 
            this.选项OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.难度选择ToolStripMenuItem,
            this.分值设置ToolStripMenuItem});
            this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            this.选项OToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.选项OToolStripMenuItem.Text = "选项(&O)";
            // 
            // 难度选择ToolStripMenuItem
            // 
            this.难度选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初级ToolStripMenuItem,
            this.中级ToolStripMenuItem,
            this.高级ToolStripMenuItem});
            this.难度选择ToolStripMenuItem.Name = "难度选择ToolStripMenuItem";
            this.难度选择ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.难度选择ToolStripMenuItem.Text = "难度选择";
            // 
            // 初级ToolStripMenuItem
            // 
            this.初级ToolStripMenuItem.Name = "初级ToolStripMenuItem";
            this.初级ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.初级ToolStripMenuItem.Text = "初级";
            this.初级ToolStripMenuItem.Click += new System.EventHandler(this.初级ToolStripMenuItem_Click);
            // 
            // 中级ToolStripMenuItem
            // 
            this.中级ToolStripMenuItem.Name = "中级ToolStripMenuItem";
            this.中级ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.中级ToolStripMenuItem.Text = "中级";
            this.中级ToolStripMenuItem.Click += new System.EventHandler(this.中级ToolStripMenuItem_Click);
            // 
            // 高级ToolStripMenuItem
            // 
            this.高级ToolStripMenuItem.Name = "高级ToolStripMenuItem";
            this.高级ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.高级ToolStripMenuItem.Text = "高级";
            this.高级ToolStripMenuItem.Click += new System.EventHandler(this.高级ToolStripMenuItem_Click);
            // 
            // 分值设置ToolStripMenuItem
            // 
            this.分值设置ToolStripMenuItem.Name = "分值设置ToolStripMenuItem";
            this.分值设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.分值设置ToolStripMenuItem.Text = "分值设置";
            this.分值设置ToolStripMenuItem.Click += new System.EventHandler(this.分值设置ToolStripMenuItem_Click);
            // 
            // 图像IToolStripMenuItem
            // 
            this.图像IToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.地鼠图像ToolStripMenuItem,
            this.锤子选择ToolStripMenuItem});
            this.图像IToolStripMenuItem.Name = "图像IToolStripMenuItem";
            this.图像IToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.图像IToolStripMenuItem.Text = "图像(&I)";
            // 
            // 地鼠图像ToolStripMenuItem
            // 
            this.地鼠图像ToolStripMenuItem.Name = "地鼠图像ToolStripMenuItem";
            this.地鼠图像ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.地鼠图像ToolStripMenuItem.Text = "地鼠图像";
            this.地鼠图像ToolStripMenuItem.Click += new System.EventHandler(this.地鼠图像ToolStripMenuItem_Click);
            // 
            // 锤子选择ToolStripMenuItem
            // 
            this.锤子选择ToolStripMenuItem.Name = "锤子选择ToolStripMenuItem";
            this.锤子选择ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.锤子选择ToolStripMenuItem.Text = "锤子选择";
            this.锤子选择ToolStripMenuItem.Click += new System.EventHandler(this.锤子选择ToolStripMenuItem_Click);
            // 
            // pictureBox_mouse
            // 
            this.pictureBox_mouse.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_mouse.Location = new System.Drawing.Point(45, 47);
            this.pictureBox_mouse.Name = "pictureBox_mouse";
            this.pictureBox_mouse.Size = new System.Drawing.Size(591, 359);
            this.pictureBox_mouse.TabIndex = 1;
            this.pictureBox_mouse.TabStop = false;
            this.pictureBox_mouse.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_mouse_Paint);
            this.pictureBox_mouse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_mouse_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始游戏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_disappear
            // 
            this.timer_disappear.Interval = 1000;
            this.timer_disappear.Tick += new System.EventHandler(this.timer_disappear_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "得分：";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(553, 9);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(11, 12);
            this.label_score.TabIndex = 4;
            this.label_score.Text = "0";
            // 
            // timer_cursor
            // 
            this.timer_cursor.Interval = 200;
            this.timer_cursor.Tick += new System.EventHandler(this.timer_cursor_Tick);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(691, 436);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_mouse);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "打地鼠";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_mouse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_disappear;
        private System.Windows.Forms.ToolStripMenuItem 难度选择ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.ToolStripMenuItem 初级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分值设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地鼠图像ToolStripMenuItem;
        private System.Windows.Forms.Timer timer_cursor;
        private System.Windows.Forms.ToolStripMenuItem 锤子选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
    }
}

