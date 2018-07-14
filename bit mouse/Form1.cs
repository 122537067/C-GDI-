using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bit_mouse
{
    public partial class Form1 : Form
    {
        Bitmap cursorbmp = new Bitmap("锤子.gif"); //鼠标缓冲图
        Bitmap cursorbmp2 = new Bitmap("锤子2.gif");//点击鼠标换冲图
        Bitmap bmp;   //缓冲图
        Graphics gBmp; //作图
        private int row = 3;// 行数
        private int col = 3;// 列数
        private int vacancy = 50; //地鼠与地鼠之间的间隔
        private int r_randNum; // 电脑随机行数
        private int c_randNum; // 电脑随机列数
        private int cellSize = 170; //  地鼠（洞）大小
        bool gameStart; // 判断游戏是否开始
        private int row_mouse = 0; //地鼠个数(行)
        private int col_mouse = 0; //地鼠个数(列)
        private int[,]flag;   //判断图片
        int score = 0;  //总得分
        int score_get = 1; //得分
        int score_lose = 1;//失分
        int prop_score_get = -4;//道具分值
        private int score_defeat=-5;   //失败的分数
        private int score_win = 30;  //胜利的分数
        Image image_hole = Image.FromFile("地鼠洞.jpg");  //地鼠洞的图片
        Image image_bit = Image.FromFile("地鼠被打.jpg");//地鼠被打的图片
        Image image_mouse = Image.FromFile("地鼠.jpg");//地鼠的图片
        Image image_defeat = Image.FromFile("地鼠赢了.jpg");//输了时地鼠的图片
        Image image_prop = Image.FromFile("道具.jpg");//道具的图片
        Image image_bitprop = Image.FromFile("道具被打.jpg");//打中道具的图片
        string hole_filepath= "地鼠洞.jpg";//地鼠洞图片的路径
        string bit_filepath= "地鼠被打.jpg";//地鼠被打图片的路径
        string mouse_filepath= "地鼠.jpg";//地鼠的图片路径
        string defeat_filepath= "地鼠赢了.jpg";//输了时地鼠的图片路径
        string prop_filepath = "道具.jpg";//道具的图片路径
        string bitprop_filepath = "道具被打.jpg";//打中道具的图片路径

        public Form1()
        {
            InitializeComponent();
        }

        private void draw(Graphics g)
        {
            Rectangle rect = new Rectangle(0, 0, cellSize, cellSize);  //定义框体
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    rect.X = j * (cellSize+vacancy);
                    rect.Y = i * (cellSize+vacancy);
                    g.DrawImage(image_hole, rect);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox_mouse.Enabled = false;
            pictureBox_mouse.Size = new Size((cellSize + vacancy) * col + 2, (cellSize + vacancy) * row + 2);  //重新定义picturebox的大小
            bmp = new Bitmap(pictureBox_mouse.Width, pictureBox_mouse.Height);
            gBmp = Graphics.FromImage(bmp);
            this.ClientSize = new Size(pictureBox_mouse.Width + 100, pictureBox_mouse.Height + 100);     //窗体大小适合难度大小
            draw(gBmp);
            //计算地鼠的个数和分布的位置
            row_mouse =pictureBox_mouse.Width/ (cellSize + vacancy);
            col_mouse = pictureBox_mouse.Height / (cellSize+vacancy);
        }

        //绘制和标记地鼠洞
        void Draw_hole()
        {
            score = 0;
            label_score.Text = score.ToString();
            pictureBox_mouse.Size = new Size((cellSize + vacancy) * col + 2, (cellSize + vacancy) * row + 2);
            bmp = new Bitmap(pictureBox_mouse.Width, pictureBox_mouse.Height);
            gBmp = Graphics.FromImage(bmp);
            draw(gBmp);
            pictureBox_mouse.CreateGraphics().DrawImage(bmp, 0, 0);   //绘制
            timer1.Start();   //开始游戏
            timer_disappear.Start();
            flag = new int[row, col];
            for (int i = 0; row > i; i++)
            {
                for (int j = 0; col > j; j++)
                {
                    flag[i, j] = 0;   //标记地鼠洞
                }
            }
            pictureBox_mouse.Refresh();
            this.ClientSize = new Size(pictureBox_mouse.Width + 100, pictureBox_mouse.Height + 100);     //窗体大小适合难度大小
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (初级ToolStripMenuItem.Checked == false &&
            中级ToolStripMenuItem.Checked == false &&
            高级ToolStripMenuItem.Checked == false)
            {
                MessageBox.Show("请先选择游戏难度");
            }
            else if (button1.Text == "开始游戏")
            {
                row_mouse = pictureBox_mouse.Width / (cellSize + vacancy);
                col_mouse = pictureBox_mouse.Height / (cellSize + vacancy);
                draw(gBmp);
                gameStart = true;
                pictureBox_mouse.Enabled = true;
                button1.Text = "暂停游戏";
                timer1.Start();
                Cursor cursor = new Cursor(cursorbmp.GetHicon());
                this.Cursor = cursor; //创建一个鼠标对象（鼠标变成锤子）
            }
            else
            {
                gameStart = false;
                pictureBox_mouse.Enabled = false;
                button1.Text = "开始游戏";
                Cursor = Cursors.Default;//鼠标变为正常
            }
        }

        //重绘
        private void pictureBox_mouse_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(bmp, new Point(0, 0));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameStart)
            {
                Random or = new Random();//道具或者地鼠
                int o = or.Next(10);
                Rectangle rect = new Rectangle(0, 0, cellSize, cellSize);  //定义框体
                Random s = new Random();//位置的随机数
                r_randNum = s.Next(row_mouse);       //生成行的随机数
                c_randNum = s.Next(col_mouse);       //生成列的随机数
                rect.X = r_randNum * (cellSize + vacancy);   //在行的位置
                rect.Y = c_randNum * (cellSize + vacancy);  //在列的位置
                //生成道具
                if (flag[c_randNum, r_randNum] == 0)  //空洞时
                {
                    if (o == 1)
                    {
                        flag[c_randNum, r_randNum] = 100;//令道具标记为100+
                        pictureBox_mouse.CreateGraphics().DrawImage(bmp, 0, 0);
                        gBmp.DrawImage(image_prop, rect);
                    }
                    else
                    {
                        flag[c_randNum, r_randNum]++;//标记老鼠
                        pictureBox_mouse.CreateGraphics().DrawImage(bmp, 0, 0);
                        gBmp.DrawImage(image_mouse, rect);
                    }
                    for (int i = 0; row > i; i++)
                    {
                        for (int j = 0; col > j; j++)
                        {
                            if (flag[i, j] >= 1)
                            {
                                flag[i, j]++;
                            }
                        }
                    }
                }
            }

            //游戏失败
            if (score <= score_defeat)
            {
                for (int i = 0; row > i; i++)
                {
                    for (int j = 0; col > j; j++)
                    {
                        if (flag[i, j] >= 1&&flag[i,j]<100)
                        {
                            //有地鼠的地方图片改变
                            Rectangle rect = new Rectangle(j * (cellSize + vacancy), i * (cellSize + vacancy), cellSize, cellSize);  //定义框体
                            gBmp.DrawImage(image_defeat, rect);
                            pictureBox_mouse.CreateGraphics().DrawImage(bmp, 0, 0);
                        }
                    }
                }
                gameStart = false;
                pictureBox_mouse.Enabled = false;
                timer1.Stop();
                Cursor = Cursors.Default;//鼠标变为正常
                timer_cursor.Stop();
                MessageBox.Show("Gameover!");
                button1.Text = "开始游戏";
                score = 0;//分数清零
            }

            //游戏胜利
            else if (score >= score_win)
            {
                for (int i = 0; row > i; i++)
                {
                    for (int j = 0; col > j; j++)
                    {
                        if (flag[i, j] >= 1 && flag[i, j] < 100)
                        {
                            //有地鼠的地方图片改变
                            Rectangle rect = new Rectangle(j * (cellSize + vacancy), i * (cellSize + vacancy), cellSize, cellSize);  //定义框体
                            gBmp.DrawImage(image_bit, rect);
                            pictureBox_mouse.CreateGraphics().DrawImage(bmp, 0, 0);
                        }
                    }
                }
                gameStart = false;
                pictureBox_mouse.Enabled = false;
                timer1.Stop();
                Cursor = Cursors.Default;//鼠标变为正常
                timer_cursor.Stop();
                MessageBox.Show("Winner!");
                button1.Text = "开始游戏";
                score = 0;//分数清零
            }
        }

        //点击图片
        private void pictureBox_mouse_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor cursor = new Cursor(cursorbmp2.GetHicon());
            this.Cursor = cursor; //创建一个鼠标对象（鼠标变成锤子2）
            timer_cursor.Start();//锤子
            int c = e.X / (cellSize + vacancy); // 算出点击的是第几列
            int r = e.Y / (cellSize + vacancy); // 算出点击的是第几行
            Rectangle rect = new Rectangle(c * (cellSize + vacancy), r * (cellSize + vacancy), cellSize, cellSize);  //定义框体
            if (flag[r, c] > 0 && flag[r, c] < 100)
            {
                gBmp.DrawImage(image_bit, rect);
                flag[r, c] = -1;    //令被打的老鼠标记为-1
                score=score+score_get;
                label_score.Text = score.ToString();  //加分

                //声音代码
                System.Media.SoundPlayer sndPlayer = new System.Media.SoundPlayer(Application.StartupPath + "/叫声.wav");
                sndPlayer.Play();
            }
            else if(flag[r,c]>=100)
            {
                gBmp.DrawImage(image_bitprop, rect);
                flag[r, c] = -1;    //令被打的老鼠标记为-1
                score = score + prop_score_get;
                label_score.Text = score.ToString();  //重置分数

                //声音代码
                System.Media.SoundPlayer sndPlayer = new System.Media.SoundPlayer(Application.StartupPath + "/道具.wav");
                sndPlayer.Play();
            }
            pictureBox_mouse.CreateGraphics().DrawImage(bmp, 0, 0);   //绘制图片
        }

        private void timer_disappear_Tick(object sender, EventArgs e)
        {
            if (gameStart == true)
            {
                for (int i = 0; row > i; i++)
                {
                    for (int j = 0; col > j; j++)
                    {
                        if (flag[i, j] >= 3 && flag[i, j] < 99)
                        {
                            //当地鼠出现时间足够大，地鼠消失且扣分
                            Rectangle rect = new Rectangle(j * (cellSize + vacancy), i * (cellSize + vacancy), cellSize, cellSize);  //定义框体
                            gBmp.DrawImage(image_hole, rect);
                            pictureBox_mouse.CreateGraphics().DrawImage(bmp, 0, 0);
                            score=score-score_lose;
                            label_score.Text = score.ToString();  //扣分
                            flag[i, j] = 0;
                        }
                        if(flag[i,j]<0||flag[i,j]>103)
                        {
                            //被打的地鼠片刻后变成地鼠洞
                            Rectangle rect = new Rectangle(j * (cellSize + vacancy), i * (cellSize + vacancy), cellSize, cellSize);  //定义框体
                            gBmp.DrawImage(image_hole, rect);
                            pictureBox_mouse.CreateGraphics().DrawImage(bmp, 0, 0);
                            flag[i, j] = 0;
                        }
                    }
                }
            }
        }

        private void 初级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            初级ToolStripMenuItem.Checked = true;
            中级ToolStripMenuItem.Checked = false;
            高级ToolStripMenuItem.Checked = false;
            gameStart = false;
            timer1.Interval = 1000;          //地鼠出现的频率
            timer_disappear.Interval = 1000;//地鼠消失得频率
            row = 3;                //横数
            col = 3;                //列数
            cellSize = 170;        //地鼠大小
            Draw_hole();           //绘制
            button1.Text = "开始游戏";
        }

        private void 中级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            初级ToolStripMenuItem.Checked = false;
            中级ToolStripMenuItem.Checked = true;
            高级ToolStripMenuItem.Checked = false;
            gameStart = false;
            timer1.Interval = 500;
            timer_disappear.Interval = 1000;
            row = 3;
            col = 4;
            cellSize = 150;
            Draw_hole();
            button1.Text = "开始游戏";
        }

        private void 高级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            初级ToolStripMenuItem.Checked = false;
            中级ToolStripMenuItem.Checked = false;
            高级ToolStripMenuItem.Checked = true;
            gameStart = false;
            timer1.Interval = 500;
            timer_disappear.Interval = 1000;
            row = 3;
            col = 5;
            cellSize = 100;
            Draw_hole();
            button1.Text = "开始游戏";
        }

        private void 分值设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(score_get, score_lose, score_win, score_defeat,prop_score_get);
            DialogResult dr=setting.ShowDialog();

            //按确定修改分值
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                score_get = setting.Getscore;
                score_lose = setting.Losescore;
                score_win = setting.Winscore;
                score_defeat = setting.Defeatscore;
                prop_score_get = setting.Propscore;
            }
        }

        private void 地鼠图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetImage setimage = new SetImage(hole_filepath,mouse_filepath,bit_filepath,defeat_filepath,prop_filepath,bitprop_filepath);
            DialogResult dr =setimage.ShowDialog();

            //按确定时图像路径读入
            //修改路径
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                image_hole = Image.FromFile(setimage.get_image_hole);
                image_bit = Image.FromFile(setimage.get_image_bit);
                image_mouse = Image.FromFile(setimage.get_image_mouse);
                image_defeat = Image.FromFile(setimage.get_image_defeat);
                image_prop = Image.FromFile(setimage.get_image_prop);
                image_bitprop = Image.FromFile(setimage.get_image_bitprop);
                hole_filepath = setimage.get_image_hole;
                mouse_filepath = setimage.get_image_mouse;
                bit_filepath = setimage.get_image_bit;
                defeat_filepath = setimage.get_image_defeat;
                prop_filepath = setimage.get_image_prop;
                bitprop_filepath = setimage.get_image_bitprop;
            }
        }

        private void timer_cursor_Tick(object sender, EventArgs e)
        {
            Cursor cursor = new Cursor(cursorbmp.GetHicon());
            this.Cursor = cursor; //创建一个鼠标对象（鼠标变成锤子）
            timer_cursor.Stop();
        }

        private void 锤子选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetHammer sethammer = new SetHammer();
            DialogResult dr = sethammer.ShowDialog();
            if(dr== System.Windows.Forms.DialogResult.OK)
            {
                cursorbmp = new Bitmap(sethammer.Hammerpath+".gif"); //鼠标缓冲图
                cursorbmp2 = new Bitmap(sethammer.Hammerpath + "2.gif");//点击鼠标换冲图
            }
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }
    }
}
