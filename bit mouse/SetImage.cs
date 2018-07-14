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
    public partial class SetImage : Form
    {
        public SetImage(string imagehole,string imagemouse,string imagebit,string imagedefeat,
            string imageprop,string imagebitprop)
        {
            InitializeComponent();

            //获取记录
            textBox_hole.Text = imagehole;
            textBox_mouse.Text = imagemouse;
            textBox_bit.Text = imagebit;
            textBox_defeat.Text = imagedefeat;
            textBox_prop.Text = imageprop;
            textBox_bitprop.Text = imagebitprop;
            pictureBox_hole.Image = Image.FromFile(textBox_hole.Text);
            pictureBox_mouse.Image = Image.FromFile(textBox_mouse.Text);
            pictureBox_bit.Image = Image.FromFile(textBox_bit.Text);
            pictureBox_defeat.Image = Image.FromFile(textBox_defeat.Text);
            pictureBox_prop.Image = Image.FromFile(textBox_prop.Text);
            pictureBox_bitprop.Image = Image.FromFile(textBox_bitprop.Text);
        }

        //图像路径
        public string get_image_hole
        {
            get { return textBox_hole.Text; }
        }

        public string get_image_bit
        {
            get { return textBox_bit.Text; }
        }

        public string get_image_mouse
        {
            get { return textBox_mouse.Text; }
        }

        public string get_image_defeat
        {
            get { return textBox_defeat.Text; }
        }
        public string get_image_prop
        {
            get { return textBox_prop.Text; }
        }
        public string get_image_bitprop
        {
            get { return textBox_bitprop.Text; }
        }

        //当输入为空时
        public void onenull()
        {
            if (textBox_hole.Text == "")
            {
                textBox_hole.Text = "地鼠洞.jpg";
            }
            if (textBox_bit.Text == "")
            {
                textBox_bit.Text = "地鼠被打.jpg";
            }
            if (textBox_mouse.Text == "")
            {
                textBox_mouse.Text = "地鼠.jpg";
            }
            if (textBox_defeat.Text == "")
            {
                textBox_defeat.Text = "地鼠赢了.jpg";
            }
            if(textBox_prop.Text=="")
            {
                textBox_prop.Text = "道具";
            }
            if(textBox_bitprop.Text=="")
            {
                textBox_bitprop.Text = "道具被打";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "图像文件(*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp";//设置打开文件类型
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox_hole.Text = open.FileName;
                pictureBox_hole.Image = Image.FromFile(textBox_hole.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "图像文件(*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp";//设置打开文件类型
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox_mouse.Text = open.FileName;
                pictureBox_mouse.Image = Image.FromFile(textBox_mouse.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "图像文件(*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp";//设置打开文件类型
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox_bit.Text = open.FileName;
                pictureBox_bit.Image = Image.FromFile(textBox_bit.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "图像文件(*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp";//设置打开文件类型
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox_defeat.Text = open.FileName;
                pictureBox_defeat.Image = Image.FromFile(textBox_defeat.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            onenull();
            this.DialogResult = DialogResult.OK;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "图像文件(*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp";//设置打开文件类型
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox_prop.Text = open.FileName;
                pictureBox_prop.Image = Image.FromFile(textBox_prop.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "图像文件(*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp";//设置打开文件类型
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox_bitprop.Text = open.FileName;
                pictureBox_bitprop.Image = Image.FromFile(textBox_bitprop.Text);
            }
        }
    }
}
